using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SakilaDBFormApp
{
    public partial class frmStart : Form
    {
        public frmStart()
        {
            InitializeComponent();
            showState();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            DB.Connect(frmConnection.serverIP, frmConnection.serverPort,
                frmConnection.userName, frmConnection.userPassword);
            showState();
            
        }

        private void showState()
        {
            pnlConnection.BackColor = (DB.Cn.State == ConnectionState.Open) ? Color.Green : Color.Red;
        }

        private void chbCoonectionForm_CheckedChanged(object sender, EventArgs e)
        {
            frmConnection form = new frmConnection();
            form.Show();
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            DB.Disconnect();
            showState();
        }

        private void btnMovies_Click(object sender, EventArgs e)
        {
            frmAdapterLight form = new frmAdapterLight();
            form.Show();
        }
    }
}
