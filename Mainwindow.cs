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

namespace WorkhubForWindows
{
    public partial class Mainwindow : Form
    {
        private bool Quiting = false;
        public Mainwindow()
        {
            InitializeComponent();
            initalizeApps();

            Widget wg = new Widget();
            wg.Show();
            //AddWindowHandler
            StaticClasses.WindowHandler.WindowHandlers.Add(new WorkhubWindowHandler((int)this.Handle,"MainForm"));
            StaticClasses.Config = StaticClasses.Config.LoadConfig();
            this.LoadConfig();
            Apps.View = View.LargeIcon;
            this.FormClosing += Form_Closing;

            StaticClasses.AppStatus.Started = true;
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
            if (sform.ShowDialog() == DialogResult.OK)
            {
                
                StaticClasses.Config.SaveConfig(StaticClasses.Config);
            }
        }

        private void ShowWidget(object sender,EventArgs e)
        {
            if (StaticClasses.Config.ShowWidget)
            {
                StaticClasses.Config.ShowWidget = false;
            }else
            {
                StaticClasses.Config.ShowWidget = true;
            }
            foreach (var i in StaticClasses.WindowHandler.WindowHandlers)
            {
                if (i.Name == "Widget") {
                    Functions.WinAPIFuncs.PostMessage(i.hWnd, StaticClasses.WorkHubMessages.WidgetConfigChanged, 0, 0);
                 }
            }
        }


        #region TrayRClick
                
        private void ShowMainWindow(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.TopMost = true;
            this.TopMost = false;
        }

        private void Quit(object sender,EventArgs e)
        {
            DialogResult diagres = MessageBox.Show("Quit Application?", "infomation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (diagres == DialogResult.Yes)
            {
                Quiting = true;
                Environment.Exit(0);
            }
        }
        #endregion

        #region Quit
        private void Form_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!Quiting)
            {
                e.Cancel = true;
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void SystemEvents_SessionEnding(object sender, SessionEndingEventArgs e)
        {
            if (e.Reason == SessionEndReasons.Logoff)
            {
                Quiting = true;
                Environment.Exit(0);
            }
            else if (e.Reason == SessionEndReasons.SystemShutdown)
            {
                Quiting = true;
                Environment.Exit(0);
            }
        }
        #endregion

        /// <summary>
        /// アプリケーションの読み込み
        /// Load Applications
        /// </summary>
        void initalizeApps()
        {
            Apps.Clear();
            IconList.Images.Clear();
            StaticClasses.Executables = Functions.Config.Applications.Load();

            for (int i = 0; i != StaticClasses.Executables.Count; i++)
            {
                if (!File.Exists(StaticClasses.Executables[i].Path))
                {
                    MessageBox.Show("A File was not found! \nThe file will be removed from the list. ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    StaticClasses.Executables.RemoveAt(i);
                    i--;
                    continue;
                }
                Bitmap bmp = Icon.ExtractAssociatedIcon(StaticClasses.Executables[i].Path).ToBitmap();

                IconList.Images.Add(StaticClasses.Executables[i].Name, bmp);
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
                    this.BackgroundImage = Image.FromFile(StaticClasses.Config.backimgpath);
                }
                else
                {
                    StaticClasses.Config.backimgpath = "";

                }
            }

            this.TrayRC_ShowWidget.Checked = StaticClasses.Config.ShowWidget;
            this.ToolStripShowWidget.Checked = StaticClasses.Config.ShowWidget;
        }
    }
}
