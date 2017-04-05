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
    public partial class frmActorsInfo : Form
    {
        OdbcCommand cmd = new OdbcCommand();
        OdbcDataReader reader;
        DataTable dtActors = new DataTable();
        string SQL;

        public frmActorsInfo()
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
                SQL = "SELECT * FROM actor_info";
                cmd.CommandText = SQL;
                reader = cmd.ExecuteReader();
                dtActors.Rows.Clear();
                dtActors.Load(reader);
                dgvActors.DataSource = dtActors;
                lblActors.Text = "Actors Found: " + dtActors.Rows.Count.ToString();
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

        private void frmActorsInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
