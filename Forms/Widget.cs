﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Interop;
using System.Threading;
using Microsoft.Win32;

namespace WorkhubForWindows
{
    public partial class Widget : Form
    {
        // private static int lngWnP;

        HotKeyRegister Hotkey;
        const int HotkeyID = 0x2501;
        const int WM_HOTKEY = 0x0312;

        bool shiftPressing = false;

        public Widget()
        {

            InitializeComponent();
            initalizeapplistview();
            System.Windows.Forms.Button appcall = new System.Windows.Forms.Button();
            this.AcceptButton = appcall;
            appcall.Click += appstartcall;
            this.FormClosing += Form_Closing;

            RCMenuRunAsAdmin.Image = Functions.WinAPIFuncs.GetSieldIcon(false).ToBitmap();
            int ScrollBW = new VScrollBar().Width;
            this.Size = new Size(this.Size.Width + ScrollBW, this.Size.Height);
            this.applistview.Size = new Size(this.applistview.Size.Width + ScrollBW, this.applistview.Size.Height);
            this.applistview.SmallImageList = StaticClasses.IconList;
            this.applistview.LargeImageList = StaticClasses.IconList;
            Backgroundset();
            //AddWindowHandler
            StaticClasses.WindowHandler.WindowHandlers.Add(new WorkhubWindowHandler((int)this.Handle, "Widget"));
            LoadLanguage();
            shiftPressing = false;

            //  Application.AddMessageFilter(MsgFilter);
        }

        private void ShowWidget(object sender, EventArgs e)
        {
            this.LoadConfig();
            Backgroundset();
        }

        private void App_Closing()
        {
            this.FormClosing -= Form_Closing;
            if (Hotkey != null)
            {
                Hotkey.Dispose();
            }
            this.Close();
        }

        private void appstartcall(object sender, EventArgs e)
        {
            if (applistview.SelectedIndices.Count != 0)
            {
                if (shiftPressing)
                {
                    Functions.Application.StartProcess(StaticClasses.Executables[applistview.SelectedIndices[0]], true);
                }
                else
                if (Functions.Application.StartProcess(StaticClasses.Executables[applistview.SelectedIndices[0]]) == 1)
                {
                    StaticClasses.Executables[applistview.SelectedItems[0].Index] = new Executable(
                        StaticClasses.Executables[applistview.SelectedItems[0].Index].Name,
                        StaticClasses.Executables[applistview.SelectedItems[0].Index].Path,
                        StaticClasses.Executables[applistview.SelectedItems[0].Index].CurrentDir,
                        StaticClasses.Executables[applistview.SelectedItems[0].Index].Argments,
                        true
                        );
                    StaticClasses.LoadIcons();

                    Functions.Config.Applications.Save(StaticClasses.Executables);
                }
            }
        }

        private void Form_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            //this.WindowState = FormWindowState.Minimized;
            this.Hide();
            StaticClasses.Config.ShowWidget = false;
        }

        private void SystemEvents_SessionEnding(object sender, SessionEndingEventArgs e)
        {
            this.FormClosing -= Form_Closing;
        }

        private void SettingsTimerTIck(object sender, EventArgs e)
        {
            if (this.Size != StaticClasses.Config.WidgetSize)
            {
                this.Size = StaticClasses.Config.WidgetSize;
            }

            if (this.applistview.BackgroundImage == null)
            {
                if (StaticClasses.Config.Widgetbackimg != "")
                {
                    Backgroundset();
                }
            }
        }

