namespace RSS_Reader
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lvNews = new System.Windows.Forms.ListView();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.linkTitle = new System.Windows.Forms.LinkLabel();
            this.dateBox = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SettingsButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvNews
            // 
            this.lvNews.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lvNews.Location = new System.Drawing.Point(12, 12);
            this.lvNews.Name = "lvNews";
            this.lvNews.Size = new System.Drawing.Size(533, 402);
            this.lvNews.TabIndex = 3;
            this.lvNews.TileSize = new System.Drawing.Size(420, 36);
            this.lvNews.UseCompatibleStateImageBehavior = false;
            this.lvNews.View = System.Windows.Forms.View.Tile;
            this.lvNews.SelectedIndexChanged += new System.EventHandler(this.lvNews_SelectedIndexChanged);
            // 
            // descriptionBox
            // 
            this.descriptionBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionBox.Location = new System.Drawing.Point(555, 63);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.ReadOnly = true;
            this.descriptionBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionBox.Size = new System.Drawing.Size(588, 351);
            this.descriptionBox.TabIndex = 4;
            // 
            // linkTitle
            // 
            this.linkTitle.AutoSize = true;
            this.linkTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkTitle.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkTitle.Location = new System.Drawing.Point(551, 12);
            this.linkTitle.MaximumSize = new System.Drawing.Size(490, 48);
            this.linkTitle.MinimumSize = new System.Drawing.Size(490, 48);
            this.linkTitle.Name = "linkTitle";
            this.linkTitle.Size = new System.Drawing.Size(490, 48);
            this.linkTitle.TabIndex = 2;
            this.linkTitle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkTitle_LinkClicked);
            // 
            // dateBox
            // 
            this.dateBox.AutoSize = true;
            this.dateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateBox.Location = new System.Drawing.Point(1043, 21);
            this.dateBox.MaximumSize = new System.Drawing.Size(100, 24);
            this.dateBox.MinimumSize = new System.Drawing.Size(100, 24);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(100, 24);
            this.dateBox.TabIndex = 5;
            this.dateBox.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SettingsButton.Image = ((System.Drawing.Image)(resources.GetObject("SettingsButton.Image")));
            this.SettingsButton.Location = new System.Drawing.Point(1062, 420);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(80, 80);
            this.SettingsButton.TabIndex = 6;
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(12, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 80);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 512);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.lvNews);
            this.Controls.Add(this.linkTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "RSS reader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lvNews;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox descriptionBox;
        public System.Windows.Forms.LinkLabel linkTitle;
        public System.Windows.Forms.Label dateBox;
    }
}

