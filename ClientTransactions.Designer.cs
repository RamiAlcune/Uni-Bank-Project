namespace BankProjectC_
{
    partial class ClientTransactions
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientTransactions));
            this.TimeDate = new System.Windows.Forms.Label();
            this.FullTime = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.TransferLogTapPage = new System.Windows.Forms.TabPage();
            this.LogsGridView = new System.Windows.Forms.DataGridView();
            this.AccountIDGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstNameGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepositGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.WithdrawTapPage = new System.Windows.Forms.TabPage();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.lbWithdrawMoney = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbWithdrawMoney = new System.Windows.Forms.TextBox();
            this.cbAccountNumberWithdraw = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DepositTapPage = new System.Windows.Forms.TabPage();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btnDepositMoney = new System.Windows.Forms.Button();
            this.lbMoney = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDepositAmount = new System.Windows.Forms.TextBox();
            this.cbAccountNumberDeposit = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.TransferLogTapPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.WithdrawTapPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.DepositTapPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // TimeDate
            // 
            this.TimeDate.AutoSize = true;
            this.TimeDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeDate.ForeColor = System.Drawing.Color.MidnightBlue;
            this.TimeDate.Location = new System.Drawing.Point(27, 296);
            this.TimeDate.Name = "TimeDate";
            this.TimeDate.Size = new System.Drawing.Size(0, 19);
            this.TimeDate.TabIndex = 11;
            // 
            // FullTime
            // 
            this.FullTime.AutoSize = true;
            this.FullTime.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullTime.ForeColor = System.Drawing.Color.MidnightBlue;
            this.FullTime.Location = new System.Drawing.Point(4, 280);
            this.FullTime.Name = "FullTime";
            this.FullTime.Size = new System.Drawing.Size(0, 16);
            this.FullTime.TabIndex = 10;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // TransferLogTapPage
            // 
            this.TransferLogTapPage.Controls.Add(this.LogsGridView);
            this.TransferLogTapPage.Controls.Add(this.pictureBox8);
            this.TransferLogTapPage.Location = new System.Drawing.Point(4, 25);
            this.TransferLogTapPage.Name = "TransferLogTapPage";
            this.TransferLogTapPage.Size = new System.Drawing.Size(746, 486);
            this.TransferLogTapPage.TabIndex = 4;
            this.TransferLogTapPage.Text = "Transfer Log";
            this.TransferLogTapPage.UseVisualStyleBackColor = true;
            // 
            // LogsGridView
            // 
            this.LogsGridView.AllowUserToAddRows = false;
            this.LogsGridView.AllowUserToDeleteRows = false;
            this.LogsGridView.AllowUserToResizeColumns = false;
            this.LogsGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogsGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.LogsGridView.BackgroundColor = System.Drawing.Color.Snow;
            this.LogsGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.LogsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.LogsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AccountIDGridView,
            this.FirstNameGridView,
            this.AmountGridView,
            this.DepositGridView,
            this.TimeGridView});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.LogsGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.LogsGridView.Location = new System.Drawing.Point(0, 91);
            this.LogsGridView.MultiSelect = false;
            this.LogsGridView.Name = "LogsGridView";
            this.LogsGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LogsGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.LogsGridView.RowHeadersVisible = false;
            this.LogsGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogsGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.LogsGridView.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.LogsGridView.ShowCellToolTips = false;
            this.LogsGridView.ShowEditingIcon = false;
            this.LogsGridView.Size = new System.Drawing.Size(444, 395);
            this.LogsGridView.TabIndex = 44;
            this.LogsGridView.TabStop = false;
            // 
            // AccountIDGridView
            // 
            this.AccountIDGridView.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AccountIDGridView.HeaderText = "Account.ID";
            this.AccountIDGridView.Name = "AccountIDGridView";
            this.AccountIDGridView.ReadOnly = true;
            // 
            // FirstNameGridView
            // 
            this.FirstNameGridView.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FirstNameGridView.HeaderText = "First-Name";
            this.FirstNameGridView.Name = "FirstNameGridView";
            this.FirstNameGridView.ReadOnly = true;
            // 
            // AmountGridView
            // 
            this.AmountGridView.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AmountGridView.HeaderText = "Amount";
            this.AmountGridView.Name = "AmountGridView";
            this.AmountGridView.ReadOnly = true;
            this.AmountGridView.Width = 81;
            // 
            // DepositGridView
            // 
            this.DepositGridView.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DepositGridView.HeaderText = "Deposit";
            this.DepositGridView.Name = "DepositGridView";
            this.DepositGridView.ReadOnly = true;
            this.DepositGridView.Width = 79;
            // 
            // TimeGridView
            // 
            this.TimeGridView.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TimeGridView.HeaderText = "Time";
            this.TimeGridView.Name = "TimeGridView";
            this.TimeGridView.ReadOnly = true;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImage = global::BankProjectC_.Properties.Resources.Uni_Bank_Image;
            this.pictureBox8.Location = new System.Drawing.Point(-4, 0);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(448, 93);
            this.pictureBox8.TabIndex = 43;
            this.pictureBox8.TabStop = false;
            // 
            // WithdrawTapPage
            // 
            this.WithdrawTapPage.BackColor = System.Drawing.Color.Snow;
            this.WithdrawTapPage.Controls.Add(this.pictureBox7);
            this.WithdrawTapPage.Controls.Add(this.btnWithdraw);
            this.WithdrawTapPage.Controls.Add(this.lbWithdrawMoney);
            this.WithdrawTapPage.Controls.Add(this.label3);
            this.WithdrawTapPage.Controls.Add(this.label5);
            this.WithdrawTapPage.Controls.Add(this.tbWithdrawMoney);
            this.WithdrawTapPage.Controls.Add(this.cbAccountNumberWithdraw);
            this.WithdrawTapPage.Controls.Add(this.label6);
            this.WithdrawTapPage.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WithdrawTapPage.ForeColor = System.Drawing.Color.DarkMagenta;
            this.WithdrawTapPage.Location = new System.Drawing.Point(4, 25);
            this.WithdrawTapPage.Name = "WithdrawTapPage";
            this.WithdrawTapPage.Size = new System.Drawing.Size(746, 486);
            this.WithdrawTapPage.TabIndex = 1;
            this.WithdrawTapPage.Text = "Withdraw";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = global::BankProjectC_.Properties.Resources.Uni_Bank_Image;
            this.pictureBox7.Location = new System.Drawing.Point(-4, 0);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(448, 93);
            this.pictureBox7.TabIndex = 49;
            this.pictureBox7.TabStop = false;
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.BackColor = System.Drawing.Color.Gainsboro;
            this.btnWithdraw.FlatAppearance.BorderSize = 0;
            this.btnWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWithdraw.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw.ForeColor = System.Drawing.Color.Black;
            this.btnWithdraw.Location = new System.Drawing.Point(113, 384);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(200, 40);
            this.btnWithdraw.TabIndex = 48;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = false;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // lbWithdrawMoney
            // 
            this.lbWithdrawMoney.AutoSize = true;
            this.lbWithdrawMoney.BackColor = System.Drawing.Color.Transparent;
            this.lbWithdrawMoney.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWithdrawMoney.ForeColor = System.Drawing.Color.Lime;
            this.lbWithdrawMoney.Location = new System.Drawing.Point(144, 219);
            this.lbWithdrawMoney.Name = "lbWithdrawMoney";
            this.lbWithdrawMoney.Size = new System.Drawing.Size(82, 32);
            this.lbWithdrawMoney.TabIndex = 47;
            this.lbWithdrawMoney.Text = "????";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(141, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 16);
            this.label3.TabIndex = 46;
            this.label3.Text = "Currently Balance:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(132, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 16);
            this.label5.TabIndex = 45;
            this.label5.Text = "Deposit Amount";
            // 
            // tbWithdrawMoney
            // 
            this.tbWithdrawMoney.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbWithdrawMoney.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWithdrawMoney.Location = new System.Drawing.Point(135, 306);
            this.tbWithdrawMoney.Name = "tbWithdrawMoney";
            this.tbWithdrawMoney.Size = new System.Drawing.Size(178, 22);
            this.tbWithdrawMoney.TabIndex = 44;
            // 
            // cbAccountNumberWithdraw
            // 
            this.cbAccountNumberWithdraw.BackColor = System.Drawing.Color.White;
            this.cbAccountNumberWithdraw.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAccountNumberWithdraw.FormattingEnabled = true;
            this.cbAccountNumberWithdraw.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbAccountNumberWithdraw.Location = new System.Drawing.Point(135, 143);
            this.cbAccountNumberWithdraw.Name = "cbAccountNumberWithdraw";
            this.cbAccountNumberWithdraw.Size = new System.Drawing.Size(145, 24);
            this.cbAccountNumberWithdraw.Sorted = true;
            this.cbAccountNumberWithdraw.TabIndex = 43;
            this.cbAccountNumberWithdraw.SelectedValueChanged += new System.EventHandler(this.cbAccountNumberWithdraw_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(132, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 16);
            this.label6.TabIndex = 42;
            this.label6.Text = "Account Number:";
            // 
            // DepositTapPage
            // 
            this.DepositTapPage.BackColor = System.Drawing.Color.Snow;
            this.DepositTapPage.Controls.Add(this.pictureBox6);
            this.DepositTapPage.Controls.Add(this.btnDepositMoney);
            this.DepositTapPage.Controls.Add(this.lbMoney);
            this.DepositTapPage.Controls.Add(this.label4);
            this.DepositTapPage.Controls.Add(this.label2);
            this.DepositTapPage.Controls.Add(this.tbDepositAmount);
            this.DepositTapPage.Controls.Add(this.cbAccountNumberDeposit);
            this.DepositTapPage.Controls.Add(this.label8);
            this.DepositTapPage.ForeColor = System.Drawing.Color.Black;
            this.DepositTapPage.Location = new System.Drawing.Point(4, 25);
            this.DepositTapPage.Name = "DepositTapPage";
            this.DepositTapPage.Padding = new System.Windows.Forms.Padding(3);
            this.DepositTapPage.Size = new System.Drawing.Size(746, 486);
            this.DepositTapPage.TabIndex = 0;
            this.DepositTapPage.Text = "Deposit";
            this.DepositTapPage.Click += new System.EventHandler(this.DepositTapPage_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::BankProjectC_.Properties.Resources.Uni_Bank_Image;
            this.pictureBox6.Location = new System.Drawing.Point(-4, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(448, 93);
            this.pictureBox6.TabIndex = 42;
            this.pictureBox6.TabStop = false;
            // 
            // btnDepositMoney
            // 
            this.btnDepositMoney.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDepositMoney.FlatAppearance.BorderSize = 0;
            this.btnDepositMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepositMoney.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepositMoney.ForeColor = System.Drawing.Color.Black;
            this.btnDepositMoney.Location = new System.Drawing.Point(113, 384);
            this.btnDepositMoney.Name = "btnDepositMoney";
            this.btnDepositMoney.Size = new System.Drawing.Size(200, 40);
            this.btnDepositMoney.TabIndex = 41;
            this.btnDepositMoney.Text = "Deposit The Money";
            this.btnDepositMoney.UseVisualStyleBackColor = false;
            this.btnDepositMoney.Click += new System.EventHandler(this.btnDepositMoney_Click);
            // 
            // lbMoney
            // 
            this.lbMoney.AutoSize = true;
            this.lbMoney.BackColor = System.Drawing.Color.Transparent;
            this.lbMoney.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMoney.ForeColor = System.Drawing.Color.Lime;
            this.lbMoney.Location = new System.Drawing.Point(144, 219);
            this.lbMoney.Name = "lbMoney";
            this.lbMoney.Size = new System.Drawing.Size(82, 32);
            this.lbMoney.TabIndex = 40;
            this.lbMoney.Text = "????";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(141, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 16);
            this.label4.TabIndex = 39;
            this.label4.Text = "Currently Balance:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(132, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "Deposit Amount";
            // 
            // tbDepositAmount
            // 
            this.tbDepositAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDepositAmount.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDepositAmount.Location = new System.Drawing.Point(135, 306);
            this.tbDepositAmount.Name = "tbDepositAmount";
            this.tbDepositAmount.Size = new System.Drawing.Size(178, 22);
            this.tbDepositAmount.TabIndex = 35;
            // 
            // cbAccountNumberDeposit
            // 
            this.cbAccountNumberDeposit.BackColor = System.Drawing.Color.White;
            this.cbAccountNumberDeposit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAccountNumberDeposit.FormattingEnabled = true;
            this.cbAccountNumberDeposit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbAccountNumberDeposit.Location = new System.Drawing.Point(135, 143);
            this.cbAccountNumberDeposit.Name = "cbAccountNumberDeposit";
            this.cbAccountNumberDeposit.Size = new System.Drawing.Size(145, 24);
            this.cbAccountNumberDeposit.Sorted = true;
            this.cbAccountNumberDeposit.TabIndex = 34;
            this.cbAccountNumberDeposit.SelectedValueChanged += new System.EventHandler(this.cbAccountNumberDeposit_SelectedValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(132, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 16);
            this.label8.TabIndex = 33;
            this.label8.Text = "Account Number:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.DepositTapPage);
            this.tabControl1.Controls.Add(this.WithdrawTapPage);
            this.tabControl1.Controls.Add(this.TransferLogTapPage);
            this.tabControl1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(142, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(754, 515);
            this.tabControl1.TabIndex = 7;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::BankProjectC_.Properties.Resources.TransecationsLogo;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.Location = new System.Drawing.Point(-2, 104);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(144, 59);
            this.pictureBox5.TabIndex = 14;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::BankProjectC_.Properties.Resources.LoginUILogo;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(-6, 383);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(148, 129);
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::BankProjectC_.Properties.Resources.DateLogo;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(-2, 169);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(138, 92);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BankProjectC_.Properties.Resources.ManageLogoUI;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 107);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::BankProjectC_.Properties.Resources.ManageClientsUI;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(7, 77);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(129, 31);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // ClientTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(590, 516);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TimeDate);
            this.Controls.Add(this.FullTime);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(606, 555);
            this.MinimumSize = new System.Drawing.Size(606, 555);
            this.Name = "ClientTransactions";
            this.Text = "Uni-Bank Transactions~Menu";
            this.Load += new System.EventHandler(this.ClientTransactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.TransferLogTapPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.WithdrawTapPage.ResumeLayout(false);
            this.WithdrawTapPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.DepositTapPage.ResumeLayout(false);
            this.DepositTapPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label TimeDate;
        private System.Windows.Forms.Label FullTime;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage DepositTapPage;
        private System.Windows.Forms.Button btnDepositMoney;
        private System.Windows.Forms.Label lbMoney;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDepositAmount;
        private System.Windows.Forms.ComboBox cbAccountNumberDeposit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage WithdrawTapPage;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Label lbWithdrawMoney;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbWithdrawMoney;
        private System.Windows.Forms.ComboBox cbAccountNumberWithdraw;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage TransferLogTapPage;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.DataGridView LogsGridView;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountIDGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstNameGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepositGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeGridView;
    }
}