        private void KeyDownEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Shift || e.KeyCode == Keys.ShiftKey)
            {
                shiftPressing = true;
            }
        }

        private void KeyUpEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Shift || e.KeyCode == Keys.ShiftKey)
            {
                shiftPressing = false;
            }
        }
        private void DeactivateCalled(object sender,EventArgs e)
        {
            shiftPressing = false;
        }

        #region Right Click ContextMenu
        private void LockWidget_Click(object sender, EventArgs e)
        {
            if (StaticClasses.Config.LockWidget)
            {
                StaticClasses.Config.LockWidget = false;
            }
            else
            {
                StaticClasses.Config.LockWidget = true;
            }

            StaticClasses.Config.SaveConfig();
        }
        private void RCMenuRunAsAdmin_Click(object sender, EventArgs e)
        {
            Functions.Application.StartProcess(StaticClasses.Executables[applistview.SelectedIndices[0]], true);
        }
        #endregion

        #region Functions
        /// <summary>
        /// アプリケーションの読み込み
        /// Load Applications
        /// </summary>
        void initalizeapplistview()
        {
            applistview.Clear();
            StaticClasses.Executables = Functions.Config.Applications.Load();
            this.Location = StaticClasses.Config.WidgetPosition;
            this.StartPosition = FormStartPosition.Manual;
            this.Size = StaticClasses.Config.WidgetSize;
            this.applistview.Size = StaticClasses.Config.WidgetSize;
            this.Font = StaticClasses.Config.font;

            FixWidgetPos.Checked = StaticClasses.Config.LockWidget;
            for (int i = 0; i != StaticClasses.IconList.Images.Count; i++)
            {

                applistview.Items.Add(EditString(StaticClasses.Executables[i].Name));
                applistview.Items[applistview.Items.Count - 1].ImageIndex = applistview.Items.Count - 1;
            }


        }

        private string EditString(string String)
        {
            string[] str = String.Split(' ');
            string returnback = str[0];

            for (int i = 1; i != str.Length; i++)
            {
                StringBuilder sb = new StringBuilder(returnback);
                if (returnback.Split('\n')[returnback.Split('\n').Length - 1].Length > 10)
                {
                    sb.Append("\n");
                    sb.Append(str[i]);
                }
                else
                {
                    sb.Append(" ");
                    sb.Append(str[i]);
                }
                returnback = sb.ToString();
            }

            return returnback;
        }

        private Image ResizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        void Backgroundset()
        {
            try
            {
                this.applistview.BackColor = StaticClasses.Config.WidgetBackColor;
                this.BackColor = StaticClasses.Config.WidgetBackColor;
                this.panel1.BackColor = StaticClasses.Config.WidgetBackColor;
            }
            catch
            {

            }
            if (StaticClasses.Config.Widgetbackimg != "")
            {

                if (File.Exists(StaticClasses.Config.Widgetbackimg))
                {
                    if (this.applistview.BackgroundImage != null)
                    {
                        //this.applistview.BackgroundImage.Dispose();
                    }

                    Bitmap background = new Bitmap(this.Width, this.Height);
                    Graphics graphics = Graphics.FromImage(background);
                    Bitmap bmp = new Bitmap(Image.FromFile(StaticClasses.Config.Widgetbackimg));
                    graphics.Clear(StaticClasses.Config.WidgetBackColor);
                    int x, y;
                    x = bmp.Width;
                    y = bmp.Height;
                    float ratio;
                    if (bmp.Width / this.Width >= bmp.Height / this.Height) //Width is larger
                    {
                        ratio = (float)bmp.Width / (float)this.Width;
                    }
                    else //Height is larger
                    {
                        ratio = (float)bmp.Height / (float)this.Height;
                    }

                    bmp = (Bitmap)ResizeImage(bmp, new Size((int)(bmp.Width / ratio), (int)(bmp.Height / ratio)));

                    graphics.DrawImage(bmp, background.Width / 2 - bmp.Width / 2, background.Height / 2 - bmp.Height / 2, bmp.Width, bmp.Height);

                    applistview.BackgroundImage = background;

                    graphics.Dispose();
                    background.Dispose();
                    bmp.Dispose();


                    //this.applistview.BackgroundImage
                }
                else if (StaticClasses.Config.Widgetbackimg != "")
                {
                    StaticClasses.Config.Widgetbackimg = "";
                }
            }

        }

        void LoadConfig()
        {
            this.Font = new Font(StaticClasses.Config.font.Name, StaticClasses.Config.font.Size);
            this.Opacity = StaticClasses.Config.WidgetOpacity;
            this.applistview.ForeColor = StaticClasses.Config.WidgetForeColor;

            this.Location = StaticClasses.Config.WidgetPosition;
            this.StartPosition = FormStartPosition.Manual;
            this.MaximumSize = StaticClasses.Config.WidgetSize;
            this.panel1.MaximumSize = StaticClasses.Config.WidgetSize;
            applistview.SizeForce(new Size(StaticClasses.Config.WidgetSize.Width + new VScrollBar().Width, StaticClasses.Config.WidgetSize.Height + SystemInformation.HorizontalScrollBarHeight - (int)this.Font.Size));
            applistview.Location = new Point(0, 0);
            this.Size = StaticClasses.Config.WidgetSize;
            this.applistview.Size = StaticClasses.Config.WidgetSize;
            this.panel1.Size = StaticClasses.Config.WidgetSize;

            FixWidgetPos.Checked = StaticClasses.Config.LockWidget;
            if (Hotkey != null)
            {
                Hotkey.Dispose();
            }
            try
            {
                Hotkey = new HotKeyRegister(this.Handle, HotkeyID, StaticClasses.Config.WidgetShortcutKey.Modifires, StaticClasses.Config.WidgetShortcutKey.keys);
            }
            catch (System.ArgumentException)
            {

            }
            catch (ApplicationException)
            {

            }
            Backgroundset();
            if (StaticClasses.Config.ShowWidget)
            {
                this.Show();
            }
            else
            {
                this.Hide();
            }
        }

        void LoadLanguage()
        {
            if (StaticClasses.Langs.Widget.WidgetRC.FixWidgetPos != null)
            {
                this.FixWidgetPos.Text = StaticClasses.Langs.Widget.WidgetRC.FixWidgetPos;
            }
            if (StaticClasses.Langs.Widget.WidgetRC.RunAsAdmin != null)
            {
                this.RCMenuRunAsAdmin.Text = StaticClasses.Langs.Widget.WidgetRC.RunAsAdmin;
            }
        }
        #endregion

        #region Move Window

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReleaseCapture();
        public const int WM_NCLBUTTONDOWN = 0x00A1; //非クライアント領域への左クリックを示すWM
        public const int HTCAPTION = 0x0002; //カーソルがタイトルバーにあることを示すDefWndProc返り
        private void Mouse_Down(object sender,
            System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                Functions.WinAPIFuncs.SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, (int)IntPtr.Zero);
            }
        }

        private void Mouse_Up(object sender,MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                StaticClasses.Config.WidgetPosition = this.Location;    
            }
        }

        #endregion

        #region WinMsg

        //COPYDATASTRUCT構造体 
        public struct COPYDATASTRUCT
        {
            public Int32 dwData;  //送信する32ビット値
            public Int32 cbData;  //lpDataのバイト数
            public string lpData;  //送信するデータへのポインタ(0も可能)
        }
        public const int WM_COPYDATA = 0x4A;
        public const int WM_USER = 0x400;

        private const int WM_QUERYENDSESSION = 0x11;
        public new void Show()
        {
            this.WindowState = FormWindowState.Normal;

            base.Show();
        }

        protected override void WndProc(ref Message m)
        {
            try
            {
                base.WndProc(ref m);
            }
            catch (ArgumentException)
            {

            }
            switch (m.Msg)
            {
                case StaticClasses.WorkHubMessages.ConfigChanged:
                    LoadConfig();
                    break;
                case StaticClasses.WorkHubMessages.AppListChanged:
                    initalizeapplistview();
                    break;
                case StaticClasses.WorkHubMessages.WidgetConfigChanged:
                    this.LoadConfig();
                    break;
                case StaticClasses.WorkHubMessages.WidgetBackgroundSet:
                    Backgroundset();
                    break;
                case StaticClasses.WorkHubMessages.WidgetPositionReset:
                    this.Location = new Point(0, 0);
                    break;
                case StaticClasses.WorkHubMessages.LanguagePackLoad:
                    LoadLanguage();
                    break;
                case StaticClasses.WorkHubMessages.IsWidgetShowChanged:
                    if (StaticClasses.Config.ShowWidget)
                    {
                        this.Show();
                    }
                    else
                    {
                        this.Hide();
                    }
                    break;
                case StaticClasses.WorkHubMessages.ApplicationQuit:
                    App_Closing();
                    this.Dispose();
                    break;
                case WM_HOTKEY:
                    if (StaticClasses.Config.ShowWidget)
                    {
                        if (Form.ActiveForm != this)
                        {
                            this.Show();
                            this.TopMost = true;
                            this.TopMost = false;
                            this.Activate();
                            this.WindowState = FormWindowState.Normal;
                        }
                        else
                        {
                            this.WindowState = FormWindowState.Minimized;
                        }
                    }

                    break;

                case WM_QUERYENDSESSION:

                    this.FormClosing -= Form_Closing;
                    Functions.WinMsgFuncs.AppClose();
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }





        #endregion
    }

    public static class Widget_Expansion
    {
        public static void SizeForce(this System.Windows.Forms.ListView listView, Size size)
        {
            listView.MinimumSize = size;
            listView.MaximumSize = size;
            listView.Size = size;
        }

        public static void SizeForce(this System.Windows.Forms.ListView listView, int Width, int Height)
        {
            listView.MinimumSize = new Size(Width, Height);
            listView.MaximumSize = new Size(Width, Height);
            listView.Size = new Size(Width, Height);
        }
    }

    public class HotKeyRegister : IMessageFilter, IDisposable
    {
        /// <summary>
        /// Define a system-wide hot key.
        /// </summary>
        /// <param name="hWnd">
        /// A handle to the window that will receive WM_HOTKEY messages generated by the
        /// hot key. If this parameter is NULL, WM_HOTKEY messages are posted to the
        /// message queue of the calling thread and must be processed in the message loop.
        /// </param>
        /// <param name="id">
        /// The identifier of the hot key. If the hWnd parameter is NULL, then the hot
        /// key is associated with the current thread rather than with a particular
        /// window.
        /// </param>
        /// <param name="fsModifiers">
        /// The keys that must be pressed in combination with the key specified by the
        /// uVirtKey parameter in order to generate the WM_HOTKEY message. The fsModifiers
        /// parameter can be a combination of the following values.
        /// MOD_ALT     0x0001
        /// MOD_CONTROL 0x0002
        /// MOD_SHIFT   0x0004
        /// MOD_WIN     0x0008
        /// </param>
        /// <param name="vk">The virtual-key code of the hot key.</param>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id,
            KeyModifiers fsModifiers, Keys vk);

        /// <summary>
        /// Frees a hot key previously registered by the calling thread.
        /// </summary>
        /// <param name="hWnd">
        /// A handle to the window associated with the hot key to be freed. This parameter
        /// should be NULL if the hot key is not associated with a window.
        /// </param>
        /// <param name="id">
        /// The identifier of the hot key to be freed.
        /// </param>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        /// <summary>
        /// Get the modifiers and key from the KeyData property of KeyEventArgs.
        /// </summary>
        /// <param name="keydata">
        /// The KeyData property of KeyEventArgs. The KeyData is a key in combination
        /// with modifiers.
        /// </param>
        /// <param name="key">The pressed key.</param>
        public static KeyModifiers GetModifiers(Keys keydata, out Keys key)
        {
            key = keydata;
            KeyModifiers modifers = KeyModifiers.None;

            // Check whether the keydata contains the CTRL modifier key.
            // The value of Keys.Control is 131072.
            if ((keydata & Keys.Control) == Keys.Control)
            {
                modifers |= KeyModifiers.Control;

                key = keydata ^ Keys.Control;
            }

            // Check whether the keydata contains the SHIFT modifier key.
            // The value of Keys.Control is 65536.
            if ((keydata & Keys.Shift) == Keys.Shift)
            {
                modifers |= KeyModifiers.Shift;
                key = key ^ Keys.Shift;
            }

            // Check whether the keydata contains the ALT modifier key.
            // The value of Keys.Control is 262144.
            if ((keydata & Keys.Alt) == Keys.Alt)
            {
                modifers |= KeyModifiers.Alt;
                key = key ^ Keys.Alt;
            }

            // Check whether a key other than SHIFT, CTRL or ALT (Menu) is pressed.
            if (key == Keys.ShiftKey || key == Keys.ControlKey || key == Keys.Menu)
            {
                key = Keys.None;
            }

            return modifers;
        }

        /// <summary>
        /// Specify whether this object is disposed.
        /// </summary>
        bool disposed = false;

        /// <summary>
        /// This constant could be found in WinUser.h if you installed Windows SDK.
        /// Each windows message has an identifier, 0x0312 means that the mesage is
        /// a WM_HOTKEY message.
        /// </summary>
        const int WM_HOTKEY = 0x0312;

        /// <summary>
        /// A handle to the window that will receive WM_HOTKEY messages generated by the
        /// hot key.
        /// </summary>
        public IntPtr Handle { get; private set; }

        /// <summary>
        /// A normal application can use any value between 0x0000 and 0xBFFF as the ID
        /// but if you are writing a DLL, then you must use GlobalAddAtom to get a
        /// unique identifier for your hot key.
        /// </summary>
        public int ID { get; private set; }

        public KeyModifiers Modifiers { get; private set; }

        public Keys Key { get; private set; }

        /// <summary>
        /// Raise an event when the hotkey is pressed.
        /// </summary>
        public event EventHandler HotKeyPressed;


        public HotKeyRegister(IntPtr handle, int id, KeyModifiers modifiers, Keys key)
        {
            if (key == Keys.None || modifiers == KeyModifiers.None)
            {
                throw new ArgumentException("The key or modifiers could not be None.");
            }

            this.Handle = handle;
            this.ID = id;
            this.Modifiers = modifiers;
            this.Key = key;

            RegisterHotKey();

            // Adds a message filter to monitor Windows messages as they are routed to
            // their destinations.
            Application.AddMessageFilter(this);
        }


        /// <summary>
        /// Register the hotkey.
        /// </summary>
        private void RegisterHotKey()
        {
            bool isKeyRegisterd = RegisterHotKey(Handle, ID, Modifiers, Key);

            // If the operation failed, try to unregister the hotkey if the thread
            // has registered it before.
            if (!isKeyRegisterd)
            {
                // IntPtr.Zero means the hotkey registered by the thread.
                UnregisterHotKey(IntPtr.Zero, ID);

                // Try to register the hotkey again.
                isKeyRegisterd = RegisterHotKey(Handle, ID, Modifiers, Key);

                // If the operation still failed, it means that the hotkey was already
                // used in another thread or process.
                if (!isKeyRegisterd)
                {
                    throw new ApplicationException("The hotkey is in use");
                }
            }
        }

        /// <summary>
        /// Filters out a message before it is dispatched.
        /// </summary>
        [PermissionSetAttribute(SecurityAction.LinkDemand, Name = "FullTrust")]
        public bool PreFilterMessage(ref Message m)
        {
            // The property WParam of Message is typically used to store small pieces
            // of information. In this scenario, it stores the ID.
            if (m.Msg == WM_HOTKEY
            && m.HWnd == this.Handle
            && m.WParam == (IntPtr)this.ID
            && HotKeyPressed != null)
            {
                // Raise the HotKeyPressed event if it is an WM_HOTKEY message.
                HotKeyPressed(this, EventArgs.Empty);

                // True to filter the message and stop it from being dispatched.
                return true;
            }

            // Return false to allow the message to continue to the next filter or
            // control.
            return false;
        }


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Unregister the hotkey.
        /// </summary>
        protected virtual void Dispose(bool disposing)
        {
            // Protect from being called multiple times.
            if (disposed)
            {
                return;
            }

            if (disposing)
            {

                // Removes a message filter from the message pump of the application.
                Application.RemoveMessageFilter(this);

                UnregisterHotKey(Handle, ID);
            }

            disposed = true;
        }
    }

    // --------------------------------------------------------------------------
    /// <summary>
    /// A nice generic class to register multiple hotkeys for your app
    /// </summary>
    // --------------------------------------------------------------------------


    /*
    struct MsgandFunction
    {
        int hWnd;

    }
    public class MsgFilter : IMessageFilter
    {
        public bool PreFilterMessage(ref Message m,)
        {
            switch (m.Msg)
            {
                case StaticClasses.WorkHubMessages.ConfigChanged:
                    LoadConfig();
                    break;
                case StaticClasses.WorkHubMessages.AppListChanged:
                    initalizeapplistview();
                    break;
                case StaticClasses.WorkHubMessages.WidgetConfigChanged:
                    this.LoadConfig();
                    break;
                case StaticClasses.WorkHubMessages.WidgetBackgroundSet:
                    Backgroundset();
                    break;
                case StaticClasses.WorkHubMessages.LanguagePackLoad:
                    LoadLanguage();
                    break;
                case StaticClasses.WorkHubMessages.ApplicationQuit:
                    App_Closing();
                    break;
                default:
                    break;
            }
            return false;
        }
    }
    */

}
