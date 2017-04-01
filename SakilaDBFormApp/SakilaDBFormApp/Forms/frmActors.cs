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
    public partial class frmActors : Form
    {
        OdbcCommand cmd = new OdbcCommand();
        OdbcDataReader reader;
        DataTable dtActors = new DataTable();
        string SQL;

        public frmActors()
        {
            InitializeComponent();
            cmd = new OdbcCommand();
            cmd.Connection = DB.Cn;
        }

        public void GetData(string filmTitle)
        {
            try
            {
                SQL = "SELECT actor.`first_name`,actor.`last_name`" + Environment.NewLine +
                        "FROM actor" + Environment.NewLine +
                        "JOIN film_actor ON actor.`actor_id`= film_actor.`actor_id`" + Environment.NewLine +
                        "JOIN film ON film_actor.`film_id`= film.`film_id`" + Environment.NewLine +
                    "WHERE film.`title`="+ My.Quote(filmTitle);
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
        
    }
}
