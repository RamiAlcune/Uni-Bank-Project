namespace BankProjectC_
{
    partial class BankProjectPannel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankProjectPannel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClientTransactions = new System.Windows.Forms.Button();
            this.ManageClients = new System.Windows.Forms.Button();
            this.DateLabel = new System.Windows.Forms.Label();
            this.TimeDate = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnClientTransactions);
            this.panel1.Controls.Add(this.ManageClients);
            this.panel1.Location = new System.Drawing.Point(220, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 506);
            this.panel1.TabIndex = 0;
            // 
            // btnClientTransactions
            // 
            this.btnClientTransactions.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClientTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientTransactions.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientTransactions.ForeColor = System.Drawing.Color.Black;
            this.btnClientTransactions.Location = new System.Drawing.Point(28, 247);
            this.btnClientTransactions.Name = "btnClientTransactions";
            this.btnClientTransactions.Size = new System.Drawing.Size(414, 86);
            this.btnClientTransactions.TabIndex = 1;
            this.btnClientTransactions.Text = "Client Transactions";
            this.btnClientTransactions.UseVisualStyleBackColor = false;
            this.btnClientTransactions.Click += new System.EventHandler(this.btnClientTransactions_Click);
            this.btnClientTransactions.MouseEnter += new System.EventHandler(this.ManageClients_MouseEnter);
            this.btnClientTransactions.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            // 
            // ManageClients
            // 
            this.ManageClients.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ManageClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManageClients.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageClients.ForeColor = System.Drawing.Color.Black;
            this.ManageClients.Location = new System.Drawing.Point(28, 97);
            this.ManageClients.Name = "ManageClients";
            this.ManageClients.Size = new System.Drawing.Size(414, 86);
            this.ManageClients.TabIndex = 0;
            this.ManageClients.Text = "Manage Clients";
            this.ManageClients.UseVisualStyleBackColor = false;
            this.ManageClients.Click += new System.EventHandler(this.ManageClients_Click);
            this.ManageClients.MouseEnter += new System.EventHandler(this.ManageClients_MouseEnter);
            this.ManageClients.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DateLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.DateLabel.Location = new System.Drawing.Point(23, 314);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(54, 19);
            this.DateLabel.TabIndex = 3;
            this.DateLabel.Text = "label1";
            this.DateLabel.Click += new System.EventHandler(this.DateLabel_Click);
            // 
            // TimeDate
            // 
            this.TimeDate.AutoSize = true;
            this.TimeDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TimeDate.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeDate.ForeColor = System.Drawing.Color.MidnightBlue;
            this.TimeDate.Location = new System.Drawing.Point(38, 336);
            this.TimeDate.Name = "TimeDate";
            this.TimeDate.Size = new System.Drawing.Size(69, 24);
            this.TimeDate.TabIndex = 5;
            this.TimeDate.Text = "label1";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::BankProjectC_.Properties.Resources.DateLogo;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(27, 203);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(171, 108);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::BankProjectC_.Properties.Resources.SubMainMenuBarPNG;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(27, 141);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(171, 40);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BankProjectC_.Properties.Resources.ManageLogoUI;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 207);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // BankProjectPannel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(706, 420);
            this.Controls.Add(this.TimeDate);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(722, 459);
            this.MinimumSize = new System.Drawing.Size(722, 459);
            this.Name = "BankProjectPannel";
            this.Text = "UniBank~Main Menu";
            this.Load += new System.EventHandler(this.BankProjectPannel_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button ManageClients;
        private System.Windows.Forms.Button btnClientTransactions;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label TimeDate;
    }
}