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
    public partial class Mainwindow : Form
    {
        private bool Quiting = false;

        public static Widget wg;
        public Mainwindow()
        {
            string name = Process.GetCurrentProcess().ProcessName;
            Process[] processes = Process.GetProcessesByName(name);
            for (int i = 0; i < processes.Length; i++)
            {
                Process proc = processes[i];
                if (proc.ProcessName == name && proc.MainWindowTitle == "WorkhubForWindows")
                {
                    Functions.WinAPIFuncs.PostMessage((int)proc.MainWindowHandle, StaticClasses.WorkHubMessages.ShowMainWindow, 0, 0);
                    this.Dispose();
                    Environment.Exit(1);
                }
            }
            InitializeComponent();
            this.Apps.SmallImageList = StaticClasses.IconList;
            this.Apps.LargeImageList = StaticClasses.IconList;
            StaticClasses.IconList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            StaticClasses.IconList.TransparentColor = Color.Transparent;
            StaticClasses.IconList.ImageSize = new Size(32, 32);
            StaticClasses.Config = StaticClasses.Config.LoadConfig();
            initalizeApps();
            RunAsAdmin.Image = Functions.WinAPIFuncs.GetSieldIcon(false).ToBitmap();
                        

            //AddWindowHandler
            StaticClasses.WindowHandler.WindowHandlers.Add(new WorkhubWindowHandler((int)this.Handle, "MainForm"));
            this.LoadConfig();
            wg = new Widget();
            Apps.View = View.LargeIcon;
            this.FormClosing += Form_Closing;
            StaticClasses.AppStatus.Started = true;
            StaticClasses.Langs.LoadLanguagePack("Languages\\" + StaticClasses.Config.Language + ".xml",ref StaticClasses.Langs);
            foreach (var i in StaticClasses.WindowHandler.WindowHandlers)
            {
                Functions.WinAPIFuncs.PostMessage(i.hWnd, StaticClasses.WorkHubMessages.LanguagePackLoad, 0, 0);
                Functions.WinAPIFuncs.PostMessage(i.hWnd, StaticClasses.WorkHubMessages.ConfigChanged, 0, 0);
            }
        }

        private void MainWindowShown(object sender, EventArgs e)
        {
            wg.Show();
        }

        private void Additem(object sender, EventArgs e)
        {
            AddItemForm additemform = new AddItemForm();
            if (additemform.ShowDialog() == DialogResult.OK)
            {
                initalizeApps();
            }
        }

        private void StartPushed(object sender, EventArgs e)
        {
            for (int i = 0; i != Apps.SelectedItems.Count; i++)
            {
                Functions.Application.StartProcess(StaticClasses.Executables[Apps.SelectedItems[i].Index]);
            }
        }

        private void EditPushed(object sender, EventArgs e)
        {
            EditItem ei = new EditItem();
            DialogResult diagres = ei.ShowDialog();

        }

        private void SettingsPushed(object sender, EventArgs e)
        {
            SettingsForm sform = new SettingsForm();
            sform.ShowDialog();
        }

        private void ShowWidget(object sender, EventArgs e)
        {
            if (StaticClasses.Config.ShowWidget)
            {
                // MessageBox.Show("I'm sorry, but you can't use it now.\nPlease wait the future update...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                StaticClasses.Config.ShowWidget = false;
                TrayRC_ShowWidget.Checked = false;
                ToolStripShowWidget.Checked = false;
            }
            else
            {
                // MessageBox.Show("I'm sorry, but you can't use it now.\nPlease wait the future update...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                StaticClasses.Config.ShowWidget = true;
                TrayRC_ShowWidget.Checked = true;
                ToolStripShowWidget.Checked = true;
                wg.Show();
            }
        }

        private void RunAsAdminClicked(object sender,EventArgs e)
        {
            for (int i = 0; i != Apps.SelectedItems.Count; i++)
            {
                Functions.Application.StartProcess(StaticClasses.Executables[Apps.SelectedItems[i].Index]);
            }
        }

        private void DeleteClicked(object sender,EventArgs e)
        {
            StaticClasses.Executables.RemoveAt(this.Apps.SelectedIndices[0]);

            Functions.Config.Applications.Save(StaticClasses.Executables);

            foreach (WorkhubWindowHandler i in StaticClasses.WindowHandler.WindowHandlers)
            {
                Functions.WinAPIFuncs.PostMessage(i.hWnd, StaticClasses.WorkHubMessages.AppListChanged, 0, 0);
            }
        }

        #region TrayRClick

        private void ShowMainWindow(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Normal;
            this.Show();
            this.TopMost = true;
            this.TopMost = false;
        }

        private void Quit(object sender, EventArgs e)
        {
            DialogResult diagres = MessageBox.Show(StaticClasses.Langs.Mainwindow.MB_Quit_Verif, "infomation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (diagres == DialogResult.Yes)
            {
                Quiting = true;
                this.Close();
                //Environment.Exit(0);
            }
        }
        #endregion

        #region Quit
        private void Form_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!Quiting)
            {
                e.Cancel = true;
                //this.WindowState = FormWindowState.Minimized;
                this.Hide();
            }
            else
            {
                Functions.WinMsgFuncs.AppClose();
            }
        }

        private void SystemEvents_SessionEnding(object sender, SessionEndingEventArgs e)
        {
            if (e.Reason == SessionEndReasons.Logoff)
            {

            }
            else if (e.Reason == SessionEndReasons.SystemShutdown)
            {

            }
            Quiting = true;
            Functions.WinMsgFuncs.AppClose();
            this.Close();
        }
        #endregion

        #region Functions
        /// <summary>
        /// アプリケーションの読み込み
        /// Load Applications
        /// </summary>
        void initalizeApps()
        {
            Apps.Clear();
            StaticClasses.Executables = Functions.Config.Applications.Load();

            StaticClasses.LoadIcons();
            for (int i = 0; i != StaticClasses.Executables.Count; i++)
            {
                Apps.Items.Add(StaticClasses.Executables[i].Name/*.Replace(' ','\n')*/);
                Apps.Items[Apps.Items.Count - 1].ImageIndex = Apps.Items.Count - 1;
            }

            Functions.Config.Applications.Save(StaticClasses.Executables);
        }

        void LoadConfig()
        {
            this.Font = new Font(StaticClasses.Config.font.Name, StaticClasses.Config.font.Size);

            if (StaticClasses.Config.backimgpath != "")
            {
                if (File.Exists(StaticClasses.Config.backimgpath))
                {
                    if (StaticClasses.Config.Homemode == HomeMode.HalfHome)
                    {
                        this.HalfModebackimg.BackgroundImage = Image.FromFile(StaticClasses.Config.backimgpath);
                    }
                }
                else if (StaticClasses.Config.backimgpath != "")
                {
                    StaticClasses.Config.backimgpath = "";

                }

                this.TrayRC_ShowWidget.Checked = StaticClasses.Config.ShowWidget;
                this.ToolStripShowWidget.Checked = StaticClasses.Config.ShowWidget;
            }
        }

        void LoadLanguage()
        {
            
            AddItemButton.Text = StaticClasses.Langs.Mainwindow.AdditemButton;
            EditButton.Text = StaticClasses.Langs.Mainwindow.EdititemButton;
            StartButton.Text = StaticClasses.Langs.Mainwindow.StartButton;
            RibbonFiles.Text = StaticClasses.Langs.Mainwindow.RibbonFiles.Text;
            Ribbon_Settings.Text = StaticClasses.Langs.Mainwindow.RibbonFiles.Settings;
            ToolStripShowWidget.Text = StaticClasses.Langs.Mainwindow.RibbonFiles.ShowWidget;
            ToolStripQuit.Text = StaticClasses.Langs.Mainwindow.RibbonFiles.Quit;
            TrayRC_ShowMain.Text = StaticClasses.Langs.Mainwindow.TasktrayIcon.ShowMainWindow;
            TrayRC_ShowWidget.Text = StaticClasses.Langs.Mainwindow.TasktrayIcon.ShowWidget;
            TrayRC_Settings.Text = StaticClasses.Langs.Mainwindow.TasktrayIcon.Settings;    
            TrayRC_AddItem.Text = StaticClasses.Langs.Mainwindow.TasktrayIcon.AddItem;
            TrayRC_Quit.Text = StaticClasses.Langs.Mainwindow.TasktrayIcon.Quit;

        }
        #endregion
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

        // ウィンドウに来たメッセージを振り分ける関数
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case StaticClasses.WorkHubMessages.ConfigChanged:
                    this.LoadConfig();
                    break;
                case StaticClasses.WorkHubMessages.AppListChanged:
                    initalizeApps();
                    break;
                case StaticClasses.WorkHubMessages.LanguagePackLoad:
                    LoadLanguage();
                    break;
                case StaticClasses.WorkHubMessages.ShowMainWindow:
                    this.Show();
                    this.TopMost = true;
                    this.TopMost = false;
                    break;
                default:
                    break;
            }

            base.WndProc(ref m);
        }

        #endregion
    }
}