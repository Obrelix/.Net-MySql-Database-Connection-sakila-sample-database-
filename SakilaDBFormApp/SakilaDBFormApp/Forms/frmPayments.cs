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
        List<CategoryID> storeList = new List<CategoryID>();
        DataTable tblPayments = new DataTable();

        public frmPayments()
        {
            InitializeComponent();

            cmd = new OdbcCommand();
            cmd.Connection = DB.Cn;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowPayments();
        }

        private void loadStores()
        {
            CategoryID a;
            string SQL = "SELECT store.`store_id`,address.`address`" + Environment.NewLine +
                        "FROM store" + Environment.NewLine +
                        "LEFT JOIN address ON store.`address_id`= address.`address_id`;";
            try
            {
                cmd.CommandText = SQL;
                reader = cmd.ExecuteReader();
                storeList.Clear();
                //lblEmployee.Text = "";
                while (reader.Read())
                {
                    a = new CategoryID(reader[0].ToString(),
                    //boroume omoios na grapsoume reader[1] bla bla
                    reader["address"].ToString());
                    storeList.Add(a);
                }
                cbxStore.SelectedIndexChanged -= new EventHandler(cbxStore_SelectedIndexChanged);
                bind(cbxStore);
                cbxStore.SelectedIndex = -1;
                cbxStore.Text = "Select Store ... ";
                // lblEmployee.Text = "";
                cbxStore.SelectedIndexChanged += new EventHandler(cbxStore_SelectedIndexChanged);
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
            cb.DataSource = storeList;
            cb.ValueMember = "id";
            cb.DisplayMember = "name";
            cb.EndUpdate();
        }

        private void ShowPayments()
        {
            string from, to;
            string sWHERE = string.Empty;
            int storeID;
            try
            {
                from = dtpFrom.Value.ToString("yyyy-MM-dd");
                to = dtpTo.Value.ToString("yyyy-MM-dd");
                sWHERE = "WHERE payment.`payment_date` BETWEEN '" + from + "' AND '" + to + "'";

                SQL = "SELECT payment.`payment_id`,CONCAT(customer.`first_name`,' ', customer.`last_name`) AS Customer,customer.`email`,payment.`amount`,payment.`payment_date`, address.`address` AS StoreAddress" + Environment.NewLine +
                    "FROM payment" + Environment.NewLine +
                    "LEFT JOIN customer ON payment.`customer_id`=customer.`customer_id`" + Environment.NewLine +
                    "LEFT JOIN store ON customer.`store_id`=store.`store_id`" + Environment.NewLine +
                    "LEFT JOIN address ON store.`address_id`=address.`address_id`" + Environment.NewLine;
                sWHERE += " AND customer.`last_name` LIKE '%" + txtCustomerLName.Text + "%'";
                if (cbxStore.SelectedIndex != -1)
                {
                    CategoryID a = (CategoryID)cbxStore.SelectedItem;
                    storeID = Convert.ToInt32(a.id);
                    sWHERE += "  AND store.`store_id`=" + storeID;
                }
                SQL += sWHERE;
                cmd.CommandText = SQL;
                reader = cmd.ExecuteReader();

                tblPayments.Rows.Clear();
                tblPayments.Load(reader);
                dvgPayments.DataSource = tblPayments;
                lblPayments.Text ="Payments Found: " + tblPayments.Rows.Count.ToString();
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
        
        

        private void cbxStore_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowPayments();
        }
        

        private void btnGo_Click_1(object sender, EventArgs e)
        {
            ShowPayments();
        }
        

        private void txtCustomerLName_TextChanged(object sender, EventArgs e)
        {
            cbxStore.SelectedIndex = -1;
            cbxStore.Text = "Select Store ... ";
        }

        private void frmPayments_Load(object sender, EventArgs e)
        {
            ShowPayments();
            loadStores();
        }

       

        private void dvgPayments_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                string payment_id = dvgPayments.Rows[e.RowIndex].Cells[0].Value.ToString();
                frmMoviesPay form = new frmMoviesPay(payment_id);
                form.Show();
            }
        }
    }
}
