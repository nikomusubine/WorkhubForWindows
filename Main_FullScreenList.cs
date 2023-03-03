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

namespace WorkhubForWindows
{
    public partial class Main_FullScreenList : Form
    {
        private bool Quiting = false;

        public static Widget wg;
        public static SettingsForm sf;
        private Image rawImage;
        private bool explosed = false;
        public Main_FullScreenList()
        {

            InitializeComponent();
            this.Apps.SmallImageList = StaticClasses.IconList;
            this.Apps.LargeImageList = StaticClasses.IconList;
            initalizeApps();
            ApplistRC_RunAsAdmin.Image = Functions.WinAPIFuncs.GetSieldIcon(false).ToBitmap();


            //AddWindowHandler
            StaticClasses.WindowHandler.WindowHandlers.Add(new WorkhubWindowHandler((int)this.Handle, "MainForm"));
            this.LoadConfig();
            wg = new Widget();
            sf = new SettingsForm();
            Apps.View = View.LargeIcon;
            this.FormClosing += Form_Closing;
            StaticClasses.AppStatus.Started = true;
            StaticClasses.Langs.LoadLanguagePack("Languages\\" + StaticClasses.Config.Language + ".xml", ref StaticClasses.Langs);
            foreach (var i in StaticClasses.WindowHandler.WindowHandlers)
            {
                Functions.WinAPIFuncs.PostMessage(i.hWnd, StaticClasses.WorkHubMessages.LanguagePackLoad, 0, 0);
                Functions.WinAPIFuncs.PostMessage(i.hWnd, StaticClasses.WorkHubMessages.ConfigChanged, 0, 0);
            }
        }

