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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.IconLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.IconRef = new System.Windows.Forms.Button();
            this.IconBox = new System.Windows.Forms.TextBox();
            this.RunasAdminBox = new System.Windows.Forms.CheckBox();
            this.RunasAdminLabel = new System.Windows.Forms.Label();
            this.CurrentLabel = new System.Windows.Forms.Label();
            this.CurrentDirBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
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
            resources.ApplyResources(this.ButtonCancel, "ButtonCancel");
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.CancelClick);
            // 
            // RefDiag
            // 
            this.RefDiag.FileName = "RefrenceFile";
            resources.ApplyResources(this.RefDiag, "RefDiag");
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ItemnameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ItemNameBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.FilepathLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.IconLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.RunasAdminBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.RunasAdminLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.CmdArgsLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.CmdArgsBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.CurrentLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.CurrentDirBox, 1, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.ButtonReference, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.FilePathBox, 0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // IconLabel
            // 
            resources.ApplyResources(this.IconLabel, "IconLabel");
            this.IconLabel.Name = "IconLabel";
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.IconRef, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.IconBox, 0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // IconRef
            // 
            resources.ApplyResources(this.IconRef, "IconRef");
            this.IconRef.Name = "IconRef";
            this.IconRef.UseVisualStyleBackColor = true;
            this.IconRef.Click += new System.EventHandler(this.IconRef_Click);
            // 
            // IconBox
            // 
            resources.ApplyResources(this.IconBox, "IconBox");
            this.IconBox.Name = "IconBox";
            // 
            // RunasAdminBox
            // 
            resources.ApplyResources(this.RunasAdminBox, "RunasAdminBox");
            this.RunasAdminBox.Name = "RunasAdminBox";
            this.RunasAdminBox.UseVisualStyleBackColor = true;
            // 
            // RunasAdminLabel
            // 
            resources.ApplyResources(this.RunasAdminLabel, "RunasAdminLabel");
            this.RunasAdminLabel.Name = "RunasAdminLabel";
            // 
            // CurrentLabel
            // 
            resources.ApplyResources(this.CurrentLabel, "CurrentLabel");
            this.CurrentLabel.Name = "CurrentLabel";
            // 
            // CurrentDirBox
            // 
            resources.ApplyResources(this.CurrentDirBox, "CurrentDirBox");
            this.CurrentDirBox.Name = "CurrentDirBox";
            // 
            // AddItemForm
            // 
            this.AcceptButton = this.ButtonApply;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonCancel;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonApply);
            this.Name = "AddItemForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label RunasAdminLabel;
        private System.Windows.Forms.CheckBox RunasAdminBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button IconRef;
        private System.Windows.Forms.TextBox IconBox;
        private System.Windows.Forms.Label IconLabel;
        private System.Windows.Forms.Label CurrentLabel;
        private System.Windows.Forms.TextBox CurrentDirBox;
    }
}