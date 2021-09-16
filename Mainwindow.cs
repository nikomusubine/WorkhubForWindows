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
        public Mainwindow()
        {
            InitializeComponent();
            initalizeApps();
            Apps.View = View.LargeIcon;
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

            }
        }





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
