namespace WorkhubForWindows
{
    partial class ListFullScreen
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.ListViewPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Apps = new System.Windows.Forms.ListView();
            this.ButtonsPunel = new System.Windows.Forms.TableLayoutPanel();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.ListViewPanel.SuspendLayout();
            this.ButtonsPunel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListViewPanel
            // 
            this.ListViewPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListViewPanel.BackColor = System.Drawing.Color.Transparent;
            this.ListViewPanel.ColumnCount = 2;
            this.ListViewPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ListViewPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ListViewPanel.Controls.Add(this.Apps, 1, 0);
            this.ListViewPanel.Controls.Add(this.ButtonsPunel, 1, 1);
            this.ListViewPanel.Location = new System.Drawing.Point(4, 4);
            this.ListViewPanel.Margin = new System.Windows.Forms.Padding(4);
            this.ListViewPanel.Name = "ListViewPanel";
            this.ListViewPanel.RowCount = 2;
            this.ListViewPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ListViewPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.ListViewPanel.Size = new System.Drawing.Size(655, 609);
            this.ListViewPanel.TabIndex = 8;
            // 
            // Apps
            // 
            this.Apps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Apps.BackColor = System.Drawing.SystemColors.Window;
            this.Apps.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Apps.HideSelection = false;
            this.Apps.Location = new System.Drawing.Point(330, 2);
            this.Apps.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Apps.MultiSelect = false;
            this.Apps.Name = "Apps";
            this.Apps.Size = new System.Drawing.Size(322, 569);
            this.Apps.TabIndex = 3;
            this.Apps.UseCompatibleStateImageBehavior = false;
            // 
            // ButtonsPunel
            // 
            this.ButtonsPunel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonsPunel.ColumnCount = 3;
            this.ButtonsPunel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonsPunel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonsPunel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonsPunel.Controls.Add(this.AddItemButton, 0, 0);
            this.ButtonsPunel.Controls.Add(this.StartButton, 2, 0);
            this.ButtonsPunel.Controls.Add(this.EditButton, 1, 0);
            this.ButtonsPunel.Location = new System.Drawing.Point(331, 577);
            this.ButtonsPunel.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonsPunel.Name = "ButtonsPunel";
            this.ButtonsPunel.RowCount = 1;
            this.ButtonsPunel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonsPunel.Size = new System.Drawing.Size(320, 28);
            this.ButtonsPunel.TabIndex = 6;
            // 
            // AddItemButton
            // 
            this.AddItemButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddItemButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AddItemButton.Location = new System.Drawing.Point(15, 2);
            this.AddItemButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(75, 24);
            this.AddItemButton.TabIndex = 5;
            this.AddItemButton.Text = "Add";
            this.AddItemButton.UseVisualStyleBackColor = true;
            // 
            // StartButton
            // 
            this.StartButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StartButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.StartButton.Location = new System.Drawing.Point(228, 2);
            this.StartButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 24);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            // 
            // EditButton
            // 
            this.EditButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EditButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.EditButton.Location = new System.Drawing.Point(121, 2);
            this.EditButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 24);
            this.EditButton.TabIndex = 4;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            // 
            // ListFullScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ListViewPanel);
            this.Name = "ListFullScreen";
            this.Size = new System.Drawing.Size(663, 617);
            this.ListViewPanel.ResumeLayout(false);
            this.ButtonsPunel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ListViewPanel;
        private System.Windows.Forms.ListView Apps;
        private System.Windows.Forms.TableLayoutPanel ButtonsPunel;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button EditButton;
    }
}
