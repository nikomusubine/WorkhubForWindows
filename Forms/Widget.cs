using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WorkhubForWindows
{
    public partial class Widget : Form
    {
        // private static int lngWnP;
        public Widget()
        {

            InitializeComponent();
            initalizeapplistview();
            Button appcall = new Button();
            this.AcceptButton = appcall;
            appcall.Click += appstartcall;
            this.FormClosing += Form_Closing;

            int ScrollBW = new VScrollBar().Width;
            this.Size = new Size(this.Size.Width + ScrollBW, this.Size.Height);
            this.applistview.Size = new Size(this.applistview.Size.Width + ScrollBW, this.applistview.Size.Height);

            Backgroundset();
            //AddWindowHandler
            StaticClasses.WindowHandler.WindowHandlers.Add(new WorkhubWindowHandler((int)this.Handle, "Widget"));
            LoadLanguage();

          //  Application.AddMessageFilter(MsgFilter);
        }

        private void ShowWidget(object sender, EventArgs e)
        {
            this.LoadConfig();
            Backgroundset();
        }

        private void App_Closing()
        {

        }

        private void appstartcall(object sender, EventArgs e)
        {
            if (applistview.SelectedIndices.Count != 0)
            {
                Functions.Application.StartProcess(StaticClasses.Executables[applistview.SelectedIndices[0]]);
            }   
        }

        private void Form_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            //this.WindowState = FormWindowState.Minimized;
            this.Hide();
            StaticClasses.Config.ShowWidget = false;
        }

        #region Right Click ContextMenu
        private void LockWidget_Click(object sender, EventArgs e)
        {
            if (StaticClasses.Config.LockWidget)
            {
                StaticClasses.Config.LockWidget = false;
            }
            else
            {
                StaticClasses.Config.LockWidget = true;
            }

            StaticClasses.Config.SaveConfig();
        }
        #endregion

        #region Functions
        /// <summary>
        /// アプリケーションの読み込み
        /// Load Applications
        /// </summary>
        void initalizeapplistview()
        {
            applistview.Clear();
            IconList.Images.Clear();
            StaticClasses.Executables = Functions.Config.Applications.Load();
            this.Location = StaticClasses.Config.WidgetPosition;
            this.StartPosition = FormStartPosition.Manual;
            this.Size = StaticClasses.Config.WidgetSize;
            this.applistview.Size = StaticClasses.Config.WidgetSize;
            this.Font = StaticClasses.Config.font;

            FixWidgetPos.Checked = StaticClasses.Config.LockWidget;
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
                applistview.Items.Add(StaticClasses.Executables[i].Name/*.Replace(' ','\n')*/);
                applistview.Items[applistview.Items.Count - 1].ImageIndex = applistview.Items.Count - 1;
            }

                    
        }

        private Image ResizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        void Backgroundset()
        {
            try
            {
                this.applistview.BackColor = StaticClasses.Config.WidgetBackColor;
            }
            catch
            {

            }
            if (StaticClasses.Config.Widgetbackimg != "")
            {

                if (File.Exists(StaticClasses.Config.Widgetbackimg))
                {
                    if (this.applistview.BackgroundImage != null)
                    {
                        //this.applistview.BackgroundImage.Dispose();
                    }

                    Bitmap background = new Bitmap(this.Width, this.Height);
                    Graphics graphics = Graphics.FromImage(background);
                    Bitmap bmp = new Bitmap(Image.FromFile(StaticClasses.Config.Widgetbackimg));
                    graphics.Clear(StaticClasses.Config.WidgetBackColor);
                    int x, y;
                    x = bmp.Width;
                    y = bmp.Height;
                    float ratio;
                    Task task = Task.Run(() =>
                    {
                        if (bmp.Width / this.Width >= bmp.Height / this.Height) //Width is larger
                        {
                            ratio = (float)bmp.Width / (float)this.Width;
                        }
                        else //Height is larger
                        {
                            ratio = (float)bmp.Height / (float)this.Height;
                        }

                        bmp = (Bitmap)ResizeImage(bmp, new Size((int)(bmp.Width / ratio), (int)(bmp.Height / ratio)));

                        graphics.DrawImage(bmp, background.Width / 2 - bmp.Width / 2, background.Height / 2 - bmp.Height / 2, bmp.Width, bmp.Height);
                    });

                    task.Wait();
                    applistview.BackgroundImage = background;

                    graphics.Dispose();
                    background.Dispose();
                    bmp.Dispose();


                    //this.applistview.BackgroundImage
                }
                else if (StaticClasses.Config.Widgetbackimg != "")
                {
                    StaticClasses.Config.Widgetbackimg = "";
                }
            }

        }

        void LoadConfig()
        {
            this.Font = new Font(StaticClasses.Config.font.Name, StaticClasses.Config.font.Size);
            this.Opacity = StaticClasses.Config.WidgetOpacity;
            this.applistview.ForeColor = StaticClasses.Config.WidgetForeColor;

            this.Location = StaticClasses.Config.WidgetPosition;
            this.StartPosition = FormStartPosition.Manual;
            this.Size = StaticClasses.Config.WidgetSize;
            this.applistview.Size = StaticClasses.Config.WidgetSize;

            FixWidgetPos.Checked = StaticClasses.Config.LockWidget;

            Backgroundset();
            if (StaticClasses.Config.ShowWidget)
            {
                this.Show();
            }
            else
            {
                this.Hide();
            }
        }

        void LoadLanguage()
        {
            if (StaticClasses.Langs.Widget.WidgetRC.FixWidgetPos != null)
            {
                this.FixWidgetPos.Text = StaticClasses.Langs.Widget.WidgetRC.FixWidgetPos;
            }
        }
        #endregion

        #region Move Window
        private Point mousePoint;

        private void Mouse_Down(object sender,
            System.Windows.Forms.MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                //位置を記憶する
                mousePoint = new Point(e.X, e.Y);
            }
        }

        private void Mouse_Move(object sender,
            System.Windows.Forms.MouseEventArgs e)
        {
            if (!StaticClasses.Config.LockWidget)
            {
                if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
                {

                    // 吸着するサイズ(範囲)
                    Size gap = new Size(12, 12);

                    // 移動先のフォーム位置
                    Rectangle newPosition = new Rectangle(
                        this.Left + e.X - mousePoint.X,
                        this.Top + e.Y - mousePoint.Y,
                        this.Width,
                        this.Height);
                    // 判定用のRECT
                    Rectangle newRect = new Rectangle();

                    // 作業領域の取得（この作業領域の内側に吸着する）
                    Size area = new Size(
                        System.Windows.Forms.Screen.GetWorkingArea(this).Width,
                        System.Windows.Forms.Screen.GetWorkingArea(this).Height);

                    // 画面端の判定用（画面の端の位置に、吸着するサイズ分のRECTを定義する）
                    Rectangle rectLeft = new Rectangle(
                                                0,
                                                0,
                                                gap.Width,
                                                area.Height);
                    Rectangle rectTop = new Rectangle(
                                                0,
                                                0,
                                                area.Width,
                                                gap.Height);
                    Rectangle rectRight = new Rectangle(
                                                area.Width - gap.Width,
                                                0,
                                                gap.Width,
                                                area.Height);
                    Rectangle rectBottom = new Rectangle(
                                                0,
                                                area.Height - gap.Height,
                                                area.Width,
                                                gap.Height);
                    // 衝突判定
                    // 判定用のRECTを自分のウィンドウの隅に重ねるように移動し、
                    // 画面端の判定用のRECTと衝突しているかチェックする。
                    // 衝突していた場合は、吸着させるように移動する

                    // 左端衝突判定
                    {
                        newRect = newPosition;
                        newRect.Width = gap.Width;

                        if (newRect.IntersectsWith(rectLeft))
                        {
                            // 左端に吸着させる
                            newPosition.X = 0;
                        }
                    }
                    // 右端衝突判定
                    {
                        newRect = newPosition;
                        newRect.X = newPosition.Right - gap.Width;  // ウィンドウの右隅
                        newRect.Width = gap.Width;

                        if (newRect.IntersectsWith(rectRight))
                        {
                            // 右端に吸着させる
                            newPosition.X = area.Width - this.Width;
                        }
                    }
                    // 上端衝突判定
                    {
                        newRect = newPosition;
                        newRect.Height = gap.Height;

                        if (newRect.IntersectsWith(rectTop))
                        {
                            // 上端に吸着させる
                            newPosition.Y = 0;
                        }
                    }
                    // 下端衝突判定
                    {
                        newRect = newPosition;
                        newRect.Y = newPosition.Bottom - gap.Height; // ウィンドウの下端
                        newRect.Height = gap.Height;

                        if (newRect.IntersectsWith(rectBottom))
                        {
                            // 下端に吸着させる
                            newPosition.Y = area.Height - this.Height;
                        }
                    }

                    // 実際に移動させる
                    this.Location = new Point(newPosition.Left, newPosition.Top);


                }
            }
        }

        private void Mouse_Up(object sender, MouseEventArgs e)
        {
            Task task = Task.Run(() =>
            {
                StaticClasses.Config.WidgetPosition = this.Location;
                StaticClasses.Config.SaveConfig(StaticClasses.Config);
            });
            task.Wait();
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


        protected override void WndProc(ref Message m)
        {
            try
            {
                base.WndProc(ref m);
            }
            catch (ArgumentException)
            {

            }
            switch (m.Msg)
            {
                case StaticClasses.WorkHubMessages.ConfigChanged:
                    LoadConfig();
                    break;
                case StaticClasses.WorkHubMessages.AppListChanged:
                    initalizeapplistview();
                    break;
                case StaticClasses.WorkHubMessages.WidgetConfigChanged:
                    this.LoadConfig();
                    break;
                case StaticClasses.WorkHubMessages.WidgetBackgroundSet:
                    Backgroundset();
                    break;
                case StaticClasses.WorkHubMessages.WidgetPositionReset:
                    this.Location = new Point(0, 0);
                    break;
                case StaticClasses.WorkHubMessages.LanguagePackLoad:
                    LoadLanguage();
                    break;
                case StaticClasses.WorkHubMessages.ApplicationQuit:
                    App_Closing();
                    break;
                default:
                    break;
            }
        }


        #endregion
    }
    /*
    struct MsgandFunction
    {
        int hWnd;

    }
    public class MsgFilter : IMessageFilter
    {
        public bool PreFilterMessage(ref Message m,)
        {
            switch (m.Msg)
            {
                case StaticClasses.WorkHubMessages.ConfigChanged:
                    LoadConfig();
                    break;
                case StaticClasses.WorkHubMessages.AppListChanged:
                    initalizeapplistview();
                    break;
                case StaticClasses.WorkHubMessages.WidgetConfigChanged:
                    this.LoadConfig();
                    break;
                case StaticClasses.WorkHubMessages.WidgetBackgroundSet:
                    Backgroundset();
                    break;
                case StaticClasses.WorkHubMessages.LanguagePackLoad:
                    LoadLanguage();
                    break;
                case StaticClasses.WorkHubMessages.ApplicationQuit:
                    App_Closing();
                    break;
                default:
                    break;
            }
            return false;
        }
    }
    */

}
