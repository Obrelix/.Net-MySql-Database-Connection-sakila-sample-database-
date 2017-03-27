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
    public partial class frmReader2 : Form
    {
        OdbcCommand cmd;
        OdbcDataReader reader;
        string SQL;
        List<IdTitle> ListEmployees = new List<IdTitle>();
        DataTable tblOrders = new DataTable();

        public frmReader2()
        {
            InitializeComponent();
            cmd = new OdbcCommand();
            cmd.Connection = DB.Cn;
        }

        private void frmReader2_Load(object sender, EventArgs e)
        {
            LoadEmployees();
        }
        private void LoadEmployees()
        {
            IdTitle a;
            SQL = "SELECT EmployeeID,FirstName,LastName FROM employees";
            try
            {
                cmd.CommandText = SQL;
                reader = cmd.ExecuteReader();
                ListEmployees.Clear();
                //lblEmployee.Text = "";
                while (reader.Read())
                {
                    a = new IdTitle(reader[0].ToString(),
                        //boroume omoios na grapsoume reader[1] bla bla
                    reader["LastName"].ToString() + " " + reader["FirstName"].ToString());
                    ListEmployees.Add(a);
                }
                cbxEmp.SelectedIndexChanged -= new EventHandler(cbxEmp_SelectedIndexChanged);
                bind(cbxEmp);
                cbxEmp.SelectedIndex = -1;
                cbxEmp.Text = "Select Employee ... ";
               // lblEmployee.Text = "";
                cbxEmp.SelectedIndexChanged += new EventHandler(cbxEmp_SelectedIndexChanged);
                if (reader != null)
                {
                    reader.Close();
                }
            }
            catch (Exception ex) {MessageBox.Show(ex.Message); }
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
            cb.DataSource = ListEmployees;
            cb.ValueMember = "id";
            cb.DisplayMember = "title";
            cb.EndUpdate();
        }


        private void cbxEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        private void ShowRentals()
        {
            int empid;
            string apo, eos;
            string sWHERE;
            try
            {
                apo = dtpApo.Value.ToString("yyyy-MM-dd");
                eos = dtpEos.Value.ToString("yyyy-MM-dd");
                sWHERE = "WHERE rental_date BETWEEN '" + apo + "' AND '" + eos + "'";
                if (cbxEmp.SelectedIndex >=0 )
                {
                    IdTitle a = (IdTitle)cbxEmp.SelectedItem;
                    empid = Convert.ToInt32(a.id);
                    sWHERE += " AND employeeid=" + empid;
                }
                if (txtCustomer.Text != "")
                {
                    sWHERE += " AND CustomerId LIKE " + My.Quote(txtCustomer.Text + "%");
                }
                SQL = "SELECT * FROM rental " + sWHERE;
                cmd.CommandText = SQL;
                reader =cmd.ExecuteReader();
                tblOrders.Rows.Clear();
                tblOrders.Load(reader);
                dgvOrders.DataSource = tblOrders;
                this.Text = tblOrders.Rows.Count.ToString();
                if (reader != null)
                {
                    reader.Close();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
            finally
            {
                //reader?.Close();
            }
        }
        private void btnGo_Click(object sender, EventArgs e)
        {
            ShowRentals();
        }
        private void cbEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowRentals();
        }

        private void tmrClock_Tick(object sender, EventArgs e)
        {

        }
        
    }
}
