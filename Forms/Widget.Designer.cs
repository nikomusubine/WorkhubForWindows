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
            this.IconList = new System.Windows.Forms.ImageList(this.components);
            this.RCMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.WidgetPosLock = new System.Windows.Forms.ToolStripMenuItem();
            this.RCMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // applistview
            // 
            this.applistview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.applistview.AutoArrange = false;
            this.applistview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.applistview.ContextMenuStrip = this.RCMenu;
            this.applistview.HideSelection = false;
            this.applistview.LargeImageList = this.IconList;
            this.applistview.Location = new System.Drawing.Point(0, 0);
            this.applistview.Margin = new System.Windows.Forms.Padding(0);
            this.applistview.MultiSelect = false;
            this.applistview.Name = "applistview";
            this.applistview.Size = new System.Drawing.Size(300, 300);
            this.applistview.SmallImageList = this.IconList;
            this.applistview.TabIndex = 0;
            this.applistview.TileSize = new System.Drawing.Size(50, 50);
            this.applistview.UseCompatibleStateImageBehavior = false;
            this.applistview.VirtualListSize = 3;
            this.applistview.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down);
            this.applistview.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down);
            this.applistview.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Mouse_Move);
            this.applistview.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Mouse_Up);
            // 
            // IconList
            // 
            this.IconList.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.IconList.ImageSize = new System.Drawing.Size(32, 32);
            this.IconList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // RCMenu
            // 
            this.RCMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WidgetPosLock});
            this.RCMenu.Name = "RCMenu";
            this.RCMenu.Size = new System.Drawing.Size(191, 26);
            // 
            // WidgetPosLock
            // 
            this.WidgetPosLock.CheckOnClick = true;
            this.WidgetPosLock.Name = "WidgetPosLock";
            this.WidgetPosLock.Size = new System.Drawing.Size(190, 22);
            this.WidgetPosLock.Text = "Fix Widget Position(&F)";
            this.WidgetPosLock.Click += new System.EventHandler(this.LockWidget_Click);
            // 
            // Widget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.applistview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Widget";
            this.Text = "Widget";
            this.Shown += new System.EventHandler(this.ShowWidget);
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