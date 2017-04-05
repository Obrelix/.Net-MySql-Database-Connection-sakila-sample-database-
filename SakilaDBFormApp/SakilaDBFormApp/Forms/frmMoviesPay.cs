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
    public partial class frmMoviesPay : Form
    {
        OdbcCommand cmd = new OdbcCommand();
        OdbcDataReader reader;
        DataTable dtFilms = new DataTable();
        string SQL;

        public frmMoviesPay(string payment_id)
        {
            InitializeComponent();
            cmd = new OdbcCommand();
            cmd.Connection = DB.Cn;
            
            GetData(payment_id);
        }

        private void GetData(string payment_id)
        {
            try
            {
                SQL = "SELECT film.`title`" + Environment.NewLine +
                        "FROM payment" + Environment.NewLine +
                        "JOIN customer ON payment.`customer_id`=customer.`customer_id`" + Environment.NewLine +
                        "JOIN rental ON customer.`customer_id`=rental.`customer_id`" + Environment.NewLine +
                        "JOIN inventory ON rental.`inventory_id`=inventory.`inventory_id`" + Environment.NewLine +
                        "JOIN film ON inventory.`film_id`=film.`film_id`" + Environment.NewLine +
                    "WHERE payment.`payment_id`="+ payment_id;
                cmd.CommandText = SQL;
                reader = cmd.ExecuteReader();
                dtFilms.Rows.Clear();
                dtFilms.Load(reader);
                dgvFilms.DataSource = dtFilms;
                lblFilms.Text = "Films Found: " + dtFilms.Rows.Count.ToString();
                if (reader != null)
                {
                    reader.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }

        }

       
    }
}

