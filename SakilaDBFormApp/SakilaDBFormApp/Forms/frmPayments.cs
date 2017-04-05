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

namespace SakilaDBFormApp
{
    public partial class frmPayments : Form
    {
        OdbcCommand cmd;
        OdbcDataReader reader;
        string SQL;
        List<CategoryID> ListMovies = new List<CategoryID>();
        DataTable tblMovies = new DataTable();

        public frmPayments()
        {
            InitializeComponent();

            cmd = new OdbcCommand();
            cmd.Connection = DB.Cn;
        }

       

        

        private void frmMovies_Load(object sender, EventArgs e)
        {
           
            ShowPayments();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowPayments();
        }

        private void ShowPayments()
        {
            string from, to;
            string sWHERE = string.Empty;
            try
            {
                from = dtpFrom.Value.ToString("yyyy-MM-dd");
                to = dtpTo.Value.ToString("yyyy-MM-dd");
                sWHERE = "Where payment_date BETWEEN'" + from + "'AND'" + to + "'"; 

                SQL = "SELECT payment.`payment_id`,payment.`amount`,payment.`payment_date`,film.`title`,customer.`last_name`,customer.`first_name`" + Environment.NewLine +
                    "FROM payment" + Environment.NewLine +
                    "LEFT JOIN customer ON payment.`customer_id` = customer.`customer_id`" + Environment.NewLine +
                    "LEFT JOIN rental ON customer.`customer_id` = rental.`customer_id`" + Environment.NewLine +
                    "LEFT JOIN inventory ON inventory.`inventory_id` = rental.`rental_id`" + Environment.NewLine +
                    "LEFT JOIN film ON film.`film_id` = inventory.`film_id`";

                SQL += sWHERE;
                cmd.CommandText = SQL;
                reader = cmd.ExecuteReader();

                tblMovies.Rows.Clear();
                tblMovies.Load(reader);
                dvgMovies.DataSource = tblMovies;
                lblMovies.Text ="Movies Found: " + tblMovies.Rows.Count.ToString();
                if (reader != null)
                {
                    reader.Close();
                }
                
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            finally
            {
                //reader?.Close();
            }
        }

        private void cbEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            ShowPayments();
        }
        

        private void dgvOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 1) return;
        }

        private void cbxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowPayments();
        }
        

        private void btnGo_Click_1(object sender, EventArgs e)
        {
            ShowPayments();
        }

        private void dgvOrders_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                string title = dvgMovies.Rows[e.RowIndex].Cells[0].Value.ToString();
                frmActors form = new frmActors(title);
                form.Show();
            }
            //form.GetDada();
        }

        
    }
}
