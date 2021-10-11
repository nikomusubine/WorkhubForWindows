namespace WorkhubForWindows.Forms
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.FontSelectDiag = new System.Windows.Forms.FontDialog();
            this.FontName = new System.Windows.Forms.Label();
            this.FontNames = new System.Windows.Forms.ComboBox();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.FontSizeBox = new System.Windows.Forms.TextBox();
            this.backimglabel = new System.Windows.Forms.Label();
            this.backimgpath = new System.Windows.Forms.TextBox();
            this.backimgref = new System.Windows.Forms.Button();
            this.widgetbackimgref = new System.Windows.Forms.Button();
            this.widgetbackimgpath = new System.Windows.Forms.TextBox();
            this.widgetbackimg = new System.Windows.Forms.Label();
            this.OpacityBar = new System.Windows.Forms.TrackBar();
            this.OpacityLabel = new System.Windows.Forms.Label();
            this.OpacityBox = new System.Windows.Forms.NumericUpDown();
            this.StartUpbutton = new System.Windows.Forms.Button();
            this.ColorDiag = new System.Windows.Forms.ColorDialog();
            this.OpacityPercent = new System.Windows.Forms.Label();
            this.WidgetForeColorLabel = new System.Windows.Forms.Label();
            this.WidgetForeColorChangeButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.GeneralSettingsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.SettingsTab = new System.Windows.Forms.TabControl();
            this.General = new System.Windows.Forms.TabPage();
            this.Widget = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OpacityBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpacityBox)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.GeneralSettingsPanel.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SettingsTab.SuspendLayout();
            this.General.SuspendLayout();
            this.Widget.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // FontName
            // 
            resources.ApplyResources(this.FontName, "FontName");
            this.FontName.Name = "FontName";
            // 
            // FontNames
            // 
            resources.ApplyResources(this.FontNames, "FontNames");
            this.FontNames.FormattingEnabled = true;
            this.FontNames.Name = "FontNames";
            // 
            // ApplyButton
            // 
            resources.ApplyResources(this.ApplyButton, "ApplyButton");
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyClicked);
            // 
            // Cancel_Button
            // 
            resources.ApplyResources(this.Cancel_Button, "Cancel_Button");
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.CancelClicked);
            // 
            // FontSizeBox
            // 
            resources.ApplyResources(this.FontSizeBox, "FontSizeBox");
            this.FontSizeBox.Name = "FontSizeBox";
            this.FontSizeBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FontSizeKeyPress);
            // 
            // backimglabel
            // 
            resources.ApplyResources(this.backimglabel, "backimglabel");
            this.backimglabel.Name = "backimglabel";
            // 
            // backimgpath
            // 
            resources.ApplyResources(this.backimgpath, "backimgpath");
            this.backimgpath.Name = "backimgpath";
            // 
            // backimgref
            // 
            resources.ApplyResources(this.backimgref, "backimgref");
            this.backimgref.Name = "backimgref";
            this.backimgref.UseVisualStyleBackColor = true;
            this.backimgref.Click += new System.EventHandler(this.BackImgRefClick);
            // 
            // widgetbackimgref
            // 
            resources.ApplyResources(this.widgetbackimgref, "widgetbackimgref");
            this.widgetbackimgref.Name = "widgetbackimgref";
            this.widgetbackimgref.UseVisualStyleBackColor = true;
            this.widgetbackimgref.Click += new System.EventHandler(this.WidgetBackImgRefClick);
            // 
            // widgetbackimgpath
            // 
            resources.ApplyResources(this.widgetbackimgpath, "widgetbackimgpath");
            this.widgetbackimgpath.Name = "widgetbackimgpath";
            // 
            // widgetbackimg
            // 
            resources.ApplyResources(this.widgetbackimg, "widgetbackimg");
            this.widgetbackimg.Name = "widgetbackimg";
            // 
            // OpacityBar
            // 
            resources.ApplyResources(this.OpacityBar, "OpacityBar");
            this.OpacityBar.Maximum = 100;
            this.OpacityBar.Name = "OpacityBar";
            this.OpacityBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.OpacityBar.Scroll += new System.EventHandler(this.OpacityBarScroll);
            // 
            // OpacityLabel
            // 
            resources.ApplyResources(this.OpacityLabel, "OpacityLabel");
            this.OpacityLabel.Name = "OpacityLabel";
            // 
            // OpacityBox
            // 
            resources.ApplyResources(this.OpacityBox, "OpacityBox");
            this.OpacityBox.Name = "OpacityBox";
            this.OpacityBox.ValueChanged += new System.EventHandler(this.OpacityBoxChanged);
            // 
            // StartUpbutton
            // 
            resources.ApplyResources(this.StartUpbutton, "StartUpbutton");
            this.StartUpbutton.Name = "StartUpbutton";
            this.StartUpbutton.UseVisualStyleBackColor = true;
            this.StartUpbutton.Click += new System.EventHandler(this.AddStartUpClicked);
            // 
            // OpacityPercent
            // 
            resources.ApplyResources(this.OpacityPercent, "OpacityPercent");
            this.OpacityPercent.Name = "OpacityPercent";
            // 
            // WidgetForeColorLabel
            // 
            resources.ApplyResources(this.WidgetForeColorLabel, "WidgetForeColorLabel");
            this.WidgetForeColorLabel.Name = "WidgetForeColorLabel";
            // 
            // WidgetForeColorChangeButton
            // 
            resources.ApplyResources(this.WidgetForeColorChangeButton, "WidgetForeColorChangeButton");
            this.WidgetForeColorChangeButton.Name = "WidgetForeColorChangeButton";
            this.WidgetForeColorChangeButton.UseVisualStyleBackColor = true;
            this.WidgetForeColorChangeButton.Click += new System.EventHandler(this.WidgetForeColorChangeButtonClicked);
            // 
            // tableLayoutPanel5
            // 
            resources.ApplyResources(this.tableLayoutPanel5, "tableLayoutPanel5");
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel8, 0, 1);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            // 
            // tableLayoutPanel6
            // 
            resources.ApplyResources(this.tableLayoutPanel6, "tableLayoutPanel6");
            this.tableLayoutPanel6.Controls.Add(this.OpacityLabel, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.OpacityBar, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel7, 1, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            // 
            // tableLayoutPanel7
            // 
            resources.ApplyResources(this.tableLayoutPanel7, "tableLayoutPanel7");
            this.tableLayoutPanel7.Controls.Add(this.OpacityBox, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.OpacityPercent, 1, 0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            // 
            // tableLayoutPanel8
            // 
            resources.ApplyResources(this.tableLayoutPanel8, "tableLayoutPanel8");
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            // 
            // GeneralSettingsPanel
            // 
            resources.ApplyResources(this.GeneralSettingsPanel, "GeneralSettingsPanel");
            this.GeneralSettingsPanel.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.GeneralSettingsPanel.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.GeneralSettingsPanel.Controls.Add(this.StartUpbutton, 0, 2);
            this.GeneralSettingsPanel.Name = "GeneralSettingsPanel";
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.FontName, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.FontNames, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.FontSizeBox, 2, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // tableLayoutPanel4
            // 
            resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
            this.tableLayoutPanel4.Controls.Add(this.backimglabel, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.backimgpath, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.backimgref, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.widgetbackimg, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.widgetbackimgpath, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.widgetbackimgref, 2, 1);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            // 
            // SettingsTab
            // 
            resources.ApplyResources(this.SettingsTab, "SettingsTab");
            this.SettingsTab.Controls.Add(this.General);
            this.SettingsTab.Controls.Add(this.Widget);
            this.SettingsTab.Name = "SettingsTab";
            this.SettingsTab.SelectedIndex = 0;
            // 
            // General
            // 
            this.General.Controls.Add(this.GeneralSettingsPanel);
            resources.ApplyResources(this.General, "General");
            this.General.Name = "General";
            this.General.UseVisualStyleBackColor = true;
            // 
            // Widget
            // 
            this.Widget.Controls.Add(this.tableLayoutPanel5);
            resources.ApplyResources(this.Widget, "Widget");
            this.Widget.Name = "Widget";
            this.Widget.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.WidgetForeColorLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.WidgetForeColorChangeButton, 1, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.ApplyButton;
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.SettingsTab);
            this.Controls.Add(this.ApplyButton);
            this.Name = "SettingsForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Settings_Closed);
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OpacityBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpacityBox)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.GeneralSettingsPanel.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.SettingsTab.ResumeLayout(false);
            this.General.ResumeLayout(false);
            this.Widget.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FontDialog FontSelectDiag;
        private System.Windows.Forms.Label FontName;
        private System.Windows.Forms.ComboBox FontNames;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.TextBox FontSizeBox;
        private System.Windows.Forms.Label backimglabel;
        private System.Windows.Forms.TextBox backimgpath;
        private System.Windows.Forms.Button backimgref;
        private System.Windows.Forms.Button widgetbackimgref;
        private System.Windows.Forms.TextBox widgetbackimgpath;
        private System.Windows.Forms.Label widgetbackimg;
        private System.Windows.Forms.TrackBar OpacityBar;
        private System.Windows.Forms.Label OpacityLabel;
        private System.Windows.Forms.NumericUpDown OpacityBox;
        private System.Windows.Forms.Button StartUpbutton;
        private System.Windows.Forms.ColorDialog ColorDiag;
        private System.Windows.Forms.Label OpacityPercent;
        private System.Windows.Forms.Label WidgetForeColorLabel;
        private System.Windows.Forms.Button WidgetForeColorChangeButton;
        private System.Windows.Forms.TableLayoutPanel GeneralSettingsPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TabControl SettingsTab;
        private System.Windows.Forms.TabPage General;
        private System.Windows.Forms.TabPage Widget;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}