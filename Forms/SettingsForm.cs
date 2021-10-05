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

            }
            initalizeform();
        }

        private void FontSizeKeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void BackImgRefClick(object sender, EventArgs e)
        {
            OpenFileDialog ofdiag = new OpenFileDialog();

            ofdiag.Filter = "Image File(*.bmp;*.png;*.jpg;*.jpeg) |*.bmp;*.png;*.jpg;*.jpeg";

            if (ofdiag.ShowDialog() == DialogResult.OK)
            {
                backimgpath.Text = ofdiag.FileName;
            }

        }

        private void WidgetBackImgRefClick(object sender, EventArgs e)
        {
            OpenFileDialog ofdiag = new OpenFileDialog();

            ofdiag.Filter = "Image File(*.bmp;*.png;*.jpg;*.jpeg) |*.bmp;*.png;*.jpg;*.jpeg";

            if (ofdiag.ShowDialog() == DialogResult.OK)
            {
                widgetbackimgpath.Text = ofdiag.FileName;
            }

        }

        private void ShutdownrefClick(object sender, EventArgs e)
        {
            OpenFileDialog ofdiag = new OpenFileDialog();
            ofdiag.FileName = Shutdownsoundbox.Text;
            ofdiag.Filter = "Sound File(*.wav) |*.wav";

            if (ofdiag.ShowDialog() == DialogResult.OK)
            {
                Shutdownsoundbox.Text = ofdiag.FileName;
            }

        }

        private void LogoffsoundrefClick(object sender, EventArgs e)
        {
            OpenFileDialog ofdiag = new OpenFileDialog();
            ofdiag.FileName = LogoffsoundBox.Text;
            ofdiag.Filter = "Sound File(*.wav) |*.wav";

            if (ofdiag.ShowDialog() == DialogResult.OK)
            {
                LogoffsoundBox.Text = ofdiag.FileName;
            }

        }

        private void OpacityChanged(object sender, EventArgs e)
        {

        }

        #region Apply or Cancel
        private void ApplyClicked(object sender, EventArgs e)
        {
            #region Change Config
            OwnFont ftmp = new OwnFont(FontNames.Text, Convert.ToSingle(FontSizeBox.Text));
            StaticClasses.Config.font = ftmp;
            StaticClasses.Config.backimgpath = backimgpath.Text;
            StaticClasses.Config.Widgetbackimg = widgetbackimgpath.Text;
            StaticClasses.Config.LogoffSound = LogoffsoundBox.Text;
            StaticClasses.Config.ShutdownSound = Shutdownsoundbox.Text;
            #endregion
            StaticClasses.Config.SaveConfig(StaticClasses.Config);
            StaticClasses.Config.ApplyConfig();
            this.Close();
        }

        private void CancelClicked(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        #endregion  

        #region Functions
        void initalizeform()
        {
            FontNames.Text = StaticClasses.Config.font.Name;
            FontSizeBox.Text = StaticClasses.Config.font.Size.ToString();

            widgetbackimgpath.Text = StaticClasses.Config.Widgetbackimg;
            backimgpath.Text = StaticClasses.Config.backimgpath;


        }
        #endregion
    }
}
