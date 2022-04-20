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
    public partial class EULA : Form
    {
        public bool agree = false;
        public EULA()
        {
            InitializeComponent();
        }

        private void AcceptClicked(object sender, EventArgs e)
        {
            agree = true;
            this.Close();
        }

        private void DelineClicked(object sender, EventArgs e)
        {

            this.Close();
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {

        }
    }
}
