namespace WorkhubForWindows.Forms
{
    partial class AddItemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddItemForm));
            this.ItemnameLabel = new System.Windows.Forms.Label();
            this.ItemNameBox = new System.Windows.Forms.TextBox();
            this.FilePathBox = new System.Windows.Forms.TextBox();
            this.FilepathLabel = new System.Windows.Forms.Label();
            this.ButtonReference = new System.Windows.Forms.Button();
            this.CmdArgsBox = new System.Windows.Forms.TextBox();
            this.CmdArgsLabel = new System.Windows.Forms.Label();
            this.ButtonApply = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.RefDiag = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // ItemnameLabel
            // 
            resources.ApplyResources(this.ItemnameLabel, "ItemnameLabel");
            this.ItemnameLabel.Name = "ItemnameLabel";
            // 
            // ItemNameBox
            // 
            resources.ApplyResources(this.ItemNameBox, "ItemNameBox");
            this.ItemNameBox.Name = "ItemNameBox";
            // 
            // FilePathBox
            // 
            resources.ApplyResources(this.FilePathBox, "FilePathBox");
            this.FilePathBox.Name = "FilePathBox";
            // 
            // FilepathLabel
            // 
            resources.ApplyResources(this.FilepathLabel, "FilepathLabel");
            this.FilepathLabel.Name = "FilepathLabel";
            // 
            // ButtonReference
            // 
            resources.ApplyResources(this.ButtonReference, "ButtonReference");
            this.ButtonReference.Name = "ButtonReference";
            this.ButtonReference.UseVisualStyleBackColor = true;
            this.ButtonReference.Click += new System.EventHandler(this.ReferenceButton);
            // 
            // CmdArgsBox
            // 
            resources.ApplyResources(this.CmdArgsBox, "CmdArgsBox");
            this.CmdArgsBox.Name = "CmdArgsBox";
            // 
            // CmdArgsLabel
            // 
            resources.ApplyResources(this.CmdArgsLabel, "CmdArgsLabel");
            this.CmdArgsLabel.Name = "CmdArgsLabel";
            // 
            // ButtonApply
            // 
            resources.ApplyResources(this.ButtonApply, "ButtonApply");
            this.ButtonApply.Name = "ButtonApply";
            this.ButtonApply.UseVisualStyleBackColor = true;
            this.ButtonApply.Click += new System.EventHandler(this.ApplyClick);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.ButtonCancel, "ButtonCancel");
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.CancelClick);
            // 
            // RefDiag
            // 
            this.RefDiag.FileName = "RefrenceFile";
            resources.ApplyResources(this.RefDiag, "RefDiag");
            // 
            // AddItemForm
            // 
            this.AcceptButton = this.ButtonApply;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonCancel;
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonApply);
            this.Controls.Add(this.CmdArgsBox);
            this.Controls.Add(this.CmdArgsLabel);
            this.Controls.Add(this.ButtonReference);
            this.Controls.Add(this.FilePathBox);
            this.Controls.Add(this.FilepathLabel);
            this.Controls.Add(this.ItemNameBox);
            this.Controls.Add(this.ItemnameLabel);
            this.Name = "AddItemForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ItemnameLabel;
        private System.Windows.Forms.TextBox ItemNameBox;
        private System.Windows.Forms.TextBox FilePathBox;
        private System.Windows.Forms.Label FilepathLabel;
        private System.Windows.Forms.Button ButtonReference;
        private System.Windows.Forms.TextBox CmdArgsBox;
        private System.Windows.Forms.Label CmdArgsLabel;
        private System.Windows.Forms.Button ButtonApply;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.OpenFileDialog RefDiag;
    }
}