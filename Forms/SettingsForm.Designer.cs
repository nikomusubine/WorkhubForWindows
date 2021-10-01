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
            this.CancelButton = new System.Windows.Forms.Button();
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
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(576, 406);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(100, 31);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelClicked);
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
            this.backimglabel.Location = new System.Drawing.Point(17, 50);
            this.backimglabel.Name = "backimglabel";
            this.backimglabel.Size = new System.Drawing.Size(208, 15);
            this.backimglabel.TabIndex = 6;
            this.backimglabel.Text = "MainWindow BackGround Image";
            // 
            // backimgpath
            // 
            this.backimgpath.Location = new System.Drawing.Point(231, 46);
            this.backimgpath.Name = "backimgpath";
            this.backimgpath.Size = new System.Drawing.Size(174, 22);
            this.backimgpath.TabIndex = 7;
            // 
            // backimgref
            // 
            this.backimgref.Location = new System.Drawing.Point(411, 45);
            this.backimgref.Name = "backimgref";
            this.backimgref.Size = new System.Drawing.Size(25, 25);
            this.backimgref.TabIndex = 8;
            this.backimgref.Text = "...";
            this.backimgref.UseVisualStyleBackColor = true;
            this.backimgref.Click += new System.EventHandler(this.BackImgRefClick);
            // 
            // widgetbackimgref
            // 
            this.widgetbackimgref.Location = new System.Drawing.Point(411, 77);
            this.widgetbackimgref.Name = "widgetbackimgref";
            this.widgetbackimgref.Size = new System.Drawing.Size(25, 25);
            this.widgetbackimgref.TabIndex = 11;
            this.widgetbackimgref.Text = "...";
            this.widgetbackimgref.UseVisualStyleBackColor = true;
            // 
            // widgetbackimgpath
            // 
            this.widgetbackimgpath.Location = new System.Drawing.Point(231, 78);
            this.widgetbackimgpath.Name = "widgetbackimgpath";
            this.widgetbackimgpath.Size = new System.Drawing.Size(174, 22);
            this.widgetbackimgpath.TabIndex = 10;
            // 
            // widgetbackimg
            // 
            this.widgetbackimg.AutoSize = true;
            this.widgetbackimg.Location = new System.Drawing.Point(17, 78);
            this.widgetbackimg.Name = "widgetbackimg";
            this.widgetbackimg.Size = new System.Drawing.Size(173, 15);
            this.widgetbackimg.TabIndex = 9;
            this.widgetbackimg.Text = "Widget BackGround Image";
            // 
            // LogoffSoundbutton
            // 
            this.LogoffSoundbutton.Location = new System.Drawing.Point(411, 137);
            this.LogoffSoundbutton.Name = "LogoffSoundbutton";
            this.LogoffSoundbutton.Size = new System.Drawing.Size(25, 25);
            this.LogoffSoundbutton.TabIndex = 17;
            this.LogoffSoundbutton.Text = "...";
            this.LogoffSoundbutton.UseVisualStyleBackColor = true;
            this.LogoffSoundbutton.Click += new System.EventHandler(this.LogoffsoundrefClick);
            // 
            // LogoffsoundBox
            // 
            this.LogoffsoundBox.Location = new System.Drawing.Point(231, 138);
            this.LogoffsoundBox.Name = "LogoffsoundBox";
            this.LogoffsoundBox.Size = new System.Drawing.Size(174, 22);
            this.LogoffsoundBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "LogoffSound";
            // 
            // Shutdownsoundbutton
            // 
            this.Shutdownsoundbutton.Location = new System.Drawing.Point(411, 105);
            this.Shutdownsoundbutton.Name = "Shutdownsoundbutton";
            this.Shutdownsoundbutton.Size = new System.Drawing.Size(25, 25);
            this.Shutdownsoundbutton.TabIndex = 14;
            this.Shutdownsoundbutton.Text = "...";
            this.Shutdownsoundbutton.UseVisualStyleBackColor = true;
            this.Shutdownsoundbutton.Click += new System.EventHandler(this.ShutdownrefClick);
            // 
            // Shutdownsoundbox
            // 
            this.Shutdownsoundbox.Location = new System.Drawing.Point(231, 106);
            this.Shutdownsoundbox.Name = "Shutdownsoundbox";
            this.Shutdownsoundbox.Size = new System.Drawing.Size(174, 22);
            this.Shutdownsoundbox.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Shutdown Sound";
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.ApplyButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.FontNames);
            this.Controls.Add(this.FontName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.Click += new System.EventHandler(this.ApplyClicked);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FontDialog FontSelectDiag;
        private System.Windows.Forms.Label FontName;
        private System.Windows.Forms.ComboBox FontNames;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Button CancelButton;
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
    }
}