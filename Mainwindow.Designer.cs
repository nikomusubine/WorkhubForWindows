
namespace WorkhubForWindows
{
    partial class Mainwindow
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainwindow));
            this.Apps = new System.Windows.Forms.ListView();
            this.IconList = new System.Windows.Forms.ImageList(this.components);
            this.Ribbon = new System.Windows.Forms.MenuStrip();
            this.RibbonFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.AddItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Ribbon.SuspendLayout();
            this.SuspendLayout();
            // 
            // Apps
            // 
            this.Apps.BackColor = System.Drawing.SystemColors.Window;
            this.Apps.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Apps.HideSelection = false;
            this.Apps.LargeImageList = this.IconList;
            this.Apps.Location = new System.Drawing.Point(284, 12);
            this.Apps.Name = "Apps";
            this.Apps.Size = new System.Drawing.Size(259, 462);
            this.Apps.TabIndex = 0;
            this.Apps.UseCompatibleStateImageBehavior = false;
            // 
            // IconList
            // 
            this.IconList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.IconList.ImageSize = new System.Drawing.Size(16, 16);
            this.IconList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Ribbon
            // 
            this.Ribbon.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Ribbon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RibbonFiles});
            this.Ribbon.Location = new System.Drawing.Point(0, 0);
            this.Ribbon.Name = "Ribbon";
            this.Ribbon.Size = new System.Drawing.Size(555, 28);
            this.Ribbon.TabIndex = 1;
            this.Ribbon.Text = "menuStrip1";
            // 
            // RibbonFiles
            // 
            this.RibbonFiles.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddItem});
            this.RibbonFiles.Name = "RibbonFiles";
            this.RibbonFiles.Size = new System.Drawing.Size(82, 24);
            this.RibbonFiles.Text = "ファイル(&F)";
            // 
            // AddItem
            // 
            this.AddItem.Name = "AddItem";
            this.AddItem.Size = new System.Drawing.Size(224, 26);
            this.AddItem.Text = "項目を追加(&A)";
            this.AddItem.Click += new System.EventHandler(this.Additem);
            // 
            // Mainwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(555, 486);
            this.Controls.Add(this.Apps);
            this.Controls.Add(this.Ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Ribbon;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Mainwindow";
            this.Text = "WorkHub";
            this.Ribbon.ResumeLayout(false);
            this.Ribbon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView Apps;
        private System.Windows.Forms.MenuStrip Ribbon;
        private System.Windows.Forms.ImageList IconList;
        private System.Windows.Forms.ToolStripMenuItem RibbonFiles;
        private System.Windows.Forms.ToolStripMenuItem AddItem;
    }
}

