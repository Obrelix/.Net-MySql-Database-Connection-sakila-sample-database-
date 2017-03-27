using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace SakilaDBFormApp
{
    public partial class frmAdapterLight : Form
    {
        OdbcConnection cn = new OdbcConnection();
        OdbcDataAdapter da = new OdbcDataAdapter();
        DataTable dt = new DataTable();

        public frmAdapterLight()
        {
            InitializeComponent();
            dgvDisplay.DataSource = dt;
            cn.ConnectionString ="Provider=MSDASQL.1" +
                            ";Driver={MySQL ODBC 5.3 UNICODE Driver}" +
                            ";Server=127.0.0.1" +
                            ";Port=3306"  +
                            ";Database=sakila" +
                            ";User=root"  +
                            ";Password="  +
                            ";Option=3";
        }

        private void loadEmps()
        {
            try
            {
                string SQL = "SELECT *  FROM film";
                da.SelectCommand =new OdbcCommand(SQL, cn);
                OdbcCommandBuilder cb = new OdbcCommandBuilder(da);
                dt.Clear();
                da.Fill(dt);
            }
            catch
            {

            }
           

        }

        private void save()
        {
            try
            {
                da.Update(dt);
            }
            catch
            {

            }
        }

        

        private void btnsave_Click(object sender, EventArgs e)
        {
            save();
        }

        private void frmAdapterLight_Load(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            loadEmps();
        }
    }
}
