using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace WorkhubForWindows.Forms
{
    public partial class SettingsForm : Form
    {
        private string aplTitle = null; // アプリ名
        private string exeFile = null;  // exeファイル名
        private string jsFile = null;   // スクリプトファイル名
        private string lnkFile = null;  // リンク名
        private bool frmLoadFlg = false; // Form1ロード済みか
        private bool isstartup = false;
        private Color WidgetForeColor;
        private Color WidgetBackColor;
        private Color MainForeColor;
        private Color MainBackColor;
        private Shortcut shortcut;

        public SettingsForm()
        {
            InitializeComponent();
            this.Font = StaticClasses.Config.font;
            // プロジェクト＞プロパティ＞アセンブリ情報　で指定した「タイトル」を取得
            var assembly = Assembly.GetExecutingAssembly();
            var attribute = Attribute.GetCustomAttribute(
              assembly,
              typeof(AssemblyTitleAttribute)
            ) as AssemblyTitleAttribute;
            aplTitle = attribute.Title;
            this.Text = aplTitle;

            // 自身のexeファイル名を取得
            exeFile = Path.GetFileName(Application.ExecutablePath);

            // WSHスクリプト名
            //jsFile = Directory.GetParent(Application.ExecutablePath) + "\\addStartup.js";
            jsFile = AppDomain.CurrentDomain.BaseDirectory + "\\addStartup.js";

            // ショートカットのリンク名
            string sMnu = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
            lnkFile = sMnu + "\\" + aplTitle + ".lnk";


        }

        #region EventHandlers
        private void Settings_Load(object sender, EventArgs e)
        {
            
            // スタートアップ有無
            isstartup = File.Exists(lnkFile);

            if (isstartup)
            {
                StartUpbutton.Text = StaticClasses.Langs.Settings.Startup_Remove;
            }
            else
            {
                StartUpbutton.Text = StaticClasses.Langs.Settings.Startup_Add;
            }
            frmLoadFlg = true;

            FontNames.Items.Clear();
            foreach (FontFamily item in FontFamily.Families)
            {
                if (item.IsStyleAvailable(FontStyle.Regular))
                {
                    FontNames.Items.Add(item.Name);
                }

            }
            initalizeform();
            LanguageLoad();
        }

        private void FontSizeKeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void BackImgRefClick(object sender, EventArgs e)
        {
            OpenFileDialog ofdiag = new OpenFileDialog();
            ofdiag.InitialDirectory = backimgpath.Text;
            ofdiag.Filter = "Image File(*.bmp;*.png;*.jpg;*.jpeg) |*.bmp;*.png;*.jpg;*.jpeg";

            if (ofdiag.ShowDialog() == DialogResult.OK)
            {
                backimgpath.Text = ofdiag.FileName;
            }
            ofdiag.Dispose();
        }

        private void WidgetBackImgRefClick(object sender, EventArgs e)
        {
            OpenFileDialog ofdiag = new OpenFileDialog();
            ofdiag.InitialDirectory = widgetbackimgpath.Text;

            ofdiag.Filter = "Image File(*.bmp;*.png;*.jpg;*.jpeg) |*.bmp;*.png;*.jpg;*.jpeg";

            if (ofdiag.ShowDialog() == DialogResult.OK)
            {
                widgetbackimgpath.Text = ofdiag.FileName;
            }
            ofdiag.Dispose();
        }

        private void AddStartUpClicked(object sender,EventArgs e)
        {
            if (!frmLoadFlg) return;

            if (!isstartup)
            {
                // スタートアップフォルダにショートカット作成
                try
                {
                    // WSHファイル作成
                    using (StreamWriter w = new StreamWriter(
                        jsFile, false, System.Text.Encoding.GetEncoding("shift_jis")))
                    {
                        w.WriteLine("ws = WScript.CreateObject('WScript.Shell');");
                        w.WriteLine("ln = ws.SpecialFolders('Startup') + '\\\\' + '" + aplTitle + ".lnk';");
                        w.WriteLine("sc = ws.CreateShortcut(ln);");
                        StringBuilder sb = new StringBuilder();
                        StringBuilder tmp = new StringBuilder();
                        string[] dividedText = (AppDomain.CurrentDomain.BaseDirectory + exeFile).Split('\\');
                        for(int i = 0; i != dividedText.Length; i++)
                        {
                            tmp.Clear();
                            tmp.Append(dividedText[i]);
                            tmp.Append("\\\\");
                            sb.Append(tmp.ToString());
                        }
                        w.WriteLine("sc.TargetPath = \'" + sb.ToString() + "';");
                        w.WriteLine("sc.Save();");
                    }

                    // addStartup.jsを実行し、スタートアップにショートカット作成
                    if (File.Exists(jsFile))
                    {
                        ProcessStartInfo psi = new ProcessStartInfo();
                        psi.FileName = "cscript";
                        psi.Arguments = @"//e:jscript " + jsFile;
                        psi.Verb = "RunAs"; 
                        psi.WindowStyle = ProcessWindowStyle.Hidden;
                        Process p = Process.Start(psi);

                        p.WaitForExit(10000); // 終了まで待つ(最大10秒)
                        File.Delete(jsFile);
                    }
                    // スタートアップフォルダに登録されたか確認
                    if (File.Exists(lnkFile))
                    {
                        MessageBox.Show(
                            "Successful to add\n\n" + lnkFile,
                            aplTitle,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        StartUpbutton.Text = StaticClasses.Langs.Settings.Startup_Remove;
                        isstartup = true;
                    }
                    else
                    {
                        MessageBox.Show(
                            "Failed to add!\n\n" + lnkFile,
                            aplTitle,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Failed to add!\n\n" + ex.Message,
                        aplTitle,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            else
            {
                // スタートアップフォルダに登録済みか確認
                if (File.Exists(lnkFile))
                {
                    try
                    {
                        File.Delete(lnkFile);
                        MessageBox.Show(
                            "Success to remove",
                            aplTitle,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        StartUpbutton.Text = StaticClasses.Langs.Settings.Startup_Add;
                        isstartup = false;
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show(
                            "Failed to remove!\n\n" + ex.Message,
                            aplTitle,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
            }

        }

        private void Settings_Closed(object sender,FormClosedEventArgs e)
        {

        }

        private void FormShown(object sender,EventArgs e)
        {
            FontNames.Items.Clear();
            foreach (FontFamily item in FontFamily.Families)
            {
                if (item.IsStyleAvailable(FontStyle.Regular))
                {
                    FontNames.Items.Add(item.Name);
                }

            }
            initalizeform();
            LanguageLoad();
        }

        private void OpacityBarScroll(object sender,EventArgs e)
        {
            OpacityBox.Value = OpacityBar.Value;
        }

        private void OpacityBoxChanged(object sender,EventArgs e)
        {
            OpacityBar.Value = (int)OpacityBox.Value;
        }

        private void WidgetForeColorChangeButtonClicked(object sender,EventArgs e)
        {
            ColorDiag.Color = WidgetForeColor;
            if (ColorDiag.ShowDialog() == DialogResult.OK)
            {
                WidgetForeColor = ColorDiag.Color;
            }
        }

        private void WidgetBackColorChange(object sender,EventArgs e)
        {
            ColorDiag.Color = WidgetBackColor;
            if (ColorDiag.ShowDialog() == DialogResult.OK)
            {
                WidgetBackColor = ColorDiag.Color;
            }
        }

        private void MainTextColorButton_Click(object sender, EventArgs e)
        {
            ColorDiag.Color = MainForeColor;
            if (ColorDiag.ShowDialog() == DialogResult.OK)
            {
                MainForeColor = ColorDiag.Color;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDiag.Color = MainBackColor;
            if (ColorDiag.ShowDialog() == DialogResult.OK)
            {
                MainBackColor = ColorDiag.Color;
            }
        }
        private void RegesterHotKeyButtonClicked(object sender,EventArgs e)
        {
            HotKeyRegester hotkey = new HotKeyRegester();
            hotkey.ShowDialog();
            if (!hotkey.Canceled)
            {
                shortcut.Modifires = hotkey.PressedKeyModifires;
                shortcut.keys = hotkey.PressedKeys;

                HotkeyBox.Text = shortcut.ToString();
            }
            hotkey.Dispose();
        }

        #region WidgetSizeChanged
        private void WidgetSizeBoxChanged(object sender,EventArgs e)
        {
            WidgetSizeBar.Value = (int)WidgetSizeBox.Value;
        }
        private void WidgetSizeBarChanged(object sender, EventArgs e)
        {
            WidgetSizeBox.Value = WidgetSizeBar.Value;
        }
        #endregion

        private void ResetWidgetPosition_Clicked(object sender,EventArgs e)
        {
            StaticClasses.Config.WidgetPosition = new Vector2(0, 0);
            foreach (var i in StaticClasses.WindowHandler.WindowHandlers)
            {
                if (i.Name == "Widget")
                {
                    Functions.WinAPIFuncs.PostMessage(i.hWnd, StaticClasses.WorkHubMessages.WidgetConfigChanged, 0, 0);
                }
            }
        }

        #region Apply or Cancel
        private void ApplyClicked(object sender, EventArgs e)
        {
            #region Change Config
            OwnFont ftmp = new OwnFont(FontNames.Text, Convert.ToSingle(FontSizeBox.Text));
            StaticClasses.Config.font = ftmp;
            StaticClasses.Config.backimgpath = backimgpath.Text;
            StaticClasses.Config.Widgetbackimg = widgetbackimgpath.Text;
            StaticClasses.Config.WidgetOpacity = (double)OpacityBox.Value / 100;
            StaticClasses.Config.WidgetForeColor = WidgetForeColor;
            StaticClasses.Config.WidgetBackColor = WidgetBackColor;
            StaticClasses.Config.MainWindowForeColor = MainForeColor;
            StaticClasses.Config.MainWindowBackColor = MainBackColor;
            StaticClasses.Config.Language = this.LanguageBox.Text;
            
            float Div = (float)StaticClasses.Config.WidgetSize.Height / StaticClasses.Config.WidgetSize.Width;
            StaticClasses.Config.WidgetSize = new Size((int)WidgetSizeBox.Value, (int)((int)WidgetSizeBox.Value * Div));
            StaticClasses.Config.WidgetShortcutKey = shortcut;
            #endregion
            StaticClasses.Config.SaveConfig(StaticClasses.Config);
            StaticClasses.Config.ApplyConfig();
            StaticClasses.Langs.LoadLanguagePack("Languages\\" + StaticClasses.Config.Language + ".xml", ref StaticClasses.Langs);
            if (MainWndStyleFull.Checked)
            {
                StaticClasses.Config.Homemode = HomeMode.FullScreen;
            }
            else
            {
                StaticClasses.Config.Homemode = HomeMode.HalfHome;
            }
            foreach (var i in StaticClasses.WindowHandler.WindowHandlers)
            {
                Functions.WinAPIFuncs.PostMessage(i.hWnd, StaticClasses.WorkHubMessages.LanguagePackLoad, 0, 0);
            }


            this.Close();
        }

        private void CancelClicked(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        #endregion
        #endregion

        #region Functions
        void initalizeform()
        {

            shortcut = new Shortcut(StaticClasses.Config.WidgetShortcutKey);
            FontNames.Text = StaticClasses.Config.font.Name;
            FontSizeBox.Text = StaticClasses.Config.font.Size.ToString();

            widgetbackimgpath.Text = StaticClasses.Config.Widgetbackimg;
            backimgpath.Text = StaticClasses.Config.backimgpath;

            OpacityBar.Value = (int)(StaticClasses.Config.WidgetOpacity * 100);
            OpacityBox.Value = (int)(StaticClasses.Config.WidgetOpacity * 100);

            WidgetForeColor = StaticClasses.Config.WidgetForeColor;
            WidgetBackColor = StaticClasses.Config.WidgetBackColor;
            WidgetSizeBox.Value = StaticClasses.Config.WidgetSize.Width;
            WidgetSizeBar.Value = StaticClasses.Config.WidgetSize.Height;
            HotkeyBox.Text = shortcut.ToString();

            MainForeColor = StaticClasses.Config.MainWindowForeColor;
            MainBackColor = StaticClasses.Config.MainWindowBackColor;
            switch (StaticClasses.Config.Homemode)
            {
                case HomeMode.HalfHome:
                    MainWndStyleFull.Checked = false;
                    MainWndStyleHalf.Checked = true;
                    break;
                case HomeMode.FullScreen:
                    MainWndStyleFull.Checked = true;
                    MainWndStyleHalf.Checked = false;
                    break;

            }
            LanguageBox.Items.Clear();
            LanguageBox.Text = StaticClasses.Config.Language;
            foreach (string str in Directory.GetFiles("Languages","*.xml",SearchOption.TopDirectoryOnly))
            {
                string temp = str.Split('\\')[str.Split('\\').Length - 1];
                temp = temp.Split('.')[0];
                LanguageBox.Items.Add(temp);
            }
        }

        void LanguageLoad()
        {
            if (StaticClasses.Langs.Settings.Tab_General != null)
            {
                this.General.Text = StaticClasses.Langs.Settings.Tab_General;
            }
            if (StaticClasses.Langs.Settings.Tab_Widget != null)
            {
                this.Widget.Text = StaticClasses.Langs.Settings.Tab_Widget;
            }
            if (StaticClasses.Langs.Settings.Label_Font != null)
            {
                this.FontLabel.Text = StaticClasses.Langs.Settings.Label_Font;
            }
            if (StaticClasses.Langs.Settings.Label_MainBackimgPath != null)
            {
                this.backimglabel.Text = StaticClasses.Langs.Settings.Label_MainBackimgPath;
            }
            if (StaticClasses.Langs.Settings.Label_WidgetBackimgPath != null)
            {
                this.widgetbackimg.Text = StaticClasses.Langs.Settings.Label_WidgetBackimgPath;
            }
            if (StaticClasses.Langs.Settings.Label_Language != null)
            {
                this.LanguageLabel.Text = StaticClasses.Langs.Settings.Label_Language;
            }
            if (StaticClasses.Langs.Settings.Label_Opacity != null)
            {
                this.OpacityLabel.Text = StaticClasses.Langs.Settings.Label_Opacity;
            }
            if (StaticClasses.Langs.Settings.Label_WidgetTextColor != null)
            {
                this.WidgetForeColorLabel.Text = StaticClasses.Langs.Settings.Label_WidgetTextColor;
            }
            if (StaticClasses.Langs.Settings.Label_WidgetBackColor != null)
            {
                this.WidgetBackColorLabel.Text = StaticClasses.Langs.Settings.Label_WidgetBackColor;
            }
            if (StaticClasses.Langs.Settings.Label_WidgetSize != null)
            {
                this.WidgetSizeLabel.Text = StaticClasses.Langs.Settings.Label_WidgetSize;
            }
            if (StaticClasses.Langs.Settings.Label_MainWndStyle != null)
            {
                this.MainWndStyleLabel.Text = StaticClasses.Langs.Settings.Label_MainWndStyle;
            }
            if (StaticClasses.Langs.Settings.Label_NeedsRestart != null)
            {
                this.NeedsToRebootLabel.Text = StaticClasses.Langs.Settings.Label_NeedsRestart;
            }
            if (StaticClasses.Langs.Settings.Label_MainTextColor != null)
            {
                this.Main_TextColor.Text = StaticClasses.Langs.Settings.Label_MainTextColor;
            }
            if (StaticClasses.Langs.Settings.Label_MainBackColor != null)
            {
                this.MainBackColorLabel.Text = StaticClasses.Langs.Settings.Label_MainBackColor;
            }

            if (StaticClasses.Langs.Settings.Button_Cancel != null)
            {
                this.Cancel_Button.Text = StaticClasses.Langs.Settings.Button_Cancel;
            }
            if (StaticClasses.Langs.Settings.Button_Apply != null)
            {
                this.ApplyButton.Text = StaticClasses.Langs.Settings.Button_Apply;
            }
            if (StaticClasses.Langs.Settings.Button_HotkeySet != null)
            {
                this.HotKeySetButton.Text = StaticClasses.Langs.Settings.Button_HotkeySet;
            }
            if (StaticClasses.Langs.Settings.Button_ResetWidgetPos != null)
            {
                this.ResetWidgetPosition.Text = StaticClasses.Langs.Settings.Button_ResetWidgetPos;
            }
        }
        #endregion
            
        private void ResetWidgetPosition_Click(object sender, EventArgs e)
        {
            foreach(var i in StaticClasses.WindowHandler.WindowHandlers)
            {
                if (i.Name == "Widget")
                {
                    Functions.WinAPIFuncs.PostMessage(i.hWnd, StaticClasses.WorkHubMessages.WidgetPositionReset, 0, 0);
                    StaticClasses.Config.WidgetPosition = new Point(0, 0);
                }
            }
        }

        private void FontNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            FontNames.Font = new Font(FontNames.Text, StaticClasses.Config.font.Size);
        }

        
    }
}