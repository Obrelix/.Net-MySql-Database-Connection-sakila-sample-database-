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
            SQL = "SELECT" + Environment.NewLine +
                   "customer.`customer_id` AS ID," + Environment.NewLine +
                    "CONCAT(customer.`first_name`, _utf8' ', customer.`last_name`) AS `FullName`," + Environment.NewLine +
                    "customer.`email` AS `E-Mail`," + Environment.NewLine +
                    "address.`address` AS `Address`," + Environment.NewLine +
                    "address.`postal_code` AS `Zip Code`," + Environment.NewLine +
                    "address.`phone` AS `Phone`," + Environment.NewLine +
                    "city.`city` AS City," + Environment.NewLine +
                    "country.`country` AS Country," + Environment.NewLine +
                    "IF(customer.`active`, _utf8'active', _utf8'') AS `Notes`," + Environment.NewLine +
                    "customer.`store_id` AS SID " + Environment.NewLine +
                    "FROM customer" + Environment.NewLine +
                    "JOIN address ON customer.`address_id`= address.`address_id`" + Environment.NewLine +
                    "JOIN city ON address.`city_id`= city.`city_id`" + Environment.NewLine +
                    "JOIN country ON city.`country_id`= country.`country_id`" + Environment.NewLine;
            try
            {
                if (txtCustomerName.Text != string.Empty)
                {
                    string sWhere = "Where last_name LIKE " + My.Quote(txtCustomerName.Text + "%");
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
            string customerName = dvgCustomers.Rows[e.RowIndex].Cells[1].Value.ToString();
            new frmCustomerMovies(customerName.Split(' ').First(), customerName.Split(' ').Last()).Show();
        }
    }
}
