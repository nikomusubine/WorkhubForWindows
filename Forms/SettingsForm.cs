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
        }

        private void Settings_Load(object sender, EventArgs e)
        {
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
            #endregion
            StaticClasses.Config.SaveConfig(StaticClasses.Config);
            StaticClasses.Config.ApplyConfig();
            this.Close();
        }

        private void CancelClicked(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
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
        }
        #endregion
    }
}
