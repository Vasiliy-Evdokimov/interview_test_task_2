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
    public partial class frmCustomer : Form
    {
        public bool IsAddition { get; set; }
        private frmMain main;

        private void FillFields()
        {
            if (IsAddition)
            {
                lblActionName.Text = "ДОБАВЛЕНИЕ ОРГАНИЗАЦИИ";
                tbName.Text = "";
                tbINN.Text = "";
                tbAddress.Text = "";
            }
            else
            {                
                string customerName = "";
                //
                if (main != null)
                {
                    customerName = main.grdCustomer.CurrentRow.Cells["CustomerName"].Value.ToString();
                    lblActionName.Text = $"РЕДАКТИРОВАНИЕ ОРГАНИЗАЦИИ \"{customerName}\"";
                    tbName.Text = customerName;
                    tbINN.Text = main.grdCustomer.CurrentRow.Cells["CustomerINN"].Value.ToString();
                    tbAddress.Text = main.grdCustomer.CurrentRow.Cells["CustomerAddress"].Value.ToString();
                }
            }            
        }

        public frmCustomer()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            main = this.Owner as frmMain;
            //
            FillFields();
        }

        private bool CheckFields()
        {
            string err = "";
            if (tbName.Text.Trim() == "") err += "\r\n- название не может быть пустым;";
            if (tbINN.Text.Trim().Length < 12) err += "\r\n- ИНН должен состоять из 12 цифр;";

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
                nRow = main.test_dbDataSet.Customer.NewRow();
            else
                nRow = main.test_dbDataSet.Customer.FindByID(
                    (int)main.grdCustomer.CurrentRow.Cells["CustomerID"].Value);            
                
            nRow["Name"] = tbName.Text.Trim();
            nRow["INN"] = tbINN.Text.Trim();
            nRow["Address"] = tbAddress.Text.Trim();  
            
            if (IsAddition) main.test_dbDataSet.Customer.Rows.Add(nRow);

            main.customerTableAdapter.Update(main.test_dbDataSet.Customer);
            main.test_dbDataSet.Customer.AcceptChanges();
            main.grdCustomer.Refresh();

            Close();
        }

        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char t = e.KeyChar;
            e.Handled = ((t > 'A') && (t <= 'z'));
        }

        private void tbINN_KeyPress(object sender, KeyPressEventArgs e)
        {
            char t = e.KeyChar;
            e.Handled = (((t <= 47) || (t >= 58)) && (t != '\b'));
        }
    }
}
