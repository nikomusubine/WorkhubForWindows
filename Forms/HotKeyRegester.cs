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
            if (StaticClasses.Langs.HotkeyRegester.Label_1 != null)
            {
                label1.Text = StaticClasses.Langs.HotkeyRegester.Label_1;
            }
            if (StaticClasses.Langs.HotkeyRegester.Label_2 != null)
            {
                label2.Text = StaticClasses.Langs.HotkeyRegester.Label_2;
            }
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
