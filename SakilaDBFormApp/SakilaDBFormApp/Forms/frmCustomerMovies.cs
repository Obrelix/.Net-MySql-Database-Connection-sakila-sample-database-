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
    public partial class frmCustomerMovies : Form
    {

        OdbcCommand cmd;
        OdbcDataReader reader;
        string SQL;
        string customerFirstName;
        string customerLastName;
        DataTable tblCustomers = new DataTable();

        public frmCustomerMovies(string customerFirstName, string customerLastName)
        {
            InitializeComponent();
            this.customerFirstName = customerFirstName;
            this.customerLastName = customerLastName;
            cmd = new OdbcCommand();
            cmd.Connection = DB.Cn;
            this.Text = customerFirstName + " " + customerLastName;
            lblCustomerName.Text = customerFirstName + " " + customerLastName + " rentals:";
        }

        private void showRentals()
        {
            SQL = "SELECT rental.`rental_id`,rental.`return_date`,inventory.`film_id`,film.`title`" +
                "FROM customer JOIN rental ON customer.`customer_id`=rental.`customer_id`" +
                "JOIN inventory ON rental.`inventory_id`=inventory.`inventory_id`" +
                "JOIN film ON inventory.`film_id`=film.`film_id`" +
                "WHERE customer.first_name='" + customerFirstName + "' AND customer.last_name='" + customerLastName + "'";
            try
            {
                cmd.CommandText = SQL;
                reader = cmd.ExecuteReader();
                tblCustomers.Rows.Clear();
                tblCustomers.Load(reader);
                dvgCustMovies.DataSource = tblCustomers;
                if (reader != null)
                {
                    reader.Close();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void frmCustomerMovies_Load(object sender, EventArgs e)
        {
            showRentals();
        }
    }
}
