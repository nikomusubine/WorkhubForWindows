
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
            this.IconList = new System.Windows.Forms.ImageList(this.components);
            this.Ribbon = new System.Windows.Forms.MenuStrip();
            this.RibbonFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.Ribbon_Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripShowWidget = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.quitQToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.TrayRClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showMainWindowSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.TrayRC_ShowWidget = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.quitQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonsPunel = new System.Windows.Forms.TableLayoutPanel();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.Apps = new System.Windows.Forms.ListView();
            this.ApplistRClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListViewPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Ribbon.SuspendLayout();
            this.TrayRClick.SuspendLayout();
            this.ButtonsPunel.SuspendLayout();
            this.ApplistRClick.SuspendLayout();
            this.ListViewPanel.SuspendLayout();
            this.SuspendLayout();
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
            this.ToolStripShowWidget,
            this.toolStripMenuItem3,
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
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            // 
            // ToolStripShowWidget
            // 
            this.ToolStripShowWidget.CheckOnClick = true;
            this.ToolStripShowWidget.Name = "ToolStripShowWidget";
            resources.ApplyResources(this.ToolStripShowWidget, "ToolStripShowWidget");
            this.ToolStripShowWidget.Click += new System.EventHandler(this.ShowWidget);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
            // 
            // quitQToolStripMenuItem1
            // 
            this.quitQToolStripMenuItem1.Name = "quitQToolStripMenuItem1";
            resources.ApplyResources(this.quitQToolStripMenuItem1, "quitQToolStripMenuItem1");
            this.quitQToolStripMenuItem1.Click += new System.EventHandler(this.Quit);
            // 
            // TrayIcon
            // 
            this.TrayIcon.ContextMenuStrip = this.TrayRClick;
            resources.ApplyResources(this.TrayIcon, "TrayIcon");
            this.TrayIcon.DoubleClick += new System.EventHandler(this.ShowMainWindow);
            // 
            // TrayRClick
            // 
            this.TrayRClick.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TrayRClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showMainWindowSToolStripMenuItem,
            this.toolStripMenuItem1,
            this.TrayRC_ShowWidget,
            this.toolStripMenuItem4,
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
            // TrayRC_ShowWidget
            // 
            this.TrayRC_ShowWidget.CheckOnClick = true;
            this.TrayRC_ShowWidget.Name = "TrayRC_ShowWidget";
            resources.ApplyResources(this.TrayRC_ShowWidget, "TrayRC_ShowWidget");
            this.TrayRC_ShowWidget.Click += new System.EventHandler(this.ShowWidget);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            resources.ApplyResources(this.toolStripMenuItem4, "toolStripMenuItem4");
            // 
            // quitQToolStripMenuItem
            // 
            this.quitQToolStripMenuItem.Name = "quitQToolStripMenuItem";
            resources.ApplyResources(this.quitQToolStripMenuItem, "quitQToolStripMenuItem");
            this.quitQToolStripMenuItem.Click += new System.EventHandler(this.Quit);
            // 
            // ButtonsPunel
            // 
            resources.ApplyResources(this.ButtonsPunel, "ButtonsPunel");
            this.ButtonsPunel.Controls.Add(this.AddItemButton, 0, 0);
            this.ButtonsPunel.Controls.Add(this.StartButton, 2, 0);
            this.ButtonsPunel.Controls.Add(this.EditButton, 1, 0);
            this.ButtonsPunel.Name = "ButtonsPunel";
            // 
            // AddItemButton
            // 
            resources.ApplyResources(this.AddItemButton, "AddItemButton");
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.UseVisualStyleBackColor = true;
            this.AddItemButton.Click += new System.EventHandler(this.Additem);
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
            // Apps
            // 
            this.Apps.AllowColumnReorder = true;
            resources.ApplyResources(this.Apps, "Apps");
            this.Apps.BackColor = System.Drawing.SystemColors.Window;
            this.Apps.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Apps.ContextMenuStrip = this.ApplistRClick;
            this.Apps.HideSelection = false;
            this.Apps.LargeImageList = this.IconList;
            this.Apps.MultiSelect = false;
            this.Apps.Name = "Apps";
            this.Apps.UseCompatibleStateImageBehavior = false;
            // 
            // ApplistRClick
            // 
            this.ApplistRClick.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ApplistRClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAToolStripMenuItem,
            this.editEToolStripMenuItem,
            this.deleteDToolStripMenuItem});
            this.ApplistRClick.Name = "ApplistRClick";
            resources.ApplyResources(this.ApplistRClick, "ApplistRClick");
            // 
            // addAToolStripMenuItem
            // 
            this.addAToolStripMenuItem.Name = "addAToolStripMenuItem";
            resources.ApplyResources(this.addAToolStripMenuItem, "addAToolStripMenuItem");
            // 
            // editEToolStripMenuItem
            // 
            this.editEToolStripMenuItem.Name = "editEToolStripMenuItem";
            resources.ApplyResources(this.editEToolStripMenuItem, "editEToolStripMenuItem");
            // 
            // deleteDToolStripMenuItem
            // 
            this.deleteDToolStripMenuItem.Name = "deleteDToolStripMenuItem";
            resources.ApplyResources(this.deleteDToolStripMenuItem, "deleteDToolStripMenuItem");
            // 
            // ListViewPanel
            // 
            resources.ApplyResources(this.ListViewPanel, "ListViewPanel");
            this.ListViewPanel.BackColor = System.Drawing.Color.Transparent;
            this.ListViewPanel.Controls.Add(this.Apps, 1, 0);
            this.ListViewPanel.Controls.Add(this.ButtonsPunel, 1, 1);
            this.ListViewPanel.Name = "ListViewPanel";
            // 
            // Mainwindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ListViewPanel);
            this.Controls.Add(this.Ribbon);
            this.MainMenuStrip = this.Ribbon;
            this.Name = "Mainwindow";
            this.Shown += new System.EventHandler(this.MainWindowShown);
            this.Ribbon.ResumeLayout(false);
            this.Ribbon.PerformLayout();
            this.TrayRClick.ResumeLayout(false);
            this.ButtonsPunel.ResumeLayout(false);
            this.ApplistRClick.ResumeLayout(false);
            this.ListViewPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip Ribbon;
        private System.Windows.Forms.ImageList IconList;
        private System.Windows.Forms.ToolStripMenuItem RibbonFiles;
        private System.Windows.Forms.ToolStripMenuItem Ribbon_Settings;
        private System.Windows.Forms.NotifyIcon TrayIcon;
        private System.Windows.Forms.ContextMenuStrip TrayRClick;
        private System.Windows.Forms.ToolStripMenuItem showMainWindowSToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quitQToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem quitQToolStripMenuItem1;
        private System.Windows.Forms.TableLayoutPanel ButtonsPunel;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.ListView Apps;
        private System.Windows.Forms.TableLayoutPanel ListViewPanel;
        private System.Windows.Forms.ToolStripMenuItem ToolStripShowWidget;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem TrayRC_ShowWidget;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ContextMenuStrip ApplistRClick;
        private System.Windows.Forms.ToolStripMenuItem addAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteDToolStripMenuItem;
    }
}

