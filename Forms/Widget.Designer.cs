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
            this.RightClickMenu = new System.Windows.Forms.MenuStrip();
            this.SuspendLayout();
            // 
            // applistview
            // 
            this.applistview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.applistview.AutoArrange = false;
            this.applistview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.applistview.HideSelection = false;
            this.applistview.LargeImageList = this.IconList;
            this.applistview.Location = new System.Drawing.Point(0, 0);
            this.applistview.Margin = new System.Windows.Forms.Padding(0);
            this.applistview.MultiSelect = false;
            this.applistview.Name = "applistview";
            this.applistview.Size = new System.Drawing.Size(400, 400);
            this.applistview.SmallImageList = this.IconList;
            this.applistview.TabIndex = 0;
            this.applistview.TileSize = new System.Drawing.Size(50, 50);
            this.applistview.UseCompatibleStateImageBehavior = false;
            this.applistview.VirtualListSize = 3;
            this.applistview.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down);
            this.applistview.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down);
            this.applistview.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Mouse_Move);
            // 
            // IconList
            // 
            this.IconList.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.IconList.ImageSize = new System.Drawing.Size(32, 32);
            this.IconList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // RightClickMenu
            // 
            this.RightClickMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.RightClickMenu.Location = new System.Drawing.Point(0, 0);
            this.RightClickMenu.Name = "RightClickMenu";
            this.RightClickMenu.Size = new System.Drawing.Size(400, 24);
            this.RightClickMenu.TabIndex = 1;
            this.RightClickMenu.Text = "RightClickMenu";
            // 
            // Widget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.applistview);
            this.Controls.Add(this.RightClickMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.RightClickMenu;
            this.Name = "Widget";
            this.Text = "Widget";
            this.Shown += new System.EventHandler(this.ShowWidget);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList IconList;
        public System.Windows.Forms.ListView applistview;
        private System.Windows.Forms.MenuStrip RightClickMenu;
    }
}