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
    public partial class frmSales : Form
    {
        OdbcCommand cmd = new OdbcCommand();
        OdbcDataReader reader;
        DataTable dtSales = new DataTable();
        string SQL;

        public frmSales()
        {
            InitializeComponent();
            cmd = new OdbcCommand();
            cmd.Connection = DB.Cn;
            loadActors();
        }
        private void loadActors()
        {
            try
            {
                SQL = "SELECT * FROM sales_by_film_category";
                cmd.CommandText = SQL;
                reader = cmd.ExecuteReader();
                dtSales.Rows.Clear();
                dtSales.Load(reader);
                dgvSales.DataSource = dtSales;
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
