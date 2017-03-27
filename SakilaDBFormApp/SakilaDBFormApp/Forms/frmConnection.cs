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
        public static string serverIP = "127.0.0.1", serverPort = "3306",
            userName = "root", userPassword = "";


        public frmConnection()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            serverIP = txtbServer.Text;
            serverPort = txtbPort.Text;
            userName = txtbUser.Text;
            userPassword = txtbPassword.Text;

            DB.Connect(frmConnection.serverIP, frmConnection.serverPort, 
                frmConnection.userName, frmConnection.userPassword);
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
