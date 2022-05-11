namespace WorkhubForWindows
{
    partial class Widget
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Widget));
            this.applistview = new System.Windows.Forms.ListView();
            this.RCMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.FixWidgetPos = new System.Windows.Forms.ToolStripMenuItem();
            this.RCMenuRunAsAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SettingsTimer = new System.Windows.Forms.Timer(this.components);
            this.RCMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // applistview
            // 
            resources.ApplyResources(this.applistview, "applistview");
            this.applistview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.applistview.ContextMenuStrip = this.RCMenu;
            this.applistview.HideSelection = false;
            this.applistview.MultiSelect = false;
            this.applistview.Name = "applistview";
            this.applistview.TileSize = new System.Drawing.Size(50, 50);
            this.applistview.UseCompatibleStateImageBehavior = false;
            this.applistview.VirtualListSize = 3;
            this.applistview.DoubleClick += new System.EventHandler(this.appstartcall);
            this.applistview.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownEvent);
            this.applistview.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUpEvent);
            this.applistview.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down);
            this.applistview.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down);
            this.applistview.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Mouse_Move);
            this.applistview.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Mouse_Up);
            // 
            // RCMenu
            // 
            this.RCMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.RCMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FixWidgetPos,
            this.RCMenuRunAsAdmin});
            this.RCMenu.Name = "RCMenu";
            resources.ApplyResources(this.RCMenu, "RCMenu");
            // 
            // FixWidgetPos
            // 
            this.FixWidgetPos.CheckOnClick = true;
            this.FixWidgetPos.Name = "FixWidgetPos";
            resources.ApplyResources(this.FixWidgetPos, "FixWidgetPos");
            this.FixWidgetPos.Click += new System.EventHandler(this.LockWidget_Click);
            // 
            // RCMenuRunAsAdmin
            // 
            this.RCMenuRunAsAdmin.Name = "RCMenuRunAsAdmin";
            resources.ApplyResources(this.RCMenuRunAsAdmin, "RCMenuRunAsAdmin");
            this.RCMenuRunAsAdmin.Click += new System.EventHandler(this.RCMenuRunAsAdmin_Click);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.applistview);
            this.panel1.Name = "panel1";
            // 
            // SettingsTimer
            // 
            this.SettingsTimer.Enabled = true;
            this.SettingsTimer.Interval = 1000;
            this.SettingsTimer.Tick += new System.EventHandler(this.SettingsTimerTIck);
            // 
            // Widget
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Widget";
            this.Shown += new System.EventHandler(this.ShowWidget);
            this.DoubleClick += new System.EventHandler(this.appstartcall);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownEvent);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUpEvent);
            this.RCMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.ListView applistview;
        private System.Windows.Forms.ContextMenuStrip RCMenu;
        private System.Windows.Forms.ToolStripMenuItem FixWidgetPos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer SettingsTimer;
        private System.Windows.Forms.ToolStripMenuItem RCMenuRunAsAdmin;
    }
}