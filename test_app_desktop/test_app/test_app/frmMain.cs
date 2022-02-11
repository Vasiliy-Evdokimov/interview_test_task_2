using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace test_app
{
    public partial class frmMain : Form
    {
        
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.customerTableAdapter.Fill(this.test_dbDataSet.Customer);
            this.accountTableAdapter.Fill(this.test_dbDataSet.Account);
        }

        private void grdCustomer_CurrentCellChanged(object sender, EventArgs e)
        {
            lblCustomerName.Text = "";
            if (grdCustomer.CurrentRow != null)
                lblCustomerName.Text = grdCustomer.CurrentRow.Cells["CustomerName"].Value.ToString();           
        }

        private void btnCustomerAdd_Click(object sender, EventArgs e)
        {
            frmCustomer MF = new frmCustomer();
            MF.Owner = this;
            MF.IsAddition = true;
            MF.ShowDialog();
        }

        private void btnCustomerEdit_Click(object sender, EventArgs e)
        {
            if (!CheckRecord(grdCustomer)) return;
            //
            frmCustomer MF = new frmCustomer();
            MF.Owner = this;
            MF.IsAddition = false;
            MF.ShowDialog();
        }

        private void btnAccountAdd_Click(object sender, EventArgs e)
        {
            frmAccount MF = new frmAccount();
            MF.Owner = this;
            MF.IsAddition = true;
            MF.ShowDialog();
        }

        private void btnAccountEdit_Click(object sender, EventArgs e)
        {
            if (!CheckRecord(grdAccount)) return;
            //
            frmAccount MF = new frmAccount();
            MF.Owner = this;
            MF.IsAddition = false;
            MF.ShowDialog();
        }

        private bool CheckRecord(DataGridView aDataGrid)
        {
            if (aDataGrid.Rows.Count <= 0)
            {
                MessageBox.Show(
                    "Не выбрана запись в таблице!", 
                    "Внимание!", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
                return false;
            }
            //
            return true;
        }

        private void btnCustomerDelete_Click(object sender, EventArgs e)
        {
            if (!CheckRecord(grdCustomer)) return;
            //
            string customer = grdCustomer.CurrentRow.Cells["CustomerName"].Value.ToString();
            DialogResult dlgRes = MessageBox.Show(
                $"Удалить организацию \"{customer}\" и все её счета?",
                "Внимание!",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);
            //
            if (dlgRes != DialogResult.OK) return;
            //
            int customerID = (int)grdCustomer.CurrentRow.Cells["CustomerID"].Value;

            DataRow[] accounts = test_dbDataSet.Account.Select("CustomerID = " + customerID);
            for (int i = 0; i < accounts.Length; i++)
                accounts[i].Delete();                
            accountTableAdapter.Update(test_dbDataSet.Account);
            test_dbDataSet.Account.AcceptChanges();
            grdAccount.Refresh();

            DataRow dRow = test_dbDataSet.Customer.FindByID(customerID);
            dRow.Delete();
            customerTableAdapter.Update(test_dbDataSet.Customer);   
            test_dbDataSet.Customer.AcceptChanges();
            grdCustomer.Refresh();
        }

        private void btnAccountDelete_Click(object sender, EventArgs e)
        {
            if (!CheckRecord(grdAccount)) return;
            //
            string account = grdAccount.CurrentRow.Cells["AccountAccount"].Value.ToString();
            DialogResult dlgRes = MessageBox.Show(
                $"Удалить счет \"{account}\"?",
                "Внимание!",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);
            //
            if (dlgRes != DialogResult.OK) return;
            //
            DataRow dRow = test_dbDataSet.Account.FindByID(
                (int)grdAccount.CurrentRow.Cells["AccountID"].Value);
            dRow.Delete();
            accountTableAdapter.Update(test_dbDataSet.Account);
            test_dbDataSet.Account.AcceptChanges();
            grdAccount.Refresh();
        }

    }
}
