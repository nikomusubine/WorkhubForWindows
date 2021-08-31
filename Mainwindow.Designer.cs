
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
            this.Ribbon_Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.StartButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.Ribbon.SuspendLayout();
            this.SuspendLayout();
            // 
            // Apps
            // 
            this.Apps.BackColor = System.Drawing.SystemColors.Window;
            this.Apps.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Apps.HideSelection = false;
            this.Apps.LargeImageList = this.IconList;
            resources.ApplyResources(this.Apps, "Apps");
            this.Apps.MultiSelect = false;
            this.Apps.Name = "Apps";
            this.Apps.UseCompatibleStateImageBehavior = false;
            // 
            // IconList
            // 
            this.IconList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            resources.ApplyResources(this.IconList, "IconList");
            this.IconList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Ribbon
            // 
            this.Ribbon.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Ribbon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RibbonFiles});
            resources.ApplyResources(this.Ribbon, "Ribbon");
            this.Ribbon.Name = "Ribbon";
            // 
            // RibbonFiles
            // 
            this.RibbonFiles.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Ribbon_Settings});
            this.RibbonFiles.Name = "RibbonFiles";
            resources.ApplyResources(this.RibbonFiles, "RibbonFiles");
            // 
            // Ribbon_Settings
            // 
            this.Ribbon_Settings.Name = "Ribbon_Settings";
            resources.ApplyResources(this.Ribbon_Settings, "Ribbon_Settings");
            this.Ribbon_Settings.Click += new System.EventHandler(this.SettingsPushed);
            // 
            // StartButton
            // 
            resources.ApplyResources(this.StartButton, "StartButton");
            this.StartButton.Name = "StartButton";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartPushed);
            // 
            // EditButton
            // 
            resources.ApplyResources(this.EditButton, "EditButton");
            this.EditButton.Name = "EditButton";
            this.EditButton.UseVisualStyleBackColor = true;
            // 
            // AddItemButton
            // 
            resources.ApplyResources(this.AddItemButton, "AddItemButton");
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.UseVisualStyleBackColor = true;
            this.AddItemButton.Click += new System.EventHandler(this.Additem);
            // 
            // Mainwindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AddItemButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.Apps);
            this.Controls.Add(this.Ribbon);
            this.MainMenuStrip = this.Ribbon;
            this.Name = "Mainwindow";
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
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.ToolStripMenuItem Ribbon_Settings;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button AddItemButton;
    }
}

