namespace WorkhubForWindows.Forms
{
    partial class EditItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditItem));
            this.Applist = new System.Windows.Forms.ListView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Close_Button = new System.Windows.Forms.Button();
            this.okbutton = new System.Windows.Forms.Button();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.RunasLabel = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.PathLabel = new System.Windows.Forms.Label();
            this.ArgsLabel = new System.Windows.Forms.Label();
            this.ArgsBox = new System.Windows.Forms.TextBox();
            this.PathBox = new System.Windows.Forms.TextBox();
            this.RunasAdminBox = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.MoveLbutton = new System.Windows.Forms.Button();
            this.MoveRbutton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Applist
            // 
            resources.ApplyResources(this.Applist, "Applist");
            this.Applist.HideSelection = false;
            this.Applist.Name = "Applist";
            this.Applist.UseCompatibleStateImageBehavior = false;
            this.Applist.View = System.Windows.Forms.View.List;
            this.Applist.SelectedIndexChanged += new System.EventHandler(this.AppsSelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.Applist, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.Close_Button, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.okbutton, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.ApplyButton, 1, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // Close_Button
            // 
            resources.ApplyResources(this.Close_Button, "Close_Button");
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.UseVisualStyleBackColor = true;
            this.Close_Button.Click += new System.EventHandler(this.CloseButtonClicked);
            // 
            // okbutton
            // 
            resources.ApplyResources(this.okbutton, "okbutton");
            this.okbutton.Name = "okbutton";
            this.okbutton.UseVisualStyleBackColor = true;
            this.okbutton.Click += new System.EventHandler(this.OKButtonClicked);
            // 
            // ApplyButton
            // 
            resources.ApplyResources(this.ApplyButton, "ApplyButton");
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButtonClicked);
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.RunasLabel, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.NameBox, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.NameLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.PathLabel, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.ArgsLabel, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.ArgsBox, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.PathBox, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.RunasAdminBox, 1, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // RunasLabel
            // 
            resources.ApplyResources(this.RunasLabel, "RunasLabel");
            this.RunasLabel.Name = "RunasLabel";
            // 
            // NameBox
            // 
            resources.ApplyResources(this.NameBox, "NameBox");
            this.NameBox.Name = "NameBox";
            // 
            // NameLabel
            // 
            resources.ApplyResources(this.NameLabel, "NameLabel");
            this.NameLabel.Name = "NameLabel";
            // 
            // PathLabel
            // 
            resources.ApplyResources(this.PathLabel, "PathLabel");
            this.PathLabel.Name = "PathLabel";
            // 
            // ArgsLabel
            // 
            resources.ApplyResources(this.ArgsLabel, "ArgsLabel");
            this.ArgsLabel.Name = "ArgsLabel";
            // 
            // ArgsBox
            // 
            resources.ApplyResources(this.ArgsBox, "ArgsBox");
            this.ArgsBox.Name = "ArgsBox";
            // 
            // PathBox
            // 
            resources.ApplyResources(this.PathBox, "PathBox");
            this.PathBox.Name = "PathBox";
            // 
            // RunasAdminBox
            // 
            resources.ApplyResources(this.RunasAdminBox, "RunasAdminBox");
            this.RunasAdminBox.Name = "RunasAdminBox";
            this.RunasAdminBox.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
            this.tableLayoutPanel4.Controls.Add(this.MoveLbutton, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.MoveRbutton, 1, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            // 
            // MoveLbutton
            // 
            resources.ApplyResources(this.MoveLbutton, "MoveLbutton");
            this.MoveLbutton.Name = "MoveLbutton";
            this.MoveLbutton.UseVisualStyleBackColor = true;
            this.MoveLbutton.Click += new System.EventHandler(this.MoveLClicked);
            // 
            // MoveRbutton
            // 
            resources.ApplyResources(this.MoveRbutton, "MoveRbutton");
            this.MoveRbutton.Name = "MoveRbutton";
            this.MoveRbutton.UseVisualStyleBackColor = true;
            this.MoveRbutton.Click += new System.EventHandler(this.MoveRClicked);
            // 
            // EditItem
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EditItem";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView Applist;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox PathBox;
        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.Label ArgsLabel;
        private System.Windows.Forms.TextBox ArgsBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button MoveLbutton;
        private System.Windows.Forms.Button MoveRbutton;
        private System.Windows.Forms.Button Close_Button;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Button okbutton;
        private System.Windows.Forms.Label RunasLabel;
        private System.Windows.Forms.CheckBox RunasAdminBox;
    }
}