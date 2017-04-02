using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SakilaDBFormApp.Forms
{
    public partial class frmCustomers : Form
    {

        OdbcCommand cmd;
        OdbcDataReader reader;
        string SQL;
        DataTable tblCustomers = new DataTable();

        public frmCustomers()
        {
            InitializeComponent();
            cmd = new OdbcCommand();
            cmd.Connection = DB.Cn;
        }

        private void showCustomers()
        {
            SQL = "SELECT first_name,last_name,email,customer_id FROM customer";
            try
            {
                if (txtCustomerName.Text != string.Empty)
                {
                    string sWhere = " Where last_name LIKE " + My.Quote(txtCustomerName.Text + "%");
                    SQL += Environment.NewLine + sWhere;
                }

                cmd.CommandText = SQL;
                reader = cmd.ExecuteReader();
                tblCustomers.Rows.Clear();
                tblCustomers.Load(reader);
                dvgCustomers.DataSource = tblCustomers;

                if (reader != null)
                {
                    reader.Close();
                }
            }
            catch (Exception ex){ MessageBox.Show(ex.Message); }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            showCustomers();
        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            showCustomers();
        }

        private void dvgCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Δυο μεταβλητές για πιο σωστο ερωτημα(SQL)
            string customerFirstName = dvgCustomers.Rows[e.RowIndex].Cells[0].Value.ToString();
            string customerLastName = dvgCustomers.Rows[e.RowIndex].Cells[1].Value.ToString();
            new frmCustomerMovies(customerFirstName, customerLastName).Show();
        }
    }
}
