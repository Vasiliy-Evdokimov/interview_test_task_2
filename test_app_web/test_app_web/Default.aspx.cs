using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace test_app_web
{
    public partial class frmMain : System.Web.UI.Page
    {
        string connectionString = "";
        const string sqlCustomerInsert = 
            "INSERT INTO Customer (Name, INN, Address) " +
            "VALUES ('{0}', '{1}', '{2}')";
        const string sqlCustomerUpdate =
            "UPDATE Customer SET " + 
                "Name = '{0}', INN = '{1}', Address = '{2}' " +
            "WHERE ID = {3}";
        const string sqlCustomerDelete =
            "DELETE FROM Account WHERE CustomerID = {0}; " +
            "DELETE FROM Customer WHERE ID = {0};";
        const string sqlAccountInsert =
            "INSERT INTO Account (CustomerID, Account, Name, BIK, Balance) " +
            "VALUES ({0}, '{1}', '{2}', '{3}', {4})";
        const string sqlAccountUpdate =
            "UPDATE Account SET " +
                "CustomerID = {0}, Account = '{1}', Name = '{2}', BIK = '{3}', Balance = {4} " +
            "WHERE ID = {5}";

        private void ExecSQL(string sql)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            //
            connectionString =
                System.Configuration.ConfigurationManager.ConnectionStrings["test_dbConnectionString"].ConnectionString;
            //
            CheckButtons();
        }

        protected void btnCustomerSave_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                string sql = "";
                int customerID = Int32.Parse(lblCustomerID.Text);
                //
                if (customerID == 0)
                {
                    sql = String.Format(
                        sqlCustomerInsert,
                        tbCustomerName.Text.Trim(),
                        tbCustomerINN.Text.Trim(),
                        tbCustomerAddress.Text.Trim()
                    );
                } else
                {
                    sql = String.Format(
                        sqlCustomerUpdate,
                        tbCustomerName.Text.Trim(),
                        tbCustomerINN.Text.Trim(),
                        tbCustomerAddress.Text.Trim(),
                        customerID
                    );
                }
                //                
                ExecSQL(sql);
                //
                grdCustomer.DataBind();
                //
                mpeCustomer.Hide();
            }
            else mpeCustomer.Show();
        }

        protected void btnCustomerCancel_Click(object sender, EventArgs e)
        {
            mpeCustomer.Hide();
        }

        protected void btnCustomerAdd_Click(object sender, EventArgs e)
        {
            lblCustomerID.Text = "0";
            tbCustomerName.Text = "";
            tbCustomerINN.Text = "";
            tbCustomerAddress.Text = "";
            lblCustomerHeader.Text = "Добавление организации";
            mpeCustomer.Show();
        }

        protected void btnCustomerEdit_Click(object sender, EventArgs e)
        {
            int indexCustomer = grdCustomer.SelectedIndex;
            if (indexCustomer >= 0) 
            {
                DataView dvc = (DataView)sdsCustomer.Select(DataSourceSelectArguments.Empty);
                DataRow drc = dvc.Table.Rows[indexCustomer];
                //                
                lblCustomerID.Text = drc.Field<int>("ID").ToString();
                tbCustomerName.Text = drc.Field<string>("Name").Trim();
                tbCustomerINN.Text = drc.Field<string>("INN").Trim();
                tbCustomerAddress.Text = drc.Field<string>("Address").Trim();
                lblCustomerHeader.Text = "Редактирование организации";
                mpeCustomer.Show();
            }
        }
        protected void btnCustomerDelete_Click(object sender, EventArgs e)
        {
            int indexCustomer = grdCustomer.SelectedIndex;
            if (indexCustomer >= 0)
            {
                int id = (int)grdCustomer.SelectedDataKey.Values["ID"];
                ExecSQL(String.Format(sqlCustomerDelete, id));
                //
                grdCustomer.SelectedIndex = -1;
                grdCustomer.DataBind();                
            }
        }

        private void CheckButtons()
        {
            lblCustomerName.Visible = (grdCustomer.SelectedIndex >= 0);
            _lblCustomerName.Visible = lblCustomerName.Visible;
            btnCustomerEdit.Visible = lblCustomerName.Visible;
            btnCustomerDelete.Visible = lblCustomerName.Visible;
            btnAccountAdd.Visible = lblCustomerName.Visible;
            btnAccountEdit.Visible = (lblCustomerName.Visible && (grdAccount.SelectedIndex >= 0));
            btnAccountDelete.Visible = btnAccountEdit.Visible;
        }

        protected void grdCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            grdAccount.SelectedIndex = -1;
            int indexCustomer = grdCustomer.SelectedIndex;
            if (indexCustomer >= 0)
            {
                DataView dv = (DataView)sdsCustomer.Select(DataSourceSelectArguments.Empty);
                DataRow dr = dv.Table.Rows[indexCustomer];
                lblCustomerName.Text = dr.Field<string>("Name");
            }
            //
            CheckButtons(); 
        }

        protected void btnAccountSave_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                string sql = "";
                int customerID = Int32.Parse(lblAccountCustomerID.Text);
                int accountID = Int32.Parse(lblAccountID.Text);
                //
                if (accountID == 0)
                {
                    sql = String.Format(
                        sqlAccountInsert,
                        customerID,
                        tbAccountNumber.Text.Trim(),
                        tbAccountName.Text.Trim(),
                        tbAccountBIK.Text.Trim(),
                        tbAccountBalance.Text.Trim().Replace(',', '.')
                    );
                }
                else
                {
                    sql = String.Format(
                        sqlAccountUpdate,                        
                        customerID,
                        tbAccountNumber.Text.Trim(),
                        tbAccountName.Text.Trim(),
                        tbAccountBIK.Text.Trim(),
                        tbAccountBalance.Text.Trim().Replace(',', '.'),
                        accountID
                    );
                }
                //                
                ExecSQL(sql);
                //
                grdAccount.DataBind();
                //
                mpeAccount.Hide();
            }
            else mpeAccount.Show();
        }

        protected void btnAccountCancel_Click(object sender, EventArgs e)
        {
            mpeAccount.Hide();
        }

        protected void btnAccountAdd_Click(object sender, EventArgs e)
        {
            int indexCustomer = grdCustomer.SelectedIndex;
            if (indexCustomer >= 0)
            {
                DataView dvc = (DataView)sdsCustomer.Select(DataSourceSelectArguments.Empty);
                DataRow drc = dvc.Table.Rows[indexCustomer];
                //                
                lblAccountID.Text = "0";
                lblAccountCustomerID.Text = drc.Field<int>("ID").ToString();
                tbAccountNumber.Text = "";
                tbAccountName.Text = "";
                tbAccountBIK.Text = "";
                tbAccountBalance.Text = "0";
                lblAccountHeader.Text = "Добавление счета";
                mpeAccount.Show();
            }
        }

        protected void btnAccountEdit_Click(object sender, EventArgs e)
        {
            int indexAccount = grdAccount.SelectedIndex;
            if (indexAccount >= 0)
            {
                DataView dva = (DataView)sdsAccount.Select(DataSourceSelectArguments.Empty);
                DataRow dra = dva.Table.Rows[indexAccount];
                //                
                lblAccountID.Text = dra.Field<int>("ID").ToString();
                lblAccountCustomerID.Text = dra.Field<int>("CustomerID").ToString();
                tbAccountNumber.Text = dra.Field<string>("Account").Trim();
                tbAccountName.Text = dra.Field<string>("Name").Trim();
                tbAccountBIK.Text = dra.Field<string>("BIK").Trim();
                tbAccountBalance.Text = dra.Field<decimal>("Balance").ToString();
                lblAccountHeader.Text = "Редактирование счета";
                mpeAccount.Show();
            }
        }

        protected void btnAccountDelete_Click(object sender, EventArgs e)
        {
            int indexAccount = grdAccount.SelectedIndex;
            if (indexAccount >= 0)
            {
                int id = (int)grdAccount.SelectedDataKey.Values["ID"];
                ExecSQL($"DELETE FROM Account WHERE ID = {id}");
                //
                grdAccount.SelectedIndex = -1;
                grdAccount.DataBind();                
            }
        }

        protected void grdAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckButtons();
        }

    }
}