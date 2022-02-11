
namespace test_app
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.test_dbDataSet = new test_app.test_dbDataSet();
            this.customerTableAdapter = new test_app.test_dbDataSetTableAdapters.CustomerTableAdapter();
            this.fKAccountCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountTableAdapter = new test_app.test_dbDataSetTableAdapters.AccountTableAdapter();
            this.pnCustomers = new System.Windows.Forms.Panel();
            this.pnCustomersGrid = new System.Windows.Forms.Panel();
            this.grdCustomer = new System.Windows.Forms.DataGridView();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerINN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnCustomersHead = new System.Windows.Forms.Panel();
            this.btnCustomerDelete = new System.Windows.Forms.Button();
            this.btnCustomerEdit = new System.Windows.Forms.Button();
            this.btnCustomerAdd = new System.Windows.Forms.Button();
            this.lblCustomers = new System.Windows.Forms.Label();
            this.pnAccounts = new System.Windows.Forms.Panel();
            this.pnAccountsGrid = new System.Windows.Forms.Panel();
            this.grdAccount = new System.Windows.Forms.DataGridView();
            this.AccountID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountCustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountBIK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnAccountsHead = new System.Windows.Forms.Panel();
            this.btnAccountDelete = new System.Windows.Forms.Button();
            this.btnAccountEdit = new System.Windows.Forms.Button();
            this.btnAccountAdd = new System.Windows.Forms.Button();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblAccounts = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.test_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKAccountCustomerBindingSource)).BeginInit();
            this.pnCustomers.SuspendLayout();
            this.pnCustomersGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomer)).BeginInit();
            this.pnCustomersHead.SuspendLayout();
            this.pnAccounts.SuspendLayout();
            this.pnAccountsGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAccount)).BeginInit();
            this.pnAccountsHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.test_dbDataSet;
            // 
            // test_dbDataSet
            // 
            this.test_dbDataSet.DataSetName = "test_dbDataSet";
            this.test_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // fKAccountCustomerBindingSource
            // 
            this.fKAccountCustomerBindingSource.DataMember = "FK_Account_Customer";
            this.fKAccountCustomerBindingSource.DataSource = this.customerBindingSource;
            // 
            // accountTableAdapter
            // 
            this.accountTableAdapter.ClearBeforeFill = true;
            // 
            // pnCustomers
            // 
            this.pnCustomers.Controls.Add(this.pnCustomersGrid);
            this.pnCustomers.Controls.Add(this.pnCustomersHead);
            this.pnCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnCustomers.Location = new System.Drawing.Point(0, 0);
            this.pnCustomers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnCustomers.Name = "pnCustomers";
            this.pnCustomers.Size = new System.Drawing.Size(784, 238);
            this.pnCustomers.TabIndex = 2;
            // 
            // pnCustomersGrid
            // 
            this.pnCustomersGrid.Controls.Add(this.grdCustomer);
            this.pnCustomersGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCustomersGrid.Location = new System.Drawing.Point(0, 40);
            this.pnCustomersGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnCustomersGrid.Name = "pnCustomersGrid";
            this.pnCustomersGrid.Size = new System.Drawing.Size(784, 198);
            this.pnCustomersGrid.TabIndex = 3;
            // 
            // grdCustomer
            // 
            this.grdCustomer.AllowUserToAddRows = false;
            this.grdCustomer.AllowUserToDeleteRows = false;
            this.grdCustomer.AutoGenerateColumns = false;
            this.grdCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.CustomerName,
            this.CustomerINN,
            this.CustomerAddress});
            this.grdCustomer.DataSource = this.customerBindingSource;
            this.grdCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCustomer.Location = new System.Drawing.Point(0, 0);
            this.grdCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grdCustomer.Name = "grdCustomer";
            this.grdCustomer.ReadOnly = true;
            this.grdCustomer.RowHeadersVisible = false;
            this.grdCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCustomer.Size = new System.Drawing.Size(784, 198);
            this.grdCustomer.TabIndex = 2;
            this.grdCustomer.CurrentCellChanged += new System.EventHandler(this.grdCustomer_CurrentCellChanged);
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "ID";
            this.CustomerID.HeaderText = "ID";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            this.CustomerID.Visible = false;
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "Name";
            this.CustomerName.HeaderText = "Название";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            this.CustomerName.Width = 250;
            // 
            // CustomerINN
            // 
            this.CustomerINN.DataPropertyName = "INN";
            this.CustomerINN.HeaderText = "ИНН";
            this.CustomerINN.Name = "CustomerINN";
            this.CustomerINN.ReadOnly = true;
            // 
            // CustomerAddress
            // 
            this.CustomerAddress.DataPropertyName = "Address";
            this.CustomerAddress.HeaderText = "Адрес";
            this.CustomerAddress.Name = "CustomerAddress";
            this.CustomerAddress.ReadOnly = true;
            this.CustomerAddress.Width = 400;
            // 
            // pnCustomersHead
            // 
            this.pnCustomersHead.Controls.Add(this.btnCustomerDelete);
            this.pnCustomersHead.Controls.Add(this.btnCustomerEdit);
            this.pnCustomersHead.Controls.Add(this.btnCustomerAdd);
            this.pnCustomersHead.Controls.Add(this.lblCustomers);
            this.pnCustomersHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnCustomersHead.Location = new System.Drawing.Point(0, 0);
            this.pnCustomersHead.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnCustomersHead.Name = "pnCustomersHead";
            this.pnCustomersHead.Size = new System.Drawing.Size(784, 40);
            this.pnCustomersHead.TabIndex = 2;
            // 
            // btnCustomerDelete
            // 
            this.btnCustomerDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCustomerDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomerDelete.Image")));
            this.btnCustomerDelete.Location = new System.Drawing.Point(728, 6);
            this.btnCustomerDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCustomerDelete.Name = "btnCustomerDelete";
            this.btnCustomerDelete.Size = new System.Drawing.Size(50, 28);
            this.btnCustomerDelete.TabIndex = 3;
            this.btnCustomerDelete.UseVisualStyleBackColor = true;
            this.btnCustomerDelete.Click += new System.EventHandler(this.btnCustomerDelete_Click);
            // 
            // btnCustomerEdit
            // 
            this.btnCustomerEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCustomerEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomerEdit.Image")));
            this.btnCustomerEdit.Location = new System.Drawing.Point(672, 6);
            this.btnCustomerEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCustomerEdit.Name = "btnCustomerEdit";
            this.btnCustomerEdit.Size = new System.Drawing.Size(50, 28);
            this.btnCustomerEdit.TabIndex = 2;
            this.btnCustomerEdit.UseVisualStyleBackColor = true;
            this.btnCustomerEdit.Click += new System.EventHandler(this.btnCustomerEdit_Click);
            // 
            // btnCustomerAdd
            // 
            this.btnCustomerAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCustomerAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomerAdd.Image")));
            this.btnCustomerAdd.Location = new System.Drawing.Point(616, 6);
            this.btnCustomerAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCustomerAdd.Name = "btnCustomerAdd";
            this.btnCustomerAdd.Size = new System.Drawing.Size(50, 28);
            this.btnCustomerAdd.TabIndex = 1;
            this.btnCustomerAdd.UseVisualStyleBackColor = true;
            this.btnCustomerAdd.Click += new System.EventHandler(this.btnCustomerAdd_Click);
            // 
            // lblCustomers
            // 
            this.lblCustomers.AutoSize = true;
            this.lblCustomers.Location = new System.Drawing.Point(14, 12);
            this.lblCustomers.Name = "lblCustomers";
            this.lblCustomers.Size = new System.Drawing.Size(100, 16);
            this.lblCustomers.TabIndex = 0;
            this.lblCustomers.Text = "ОРГАНИЗАЦИИ:";
            // 
            // pnAccounts
            // 
            this.pnAccounts.Controls.Add(this.pnAccountsGrid);
            this.pnAccounts.Controls.Add(this.pnAccountsHead);
            this.pnAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnAccounts.Location = new System.Drawing.Point(0, 238);
            this.pnAccounts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnAccounts.Name = "pnAccounts";
            this.pnAccounts.Size = new System.Drawing.Size(784, 323);
            this.pnAccounts.TabIndex = 3;
            // 
            // pnAccountsGrid
            // 
            this.pnAccountsGrid.Controls.Add(this.grdAccount);
            this.pnAccountsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnAccountsGrid.Location = new System.Drawing.Point(0, 40);
            this.pnAccountsGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnAccountsGrid.Name = "pnAccountsGrid";
            this.pnAccountsGrid.Size = new System.Drawing.Size(784, 283);
            this.pnAccountsGrid.TabIndex = 4;
            // 
            // grdAccount
            // 
            this.grdAccount.AllowUserToAddRows = false;
            this.grdAccount.AllowUserToDeleteRows = false;
            this.grdAccount.AutoGenerateColumns = false;
            this.grdAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AccountID,
            this.AccountCustomerID,
            this.AccountName,
            this.AccountAccount,
            this.AccountBIK,
            this.AccountBalance});
            this.grdAccount.DataSource = this.fKAccountCustomerBindingSource;
            this.grdAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdAccount.Location = new System.Drawing.Point(0, 0);
            this.grdAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grdAccount.Name = "grdAccount";
            this.grdAccount.ReadOnly = true;
            this.grdAccount.RowHeadersVisible = false;
            this.grdAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdAccount.Size = new System.Drawing.Size(784, 283);
            this.grdAccount.TabIndex = 3;
            // 
            // AccountID
            // 
            this.AccountID.DataPropertyName = "ID";
            this.AccountID.HeaderText = "ID";
            this.AccountID.Name = "AccountID";
            this.AccountID.ReadOnly = true;
            this.AccountID.Visible = false;
            // 
            // AccountCustomerID
            // 
            this.AccountCustomerID.DataPropertyName = "CustomerID";
            this.AccountCustomerID.HeaderText = "CustomerID";
            this.AccountCustomerID.Name = "AccountCustomerID";
            this.AccountCustomerID.ReadOnly = true;
            this.AccountCustomerID.Visible = false;
            // 
            // AccountName
            // 
            this.AccountName.DataPropertyName = "Name";
            this.AccountName.HeaderText = "Название";
            this.AccountName.Name = "AccountName";
            this.AccountName.ReadOnly = true;
            this.AccountName.Width = 250;
            // 
            // AccountAccount
            // 
            this.AccountAccount.DataPropertyName = "Account";
            this.AccountAccount.HeaderText = "Счет";
            this.AccountAccount.Name = "AccountAccount";
            this.AccountAccount.ReadOnly = true;
            this.AccountAccount.Width = 150;
            // 
            // AccountBIK
            // 
            this.AccountBIK.DataPropertyName = "BIK";
            this.AccountBIK.HeaderText = "БИК";
            this.AccountBIK.Name = "AccountBIK";
            this.AccountBIK.ReadOnly = true;
            // 
            // AccountBalance
            // 
            this.AccountBalance.DataPropertyName = "Balance";
            this.AccountBalance.HeaderText = "Остаток";
            this.AccountBalance.Name = "AccountBalance";
            this.AccountBalance.ReadOnly = true;
            // 
            // pnAccountsHead
            // 
            this.pnAccountsHead.Controls.Add(this.btnAccountDelete);
            this.pnAccountsHead.Controls.Add(this.btnAccountEdit);
            this.pnAccountsHead.Controls.Add(this.btnAccountAdd);
            this.pnAccountsHead.Controls.Add(this.lblCustomerName);
            this.pnAccountsHead.Controls.Add(this.lblAccounts);
            this.pnAccountsHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnAccountsHead.Location = new System.Drawing.Point(0, 0);
            this.pnAccountsHead.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnAccountsHead.Name = "pnAccountsHead";
            this.pnAccountsHead.Size = new System.Drawing.Size(784, 40);
            this.pnAccountsHead.TabIndex = 3;
            // 
            // btnAccountDelete
            // 
            this.btnAccountDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccountDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnAccountDelete.Image")));
            this.btnAccountDelete.Location = new System.Drawing.Point(728, 6);
            this.btnAccountDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAccountDelete.Name = "btnAccountDelete";
            this.btnAccountDelete.Size = new System.Drawing.Size(50, 28);
            this.btnAccountDelete.TabIndex = 11;
            this.btnAccountDelete.UseVisualStyleBackColor = true;
            this.btnAccountDelete.Click += new System.EventHandler(this.btnAccountDelete_Click);
            // 
            // btnAccountEdit
            // 
            this.btnAccountEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccountEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnAccountEdit.Image")));
            this.btnAccountEdit.Location = new System.Drawing.Point(672, 6);
            this.btnAccountEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAccountEdit.Name = "btnAccountEdit";
            this.btnAccountEdit.Size = new System.Drawing.Size(50, 28);
            this.btnAccountEdit.TabIndex = 10;
            this.btnAccountEdit.UseVisualStyleBackColor = true;
            this.btnAccountEdit.Click += new System.EventHandler(this.btnAccountEdit_Click);
            // 
            // btnAccountAdd
            // 
            this.btnAccountAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccountAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAccountAdd.Image")));
            this.btnAccountAdd.Location = new System.Drawing.Point(616, 6);
            this.btnAccountAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAccountAdd.Name = "btnAccountAdd";
            this.btnAccountAdd.Size = new System.Drawing.Size(50, 28);
            this.btnAccountAdd.TabIndex = 9;
            this.btnAccountAdd.UseVisualStyleBackColor = true;
            this.btnAccountAdd.Click += new System.EventHandler(this.btnAccountAdd_Click);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCustomerName.Location = new System.Drawing.Point(67, 12);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(117, 16);
            this.lblCustomerName.TabIndex = 8;
            this.lblCustomerName.Text = "[CustomerName]";
            // 
            // lblAccounts
            // 
            this.lblAccounts.AutoSize = true;
            this.lblAccounts.Location = new System.Drawing.Point(14, 12);
            this.lblAccounts.Name = "lblAccounts";
            this.lblAccounts.Size = new System.Drawing.Size(47, 16);
            this.lblAccounts.TabIndex = 7;
            this.lblAccounts.Text = "СЧЕТА";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pnAccounts);
            this.Controls.Add(this.pnCustomers);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "..:: ТЕСТОВАЯ ПРОГРАММА ::..";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.test_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKAccountCustomerBindingSource)).EndInit();
            this.pnCustomers.ResumeLayout(false);
            this.pnCustomersGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomer)).EndInit();
            this.pnCustomersHead.ResumeLayout(false);
            this.pnCustomersHead.PerformLayout();
            this.pnAccounts.ResumeLayout(false);
            this.pnAccountsGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdAccount)).EndInit();
            this.pnAccountsHead.ResumeLayout(false);
            this.pnAccountsHead.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public test_dbDataSet test_dbDataSet;
        public System.Windows.Forms.BindingSource customerBindingSource;
        public test_dbDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        public test_dbDataSetTableAdapters.AccountTableAdapter accountTableAdapter;
        public System.Windows.Forms.BindingSource fKAccountCustomerBindingSource;
        private System.Windows.Forms.Panel pnCustomers;
        private System.Windows.Forms.Panel pnAccounts;
        private System.Windows.Forms.Panel pnCustomersGrid;
        public System.Windows.Forms.DataGridView grdCustomer;
        private System.Windows.Forms.Panel pnCustomersHead;
        private System.Windows.Forms.Panel pnAccountsGrid;
        public System.Windows.Forms.DataGridView grdAccount;
        private System.Windows.Forms.Panel pnAccountsHead;
        private System.Windows.Forms.Button btnCustomerDelete;
        private System.Windows.Forms.Button btnCustomerEdit;
        private System.Windows.Forms.Button btnCustomerAdd;
        private System.Windows.Forms.Label lblCustomers;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblAccounts;
        private System.Windows.Forms.Button btnAccountDelete;
        private System.Windows.Forms.Button btnAccountEdit;
        private System.Windows.Forms.Button btnAccountAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountCustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountBIK;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerINN;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerAddress;
    }
}

