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
            this.SuspendLayout();
            // 
            // FontName
            // 
            this.FontName.AutoSize = true;
            this.FontName.Location = new System.Drawing.Point(13, 13);
            this.FontName.Name = "FontName";
            this.FontName.Size = new System.Drawing.Size(30, 12);
            this.FontName.TabIndex = 0;
            this.FontName.Text = "Font:";
            // 
            // FontNames
            // 
            this.FontNames.FormattingEnabled = true;
            this.FontNames.Location = new System.Drawing.Point(69, 10);
            this.FontNames.Name = "FontNames";
            this.FontNames.Size = new System.Drawing.Size(121, 20);
            this.FontNames.TabIndex = 1;
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(513, 325);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(75, 25);
            this.ApplyButton.TabIndex = 3;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(432, 325);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 25);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelClicked);
            // 
            // FontSizeBox
            // 
            this.FontSizeBox.Location = new System.Drawing.Point(196, 11);
            this.FontSizeBox.Name = "FontSizeBox";
            this.FontSizeBox.Size = new System.Drawing.Size(51, 19);
            this.FontSizeBox.TabIndex = 5;
            this.FontSizeBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FontSizeKeyPress);
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.ApplyButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.FontSizeBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.FontNames);
            this.Controls.Add(this.FontName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
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
    }
}