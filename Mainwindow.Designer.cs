
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
            this.ButtonsPunel = new System.Windows.Forms.TableLayoutPanel();
            this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ListViewPanel = new System.Windows.Forms.TableLayoutPanel();
            this.TrayRClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showMainWindowSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.quitQToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Ribbon.SuspendLayout();
            this.ButtonsPunel.SuspendLayout();
            this.ListViewPanel.SuspendLayout();
            this.TrayRClick.SuspendLayout();
            this.SuspendLayout();
            // 
            // Apps
            // 
            resources.ApplyResources(this.Apps, "Apps");
            this.Apps.BackColor = System.Drawing.SystemColors.Window;
            this.Apps.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Apps.HideSelection = false;
            this.Apps.LargeImageList = this.IconList;
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
            this.Ribbon_Settings,
            this.toolStripMenuItem2,
            this.quitQToolStripMenuItem1});
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
            this.EditButton.Click += new System.EventHandler(this.EditPushed);
            // 
            // AddItemButton
            // 
            resources.ApplyResources(this.AddItemButton, "AddItemButton");
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.UseVisualStyleBackColor = true;
            this.AddItemButton.Click += new System.EventHandler(this.Additem);
            // 
            // ButtonsPunel
            // 
            resources.ApplyResources(this.ButtonsPunel, "ButtonsPunel");
            this.ButtonsPunel.Controls.Add(this.AddItemButton, 0, 0);
            this.ButtonsPunel.Controls.Add(this.StartButton, 2, 0);
            this.ButtonsPunel.Controls.Add(this.EditButton, 1, 0);
            this.ButtonsPunel.Name = "ButtonsPunel";
            // 
            // TrayIcon
            // 
            this.TrayIcon.ContextMenuStrip = this.TrayRClick;
            resources.ApplyResources(this.TrayIcon, "TrayIcon");
            this.TrayIcon.DoubleClick += new System.EventHandler(this.ShowMainWindow);
            // 
            // ListViewPanel
            // 
            resources.ApplyResources(this.ListViewPanel, "ListViewPanel");
            this.ListViewPanel.BackColor = System.Drawing.Color.Transparent;
            this.ListViewPanel.Controls.Add(this.Apps, 1, 0);
            this.ListViewPanel.Controls.Add(this.ButtonsPunel, 1, 1);
            this.ListViewPanel.Name = "ListViewPanel";
            // 
            // TrayRClick
            // 
            this.TrayRClick.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TrayRClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showMainWindowSToolStripMenuItem,
            this.toolStripMenuItem1,
            this.quitQToolStripMenuItem});
            this.TrayRClick.Name = "TrayRClick";
            resources.ApplyResources(this.TrayRClick, "TrayRClick");
            // 
            // showMainWindowSToolStripMenuItem
            // 
            this.showMainWindowSToolStripMenuItem.Name = "showMainWindowSToolStripMenuItem";
            resources.ApplyResources(this.showMainWindowSToolStripMenuItem, "showMainWindowSToolStripMenuItem");
            this.showMainWindowSToolStripMenuItem.Click += new System.EventHandler(this.ShowMainWindow);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // quitQToolStripMenuItem
            // 
            this.quitQToolStripMenuItem.Name = "quitQToolStripMenuItem";
            resources.ApplyResources(this.quitQToolStripMenuItem, "quitQToolStripMenuItem");
            this.quitQToolStripMenuItem.Click += new System.EventHandler(this.Quit);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            // 
            // quitQToolStripMenuItem1
            // 
            this.quitQToolStripMenuItem1.Name = "quitQToolStripMenuItem1";
            resources.ApplyResources(this.quitQToolStripMenuItem1, "quitQToolStripMenuItem1");
            this.quitQToolStripMenuItem1.Click += new System.EventHandler(this.Quit);
            // 
            // Mainwindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ListViewPanel);
            this.Controls.Add(this.Ribbon);
            this.MainMenuStrip = this.Ribbon;
            this.Name = "Mainwindow";
            this.Ribbon.ResumeLayout(false);
            this.Ribbon.PerformLayout();
            this.ButtonsPunel.ResumeLayout(false);
            this.ListViewPanel.ResumeLayout(false);
            this.TrayRClick.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel ButtonsPunel;
        private System.Windows.Forms.NotifyIcon TrayIcon;
        private System.Windows.Forms.TableLayoutPanel ListViewPanel;
        private System.Windows.Forms.ContextMenuStrip TrayRClick;
        private System.Windows.Forms.ToolStripMenuItem showMainWindowSToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quitQToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem quitQToolStripMenuItem1;
    }
}

