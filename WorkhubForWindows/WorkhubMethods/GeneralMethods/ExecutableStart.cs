using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkhubForWindows.Variant;

namespace WorkhubForWindows.WorkhubMethods.GeneralMethods
{
    public static class ExecutableStart
    {
        public static void ProcessStart(Executable exe)
        {
            ProcessStart(exe.Path, exe.Arguments, exe.CurrentDir, exe.RunasAdmin);
            return;
        }

        private static bool ProcessStart(
            string Path,
            string Arguments,
            string CurrentDir,
            bool runAsAdmin)
        {
            Process process=new Process();
            process.StartInfo.FileName = Path;
            process.StartInfo.Arguments = Arguments;
            process.StartInfo.WorkingDirectory=CurrentDir;
            if(runAsAdmin)
            {
                process.StartInfo.Verb = "runAs";
            }
            
            return process.Start();
        }
    }
}
