
namespace WorkhubForWindows
{
    partial class Main_FullScreenList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_FullScreenList));
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
            this.AddItemButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.Apps = new System.Windows.Forms.ListView();
            this.ApplistRClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ApplistRC_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.ApplistRC_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.ApplistRC_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.ApplistRC_RunAsAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Ribbon.SuspendLayout();
            this.TrayRClick.SuspendLayout();
            this.ApplistRClick.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ribbon
            // 
            this.Ribbon.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Ribbon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RibbonFiles});
            this.Ribbon.Location = new System.Drawing.Point(0, 0);
            this.Ribbon.Name = "Ribbon";
            this.Ribbon.Size = new System.Drawing.Size(645, 28);
            this.Ribbon.TabIndex = 3;
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
            this.RibbonFiles.Size = new System.Drawing.Size(14, 20);
            // 
            // Ribbon_Settings
            // 
            this.Ribbon_Settings.Name = "Ribbon_Settings";
            this.Ribbon_Settings.Size = new System.Drawing.Size(83, 26);
            this.Ribbon_Settings.Click += new System.EventHandler(this.SettingsPushed);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(80, 6);
            // 
            // ToolStripShowWidget
            // 
            this.ToolStripShowWidget.CheckOnClick = true;
            this.ToolStripShowWidget.Name = "ToolStripShowWidget";
            this.ToolStripShowWidget.Size = new System.Drawing.Size(83, 26);
            this.ToolStripShowWidget.Click += new System.EventHandler(this.ShowWidget);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(80, 6);
            // 
            // ToolStripQuit
            // 
            this.ToolStripQuit.Name = "ToolStripQuit";
            this.ToolStripQuit.Size = new System.Drawing.Size(83, 26);
            this.ToolStripQuit.Click += new System.EventHandler(this.Quit);
            // 
            // TrayIcon
            // 
            this.TrayIcon.ContextMenuStrip = this.TrayRClick;
            this.TrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("TrayIcon.Icon")));
            this.TrayIcon.Visible = true;
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
            this.TrayRClick.Size = new System.Drawing.Size(70, 126);
            // 
            // TrayRC_ShowMain
            // 
            this.TrayRC_ShowMain.Name = "TrayRC_ShowMain";
            this.TrayRC_ShowMain.Size = new System.Drawing.Size(69, 22);
            this.TrayRC_ShowMain.Click += new System.EventHandler(this.ShowMainWindow);
            // 
            // TrayRC_ShowWidget
            // 
            this.TrayRC_ShowWidget.CheckOnClick = true;
            this.TrayRC_ShowWidget.Name = "TrayRC_ShowWidget";
            this.TrayRC_ShowWidget.Size = new System.Drawing.Size(69, 22);
            this.TrayRC_ShowWidget.Click += new System.EventHandler(this.ShowWidget);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(66, 6);
            // 
            // TrayRC_Settings
            // 
            this.TrayRC_Settings.Name = "TrayRC_Settings";
            this.TrayRC_Settings.Size = new System.Drawing.Size(69, 22);
            this.TrayRC_Settings.Click += new System.EventHandler(this.SettingsPushed);
            // 
            // TrayRC_AddItem
            // 
            this.TrayRC_AddItem.Name = "TrayRC_AddItem";
            this.TrayRC_AddItem.Size = new System.Drawing.Size(69, 22);
            this.TrayRC_AddItem.Click += new System.EventHandler(this.Additem);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(66, 6);
            // 
            // TrayRC_Quit
            // 
            this.TrayRC_Quit.Name = "TrayRC_Quit";
            this.TrayRC_Quit.Size = new System.Drawing.Size(69, 22);
            this.TrayRC_Quit.Click += new System.EventHandler(this.Quit);
            // 
            // AddItemButton
            // 
            this.AddItemButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AddItemButton.Location = new System.Drawing.Point(66, 5);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(75, 23);
            this.AddItemButton.TabIndex = 0;
            this.AddItemButton.Text = "Add";
            this.AddItemButton.UseVisualStyleBackColor = true;
            this.AddItemButton.Click += new System.EventHandler(this.Additem);
            // 
            // StartButton
            // 
            this.StartButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.StartButton.Location = new System.Drawing.Point(480, 5);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartPushed);
            // 
            // EditButton
            // 
            this.EditButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.EditButton.Location = new System.Drawing.Point(273, 5);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 2;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditPushed);
            // 
            // Apps
            // 
            this.Apps.AllowColumnReorder = true;
            this.Apps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Apps.BackColor = System.Drawing.SystemColors.Window;
            this.Apps.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Apps.ContextMenuStrip = this.ApplistRClick;
            this.Apps.HideSelection = false;
            this.Apps.Location = new System.Drawing.Point(3, 3);
            this.Apps.MultiSelect = false;
            this.Apps.Name = "Apps";
            this.Apps.Size = new System.Drawing.Size(615, 494);
            this.Apps.TabIndex = 1;
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
            this.ApplistRClick.Size = new System.Drawing.Size(70, 92);
            // 
            // ApplistRC_Add
            // 
            this.ApplistRC_Add.Name = "ApplistRC_Add";
            this.ApplistRC_Add.Size = new System.Drawing.Size(69, 22);
            this.ApplistRC_Add.Click += new System.EventHandler(this.Additem);
            // 
            // ApplistRC_Edit
            // 
            this.ApplistRC_Edit.Name = "ApplistRC_Edit";
            this.ApplistRC_Edit.Size = new System.Drawing.Size(69, 22);
            this.ApplistRC_Edit.Click += new System.EventHandler(this.EditPushed);
            // 
            // ApplistRC_Delete
            // 
            this.ApplistRC_Delete.Name = "ApplistRC_Delete";
            this.ApplistRC_Delete.Size = new System.Drawing.Size(69, 22);
            this.ApplistRC_Delete.Click += new System.EventHandler(this.DeleteClicked);
            // 
            // ApplistRC_RunAsAdmin
            // 
            this.ApplistRC_RunAsAdmin.Name = "ApplistRC_RunAsAdmin";
            this.ApplistRC_RunAsAdmin.Size = new System.Drawing.Size(69, 22);
            this.ApplistRC_RunAsAdmin.Click += new System.EventHandler(this.RunAsAdminClicked);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Apps, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(621, 531);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.AddItemButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.StartButton, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.EditButton, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 500);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(621, 31);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // Main_FullScreenList
            // 
            this.AcceptButton = this.StartButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 570);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Ribbon;
            this.Name = "Main_FullScreenList";
            this.Text = "WorkhubForWindows";
            this.Shown += new System.EventHandler(this.MainWindowShown);
            this.SizeChanged += new System.EventHandler(this.PaintCalled);
            this.Ribbon.ResumeLayout(false);
            this.Ribbon.PerformLayout();
            this.TrayRClick.ResumeLayout(false);
            this.ApplistRClick.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
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
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.ListView Apps;
        private System.Windows.Forms.ToolStripMenuItem ToolStripShowWidget;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem TrayRC_ShowWidget;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ContextMenuStrip ApplistRClick;
        private System.Windows.Forms.ToolStripMenuItem ApplistRC_Add;
        private System.Windows.Forms.ToolStripMenuItem ApplistRC_Edit;
        private System.Windows.Forms.ToolStripMenuItem ApplistRC_Delete;
        private System.Windows.Forms.ToolStripMenuItem TrayRC_Settings;
        private System.Windows.Forms.ToolStripMenuItem TrayRC_AddItem;
        private System.Windows.Forms.ToolStripMenuItem ApplistRC_RunAsAdmin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}

