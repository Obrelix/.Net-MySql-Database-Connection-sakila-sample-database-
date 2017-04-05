﻿using System;
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
        List<CategoryID> ListMovies = new List<CategoryID>();
        DataTable tblMovies = new DataTable();

        public frmMovies()
        {
            InitializeComponent();

            cmd = new OdbcCommand();
            cmd.Connection = DB.Cn;
        }

        private void loadMovies()
        {
            CategoryID a;
            string SQL = "SELECT category.`category_id`,category.`name` FROM category";
            try
            {
                cmd.CommandText = SQL;
                reader = cmd.ExecuteReader();
                ListMovies.Clear();
                //lblEmployee.Text = "";
                while (reader.Read())
                {
                    a = new CategoryID(reader[0].ToString(),
                    //boroume omoios na grapsoume reader[1] bla bla
                    reader["name"].ToString());
                    ListMovies.Add(a);
                }
               cbxCategories.SelectedIndexChanged -= new EventHandler(cbxCategories_SelectedIndexChanged);
                bind(cbxCategories);
                cbxCategories.SelectedIndex = -1;
                cbxCategories.Text = "Select Category ... ";
               // lblEmployee.Text = "";
               cbxCategories.SelectedIndexChanged += new EventHandler(cbxCategories_SelectedIndexChanged);
                if (reader != null)
                {
                    reader.Close();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally
            {
                //reader?.Close(); //if (reader != null) reader.Close();
            }
        }

        private void bind(ComboBox cb)
        {
            cb.BeginUpdate();
            cb.DataSource = null;
            cb.DataSource = ListMovies;
            cb.ValueMember = "id";
            cb.DisplayMember = "name";
            cb.EndUpdate();
        }

        private void frmMovies_Load(object sender, EventArgs e)
        {
            loadMovies();
            ShowFilms();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowFilms();
        }

        private void ShowFilms()
        {
            int categoryID;
            string sWHERE = string.Empty;
            try
            {
                SQL = "SELECT" + Environment.NewLine +
                    "`film`.`film_id`     AS `FID`," + Environment.NewLine +
                    "`film`.`title`       AS `title`," + Environment.NewLine +
                    "`category`.`name`    AS `category`," + Environment.NewLine +
                    "`film`.`length`      AS `length`," + Environment.NewLine +
                    "`film`.`rating`      AS `rating`," + Environment.NewLine +
                    "`film`.`rental_rate` AS `price`," + Environment.NewLine +
                    "film.`special_features` AS special_features," + Environment.NewLine +
                    "film.`rental_duration` AS rental_duration," + Environment.NewLine +
                    "film.`replacement_cost` AS replacement_cost," + Environment.NewLine +
                    "`film`.`description` AS `description`" + Environment.NewLine +
                    "FROM category" + Environment.NewLine +
                    "LEFT JOIN film_category ON category.`category_id`= film_category.`category_id`" + Environment.NewLine +
                    "LEFT JOIN film ON film_category.`film_id`= film.`film_id`" + Environment.NewLine;
                
                sWHERE = " Where film.`title` LIKE " + My.Quote(txtMovieName.Text + "%");
                if (cbxCategories.SelectedIndex != -1)
                {
                    CategoryID a = (CategoryID)cbxCategories.SelectedItem;
                    categoryID = Convert.ToInt32(a.id);
                    sWHERE += " AND category.`category_id`=" + categoryID;
                }
                
                if (txtMovieName.Text != string.Empty || cbxCategories.SelectedIndex != -1) SQL += Environment.NewLine + sWHERE;
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
            txtMovieName.Text = string.Empty;
            ShowFilms();
        }
        

        private void cbxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowFilms();
        }
        

        private void btnGo_Click_1(object sender, EventArgs e)
        {
            ShowFilms();
        }
        

        private void txtMovieName_TextChanged(object sender, EventArgs e)
        {
            cbxCategories.SelectedIndex = -1;
            cbxCategories.Text = "Select Category ... ";
        }

        private void dvgMovies_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                string title = dvgMovies.Rows[e.RowIndex].Cells[1].Value.ToString();
                frmActors form = new frmActors(title);
                form.Show();
            }
        }

        private void dvgMovies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
