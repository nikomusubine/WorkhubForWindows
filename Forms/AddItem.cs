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
        }

        private void ReferenceButton(object sender,EventArgs e)
        {
            RefDiag.FileName = FilePathBox.Text;
            if (RefDiag.ShowDialog() == DialogResult.OK)
            {
                FilePathBox.Text = RefDiag.FileName;
            }
        }

        private void ApplyClick(object sender,EventArgs e)
        {
            StaticClasses.Executables.Add
                (
                new Executable()
                {
                    Name = ItemNameBox.Text,
                    Path = FilePathBox.Text,
                    Argments=CmdArgsBox.Text
                }
                );

            Functions.Config.Applications.Save(StaticClasses.Executables);

            this.DialogResult = DialogResult.OK;
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
    }
}
