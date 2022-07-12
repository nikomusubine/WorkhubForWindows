namespace WorkhubForWindows.Forms
{
    partial class EULA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EULA));
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonAccept = new System.Windows.Forms.Button();
            this.DelineButton = new System.Windows.Forms.Button();
            this.EulaText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 40F);
            this.label1.Location = new System.Drawing.Point(38, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(709, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thank you for download!";
            // 
            // ButtonAccept
            // 
            this.ButtonAccept.Location = new System.Drawing.Point(713, 415);
            this.ButtonAccept.Name = "ButtonAccept";
            this.ButtonAccept.Size = new System.Drawing.Size(75, 23);
            this.ButtonAccept.TabIndex = 2;
            this.ButtonAccept.Text = "Accept";
            this.ButtonAccept.UseVisualStyleBackColor = true;
            this.ButtonAccept.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // DelineButton
            // 
            this.DelineButton.Location = new System.Drawing.Point(13, 415);
            this.DelineButton.Name = "DelineButton";
            this.DelineButton.Size = new System.Drawing.Size(75, 23);
            this.DelineButton.TabIndex = 3;
            this.DelineButton.Text = "Deline";
            this.DelineButton.UseVisualStyleBackColor = true;
            // 
            // EulaText
            // 
            this.EulaText.Location = new System.Drawing.Point(13, 80);
            this.EulaText.Name = "EulaText";
            this.EulaText.Size = new System.Drawing.Size(775, 311);
            this.EulaText.TabIndex = 1;
            this.EulaText.Text = "";
            // 
            // EULA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DelineButton);
            this.Controls.Add(this.ButtonAccept);
            this.Controls.Add(this.EulaText);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EULA";
            this.Text = "EULA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonAccept;
        private System.Windows.Forms.Button DelineButton;
        private System.Windows.Forms.RichTextBox EulaText;
    }
}