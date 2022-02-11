using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_app
{
    public partial class frmAccount : Form
    {
        public bool IsAddition { get; set; }
        private frmMain main;
        private string customerName = "";
        private int customerID = 0;

        private void FillFields()
        {
            customerID = (int)main.grdCustomer.CurrentRow.Cells["CustomerID"].Value;
            customerName = main.grdCustomer.CurrentRow.Cells["CustomerName"].Value.ToString();
            
            lblCustomerName.Text = customerName;

            if (IsAddition)
            {
                lblActionName.Text = "ДОБАВЛЕНИЕ СЧЕТА";
                tbName.Text = "";
                tbAccount.Text = "";
                tbBIK.Text = "";
                tbBalance.Text = "";
            }
            else
            {                
                if (main != null)
                {
                    string accountName = main.grdAccount.CurrentRow.Cells["AccountName"].Value.ToString();
                    lblActionName.Text = $"РЕДАКТИРОВАНИЕ СЧЕТА \"{accountName}\"";
                    tbName.Text = accountName;
                    tbAccount.Text = main.grdAccount.CurrentRow.Cells["AccountAccount"].Value.ToString();
                    tbBIK.Text = main.grdAccount.CurrentRow.Cells["AccountBIK"].Value.ToString();
                    tbBalance.Text = main.grdAccount.CurrentRow.Cells["AccountBalance"].Value.ToString();
                }
            }
        }

        public frmAccount()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool CheckFields()
        {
            string err = "";
            if (tbAccount.Text.Trim().Length != 20) err += "\r\n- счёт должен состоять из 20 цифр;";
            if (tbBIK.Text.Trim().Length != 9) err += "\r\n- БИК должен состоять из 9 цифр;";
            //
            string b_str = tbBalance.Text.Trim();
            if (b_str == "") b_str = "0"; 
            double b_dbl = 0;
            bool fl = double.TryParse(b_str, out b_dbl);
            fl = fl && (b_dbl >= 0) && (b_dbl <= (Math.Pow(10, 12) - 0.01));                
            if (!fl) err += "\r\n- баланс содержит некорректное число;";

            if (err == "") return true;

            err = "Обнаружены следующие ошибки:" + err.Substring(0, err.Length - 1) + '.';
            MessageBox.Show(
                err,
                "Внимание!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            return false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckFields()) return;

            DataRow nRow;

            if (IsAddition)
                nRow = main.test_dbDataSet.Account.NewRow();
            else
                nRow = main.test_dbDataSet.Account.FindByID(
                    (int)main.grdAccount.CurrentRow.Cells["AccountID"].Value);                   

            nRow["CustomerID"] = customerID;
            nRow["Name"] = tbName.Text.Trim();
            nRow["Account"] = tbAccount.Text.Trim();
            nRow["BIK"] = tbBIK.Text.Trim();
            nRow["Balance"] = tbBalance.Text.Trim();

            if (IsAddition) main.test_dbDataSet.Account.Rows.Add(nRow);

            main.accountTableAdapter.Update(main.test_dbDataSet.Account);
            main.test_dbDataSet.Account.AcceptChanges();
            main.grdAccount.Refresh();

            Close();
        }

        private void tbAccount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char t = e.KeyChar;
            e.Handled = (((t <= 47) || (t >= 58)) && (t != '\b'));
        }

        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char t = e.KeyChar;
            e.Handled = ((t > 'A') && (t <= 'z'));
        }

        private void tbBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            char t = e.KeyChar;
            e.Handled = (((t <= 47) || (t >= 58)) && (t != '\b') && (t != ','));
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {
            main = this.Owner as frmMain;
            //
            FillFields();
        }
    }
}
