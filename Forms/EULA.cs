using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkhubForWindows.Forms
{
    public partial class EULA : Form
    {
        public bool agree = false;
        public EULA()
        {
            InitializeComponent();
            this.Load += Load_Window;
            #region EULA Load
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "WorkhubForWindows.Resources.EULA.Ja_Jp.txt";
            string manualFileContent = "";
            using (var stream = assembly.GetManifestResourceStream(resourceName))
            {
                if (stream != null)
                {
                    using (var sr = new StreamReader(stream,Encoding.UTF8))
                    {
                        manualFileContent = sr.ReadToEnd();
                    }
                }
            }
            #endregion
            EulaText.Text = manualFileContent;
            this.FormClosing += ClosingWnd;
        }



        private void AcceptButton_Click(object sender, EventArgs e)
        {
            agree = true;
            this.Close();
        }

        private void ClosingWnd(object sender ,FormClosingEventArgs e)
        {
            if (!agree && !(MessageBox.Show("利用規約に同意しない場合、あなたは本ソフトウェアを利用できません！\nIf you don't agree this EULA, you CANNOT use this software!", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK))
            {

                e.Cancel = true;

            }
        }
        private void Load_Window(object sender,EventArgs e)
        {

        }

        private void DelineButton_Click(object sender, EventArgs e)
        {
                this.Close();
            
        }
    }
}
