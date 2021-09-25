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

namespace WorkhubForWindows
{
    public partial class Mainwindow : Form
    {
        private bool Quiting = false;
        public Mainwindow()
        {
            InitializeComponent();
            initalizeApps();
            StaticClasses.Config = StaticClasses.Config.LoadConfig();
            this.Font=new Font(StaticClasses.Config.font.Name,StaticClasses.Config.font.Size);
            Apps.View = View.LargeIcon;
            this.FormClosing += Form_Closing;
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

        }

        private void SettingsPushed(object sender, EventArgs e)
        {
            SettingsForm sform = new SettingsForm();
            if (sform.ShowDialog() == DialogResult.OK)
            {
                this.Font = new Font(StaticClasses.Config.font.Name,StaticClasses.Config.font.Size);
                
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
                StaticClasses.Config.SaveConfig(StaticClasses.Config);
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

        #region QuitCancel
        private void Form_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!Quiting)
            {
                e.Cancel = true;
                this.WindowState = FormWindowState.Minimized;
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


        }
    }
}
