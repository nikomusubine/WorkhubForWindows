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
            this.FormClosed += WindowClosed;
            LoadLanguage();
        }

        private void AppsSelectedIndexChanged(object sender, EventArgs e)
        {
            //Applist.SelectedIndices[0]
            if (Applist.SelectedIndices.Count != 0)
            {
                NameBox.Text = StaticClasses.Executables[Applist.SelectedIndices[0]].Name;
                PathBox.Text = StaticClasses.Executables[Applist.SelectedIndices[0]].Path;
                ArgsBox.Text = StaticClasses.Executables[Applist.SelectedIndices[0]].Argments;
            }
        }

        private void CloseButtonClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OKButtonClicked(object sender, EventArgs e)
        {
            if (Applist.SelectedIndices.Count != 0)
            {
                StaticClasses.Executables[Applist.SelectedIndices[0]] = new Executable(NameBox.Text, PathBox.Text, ArgsBox.Text);
            }
            this.Close();
        }

        private void ApplyButtonClicked(object sender, EventArgs e)
        {
            if (NameBox.Text == "")
            {

            }
            else
            {
                StaticClasses.Executables[Applist.SelectedIndices[0]] = new Executable(NameBox.Text, PathBox.Text, ArgsBox.Text);
            }
        }

        private void WindowClosed(object sender, EventArgs e)
        {
            Functions.Config.Applications.Save(StaticClasses.Executables);

            foreach (WorkhubWindowHandler i in StaticClasses.WindowHandler.WindowHandlers)
            {
                Functions.WinAPIFuncs.PostMessage(i.hWnd, StaticClasses.WorkHubMessages.AppListChanged, 0, 0);
            }
            this.Dispose();
        }

        private void MoveLClicked(object sender,EventArgs e)
        {
            if (Applist.SelectedIndices.Count != 0)
            {
                if (Applist.SelectedIndices[0] != 0)
                {
                    Executable tmp = new Executable(StaticClasses.Executables[Applist.SelectedIndices[0]]);
                    StaticClasses.Executables.Remove(StaticClasses.Executables[Applist.SelectedIndices[0]]);
                    StaticClasses.Executables.Insert(Applist.SelectedIndices[0] - 1, tmp);
                    Functions.Config.Applications.Save(StaticClasses.Executables);
                    int selecteditem = Applist.SelectedIndices[0] - 1;
                    initalizeApplist();
                    Applist.Items[selecteditem].Selected = true;
                }
                else
                {
                    Executable tmp = new Executable(StaticClasses.Executables[Applist.SelectedIndices[0]]);
                    StaticClasses.Executables.Remove(StaticClasses.Executables[Applist.SelectedIndices[0]]);
                    StaticClasses.Executables.Insert(Applist.Items.Count - 1, tmp);
                    Functions.Config.Applications.Save(StaticClasses.Executables);
                    int selecteditem = Applist.Items.Count - 1;
                    initalizeApplist();
                    Applist.Items[selecteditem].Selected = true;
                }
            }
        }

        private void MoveRClicked(object sender, EventArgs e)
        {
            if (Applist.SelectedIndices.Count != 0)
            {
                if (Applist.SelectedIndices[0] != Applist.SelectedIndices.Count - 1)
                {
                    Executable tmp = new Executable(StaticClasses.Executables[Applist.SelectedIndices[0]]);
                    StaticClasses.Executables.Remove(StaticClasses.Executables[Applist.SelectedIndices[0]]);
                    StaticClasses.Executables.Insert(Applist.SelectedIndices[0] + 1, tmp);
                    Functions.Config.Applications.Save(StaticClasses.Executables);
                    int selecteditem = Applist.SelectedIndices[0] + 1;
                    initalizeApplist();
                    Applist.Items[selecteditem].Selected = true;
                }
                else
                {
                    Executable tmp = new Executable(StaticClasses.Executables[Applist.SelectedIndices[0]]);
                    StaticClasses.Executables.Remove(StaticClasses.Executables[Applist.SelectedIndices[0]]);
                    StaticClasses.Executables.Insert(0, tmp);
                    Functions.Config.Applications.Save(StaticClasses.Executables);
                    int selecteditem = 0;
                    initalizeApplist();
                    Applist.Items[selecteditem].Selected = true;
                }
            }
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

        void LoadLanguage()
        {
            if (StaticClasses.Langs.EditItem.WindowTitle != null)
            {
                this.Text = StaticClasses.Langs.EditItem.WindowTitle;
            }
            if (StaticClasses.Langs.EditItem.Label_Name != null)
            {
                this.NameLabel.Text = StaticClasses.Langs.EditItem.Label_Name;
            }
            if (StaticClasses.Langs.EditItem.Label_Path != null)
            {
                this.PathLabel.Text = StaticClasses.Langs.EditItem.Label_Path;
            }
            if (StaticClasses.Langs.EditItem.Label_Args!=null)
            {
                this.ArgsLabel.Text = StaticClasses.Langs.EditItem.Label_Args;
            }
            if (StaticClasses.Langs.EditItem.OKButton != null)
            {
                this.okbutton.Text = StaticClasses.Langs.EditItem.OKButton;
            }
            if (StaticClasses.Langs.EditItem.ApplyButton != null)
            {
                this.ApplyButton.Text = StaticClasses.Langs.EditItem.ApplyButton;
            }
            if (StaticClasses.Langs.EditItem.CloseButton != null)
            {
                this.Close_Button.Text = StaticClasses.Langs.EditItem.CloseButton;
            }
        }

    }
}
