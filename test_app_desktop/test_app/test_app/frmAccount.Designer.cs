
namespace test_app
{
    partial class frmAccount
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
            this.lblActionName = new System.Windows.Forms.Label();
            this.lblAccount = new System.Windows.Forms.Label();
            this.lblBIK = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tbAccount = new System.Windows.Forms.TextBox();
            this.tbBIK = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbBalance = new System.Windows.Forms.Label();
            this.tbBalance = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblActionName
            // 
            this.lblActionName.AutoSize = true;
            this.lblActionName.Location = new System.Drawing.Point(13, 33);
            this.lblActionName.Name = "lblActionName";
            this.lblActionName.Size = new System.Drawing.Size(137, 16);
            this.lblActionName.TabIndex = 17;
            this.lblActionName.Text = "НАЗВАНИЕ ОПЕРАЦИИ";
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(26, 96);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(41, 16);
            this.lblAccount.TabIndex = 16;
            this.lblAccount.Text = "Счет:";
            // 
            // lblBIK
            // 
            this.lblBIK.AutoSize = true;
            this.lblBIK.Location = new System.Drawing.Point(26, 127);
            this.lblBIK.Name = "lblBIK";
            this.lblBIK.Size = new System.Drawing.Size(36, 16);
            this.lblBIK.TabIndex = 15;
            this.lblBIK.Text = "БИК:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(26, 65);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(69, 16);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "Название:";
            // 
            // tbAccount
            // 
            this.tbAccount.Location = new System.Drawing.Point(111, 93);
            this.tbAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbAccount.MaxLength = 20;
            this.tbAccount.Name = "tbAccount";
            this.tbAccount.Size = new System.Drawing.Size(262, 23);
            this.tbAccount.TabIndex = 1;
            this.tbAccount.WordWrap = false;
            this.tbAccount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAccount_KeyPress);
            // 
            // tbBIK
            // 
            this.tbBIK.Location = new System.Drawing.Point(111, 124);
            this.tbBIK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbBIK.MaxLength = 9;
            this.tbBIK.Name = "tbBIK";
            this.tbBIK.Size = new System.Drawing.Size(116, 23);
            this.tbBIK.TabIndex = 2;
            this.tbBIK.WordWrap = false;
            this.tbBIK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAccount_KeyPress);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(111, 62);
            this.tbName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbName.MaxLength = 100;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(262, 23);
            this.tbName.TabIndex = 0;
            this.tbName.WordWrap = false;
            this.tbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(273, 198);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "ОТМЕНА";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(167, 198);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "СОХРАНИТЬ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbBalance
            // 
            this.lbBalance.AutoSize = true;
            this.lbBalance.Location = new System.Drawing.Point(26, 158);
            this.lbBalance.Name = "lbBalance";
            this.lbBalance.Size = new System.Drawing.Size(60, 16);
            this.lbBalance.TabIndex = 19;
            this.lbBalance.Text = "Остаток:";
            // 
            // tbBalance
            // 
            this.tbBalance.Location = new System.Drawing.Point(111, 155);
            this.tbBalance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbBalance.MaxLength = 15;
            this.tbBalance.Name = "tbBalance";
            this.tbBalance.Size = new System.Drawing.Size(116, 23);
            this.tbBalance.TabIndex = 3;
            this.tbBalance.WordWrap = false;
            this.tbBalance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBalance_KeyPress);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCustomerName.Location = new System.Drawing.Point(13, 9);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(158, 16);
            this.lblCustomerName.TabIndex = 20;
            this.lblCustomerName.Text = "Название организации";
            // 
            // frmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 239);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lbBalance);
            this.Controls.Add(this.tbBalance);
            this.Controls.Add(this.lblActionName);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.lblBIK);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbAccount);
            this.Controls.Add(this.tbBIK);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "..:: СЧЕТ ::..";
            this.Load += new System.EventHandler(this.frmAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblActionName;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Label lblBIK;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbAccount;
        private System.Windows.Forms.TextBox tbBIK;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbBalance;
        private System.Windows.Forms.TextBox tbBalance;
        private System.Windows.Forms.Label lblCustomerName;
    }
}