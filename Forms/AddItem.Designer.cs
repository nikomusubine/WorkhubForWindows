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
            this.label1 = new System.Windows.Forms.Label();
            this.ItemNameBox = new System.Windows.Forms.TextBox();
            this.FilePathBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonReference = new System.Windows.Forms.Button();
            this.CmdArgs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonApply = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
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
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // ButtonReference
            // 
            resources.ApplyResources(this.ButtonReference, "ButtonReference");
            this.ButtonReference.Name = "ButtonReference";
            this.ButtonReference.UseVisualStyleBackColor = true;
            // 
            // CmdArgs
            // 
            resources.ApplyResources(this.CmdArgs, "CmdArgs");
            this.CmdArgs.Name = "CmdArgs";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // ButtonApply
            // 
            resources.ApplyResources(this.ButtonApply, "ButtonApply");
            this.ButtonApply.Name = "ButtonApply";
            this.ButtonApply.UseVisualStyleBackColor = true;
            // 
            // ButtonCancel
            // 
            resources.ApplyResources(this.ButtonCancel, "ButtonCancel");
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // AddItemForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonApply);
            this.Controls.Add(this.CmdArgs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ButtonReference);
            this.Controls.Add(this.FilePathBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ItemNameBox);
            this.Controls.Add(this.label1);
            this.Name = "AddItemForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ItemNameBox;
        private System.Windows.Forms.TextBox FilePathBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonReference;
        private System.Windows.Forms.TextBox CmdArgs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ButtonApply;
        private System.Windows.Forms.Button ButtonCancel;
    }
}