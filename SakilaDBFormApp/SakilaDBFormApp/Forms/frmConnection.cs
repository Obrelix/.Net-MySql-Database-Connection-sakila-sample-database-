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
    public partial class frmConnection : Form
    {
        public frmConnection()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            DB.Connect(txtbServer.Text, txtbPort.Text, txtbUser.Text, txtbPassword.Text);
            showState();
            
        }

        private void showState()
        {
            this.BackColor = (DB.Cn.State == ConnectionState.Open) ? Color.Green : Color.Red;
        }

        private void frmConnection_Load(object sender, EventArgs e)
        {
            showState();
        }

    }
}
