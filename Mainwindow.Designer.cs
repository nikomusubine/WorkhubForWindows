﻿
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
            this.Ribbon = new System.Windows.Forms.MenuStrip();
            this.RibbonFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.Ribbon_Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripShowWidget = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.TrayRClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TrayRC_ShowMain = new System.Windows.Forms.ToolStripMenuItem();
            this.TrayRC_ShowWidget = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.TrayRC_Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.TrayRC_AddItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.TrayRC_Quit = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonsPunel = new System.Windows.Forms.TableLayoutPanel();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.Apps = new System.Windows.Forms.ListView();
            this.ApplistRClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ApplistRC_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.ApplistRC_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.ApplistRC_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.ApplistRC_RunAsAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.HomePanel = new System.Windows.Forms.TableLayoutPanel();
            this.ListViewPanel = new System.Windows.Forms.TableLayoutPanel();
            this.HalfModebackimg = new System.Windows.Forms.PictureBox();
            this.Ribbon.SuspendLayout();
            this.TrayRClick.SuspendLayout();
            this.ButtonsPunel.SuspendLayout();
            this.ApplistRClick.SuspendLayout();
            this.HomePanel.SuspendLayout();
            this.ListViewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HalfModebackimg)).BeginInit();
            this.SuspendLayout();
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
            this.ToolStripQuit});
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
            // ToolStripQuit
            // 
            this.ToolStripQuit.Name = "ToolStripQuit";
            resources.ApplyResources(this.ToolStripQuit, "ToolStripQuit");
            this.ToolStripQuit.Click += new System.EventHandler(this.Quit);
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
            this.TrayRC_ShowMain,
            this.TrayRC_ShowWidget,
            this.toolStripMenuItem1,
            this.TrayRC_Settings,
            this.TrayRC_AddItem,
            this.toolStripMenuItem4,
            this.TrayRC_Quit});
            this.TrayRClick.Name = "TrayRClick";
            resources.ApplyResources(this.TrayRClick, "TrayRClick");
            // 
            // TrayRC_ShowMain
            // 
            this.TrayRC_ShowMain.Name = "TrayRC_ShowMain";
            resources.ApplyResources(this.TrayRC_ShowMain, "TrayRC_ShowMain");
            this.TrayRC_ShowMain.Click += new System.EventHandler(this.ShowMainWindow);
            // 
            // TrayRC_ShowWidget
            // 
            this.TrayRC_ShowWidget.CheckOnClick = true;
            this.TrayRC_ShowWidget.Name = "TrayRC_ShowWidget";
            resources.ApplyResources(this.TrayRC_ShowWidget, "TrayRC_ShowWidget");
            this.TrayRC_ShowWidget.Click += new System.EventHandler(this.ShowWidget);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // TrayRC_Settings
            // 
            this.TrayRC_Settings.Name = "TrayRC_Settings";
            resources.ApplyResources(this.TrayRC_Settings, "TrayRC_Settings");
            this.TrayRC_Settings.Click += new System.EventHandler(this.SettingsPushed);
            // 
            // TrayRC_AddItem
            // 
            this.TrayRC_AddItem.Name = "TrayRC_AddItem";
            resources.ApplyResources(this.TrayRC_AddItem, "TrayRC_AddItem");
            this.TrayRC_AddItem.Click += new System.EventHandler(this.Additem);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            resources.ApplyResources(this.toolStripMenuItem4, "toolStripMenuItem4");
            // 
            // TrayRC_Quit
            // 
            this.TrayRC_Quit.Name = "TrayRC_Quit";
            resources.ApplyResources(this.TrayRC_Quit, "TrayRC_Quit");
            this.TrayRC_Quit.Click += new System.EventHandler(this.Quit);
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
            this.Apps.ContextMenuStrip = this.ApplistRClick;
            this.Apps.HideSelection = false;
            this.Apps.MultiSelect = false;
            this.Apps.Name = "Apps";
            this.Apps.UseCompatibleStateImageBehavior = false;
            this.Apps.DoubleClick += new System.EventHandler(this.StartPushed);
            // 
            // ApplistRClick
            // 
            this.ApplistRClick.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ApplistRClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ApplistRC_Add,
            this.ApplistRC_Edit,
            this.ApplistRC_Delete,
            this.ApplistRC_RunAsAdmin});
            this.ApplistRClick.Name = "ApplistRClick";
            resources.ApplyResources(this.ApplistRClick, "ApplistRClick");
            // 
            // ApplistRC_Add
            // 
            this.ApplistRC_Add.Name = "ApplistRC_Add";
            resources.ApplyResources(this.ApplistRC_Add, "ApplistRC_Add");
            this.ApplistRC_Add.Click += new System.EventHandler(this.Additem);
            // 
            // ApplistRC_Edit
            // 
            this.ApplistRC_Edit.Name = "ApplistRC_Edit";
            resources.ApplyResources(this.ApplistRC_Edit, "ApplistRC_Edit");
            this.ApplistRC_Edit.Click += new System.EventHandler(this.EditPushed);
            // 
            // ApplistRC_Delete
            // 
            this.ApplistRC_Delete.Name = "ApplistRC_Delete";
            resources.ApplyResources(this.ApplistRC_Delete, "ApplistRC_Delete");
            this.ApplistRC_Delete.Click += new System.EventHandler(this.DeleteClicked);
            // 
            // ApplistRC_RunAsAdmin
            // 
            this.ApplistRC_RunAsAdmin.Name = "ApplistRC_RunAsAdmin";
            resources.ApplyResources(this.ApplistRC_RunAsAdmin, "ApplistRC_RunAsAdmin");
            this.ApplistRC_RunAsAdmin.Click += new System.EventHandler(this.RunAsAdminClicked);
            // 
            // HomePanel
            // 
            resources.ApplyResources(this.HomePanel, "HomePanel");
            this.HomePanel.BackColor = System.Drawing.Color.Transparent;
            this.HomePanel.Controls.Add(this.ListViewPanel, 1, 0);
            this.HomePanel.Controls.Add(this.HalfModebackimg, 0, 0);
            this.HomePanel.Name = "HomePanel";
            // 
            // ListViewPanel
            // 
            resources.ApplyResources(this.ListViewPanel, "ListViewPanel");
            this.ListViewPanel.Controls.Add(this.ButtonsPunel, 0, 1);
            this.ListViewPanel.Controls.Add(this.Apps, 0, 0);
            this.ListViewPanel.Name = "ListViewPanel";
            // 
            // HalfModebackimg
            // 
            resources.ApplyResources(this.HalfModebackimg, "HalfModebackimg");
            this.HalfModebackimg.Name = "HalfModebackimg";
            this.HalfModebackimg.TabStop = false;
            // 
            // Mainwindow
            // 
            this.AcceptButton = this.StartButton;
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.HomePanel);
            this.Controls.Add(this.Ribbon);
            this.MainMenuStrip = this.Ribbon;
            this.Name = "Mainwindow";
            this.Shown += new System.EventHandler(this.MainWindowShown);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragAndDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.EnterDragItem);
            this.Ribbon.ResumeLayout(false);
            this.Ribbon.PerformLayout();
            this.TrayRClick.ResumeLayout(false);
            this.ButtonsPunel.ResumeLayout(false);
            this.ApplistRClick.ResumeLayout(false);
            this.HomePanel.ResumeLayout(false);
            this.ListViewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HalfModebackimg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip Ribbon;
        private System.Windows.Forms.ToolStripMenuItem RibbonFiles;
        private System.Windows.Forms.ToolStripMenuItem Ribbon_Settings;
        private System.Windows.Forms.NotifyIcon TrayIcon;
        private System.Windows.Forms.ContextMenuStrip TrayRClick;
        private System.Windows.Forms.ToolStripMenuItem TrayRC_ShowMain;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem TrayRC_Quit;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ToolStripQuit;
        private System.Windows.Forms.TableLayoutPanel ButtonsPunel;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.ListView Apps;
        private System.Windows.Forms.TableLayoutPanel HomePanel;
        private System.Windows.Forms.ToolStripMenuItem ToolStripShowWidget;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem TrayRC_ShowWidget;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ContextMenuStrip ApplistRClick;
        private System.Windows.Forms.ToolStripMenuItem ApplistRC_Add;
        private System.Windows.Forms.ToolStripMenuItem ApplistRC_Edit;
        private System.Windows.Forms.ToolStripMenuItem ApplistRC_Delete;
        private System.Windows.Forms.TableLayoutPanel ListViewPanel;
        private System.Windows.Forms.ToolStripMenuItem TrayRC_Settings;
        private System.Windows.Forms.ToolStripMenuItem TrayRC_AddItem;
        private System.Windows.Forms.ToolStripMenuItem ApplistRC_RunAsAdmin;
        private System.Windows.Forms.PictureBox HalfModebackimg;
    }
}

