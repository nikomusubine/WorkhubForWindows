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
    public partial class HotKeyRegester : Form
    {
        public Keys PressedKeys;
        public KeyModifiers PressedKeyModifires;

        public HotKeyRegester()
        {
            InitializeComponent();

            this.Font = StaticClasses.Config.font;
            label1.Font = new Font(StaticClasses.Config.font.Name, 32);
            label2.Font = new Font(StaticClasses.Config.font.Name, 18);

        }
        private void KeyUpEvent(object sender, KeyEventArgs e)
        {
            PressedKeys = e.KeyCode;
            if((e.KeyData & Keys.Control) != 0)
            {
                PressedKeyModifires = KeyModifiers.Control;
            }
            if ((e.KeyData & Keys.Shift) != 0)
            {
                PressedKeyModifires = PressedKeyModifires | KeyModifiers.Shift;
            }
            if ((e.KeyData & Keys.Alt) != 0)
            {
                PressedKeyModifires = PressedKeyModifires | KeyModifiers.Alt;
            }
            this.Close();
        }
    }
}
