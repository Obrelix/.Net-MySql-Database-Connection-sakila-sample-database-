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

namespace SakilaDBFormApp.Forms
{
    public partial class frmRegister : Form
    {
        OdbcCommand command;
        OdbcDataReader reader;
        List<CategoryID> listLanguages, listRatings;
        DateTime dt;
        
        

        public frmRegister()
        {
            InitializeComponent();
            command = new OdbcCommand();
            command.Connection = DB.Cn;
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReleaseYear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRentalDuration = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRentalRate = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtReplacementCost = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxLanguages = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxRatings = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(136, 23);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Release Year:";
            // 
            // txtReleaseYear
            // 
            this.txtReleaseYear.Location = new System.Drawing.Point(159, 55);
            this.txtReleaseYear.Name = "txtReleaseYear";
            this.txtReleaseYear.Size = new System.Drawing.Size(100, 20);
            this.txtReleaseYear.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rental Duration:";
            // 
            // txtRentalDuration
            // 
            this.txtRentalDuration.Location = new System.Drawing.Point(168, 89);
            this.txtRentalDuration.Name = "txtRentalDuration";
            this.txtRentalDuration.Size = new System.Drawing.Size(100, 20);
            this.txtRentalDuration.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Rental Rate:";
            // 
            // txtRentalRate
            // 
            this.txtRentalRate.Location = new System.Drawing.Point(159, 128);
            this.txtRentalRate.Name = "txtRentalRate";
            this.txtRentalRate.Size = new System.Drawing.Size(100, 20);
            this.txtRentalRate.TabIndex = 7;
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(159, 164);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 20);
            this.txtLength.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Length:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Replacement Cost:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Description:";
            // 
            // txtReplacementCost
            // 
            this.txtReplacementCost.Location = new System.Drawing.Point(162, 196);
            this.txtReplacementCost.Name = "txtReplacementCost";
            this.txtReplacementCost.Size = new System.Drawing.Size(100, 20);
            this.txtReplacementCost.TabIndex = 12;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(136, 236);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(100, 20);
            this.txtDescription.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Language:";
            // 
            // cbxLanguages
            // 
            this.cbxLanguages.FormattingEnabled = true;
            this.cbxLanguages.Location = new System.Drawing.Point(123, 268);
            this.cbxLanguages.Name = "cbxLanguages";
            this.cbxLanguages.Size = new System.Drawing.Size(121, 21);
            this.cbxLanguages.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(59, 303);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Ratings:";
            // 
            // cbxRatings
            // 
            this.cbxRatings.FormattingEnabled = true;
            this.cbxRatings.Location = new System.Drawing.Point(123, 303);
            this.cbxRatings.Name = "cbxRatings";
            this.cbxRatings.Size = new System.Drawing.Size(121, 21);
            this.cbxRatings.TabIndex = 17;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(136, 341);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmRegister
            // 
            this.BackgroundImage = global::SakilaDBFormApp.Properties.Resources.cinema;
            this.ClientSize = new System.Drawing.Size(560, 376);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbxRatings);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbxLanguages);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtReplacementCost);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.txtRentalRate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRentalDuration);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtReleaseYear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label1);
            this.Name = "frmRegister";
            this.Text = "Add Movie";
            this.Load += new System.EventHandler(this.frmRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void LoadLanguages()
        {
            CategoryID category;
            listLanguages = new List<CategoryID>();
            string query = "SELECT language.`language_id`, language.`name` FROM language";

            try
            {
                command.CommandText = query;
                reader = command.ExecuteReader();
                listLanguages.Clear();

                while (reader.Read())
                {
                    category = new CategoryID(reader[0].ToString(), reader["name"].ToString());
                    listLanguages.Add(category);
                }

                bind(cbxLanguages, listLanguages);
                cbxLanguages.SelectedIndex = -1;
                cbxLanguages.Text = "Choose Language";

                if (reader != null) reader.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void bind(ComboBox cb, List<CategoryID> ls)
        {
            cb.BeginUpdate();
            cb.DataSource = null;
            cb.DataSource = ls;
            cb.ValueMember = "id";
            cb.DisplayMember = "name";
            cb.EndUpdate();
        }

        private void LoadRatings()
        {
            CategoryID category;
            listRatings = new List<CategoryID>();
            string query = "SELECT DISTINCT film.`rating` AS `name` FROM film";
            int counter = -1;

            try
            {
                command.CommandText = query;
                reader = command.ExecuteReader();
                listRatings.Clear();

                while (reader.Read())
                {
                    category = new CategoryID(counter++.ToString(), reader["name"].ToString());
                    listRatings.Add(category);
                }

                bind(cbxRatings, listRatings);
                cbxRatings.SelectedIndex = -1;
                cbxRatings.Text = "Choose Rating";

                if (reader != null) reader.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private bool CheckForNull()
        {
            bool boolean = true;

            if (txtTitle.Text == string.Empty || txtReleaseYear.Text == string.Empty || txtRentalDuration.Text == string.Empty ||
                txtRentalRate.Text == string.Empty || txtLength.Text == string.Empty || txtReplacementCost.Text == string.Empty ||
                txtDescription.Text == string.Empty || cbxLanguages.SelectedIndex == -1 || cbxRatings.SelectedIndex == -1 )
                
            {
                MessageBox.Show("You haven't completed the requiered fields.");
                boolean = false;
            }

            return boolean;
        }

        private int CalculateMovieId()
        {
            int id = 0;
            string query = "SELECT MAX(film_id) AS `count` FROM film";

            try
            {
                command.CommandText = query;
                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    id = Convert.ToInt32(reader[0].ToString());
                }

                if (reader != null) reader.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return id + 1;
        }

        private void SaveNewMovieToDatabase()
        {
            dt = DateTime.Now;

            string query = "INSERT INTO film VALUES (" + CalculateMovieId() + ",'" + txtTitle.Text + "','" + txtDescription.Text + "'," +
                txtReleaseYear.Text + "," + cbxLanguages.SelectedIndex + 1 + ",NULL," + txtRentalDuration.Text + "," + txtRentalRate.Text +
                "," + txtLength.Text + "," + txtReplacementCost.Text + "," + cbxRatings.SelectedIndex + 1 +",NULL,'" + dt.ToString("yyyy-MM-dd H:mm:ss") + "',NULL);";
            try { command.CommandText = query; reader = command.ExecuteReader(); reader?.Close(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckForNull())
            {

                SaveNewMovieToDatabase();
                MessageBox.Show("INSERT INTO film VALUES (" + CalculateMovieId() + ",'" + txtTitle.Text + "','" + txtDescription.Text + "'," +
                txtReleaseYear.Text + "," + cbxLanguages.SelectedIndex + 1 + ",NULL," + txtRentalDuration.Text + "," + txtRentalRate.Text +
                "," + txtLength.Text + "," + txtReplacementCost.Text + ",'" + cbxRatings.SelectedIndex + 1 + ",NULL," + dt.ToString("yyyy-MM-dd H:mm:ss") + "',NULL);");
            }
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {

            LoadLanguages();
            LoadRatings();

            txtTitle.Text = "s";
            txtReplacementCost.Text = "12";
            txtRentalRate.Text = "1";
            txtLength.Text = "120";
            txtReleaseYear.Text = "2000";
            txtDescription.Text = "GAMW TI MANA SOU";
            txtRentalDuration.Text = "6";

        }
        

       

    }
}
