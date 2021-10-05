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
            ((System.ComponentModel.ISupportInitialize)(this.OpacityBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpacityBox)).BeginInit();
            this.SuspendLayout();
            // 
            // FontName
            // 
            this.FontName.AutoSize = true;
            this.FontName.Location = new System.Drawing.Point(17, 16);
            this.FontName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FontName.Name = "FontName";
            this.FontName.Size = new System.Drawing.Size(39, 15);
            this.FontName.TabIndex = 0;
            this.FontName.Text = "Font:";
            // 
            // FontNames
            // 
            this.FontNames.FormattingEnabled = true;
            this.FontNames.Location = new System.Drawing.Point(92, 12);
            this.FontNames.Margin = new System.Windows.Forms.Padding(4);
            this.FontNames.Name = "FontNames";
            this.FontNames.Size = new System.Drawing.Size(160, 23);
            this.FontNames.TabIndex = 1;
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(684, 406);
            this.ApplyButton.Margin = new System.Windows.Forms.Padding(4);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(100, 31);
            this.ApplyButton.TabIndex = 3;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyClicked);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(576, 406);
            this.Cancel_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(100, 31);
            this.Cancel_Button.TabIndex = 4;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.CancelClicked);
            // 
            // FontSizeBox
            // 
            this.FontSizeBox.Location = new System.Drawing.Point(261, 14);
            this.FontSizeBox.Margin = new System.Windows.Forms.Padding(4);
            this.FontSizeBox.Name = "FontSizeBox";
            this.FontSizeBox.Size = new System.Drawing.Size(67, 22);
            this.FontSizeBox.TabIndex = 5;
            this.FontSizeBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FontSizeKeyPress);
            // 
            // backimglabel
            // 
            this.backimglabel.AutoSize = true;
            this.backimglabel.Location = new System.Drawing.Point(16, 46);
            this.backimglabel.Name = "backimglabel";
            this.backimglabel.Size = new System.Drawing.Size(208, 15);
            this.backimglabel.TabIndex = 6;
            this.backimglabel.Text = "MainWindow BackGround Image";
            // 
            // backimgpath
            // 
            this.backimgpath.Location = new System.Drawing.Point(230, 42);
            this.backimgpath.Name = "backimgpath";
            this.backimgpath.Size = new System.Drawing.Size(174, 22);
            this.backimgpath.TabIndex = 7;
            // 
            // backimgref
            // 
            this.backimgref.Location = new System.Drawing.Point(410, 41);
            this.backimgref.Name = "backimgref";
            this.backimgref.Size = new System.Drawing.Size(25, 25);
            this.backimgref.TabIndex = 8;
            this.backimgref.Text = "...";
            this.backimgref.UseVisualStyleBackColor = true;
            this.backimgref.Click += new System.EventHandler(this.BackImgRefClick);
            // 
            // widgetbackimgref
            // 
            this.widgetbackimgref.Location = new System.Drawing.Point(410, 73);
            this.widgetbackimgref.Name = "widgetbackimgref";
            this.widgetbackimgref.Size = new System.Drawing.Size(25, 25);
            this.widgetbackimgref.TabIndex = 11;
            this.widgetbackimgref.Text = "...";
            this.widgetbackimgref.UseVisualStyleBackColor = true;
            this.widgetbackimgref.Click += new System.EventHandler(this.WidgetBackImgRefClick);
            // 
            // widgetbackimgpath
            // 
            this.widgetbackimgpath.Location = new System.Drawing.Point(230, 74);
            this.widgetbackimgpath.Name = "widgetbackimgpath";
            this.widgetbackimgpath.Size = new System.Drawing.Size(174, 22);
            this.widgetbackimgpath.TabIndex = 10;
            // 
            // widgetbackimg
            // 
            this.widgetbackimg.AutoSize = true;
            this.widgetbackimg.Location = new System.Drawing.Point(16, 74);
            this.widgetbackimg.Name = "widgetbackimg";
            this.widgetbackimg.Size = new System.Drawing.Size(173, 15);
            this.widgetbackimg.TabIndex = 9;
            this.widgetbackimg.Text = "Widget BackGround Image";
            // 
            // LogoffSoundbutton
            // 
            this.LogoffSoundbutton.Location = new System.Drawing.Point(410, 133);
            this.LogoffSoundbutton.Name = "LogoffSoundbutton";
            this.LogoffSoundbutton.Size = new System.Drawing.Size(25, 25);
            this.LogoffSoundbutton.TabIndex = 17;
            this.LogoffSoundbutton.Text = "...";
            this.LogoffSoundbutton.UseVisualStyleBackColor = true;
            this.LogoffSoundbutton.Click += new System.EventHandler(this.LogoffsoundrefClick);
            // 
            // LogoffsoundBox
            // 
            this.LogoffsoundBox.Location = new System.Drawing.Point(230, 134);
            this.LogoffsoundBox.Name = "LogoffsoundBox";
            this.LogoffsoundBox.Size = new System.Drawing.Size(174, 22);
            this.LogoffsoundBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "LogoffSound";
            // 
            // Shutdownsoundbutton
            // 
            this.Shutdownsoundbutton.Location = new System.Drawing.Point(410, 101);
            this.Shutdownsoundbutton.Name = "Shutdownsoundbutton";
            this.Shutdownsoundbutton.Size = new System.Drawing.Size(25, 25);
            this.Shutdownsoundbutton.TabIndex = 14;
            this.Shutdownsoundbutton.Text = "...";
            this.Shutdownsoundbutton.UseVisualStyleBackColor = true;
            this.Shutdownsoundbutton.Click += new System.EventHandler(this.ShutdownrefClick);
            // 
            // Shutdownsoundbox
            // 
            this.Shutdownsoundbox.Location = new System.Drawing.Point(230, 102);
            this.Shutdownsoundbox.Name = "Shutdownsoundbox";
            this.Shutdownsoundbox.Size = new System.Drawing.Size(174, 22);
            this.Shutdownsoundbox.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Shutdown Sound";
            // 
            // WidgetsSettingsLabel
            // 
            this.WidgetsSettingsLabel.AutoSize = true;
            this.WidgetsSettingsLabel.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.WidgetsSettingsLabel.Location = new System.Drawing.Point(13, 160);
            this.WidgetsSettingsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WidgetsSettingsLabel.Name = "WidgetsSettingsLabel";
            this.WidgetsSettingsLabel.Size = new System.Drawing.Size(116, 17);
            this.WidgetsSettingsLabel.TabIndex = 18;
            this.WidgetsSettingsLabel.Text = "WidgetSettings";
            // 
            // OpacityBar
            // 
            this.OpacityBar.Location = new System.Drawing.Point(230, 188);
            this.OpacityBar.Maximum = 100;
            this.OpacityBar.Name = "OpacityBar";
            this.OpacityBar.Size = new System.Drawing.Size(174, 56);
            this.OpacityBar.TabIndex = 19;
            this.OpacityBar.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // OpacityLabel
            // 
            this.OpacityLabel.AutoSize = true;
            this.OpacityLabel.Location = new System.Drawing.Point(17, 188);
            this.OpacityLabel.Name = "OpacityLabel";
            this.OpacityLabel.Size = new System.Drawing.Size(55, 15);
            this.OpacityLabel.TabIndex = 20;
            this.OpacityLabel.Text = "Opacity";
            // 
            // OpacityBox
            // 
            this.OpacityBox.Location = new System.Drawing.Point(92, 188);
            this.OpacityBox.Name = "OpacityBox";
            this.OpacityBox.Size = new System.Drawing.Size(132, 22);
            this.OpacityBox.TabIndex = 21;
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.ApplyButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.Click += new System.EventHandler(this.ApplyClicked);
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
    }
}