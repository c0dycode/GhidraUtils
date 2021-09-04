using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Diagnostics;
using HeadlessGUI.Properties;

namespace HeadlessGUI
{
    public partial class Form1 : Form
    {
        public string SupportDirPath { get; set; }
        public string ProjectDirPath { get; set; }
        public List<string> AvailableProjectNames { get; set; } = new List<string>();
        public List<string> SubProjectNames { get; set; } = new List<string>();

        public string SelectedProjectName { get; set; }
        public string SelectedSubProject { get; set; }

        public Form1()
        {
            InitializeComponent();
            LoadSettings();
        }

        private void SaveSettings()
        {
            Settings.Default.SupportDir = SupportDirPath;
            Settings.Default.LastProjectDir = ProjectDirPath;
            Settings.Default.Save();
        }

        private void LoadSettings()
        {
            ProjectDirPath = Settings.Default.LastProjectDir;
            SupportDirPath = Settings.Default.SupportDir;

            this.txtBoxProjectDir.Text = ProjectDirPath;
            this.txtBoxSupportDir.Text = SupportDirPath;

            this.txtBoxProjectDir.Invalidate();
            this.txtBoxSupportDir.Invalidate();
        }

        private void btnSupportDir_Click(object sender, EventArgs e)
        {
            DialogResult dr = this.folderBrowserDialog.ShowDialog();
            if(dr == DialogResult.OK || dr == DialogResult.Yes)
            {
                string selection = this.folderBrowserDialog.SelectedPath;
                if (!System.IO.File.Exists(Path.Combine(selection, "analyzeHeadless.bat")))
                {
                    MessageBox.Show("Invalid directory selected!\nSelect the \"support\"-directory in the ghidra installation folder. ", "Invalid input!");
                    return;
                }
                SupportDirPath = selection;
                this.txtBoxSupportDir.Text = SupportDirPath;
                this.txtBoxSupportDir.Invalidate();
                SaveSettings();
            }
        }

        private void btnProjectDir_Click(object sender, EventArgs e)
        {
            this.txtBoxProjectDir.TextChanged -= this.txtBoxProjectDir_TextChanged;
            DialogResult dr = this.folderBrowserDialog.ShowDialog();
            if (dr == DialogResult.OK || dr == DialogResult.Yes)
            {
                string selection = this.folderBrowserDialog.SelectedPath;
                
                ProjectDirPath = selection;
                this.txtBoxProjectDir.Text = ProjectDirPath;
                this.txtBoxProjectDir.Invalidate();
                TryLoadProjectFiles(selection);
                SaveSettings();
            }
            this.txtBoxProjectDir.TextChanged += this.txtBoxProjectDir_TextChanged;
        }

        private void GetProjectNames(string directory)
        {
            List<string> availableProjectNames = new List<string>();
            List<string> files = Directory.EnumerateFiles(directory).ToList();
            if (files.Count > 0)
            {
                for (int i = 0; i < files.Count; ++i)
                {
                    if (files[i].ToString().EndsWith(".gpr"))
                    {
                        availableProjectNames.Add(files[i].ToString().Substring(0, files[i].ToString().Length - 4).Replace(directory + "\\", ""));
                    }
                }
            }
            AvailableProjectNames = availableProjectNames;
            this.comboBoxProjects.DataSource = AvailableProjectNames;
            this.comboBoxProjects.Invalidate();
        }

        private void TryLoadProjectFiles(string directory)
        {
            GetProjectNames(directory);
        }

        private void txtBoxProjectDir_TextChanged(object sender, EventArgs e)
        {
            TextBox s = sender as TextBox;
            string data = s.Text;
            if (Directory.Exists(data))
            {
                TryLoadProjectFiles(data);
                SaveSettings();
            }
            ProjectDirPath = data;
        }

        private void ReadAllSubProjects(List<string> projectFiles)
        {
            List<string> subProjectNames = new List<string>();
            XmlDocument xmlDoc = new XmlDocument();
            foreach (var projectFile in projectFiles)
            {
                xmlDoc.Load(projectFile);
                XmlNodeList nodes = xmlDoc.DocumentElement.SelectNodes("/FILE_INFO/BASIC_INFO/STATE");
                foreach (XmlNode node in nodes)
                {
                    if (node.Attributes["NAME"].Value == "NAME") 
                    {
                        subProjectNames.Add(node.Attributes["VALUE"].Value);
                    }                    
                }
            }
            SubProjectNames = subProjectNames;
        }

        private void GetAllSubProjects()
        {
            string combinedPath = Path.Combine(ProjectDirPath, SelectedProjectName + ".rep", "idata");
            List<string> innerProjectDirectories = Directory.EnumerateDirectories(combinedPath).ToList();
            List<string> innerProjectFiles = new List<string>();

            for (int i = 0; i < innerProjectDirectories.Count; ++i)
            {
                List<string> files = Directory.EnumerateFiles(innerProjectDirectories[i].ToString()).ToList();
                foreach (var file in files)
                {
                    if (file.EndsWith(".prp"))
                        innerProjectFiles.Add(file);
                }
            }
            ReadAllSubProjects(innerProjectFiles);
            this.listBoxSubProjects.DataSource = SubProjectNames;
            this.listBoxSubProjects.Invalidate();
        }

        private void comboBoxProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox s = sender as ComboBox;
            SelectedProjectName = s.SelectedItem.ToString();
            GetAllSubProjects();
        }

        private void btnImportAction_Click(object sender, EventArgs e)
        {
            this.openFileDialog.Multiselect = false;
            DialogResult dr = this.openFileDialog.ShowDialog();
            if(dr == DialogResult.OK || dr == DialogResult.Yes)
            {
                string selectedFileToImport = this.openFileDialog.FileName;
                Process proc = new Process();
                proc.StartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    WorkingDirectory = SupportDirPath,
                    Arguments = $"/k analyzeHeadless.bat \"{ProjectDirPath}\" \"{SelectedProjectName}\" -import \"{selectedFileToImport}\"",
                };

                proc.Start();
            }
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            Process proc = new Process();
            proc.StartInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                WorkingDirectory = SupportDirPath,
                Arguments = $"/k analyzeHeadless.bat \"{ProjectDirPath}\" \"{SelectedProjectName}\" -process \"{SelectedSubProject}\"",                
            };

            proc.Start();
        }

        private void listBoxSubProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox s = sender as ListBox;
            SelectedSubProject = s.SelectedItem.ToString();
        }
    }
}
