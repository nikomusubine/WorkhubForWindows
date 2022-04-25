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
        Main_FullScreenList FMainwnd;
        Mainwindow halfMainwnd;
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
            StaticClasses.WindowHandler.WindowHandlers.Add(new WorkhubWindowHandler((int)this.Handle, "Base"));
            switch (StaticClasses.Config.Homemode)
            {
                case HomeMode.FullScreen:
                     FMainwnd = new Main_FullScreenList();
                    FMainwnd.ShowDialog();
                    break;
                case HomeMode.HalfHome:
                    halfMainwnd = new Mainwindow();
                    halfMainwnd.ShowDialog();
                    break;
            }
            this.Load += OpenAndClose;
            this.Shown += OpenAndClose;
        }

        private void OpenAndClose(object sender,EventArgs e)
        {
            this.Hide();
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
        #region WinMsg

        //COPYDATASTRUCT構造体 
        public struct COPYDATASTRUCT
        {
            public Int32 dwData;  //送信する32ビット値
            public Int32 cbData;  //lpDataのバイト数
            public string lpData;  //送信するデータへのポインタ(0も可能)
        }
        public const int WM_COPYDATA = 0x4A;
        public const int WM_USER = 0x400;
        private const int WM_QUERYENDSESSION = 0x11;

        // ウィンドウに来たメッセージを振り分ける関数
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case StaticClasses.WorkHubMessages.ApplicationQuit:
                    this.Dispose();
                    break;
                case WM_QUERYENDSESSION:
                    Functions.WinMsgFuncs.AppClose();
                    break;
                default:
                    break;
            }

            base.WndProc(ref m);
        }

        #endregion
    }
}