        #region Events
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
                if (Functions.Application.StartProcess(StaticClasses.Executables[Apps.SelectedItems[i].Index]) == 1)
                {
                    StaticClasses.Executables[Apps.SelectedItems[i].Index] = new Executable(
                        StaticClasses.Executables[Apps.SelectedItems[i].Index].Name,
                        StaticClasses.Executables[Apps.SelectedItems[i].Index].Path,
                        StaticClasses.Executables[Apps.SelectedItems[i].Index].CurrentDir,
                        StaticClasses.Executables[Apps.SelectedItems[i].Index].Argments,
                        true
                        );
                    StaticClasses.LoadIcons();

                    Functions.Config.Applications.Save(StaticClasses.Executables);
                }
            }
        }

        private void EditPushed(object sender, EventArgs e)
        {
            EditItem ei = new EditItem();
            DialogResult diagres = ei.ShowDialog();

        }

        private void SettingsPushed(object sender, EventArgs e)
        {
            sf.ShowDialog();
        }

        private void ShowWidget(object sender, EventArgs e)
        {
            if (StaticClasses.Config.ShowWidget)
            {
                // MessageBox.Show("I'm sorry, but you can't use it now.\nPlease wait the future update...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                StaticClasses.Config.ShowWidget = false;
                TrayRC_ShowWidget.Checked = false;
                ToolStripShowWidget.Checked = false;
                StaticClasses.Config.SaveConfig();
            }
            else
            {
                // MessageBox.Show("I'm sorry, but you can't use it now.\nPlease wait the future update...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                StaticClasses.Config.ShowWidget = true;
                TrayRC_ShowWidget.Checked = true;
                ToolStripShowWidget.Checked = true;
                wg.Show();
                StaticClasses.Config.SaveConfig();
            }
        }

        private void RunAsAdminClicked(object sender, EventArgs e)
        {
            for (int i = 0; i != Apps.SelectedItems.Count; i++)
            {
                Functions.Application.StartProcess(StaticClasses.Executables[Apps.SelectedItems[i].Index], true);
            }
        }

        private void DeleteClicked(object sender, EventArgs e)
        {
            StaticClasses.Executables.RemoveAt(this.Apps.SelectedIndices[0]);

            Functions.Config.Applications.Save(StaticClasses.Executables);

            foreach (WorkhubWindowHandler i in StaticClasses.WindowHandler.WindowHandlers)
            {
                Functions.WinAPIFuncs.PostMessage(i.hWnd, StaticClasses.WorkHubMessages.AppListChanged, 0, 0);
            }
        }
        #region Explosion
        private const short ExpKeys= 3;
        bool[] keys = new bool[ExpKeys];
        private void KeyDownCalled(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.E:
                    keys[0] = true;
                    break;
                case Keys.X:
                    keys[1] = true;
                    break;
                case Keys.P:
                    keys[2] = true;
                    break;
            }
            bool isExplode = true;
            for (int i = 0; i != keys.Length; i++)
            {
                if (!keys[i])
                {
                    isExplode = false;
                    break;
                }
            }
            if (isExplode)
            {
                //Explode
                MessageBox.Show ("Explode!");
            }
        }

        private void KeyUpCalled(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.E:
                    keys[0] = false;
                    break;
                case Keys.X:
                    keys[1] = false;
                    break;
                case Keys.P:
                    keys[2] = false;
                    break;
            }
        }
        private void DeactivatedCalled(object sender,EventArgs e)
        {
            for(int i = 0; i != keys.Length; i++)
            {
                keys[i] = false;
            }
        }
        #endregion
        #endregion
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
                foreach(WorkhubWindowHandler wh in StaticClasses.WindowHandler.WindowHandlers)
                {
                    Functions.WinAPIFuncs.PostMessage(wh.hWnd, StaticClasses.WorkHubMessages.ApplicationQuit, 0, 0);
                }
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
                    rawImage=Image.FromFile(StaticClasses.Config.backimgpath);
                    BackgroundImageSet();


                }
                else if (StaticClasses.Config.backimgpath != "")
                {
                    StaticClasses.Config.backimgpath = "";

                }


            }
            else if(rawImage != null)
            {
                rawImage.Dispose();
            }
            this.BackColor = StaticClasses.Config.MainWindowBackColor;
            this.AddItemButton.BackColor = StaticClasses.Config.MainWindowBackColor;
            this.EditButton.BackColor = StaticClasses.Config.MainWindowBackColor;
            this.StartButton.BackColor = StaticClasses.Config.MainWindowBackColor;
            this.Ribbon.BackColor = StaticClasses.Config.MainWindowBackColor;
            this.ForeColor = StaticClasses.Config.MainWindowForeColor;
            this.Ribbon.ForeColor = StaticClasses.Config.MainWindowForeColor;
            this.Apps.ForeColor = StaticClasses.Config.MainWindowForeColor;
            this.TrayRC_ShowWidget.Checked = StaticClasses.Config.ShowWidget;
            this.ToolStripShowWidget.Checked = StaticClasses.Config.ShowWidget;
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
            ApplistRC_Add.Text = StaticClasses.Langs.Mainwindow.ApplistRC.Add;
            ApplistRC_Edit.Text = StaticClasses.Langs.Mainwindow.ApplistRC.Edit;
            ApplistRC_Delete.Text = StaticClasses.Langs.Mainwindow.ApplistRC.Delete;
            ApplistRC_RunAsAdmin.Text = StaticClasses.Langs.Mainwindow.ApplistRC.RunAdmin;
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
        private const int WM_QUERYENDSESSION = 0x11;

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
                case StaticClasses.WorkHubMessages.ApplicationQuit:
                    this.FormClosing -= Form_Closing;
                    Quiting = true;
                    StaticClasses.Config.SaveConfig();
                    this.Dispose();
                    break;
                case WM_QUERYENDSESSION:
                    this.FormClosing -= Form_Closing;
                    Quiting = true;
                    Functions.WinMsgFuncs.AppClose();
                    break;
                case WM_COPYDATA:
                    string[] tmpStrs = getString(m).Split('\t');
                    foreach (string str in tmpStrs)
                    {
                        AddItemForm additem = new AddItemForm(str);
                        additem.ShowDialog();
                        if (additem.ShowDialog() == DialogResult.OK)
                        {
                            initalizeApps();
                        }
                    }
                    break;
                default:
                    break;
            }

            base.WndProc(ref m);
        }

        private string getString(Message m)
        {
            string str = null;
            try
            {
                COPYDATASTRUCT cds = (COPYDATASTRUCT)m.GetLParam(typeof(COPYDATASTRUCT));
                str = cds.lpData;
                str = str.Substring(0, cds.cbData / 2);

            }
            catch (Exception)
            {
                str = null;
            }
            return str;
        }
        #endregion

        private void PaintCalled(object sender, EventArgs e)
        {
            if (rawImage != null)
            {
                BackgroundImageSet();
            }

        }

        void BackgroundImageSet()
        {
            if (Apps == null) { return; }
            Image image = new Bitmap(Apps.Width, Apps.Height);
            Graphics graphics = Graphics.FromImage(image);
            graphics.Clear(StaticClasses.Config.MainWindowBackColor);
            float x = rawImage.Size.Width, y = rawImage.Size.Height;
            if (y / (x / Apps.Width) < Apps.Height)//縦そろえる
            {
                graphics.DrawImage((Image)new Bitmap(rawImage, new Size(Apps.Width, (int)(y / (x / Apps.Width)))), 0, (Apps.Height - (int)(y / (x / Apps.Width))) / 2, Apps.Width, (int)(y / (x / Apps.Width)));

                this.Apps.BackgroundImage = image;
            }
            else
            {
                graphics.DrawImage((Image)new Bitmap(rawImage, new Size((int)(x / (y / Apps.Height)), Apps.Height))
                    , (Apps.Width - (int)(x / (y / Apps.Height))) / 2, 0, (int)(x / (y / Apps.Height)), Apps.Height);

                this.Apps.BackgroundImage = image;
            }
        }
        private void DragAndDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (string str in files)
            {
                string Extention = Path.GetExtension(str);
                if (Extention == ".lnk")
                {
                    IWshRuntimeLibrary.WshShell shell = new IWshRuntimeLibrary.WshShell();
                    // ショートカットオブジェクトの取得
                    IWshRuntimeLibrary.IWshShortcut shortcut = (IWshRuntimeLibrary.IWshShortcut)shell.CreateShortcut(str);

                    // ショートカットのリンク先の取得
                    string targetPath = shortcut.TargetPath.ToString();
                    if (Path.GetExtension(targetPath) == ".exe")
                    {
                        AddItemForm additemform = new AddItemForm(targetPath, Path.GetFileNameWithoutExtension(str));
                        if (additemform.ShowDialog() == DialogResult.OK)
                        {
                            initalizeApps();
                        }
                    }
                }
                else
                if (Extention == ".exe")
                {
                    AddItemForm additemform = new AddItemForm(str);
                    if (additemform.ShowDialog() == DialogResult.OK)
                    {
                        initalizeApps();
                    }
                }
            }
        }

        private void EnterDragItem(object sender,DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            bool CanDrop = true;
            foreach (string str in files)
            {
                string Extention = Path.GetExtension(str);
                if (Extention != ".exe" && Extention != ".lnk")
                {
                    CanDrop = false;
                }
            }

            if (e.Data.GetDataPresent(DataFormats.FileDrop) && CanDrop)
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
    }

}