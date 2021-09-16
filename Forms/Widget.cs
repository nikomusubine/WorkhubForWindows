using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WorkhubForWindows
{
    public partial class Widget : Form
    {
        public Widget()
        {
            InitializeComponent();
            initalizeapplistview();
        }


        private void ListViewPanel_Paint(object sender, PaintEventArgs e)
        {

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
        #endregion

        #region Move Window
        private Point mousePoint;

        private void Mouse_Down(object sender,
            System.Windows.Forms.MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                //Record position
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
                    // adsorption Range
                    Size gap = new Size(12, 12);

                    // move to the window
                    Rectangle newPosition = new Rectangle(
                        this.Left + e.X - mousePoint.X,
                        this.Top + e.Y - mousePoint.Y,
                        this.Width,
                        this.Height);
                    // judgement RECT
                    Rectangle newRect = new Rectangle();

                    Size area = new Size(
                        System.Windows.Forms.Screen.GetWorkingArea(this).Width,
                        System.Windows.Forms.Screen.GetWorkingArea(this).Height);

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

                    // Collision left 
                    {
                        newRect = newPosition;
                        newRect.Width = gap.Width;

                        if (newRect.IntersectsWith(rectLeft))
                        {
                            // Left adsorption
                            newPosition.X = 0;
                        }
                    }
                    // Right Collision
                    {
                        newRect = newPosition;
                        newRect.X = newPosition.Right - gap.Width;  // Right the window
                        newRect.Width = gap.Width;

                        if (newRect.IntersectsWith(rectRight))
                        {
                            // Right adsorption
                            newPosition.X = area.Width - this.Width;
                        }
                    }
                    // Collision up the window
                    {
                        newRect = newPosition;
                        newRect.Height = gap.Height;

                        if (newRect.IntersectsWith(rectTop))
                        {
                            // up adsorption
                            newPosition.Y = 0;
                        }
                    }
                    // Collision under the window
                    {
                        newRect = newPosition;
                        newRect.Y = newPosition.Bottom - gap.Height; // Under the window
                        newRect.Height = gap.Height;

                        if (newRect.IntersectsWith(rectBottom))
                        {
                            //Under adsorption
                            newPosition.Y = area.Height - this.Height;
                        }
                    }

                    // Move
                    this.Left = newPosition.Left;
                    this.Top = newPosition.Top;
                }
            }
        }

        #endregion
    }
}
