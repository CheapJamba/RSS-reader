namespace RSS_Reader
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.SourcesLabel = new System.Windows.Forms.Label();
            this.SourcesListBox = new System.Windows.Forms.ListBox();
            this.NewSourceTextBox = new System.Windows.Forms.TextBox();
            this.NewSourceButton = new System.Windows.Forms.Button();
            this.RefreshDelayLabel = new System.Windows.Forms.Label();
            this.RefreshDelayTextBox = new System.Windows.Forms.TextBox();
            this.SaveChangesButton = new System.Windows.Forms.Button();
            this.CancelButton1 = new System.Windows.Forms.Button();
            this.DeleteSourceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SourcesLabel
            // 
            this.SourcesLabel.AutoSize = true;
            this.SourcesLabel.Location = new System.Drawing.Point(52, 66);
            this.SourcesLabel.Name = "SourcesLabel";
            this.SourcesLabel.Size = new System.Drawing.Size(60, 17);
            this.SourcesLabel.TabIndex = 0;
            this.SourcesLabel.Text = "Sources";
            // 
            // SourcesListBox
            // 
            this.SourcesListBox.FormattingEnabled = true;
            this.SourcesListBox.ItemHeight = 16;
            this.SourcesListBox.Location = new System.Drawing.Point(55, 98);
            this.SourcesListBox.Name = "SourcesListBox";
            this.SourcesListBox.Size = new System.Drawing.Size(638, 180);
            this.SourcesListBox.TabIndex = 1;
            // 
            // NewSourceTextBox
            // 
            this.NewSourceTextBox.Location = new System.Drawing.Point(55, 300);
            this.NewSourceTextBox.Name = "NewSourceTextBox";
            this.NewSourceTextBox.Size = new System.Drawing.Size(424, 22);
            this.NewSourceTextBox.TabIndex = 2;
            // 
            // NewSourceButton
            // 
            this.NewSourceButton.Location = new System.Drawing.Point(485, 295);
            this.NewSourceButton.Name = "NewSourceButton";
            this.NewSourceButton.Size = new System.Drawing.Size(101, 33);
            this.NewSourceButton.TabIndex = 3;
            this.NewSourceButton.Text = "Add";
            this.NewSourceButton.UseVisualStyleBackColor = true;
            this.NewSourceButton.Click += new System.EventHandler(this.NewSourceButton_Click);
            // 
            // RefreshDelayLabel
            // 
            this.RefreshDelayLabel.AutoSize = true;
            this.RefreshDelayLabel.Location = new System.Drawing.Point(52, 348);
            this.RefreshDelayLabel.Name = "RefreshDelayLabel";
            this.RefreshDelayLabel.Size = new System.Drawing.Size(163, 17);
            this.RefreshDelayLabel.TabIndex = 4;
            this.RefreshDelayLabel.Text = "Refresh delay (seconds)";
            // 
            // RefreshDelayTextBox
            // 
            this.RefreshDelayTextBox.Location = new System.Drawing.Point(221, 345);
            this.RefreshDelayTextBox.Name = "RefreshDelayTextBox";
            this.RefreshDelayTextBox.Size = new System.Drawing.Size(81, 22);
            this.RefreshDelayTextBox.TabIndex = 5;
            this.RefreshDelayTextBox.Leave += new System.EventHandler(this.RefreshDelayTextBox_Leave);
            // 
            // SaveChangesButton
            // 
            this.SaveChangesButton.Location = new System.Drawing.Point(592, 396);
            this.SaveChangesButton.Name = "SaveChangesButton";
            this.SaveChangesButton.Size = new System.Drawing.Size(137, 32);
            this.SaveChangesButton.TabIndex = 6;
            this.SaveChangesButton.Text = "Save Changes";
            this.SaveChangesButton.UseVisualStyleBackColor = true;
            this.SaveChangesButton.Click += new System.EventHandler(this.SaveChangesButton_Click);
            // 
            // CancelButton1
            // 
            this.CancelButton1.Location = new System.Drawing.Point(449, 396);
            this.CancelButton1.Name = "CancelButton1";
            this.CancelButton1.Size = new System.Drawing.Size(137, 32);
            this.CancelButton1.TabIndex = 7;
            this.CancelButton1.Text = "Cancel";
            this.CancelButton1.UseVisualStyleBackColor = true;
            this.CancelButton1.Click += new System.EventHandler(this.CancelButton1_Click);
            // 
            // DeleteSourceButton
            // 
            this.DeleteSourceButton.Location = new System.Drawing.Point(592, 295);
            this.DeleteSourceButton.Name = "DeleteSourceButton";
            this.DeleteSourceButton.Size = new System.Drawing.Size(101, 33);
            this.DeleteSourceButton.TabIndex = 8;
            this.DeleteSourceButton.Text = "Delete";
            this.DeleteSourceButton.UseVisualStyleBackColor = true;
            this.DeleteSourceButton.Click += new System.EventHandler(this.DeleteSourceButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 440);
            this.Controls.Add(this.DeleteSourceButton);
            this.Controls.Add(this.CancelButton1);
            this.Controls.Add(this.SaveChangesButton);
            this.Controls.Add(this.RefreshDelayTextBox);
            this.Controls.Add(this.RefreshDelayLabel);
            this.Controls.Add(this.NewSourceButton);
            this.Controls.Add(this.NewSourceTextBox);
            this.Controls.Add(this.SourcesListBox);
            this.Controls.Add(this.SourcesLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SourcesLabel;
        private System.Windows.Forms.ListBox SourcesListBox;
        private System.Windows.Forms.TextBox NewSourceTextBox;
        private System.Windows.Forms.Button NewSourceButton;
        private System.Windows.Forms.Label RefreshDelayLabel;
        private System.Windows.Forms.TextBox RefreshDelayTextBox;
        private System.Windows.Forms.Button SaveChangesButton;
        private System.Windows.Forms.Button CancelButton1;
        private System.Windows.Forms.Button DeleteSourceButton;
    }
}