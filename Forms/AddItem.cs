using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkhubForWindows.Forms
{
    public partial class AddItemForm : Form
    {
        public AddItemForm()
        {
            InitializeComponent();
            this.FormClosed += WindowClosed;
            this.Font = StaticClasses.Config.font;
            LoadLanguage();
        }
        #region Event Handlers
        private void ReferenceButton(object sender,EventArgs e)
        {
            RefDiag.FileName = FilePathBox.Text;
            if (RefDiag.ShowDialog() == DialogResult.OK)
            {
                FilePathBox.Text = RefDiag.FileName;
            }
        }

        private void ApplyClick(object sender, EventArgs e)
        {
            if (ItemNameBox.Text == "")
            {
                MessageBox.Show("You must type the file Name!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }else
            if (FilePathBox.Text == "")
            {
                MessageBox.Show("You must type the file path!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                StaticClasses.Executables.Add
                    (
                    new Executable()
                    {
                        Name = ItemNameBox.Text,
                        Path = FilePathBox.Text,
                        Argments = CmdArgsBox.Text
                    }
                    );

                Functions.Config.Applications.Save(StaticClasses.Executables);
                foreach (WorkhubWindowHandler i in StaticClasses.WindowHandler.WindowHandlers)
                {
                    Functions.WinAPIFuncs.PostMessage(i.hWnd, StaticClasses.WorkHubMessages.AppListChanged, 0, 0);
                }
                this.DialogResult = DialogResult.OK;

            }
        }
        private void CancelClick(object sender,EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void WindowClosed(object sender,EventArgs e)
        {
            this.Dispose();
        }
        #endregion

        private void LoadLanguage()
        {
            this.Text = StaticClasses.Langs.AddItem.WindowTitle;
            ItemnameLabel.Text = StaticClasses.Langs.AddItem.Label_Name;
            FilepathLabel.Text = StaticClasses.Langs.AddItem.Label_Path;
            CmdArgsLabel.Text = StaticClasses.Langs.AddItem.Label_Args;

            ButtonApply.Text = StaticClasses.Langs.AddItem.ApplyButton;
            ButtonCancel.Text = StaticClasses.Langs.AddItem.CancelButton;
            ButtonReference.Text = StaticClasses.Langs.AddItem.RefButton;
        }
    }
}
