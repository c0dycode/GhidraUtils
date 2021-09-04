
namespace HeadlessGUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblSupportDir = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.txtBoxSupportDir = new System.Windows.Forms.TextBox();
            this.btnSupportDir = new System.Windows.Forms.Button();
            this.lblProjectFolder = new System.Windows.Forms.Label();
            this.txtBoxProjectDir = new System.Windows.Forms.TextBox();
            this.btnProjectDir = new System.Windows.Forms.Button();
            this.comboBoxProjects = new System.Windows.Forms.ComboBox();
            this.listBoxSubProjects = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSubProject = new System.Windows.Forms.Label();
            this.lblActions = new System.Windows.Forms.Label();
            this.btnImportAction = new System.Windows.Forms.Button();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lblSupportDir
            // 
            this.lblSupportDir.AutoSize = true;
            this.lblSupportDir.Location = new System.Drawing.Point(13, 13);
            this.lblSupportDir.Name = "lblSupportDir";
            this.lblSupportDir.Size = new System.Drawing.Size(89, 13);
            this.lblSupportDir.TabIndex = 0;
            this.lblSupportDir.Text = "Support Directory";
            // 
            // txtBoxSupportDir
            // 
            this.txtBoxSupportDir.Location = new System.Drawing.Point(16, 30);
            this.txtBoxSupportDir.Name = "txtBoxSupportDir";
            this.txtBoxSupportDir.ReadOnly = true;
            this.txtBoxSupportDir.Size = new System.Drawing.Size(445, 20);
            this.txtBoxSupportDir.TabIndex = 1;
            // 
            // btnSupportDir
            // 
            this.btnSupportDir.Location = new System.Drawing.Point(467, 28);
            this.btnSupportDir.Name = "btnSupportDir";
            this.btnSupportDir.Size = new System.Drawing.Size(75, 23);
            this.btnSupportDir.TabIndex = 2;
            this.btnSupportDir.Text = "Browse...";
            this.btnSupportDir.UseVisualStyleBackColor = true;
            this.btnSupportDir.Click += new System.EventHandler(this.btnSupportDir_Click);
            // 
            // lblProjectFolder
            // 
            this.lblProjectFolder.AutoSize = true;
            this.lblProjectFolder.Location = new System.Drawing.Point(13, 61);
            this.lblProjectFolder.Name = "lblProjectFolder";
            this.lblProjectFolder.Size = new System.Drawing.Size(72, 13);
            this.lblProjectFolder.TabIndex = 3;
            this.lblProjectFolder.Text = "Project Folder";
            // 
            // txtBoxProjectDir
            // 
            this.txtBoxProjectDir.Location = new System.Drawing.Point(16, 79);
            this.txtBoxProjectDir.Name = "txtBoxProjectDir";
            this.txtBoxProjectDir.Size = new System.Drawing.Size(445, 20);
            this.txtBoxProjectDir.TabIndex = 4;
            this.txtBoxProjectDir.TextChanged += new System.EventHandler(this.txtBoxProjectDir_TextChanged);
            // 
            // btnProjectDir
            // 
            this.btnProjectDir.Location = new System.Drawing.Point(467, 77);
            this.btnProjectDir.Name = "btnProjectDir";
            this.btnProjectDir.Size = new System.Drawing.Size(75, 23);
            this.btnProjectDir.TabIndex = 5;
            this.btnProjectDir.Text = "Browse...";
            this.btnProjectDir.UseVisualStyleBackColor = true;
            this.btnProjectDir.Click += new System.EventHandler(this.btnProjectDir_Click);
            // 
            // comboBoxProjects
            // 
            this.comboBoxProjects.FormattingEnabled = true;
            this.comboBoxProjects.Location = new System.Drawing.Point(16, 129);
            this.comboBoxProjects.Name = "comboBoxProjects";
            this.comboBoxProjects.Size = new System.Drawing.Size(268, 21);
            this.comboBoxProjects.TabIndex = 8;
            this.comboBoxProjects.SelectedIndexChanged += new System.EventHandler(this.comboBoxProjects_SelectedIndexChanged);
            // 
            // listBoxSubProjects
            // 
            this.listBoxSubProjects.FormattingEnabled = true;
            this.listBoxSubProjects.Location = new System.Drawing.Point(16, 178);
            this.listBoxSubProjects.Name = "listBoxSubProjects";
            this.listBoxSubProjects.Size = new System.Drawing.Size(329, 316);
            this.listBoxSubProjects.TabIndex = 9;
            this.listBoxSubProjects.SelectedIndexChanged += new System.EventHandler(this.listBoxSubProjects_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Project";
            // 
            // lblSubProject
            // 
            this.lblSubProject.AutoSize = true;
            this.lblSubProject.Location = new System.Drawing.Point(13, 162);
            this.lblSubProject.Name = "lblSubProject";
            this.lblSubProject.Size = new System.Drawing.Size(62, 13);
            this.lblSubProject.TabIndex = 11;
            this.lblSubProject.Text = "Sub Project";
            // 
            // lblActions
            // 
            this.lblActions.AutoSize = true;
            this.lblActions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActions.Location = new System.Drawing.Point(365, 178);
            this.lblActions.Name = "lblActions";
            this.lblActions.Size = new System.Drawing.Size(72, 24);
            this.lblActions.TabIndex = 12;
            this.lblActions.Text = "Actions";
            // 
            // btnImportAction
            // 
            this.btnImportAction.Location = new System.Drawing.Point(369, 215);
            this.btnImportAction.Name = "btnImportAction";
            this.btnImportAction.Size = new System.Drawing.Size(75, 23);
            this.btnImportAction.TabIndex = 14;
            this.btnImportAction.Text = "Import";
            this.btnImportAction.UseVisualStyleBackColor = true;
            this.btnImportAction.Click += new System.EventHandler(this.btnImportAction_Click);
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Location = new System.Drawing.Point(369, 254);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(75, 23);
            this.btnAnalyze.TabIndex = 15;
            this.btnAnalyze.Text = "Analyze";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 501);
            this.Controls.Add(this.btnAnalyze);
            this.Controls.Add(this.btnImportAction);
            this.Controls.Add(this.lblActions);
            this.Controls.Add(this.lblSubProject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxSubProjects);
            this.Controls.Add(this.comboBoxProjects);
            this.Controls.Add(this.btnProjectDir);
            this.Controls.Add(this.txtBoxProjectDir);
            this.Controls.Add(this.lblProjectFolder);
            this.Controls.Add(this.btnSupportDir);
            this.Controls.Add(this.txtBoxSupportDir);
            this.Controls.Add(this.lblSupportDir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Ghidra Headless GUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSupportDir;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.TextBox txtBoxSupportDir;
        private System.Windows.Forms.Button btnSupportDir;
        private System.Windows.Forms.Label lblProjectFolder;
        private System.Windows.Forms.TextBox txtBoxProjectDir;
        private System.Windows.Forms.Button btnProjectDir;
        private System.Windows.Forms.ComboBox comboBoxProjects;
        private System.Windows.Forms.ListBox listBoxSubProjects;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSubProject;
        private System.Windows.Forms.Label lblActions;
        private System.Windows.Forms.Button btnImportAction;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

