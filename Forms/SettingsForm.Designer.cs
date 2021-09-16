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
            this.FontNames.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FontNames.Name = "FontNames";
            this.FontNames.Size = new System.Drawing.Size(160, 23);
            this.FontNames.TabIndex = 1;
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(684, 406);
            this.ApplyButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(100, 31);
            this.ApplyButton.TabIndex = 3;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(576, 406);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.FontSizeBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.backimglabel.Size = new System.Drawing.Size(127, 15);
            this.backimglabel.TabIndex = 6;
            this.backimglabel.Text = "BackGround Image";
            // 
            // backimgpath
            // 
            this.backimgpath.Location = new System.Drawing.Point(150, 47);
            this.backimgpath.Name = "backimgpath";
            this.backimgpath.Size = new System.Drawing.Size(174, 22);
            this.backimgpath.TabIndex = 7;
            // 
            // backimgref
            // 
            this.backimgref.Location = new System.Drawing.Point(330, 46);
            this.backimgref.Name = "backimgref";
            this.backimgref.Size = new System.Drawing.Size(25, 25);
            this.backimgref.TabIndex = 8;
            this.backimgref.Text = "...";
            this.backimgref.UseVisualStyleBackColor = true;
            this.backimgref.Click += new System.EventHandler(this.BackImgRefClick);
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.ApplyButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}