using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkhubForWindows.Forms;
using System.IO;
using Microsoft.Win32;
using System.Xml.Serialization;
using System.Text.Json;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace WorkhubForWindows
{
    internal class MainBase: System.Windows.Forms.Form
    {

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

        public MainBase()
        {
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
                    Main_FullScreenList FMainwnd = new Main_FullScreenList();
                    FMainwnd.ShowDialog();
                    break;
                case HomeMode.HalfHome:
                    Mainwindow halfMainwnd = new Mainwindow();
                    halfMainwnd.ShowDialog();
                    break;
            }
            this.Load += OpenAndClose;
        }

        private void OpenAndClose(object sender,EventArgs e)
        {
            this.Close();
        }

        private System.ComponentModel.IContainer components = null; 
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}