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
    public partial class frmMovies : Form
    {
        OdbcCommand cmd;
        OdbcDataReader reader;
        string SQL;
        List<IdTitle> ListMovies = new List<IdTitle>();
        DataTable tblMovies = new DataTable();

        public frmMovies()
        {
            InitializeComponent();

            cmd = new OdbcCommand();
            cmd.Connection = DB.Cn;
        }

        private void loadMovies()
        {
            IdTitle a;
            SQL = "SELECT film_id, title FROM film  ";
            try
            {
                cmd.CommandText = SQL;
                reader = cmd.ExecuteReader();
                ListMovies.Clear();
                //lblEmployee.Text = "";
                while (reader.Read())
                {
                    a = new IdTitle(reader[0].ToString(),
                    //boroume omoios na grapsoume reader[1] bla bla
                    reader["film_id"].ToString() + " " + reader["title"].ToString());
                    ListMovies.Add(a);
                }
               // cbxMovies.SelectedIndexChanged -= new EventHandler(cbxMovies_SelectedIndexChanged);
                bind(cbxMovies);
                cbxMovies.SelectedIndex = -1;
                cbxMovies.Text = "Select Movie ... ";
               // lblEmployee.Text = "";
               // cbxMovies.SelectedIndexChanged += new EventHandler(cbxMovies_SelectedIndexChanged);
                if (reader != null)
                {
                    reader.Close();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally
            {
                //Mporoume na to baloume kai mesa sthn try
                //? einai o telesths melous kai sthn ousia leei an to antikeimeno den einai null proxora
                //tha mporousame na xrisimopoihsoume using() kai sto teleos den xreiazetai to reader.close
                //tha to kleisei kai tha to katharisei mono tou

                //reader?.Close(); //if (reader != null) reader.Close();
            }
        }

        private void bind(ComboBox cb)
        {
            cb.BeginUpdate();
            cb.DataSource = null;
            cb.DataSource = ListMovies;
            cb.ValueMember = "id";
            cb.DisplayMember = "title";
            cb.EndUpdate();
        }

        private void frmMovies_Load(object sender, EventArgs e)
        {
            loadMovies();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadMovies();
        }
    }
}
