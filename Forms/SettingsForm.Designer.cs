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
            this.LogoffSoundbutton = new System.Windows.Forms.Button();
            this.LogoffsoundBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Shutdownsoundbutton = new System.Windows.Forms.Button();
            this.Shutdownsoundbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.WidgetsSettingsLabel = new System.Windows.Forms.Label();
            this.OpacityBar = new System.Windows.Forms.TrackBar();
            this.OpacityLabel = new System.Windows.Forms.Label();
            this.OpacityBox = new System.Windows.Forms.NumericUpDown();
            this.StartUpbutton = new System.Windows.Forms.Button();
            this.ColorDiag = new System.Windows.Forms.ColorDialog();
            this.OpacityPercent = new System.Windows.Forms.Label();
            this.WidgetForeColorLabel = new System.Windows.Forms.Label();
            this.WidgetForeColorChangeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OpacityBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpacityBox)).BeginInit();
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
            // LogoffSoundbutton
            // 
            resources.ApplyResources(this.LogoffSoundbutton, "LogoffSoundbutton");
            this.LogoffSoundbutton.Name = "LogoffSoundbutton";
            this.LogoffSoundbutton.UseVisualStyleBackColor = true;
            this.LogoffSoundbutton.Click += new System.EventHandler(this.LogoffsoundrefClick);
            // 
            // LogoffsoundBox
            // 
            resources.ApplyResources(this.LogoffsoundBox, "LogoffsoundBox");
            this.LogoffsoundBox.Name = "LogoffsoundBox";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // Shutdownsoundbutton
            // 
            resources.ApplyResources(this.Shutdownsoundbutton, "Shutdownsoundbutton");
            this.Shutdownsoundbutton.Name = "Shutdownsoundbutton";
            this.Shutdownsoundbutton.UseVisualStyleBackColor = true;
            this.Shutdownsoundbutton.Click += new System.EventHandler(this.ShutdownrefClick);
            // 
            // Shutdownsoundbox
            // 
            resources.ApplyResources(this.Shutdownsoundbox, "Shutdownsoundbox");
            this.Shutdownsoundbox.Name = "Shutdownsoundbox";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // WidgetsSettingsLabel
            // 
            resources.ApplyResources(this.WidgetsSettingsLabel, "WidgetsSettingsLabel");
            this.WidgetsSettingsLabel.Name = "WidgetsSettingsLabel";
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
            // SettingsForm
            // 
            this.AcceptButton = this.ApplyButton;
            resources.ApplyResources(this, "$this");
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.WidgetForeColorChangeButton);
            this.Controls.Add(this.WidgetForeColorLabel);
            this.Controls.Add(this.OpacityPercent);
            this.Controls.Add(this.StartUpbutton);
            this.Controls.Add(this.OpacityBox);
            this.Controls.Add(this.OpacityLabel);
            this.Controls.Add(this.OpacityBar);
            this.Controls.Add(this.WidgetsSettingsLabel);
            this.Controls.Add(this.LogoffSoundbutton);
            this.Controls.Add(this.LogoffsoundBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Shutdownsoundbutton);
            this.Controls.Add(this.Shutdownsoundbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.widgetbackimgref);
            this.Controls.Add(this.widgetbackimgpath);
            this.Controls.Add(this.widgetbackimg);
            this.Controls.Add(this.backimgref);
            this.Controls.Add(this.backimgpath);
            this.Controls.Add(this.backimglabel);
            this.Controls.Add(this.FontSizeBox);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.FontNames);
            this.Controls.Add(this.FontName);
            this.Name = "SettingsForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Settings_Closed);
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OpacityBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpacityBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button LogoffSoundbutton;
        private System.Windows.Forms.TextBox LogoffsoundBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Shutdownsoundbutton;
        private System.Windows.Forms.TextBox Shutdownsoundbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label WidgetsSettingsLabel;
        private System.Windows.Forms.TrackBar OpacityBar;
        private System.Windows.Forms.Label OpacityLabel;
        private System.Windows.Forms.NumericUpDown OpacityBox;
        private System.Windows.Forms.Button StartUpbutton;
        private System.Windows.Forms.ColorDialog ColorDiag;
        private System.Windows.Forms.Label OpacityPercent;
        private System.Windows.Forms.Label WidgetForeColorLabel;
        private System.Windows.Forms.Button WidgetForeColorChangeButton;
    }
}