using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
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

        public SettingsForm()
        {
            InitializeComponent();

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

        #region EventHandlers
        private void Settings_Load(object sender, EventArgs e)
        {
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
            jsFile = Directory.GetParent(Application.ExecutablePath) + "\\addStartup.js";

            // ショートカットのリンク名
            String sMnu = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
            lnkFile = sMnu + "\\" + aplTitle + ".lnk";


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
        }

        private void FontSizeKeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void BackImgRefClick(object sender, EventArgs e)
        {
            OpenFileDialog ofdiag = new OpenFileDialog();

            ofdiag.Filter = "Image File(*.bmp;*.png;*.jpg;*.jpeg) |*.bmp;*.png;*.jpg;*.jpeg";

            if (ofdiag.ShowDialog() == DialogResult.OK)
            {
                backimgpath.Text = ofdiag.FileName;
            }

        }

        private void WidgetBackImgRefClick(object sender, EventArgs e)
        {
            OpenFileDialog ofdiag = new OpenFileDialog();

            ofdiag.Filter = "Image File(*.bmp;*.png;*.jpg;*.jpeg) |*.bmp;*.png;*.jpg;*.jpeg";

            if (ofdiag.ShowDialog() == DialogResult.OK)
            {
                widgetbackimgpath.Text = ofdiag.FileName;
            }

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
                        w.WriteLine("sc.TargetPath = ws.CurrentDirectory + '\\\\" + exeFile + "';");
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
            this.Dispose();
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
            StaticClasses.Config.Language = this.LanguageBox.Text;
            #endregion
            StaticClasses.Config.SaveConfig(StaticClasses.Config);
            StaticClasses.Config.ApplyConfig();
            StaticClasses.Langs.LoadLanguagePack("Languages\\" + StaticClasses.Config.Language + ".xml", ref StaticClasses.Langs);
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
            FontNames.Text = StaticClasses.Config.font.Name;
            FontSizeBox.Text = StaticClasses.Config.font.Size.ToString();

            widgetbackimgpath.Text = StaticClasses.Config.Widgetbackimg;
            backimgpath.Text = StaticClasses.Config.backimgpath;

            OpacityBar.Value = (int)(StaticClasses.Config.WidgetOpacity * 100);
            OpacityBox.Value = (int)(StaticClasses.Config.WidgetOpacity * 100);

            WidgetForeColor = StaticClasses.Config.WidgetForeColor;
            WidgetBackColor = StaticClasses.Config.WidgetBackColor;

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
            if (StaticClasses.Langs.Settings.Label_WidgetSCKey != null)
            {
                this.WidgetSCKeyLabel.Text = StaticClasses.Langs.Settings.Label_WidgetSCKey;
            }
            if (StaticClasses.Langs.Settings.Button_Cancel != null)
            {
                this.Cancel_Button.Text = StaticClasses.Langs.Settings.Button_Cancel;
            }
            if (StaticClasses.Langs.Settings.Button_Apply != null)
            {
                this.ApplyButton.Text = StaticClasses.Langs.Settings.Button_Apply;
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
    }
}