using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkhubForWindows.Forms;
using System.Security.Cryptography;

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
#if DEBUG
            goto SkipCheck;  
#endif
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
            SkipCheck:

            //EULA
            #region EULA Load
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "WorkhubForWindows.Resources.EULA.Ja_Jp.txt";
            string manualFileContent = "";
            using (var stream = assembly.GetManifestResourceStream(resourceName))
            {
                if (stream != null)
                {
                    using (var sr = new StreamReader(stream, Encoding.UTF8))
                    {
                        manualFileContent = sr.ReadToEnd();
                    }
                }
            }
#endregion
            if (StaticClasses.Config.EULA != Functions.Hash.GetHashString<SHA256CryptoServiceProvider>(manualFileContent))
            {
                EULA eula = new EULA();
                eula.ShowDialog();
                if (!eula.agree)
                {
                    Environment.Exit(-1);
                }
                StaticClasses.Config.EULA = Functions.Hash.GetHashString<SHA256CryptoServiceProvider>(manualFileContent);
            }
            StaticClasses.IconList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            StaticClasses.IconList.TransparentColor = Color.Transparent;
            StaticClasses.IconList.ImageSize = new Size(32, 32);
            StaticClasses.Config.SaveConfig();
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
