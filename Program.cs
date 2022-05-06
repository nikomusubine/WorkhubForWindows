using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkhubForWindows
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string name = Process.GetCurrentProcess().ProcessName;
            Process[] processes = Process.GetProcessesByName(name);
            for (int i = 0; i < processes.Length; i++)
            {
                Process proc = processes[i];
                if (proc.ProcessName == name && proc.MainWindowTitle == "WorkhubForWindows")
                {
                    Functions.WinAPIFuncs.PostMessage((int)proc.MainWindowHandle, StaticClasses.WorkHubMessages.ShowMainWindow, 0, 0);

                    Environment.Exit(1);
                }
            }
            StaticClasses.Config = StaticClasses.Config.LoadConfig();
            //EULA

            StaticClasses.IconList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            StaticClasses.IconList.TransparentColor = Color.Transparent;
            StaticClasses.IconList.ImageSize = new Size(32, 32);
            switch (StaticClasses.Config.Homemode)
            {
                case HomeMode.FullScreen:

                    Application.Run(new Main_FullScreenList());
                    break;
                case HomeMode.HalfHome:
                    Application.Run(new Mainwindow());
                    break;
            }
        }
    }
}
