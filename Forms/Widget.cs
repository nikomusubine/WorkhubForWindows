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

            Backgroundset();
            //AddWindowHandler
            StaticClasses.WindowHandler.WindowHandlers.Add(new WorkhubWindowHandler((int)this.Handle,"Widget"));


        }

        private void ShowWidget(object sender,EventArgs e)
        {
            this.LoadConfig();
        }

        private void App_Closing()
        {

        }


        private void appstartcall(object sender, EventArgs e)
        {
            Functions.Application.StartProcess(StaticClasses.Executables[applistview.SelectedIndices[0]]);
        }

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

        void Backgroundset()
        {
            if (StaticClasses.Config.Widgetbackimg != "")
            {
                if (File.Exists(StaticClasses.Config.Widgetbackimg))
                {
                    if (this.applistview.BackgroundImage != null)
                    {
                        //this.applistview.BackgroundImage.Dispose();
                    }
                    this.applistview.BackgroundImage = Image.FromFile(StaticClasses.Config.Widgetbackimg);
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
                    initalizeapplistview();
                    break;
                case StaticClasses.WorkHubMessages.WidgetConfigChanged:
                    this.LoadConfig();
                    break;

                case StaticClasses.WorkHubMessages.ApplicationQuit:
                    App_Closing();
                    break;
                default:
                    break;
            }

            base.WndProc(ref m);
        }

        #endregion


    }
}
