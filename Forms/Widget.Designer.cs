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
            this.SuspendLayout();
            // 
            // applistview
            // 
            this.applistview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.applistview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.applistview.HideSelection = false;
            this.applistview.LargeImageList = this.IconList;
            this.applistview.Location = new System.Drawing.Point(0, 0);
            this.applistview.MultiSelect = false;
            this.applistview.Name = "applistview";
            this.applistview.Size = new System.Drawing.Size(350, 350);
            this.applistview.TabIndex = 0;
            this.applistview.UseCompatibleStateImageBehavior = false;
            this.applistview.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down);
            this.applistview.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down);
            this.applistview.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Mouse_Move);
            // 
            // IconList
            // 
            this.IconList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.IconList.ImageSize = new System.Drawing.Size(28, 28);
            this.IconList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Widget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 350);
            this.Controls.Add(this.applistview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Widget";
            this.Text = "Widget";
            this.Shown += new System.EventHandler(this.ShowWidget);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList IconList;
        public System.Windows.Forms.ListView applistview;
    }
}