using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _20211101_RunFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string exePath = @"\\PATH\OF\EXE";
            RunFile(exePath, "", "");

            string exeWithArgPath = @"\\PATH\OF\EXE\WITH\ARG";
            string exeArgString = "EXE_ARG_STRING";
            RunFile(exeWithArgPath, exeArgString, "");

            string pythonPath = @"\\PATH\OF\PYTHON";
            string pythonScriptPath = @"\\PATH\OF\PYTHON_SCRIPT";
            string pythonArgString = "PYTHON_ARG_STRING";
            RunPython(pythonPath, pythonScriptPath, pythonArgString, "");
        }

        static void RunPython(string pythonPath, string pythonScriptPath, string pythonArgString, string workingDirectory)
        {
            string args = pythonScriptPath + " " + pythonArgString;
            // Call the run file in order to keep the logic same.
            RunFile(pythonPath, args, workingDirectory);
        }

        static void RunFile(string filePath, string args, string workingDirectory)
        {
            // Initiate the process.
            Process proc = new Process();

            // Initiate the start info.
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = filePath;
            info.Arguments = args;
            info.WorkingDirectory = workingDirectory;

            // Assign the start info to the process.
            proc.StartInfo = info;

            proc.Start();

            proc.WaitForExit();
        }
    }
}
