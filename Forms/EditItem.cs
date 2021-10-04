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

namespace WorkhubForWindows.Forms
{
    public partial class EditItem : Form
    {
        public EditItem()
        {
            InitializeComponent();
            initalizeApplist();
            StaticClasses.Config = StaticClasses.Config.LoadConfig();
            this.Font = new Font(StaticClasses.Config.font.Name, StaticClasses.Config.font.Size);
            Applist.View = View.LargeIcon;
        }

        private void AppsSelectedIndexChanged(object sender,EventArgs e)
        {
            //Applist.SelectedIndices[0]
            NameBox.Text = StaticClasses.Executables[Applist.SelectedIndices[0]].Name;
            PathBox.Text =StaticClasses.Executables[Applist.SelectedIndices[0]].Path;
            ArgsBox.Text = StaticClasses.Executables[Applist.SelectedIndices[0]].Argments;

        }

        /// <summary>
        /// アプリケーションの読み込み
        /// Load Applications
        /// </summary>
        void initalizeApplist()
        {
            Applist.Clear();
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
                Applist.Items.Add(StaticClasses.Executables[i].Name/*.Replace(' ','\n')*/);
                Applist.Items[Applist.Items.Count - 1].ImageIndex = Applist.Items.Count - 1;
            }


        }
    }
}
