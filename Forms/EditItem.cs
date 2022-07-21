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
            this.Icons = StaticClasses.IconList;
            this.Applist.SmallImageList = this.Icons;
            this.Applist.LargeImageList = this.Icons;
            LoadLanguage();
        }

        private void AppsSelectedIndexChanged(object sender, EventArgs e)
        {
            //Applist.SelectedIndices[0]
            if (Applist.SelectedIndices.Count != 0)
            {
                NameBox.Text = StaticClasses.Executables[Applist.SelectedIndices[0]].Name;
                PathBox.Text = StaticClasses.Executables[Applist.SelectedIndices[0]].Path;
                CurrentDirBox.Text = StaticClasses.Executables[Applist.SelectedIndices[0]].CurrentDir;
                ArgsBox.Text = StaticClasses.Executables[Applist.SelectedIndices[0]].Argments;
                RunasAdminBox.Checked=StaticClasses.Executables[Applist.SelectedIndices[0]].RunasAdmin;
                IconBox.Text = StaticClasses.Executables[Applist.SelectedIndices[0]].IconPath;
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
                StaticClasses.Executables[Applist.SelectedIndices[0]] = new Executable(NameBox.Text, PathBox.Text, CurrentDirBox.Text, ArgsBox.Text);
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
                StaticClasses.Executables[Applist.SelectedIndices[0]] = new Executable(NameBox.Text, PathBox.Text, CurrentDirBox.Text,ArgsBox.Text, IconBox.Text, RunasAdminBox.Checked);
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
                    Image img = Icons.Images[Applist.SelectedIndices[0]];
                    Icons.Images[Applist.SelectedIndices[0]] = Icons.Images[Applist.SelectedIndices[0] - 1];
                    Icons.Images[Applist.SelectedIndices[0]-1] = img;
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

                    Image img = Icons.Images[Applist.SelectedIndices[0]];
                    Icons.Images.RemoveAt(Applist.SelectedIndices[0]);
                    Icons.Images.Add(img);
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
                if (Applist.SelectedIndices[0] != Applist.Items.Count - 1)
                {
                    Executable tmp = new Executable(StaticClasses.Executables[Applist.SelectedIndices[0]]);
                    StaticClasses.Executables.Remove(StaticClasses.Executables[Applist.SelectedIndices[0]]);
                    StaticClasses.Executables.Insert(Applist.SelectedIndices[0] + 1, tmp);
                    Functions.Config.Applications.Save(StaticClasses.Executables);
                    Image img = Icons.Images[Applist.SelectedIndices[0]];
                    Icons.Images[Applist.SelectedIndices[0]] = Icons.Images[Applist.SelectedIndices[0] + 1];
                    Icons.Images[Applist.SelectedIndices[0] + 1] = img;
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

                    Image swap1 = Icons.Images[0], swap2;
                    for (int i = 0; i != Applist.Items.Count; i++)
                    {
                        if(i == 0)
                        {
                            Icons.Images[i] = Icons.Images[Applist.SelectedIndices[0]];
                            continue;
                        }
                        swap2 = Icons.Images[i];
                        Icons.Images[i] = swap1;
                        swap1 = swap2;

                    }

                  
                    
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
            StaticClasses.Executables = Functions.Config.Applications.Load();

            for (int i = 0; i != StaticClasses.Executables.Count; i++)
            {
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
            if (StaticClasses.Langs.EditItem.Label_Current != null)
            {
                this.CurrentPath.Text = StaticClasses.Langs.EditItem.Label_Current;
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
            if (StaticClasses.Langs.EditItem.Label_RunasAdmin != null)
            {
                this.RunasLabel.Text = StaticClasses.Langs.EditItem.Label_RunasAdmin;
            }
        }
    }
}
