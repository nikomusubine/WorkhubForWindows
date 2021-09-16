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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

            foreach (FontFamily item in FontFamily.Families)
            {
                if (item.IsStyleAvailable(FontStyle.Regular))
                {
                    FontNames.Items.Add(item.Name);
                }
                FontNames.Text = StaticClasses.Config.font.Name;
                FontSizeBox.Text = StaticClasses.Config.font.Size.ToString();
            }
        }

        private void FontSizeKeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void BackImgRefClick(object sender,EventArgs e)
        {
            OpenFileDialog ofdiag = new OpenFileDialog();

            ofdiag.Filter = "Image File(*.bmp;*.png;*.jpg;*.jpeg) |*.bmp;*.png;*.jpg;*.jpeg"; 

            if (ofdiag.ShowDialog() == DialogResult.OK)
            {
                StaticClasses.Config.backimgpath = ofdiag.FileName;
            }

        }

        private void ApplyClicked(object sender, EventArgs e)
        {
            Font ftmp = new Font(FontNames.Text, Convert.ToSingle(FontSizeBox.Text));
            StaticClasses.Config.font = ftmp;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelClicked(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
