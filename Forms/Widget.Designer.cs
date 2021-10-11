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
            this.WidgetPosLock = new System.Windows.Forms.ToolStripMenuItem();
            this.IconList = new System.Windows.Forms.ImageList(this.components);
            this.RCMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // applistview
            // 
            resources.ApplyResources(this.applistview, "applistview");
            this.applistview.AutoArrange = false;
            this.applistview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.applistview.ContextMenuStrip = this.RCMenu;
            this.applistview.HideSelection = false;
            this.applistview.LargeImageList = this.IconList;
            this.applistview.MultiSelect = false;
            this.applistview.Name = "applistview";
            this.applistview.SmallImageList = this.IconList;
            this.applistview.TileSize = new System.Drawing.Size(50, 50);
            this.applistview.UseCompatibleStateImageBehavior = false;
            this.applistview.VirtualListSize = 3;
            this.applistview.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down);
            this.applistview.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down);
            this.applistview.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Mouse_Move);
            this.applistview.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Mouse_Up);
            // 
            // RCMenu
            // 
            this.RCMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.RCMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WidgetPosLock});
            this.RCMenu.Name = "RCMenu";
            resources.ApplyResources(this.RCMenu, "RCMenu");
            // 
            // WidgetPosLock
            // 
            this.WidgetPosLock.CheckOnClick = true;
            this.WidgetPosLock.Name = "WidgetPosLock";
            resources.ApplyResources(this.WidgetPosLock, "WidgetPosLock");
            this.WidgetPosLock.Click += new System.EventHandler(this.LockWidget_Click);
            // 
            // IconList
            // 
            this.IconList.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            resources.ApplyResources(this.IconList, "IconList");
            this.IconList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Widget
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.applistview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Widget";
            this.Shown += new System.EventHandler(this.ShowWidget);
            this.DoubleClick += new System.EventHandler(this.appstartcall);
            this.RCMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList IconList;
        public System.Windows.Forms.ListView applistview;
        private System.Windows.Forms.ContextMenuStrip RCMenu;
        private System.Windows.Forms.ToolStripMenuItem WidgetPosLock;
    }
}