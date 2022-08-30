﻿using System;
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
            bool openWithItem = Environment.GetCommandLineArgs().Length > 1;
            bool endProgram = false;
            Parallel.For(0, processes.Length, i =>
           {
               Process proc = processes[i];
               if (proc.ProcessName.ToLower() == name.ToLower() && proc.MainWindowTitle.ToLower() == "workhubforwindows")
               {
                   if (openWithItem)
                   {
                       Functions.WinAPIFuncs.COPYDATASTRUCT cds = new Functions.WinAPIFuncs.COPYDATASTRUCT();
                       StringBuilder sb =new StringBuilder(Environment.GetCommandLineArgs()[1]);
                       for(int j = 2; j != Environment.GetCommandLineArgs().Length; j++)
                       {
                           sb.Append('\t');
                           sb.Append(Environment.GetCommandLineArgs()[j]);
                       }

                       cds.dwData = IntPtr.Zero;
                       cds.lpData = sb.ToString();
                       cds.cbData = sb.ToString().Length * sizeof(char);
                       Functions.WinAPIFuncs.SendMessage((IntPtr)proc.MainWindowHandle, StaticClasses.WorkHubMessages.WM_COPYDATA, StaticClasses.WorkHubMessages.OpenAddItem, ref cds);
                   }
                   else
                   {
                       Functions.WinAPIFuncs.PostMessage((int)proc.MainWindowHandle, StaticClasses.WorkHubMessages.ShowMainWindow, 0, 0);
                   }
                   endProgram = true;
               }
           });
            if (endProgram)
                Environment.Exit(1);
            
            StaticClasses.Config = StaticClasses.Config.LoadConfig();
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
                    Main_FullScreenList mfs = new Main_FullScreenList();
                        mfs.Text = "WorkhubForWindows";
                    Application.Run(mfs);
                    break;
                case HomeMode.HalfHome:
                    Mainwindow mw = new Mainwindow();
                    mw.Text = "WorkhubForWindows";
                    Application.Run(mw);
                    break;
            }
        }
    }
}
