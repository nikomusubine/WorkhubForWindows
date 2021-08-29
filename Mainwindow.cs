using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkhubForWindows
{
    public partial class Mainwindow : Form
    {
        public Mainwindow()
        {
            InitializeComponent();
            Apps.View = View.LargeIcon;

        }


        /// <summary>
        /// すべてを構成する
        /// Make up everything 
        /// </summary>
        void initalizeListview()
        {
            StaticClasses.Executables = Functions.Config.Applications.Load();

            foreach(Executable exe in StaticClasses.Executables)
            {
                Bitmap bmp = Icon.ExtractAssociatedIcon(exe.Path).ToBitmap();
                IconList.Images.Add(exe.Name, bmp);
                Apps.Items.Add(exe.Name);
                Apps.Items[Apps.Items.Count - 1].ImageIndex = Apps.Items.Count - 1;
            }


        }

        private void Additem(object sender, EventArgs e)
        {

        }
    }
}
