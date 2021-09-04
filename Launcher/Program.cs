using System.Diagnostics;
using System.IO;

namespace Launcher
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!File.Exists("ghidraRun.bat"))
                return;
            Process proc = new Process();
            proc.StartInfo = new ProcessStartInfo
            {
                FileName = "ghidraRun.bat"
            };

            proc.Start();
        }
    }
}
