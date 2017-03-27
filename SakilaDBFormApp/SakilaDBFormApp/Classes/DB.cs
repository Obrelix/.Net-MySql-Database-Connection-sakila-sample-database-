using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;
using System.Data;

namespace SakilaDBFormApp
{
    public static class DB
    {

        public static OdbcConnection Cn = new OdbcConnection();
        public static OdbcCommand Cmd;
        public static OdbcDataReader Reader;
        public static string ConnectionString;

        public static void Connect(string server, string port, string user, string password)
        {
            try
            {
                if (Cn == null)
                {
                    Cn = new OdbcConnection();
                }
                if (Cn.State != System.Data.ConnectionState.Open)
                {
                    Cn.ConnectionString = "Provider=MSDASQL.1" +
                            ";Driver={MySQL ODBC 5.3 UNICODE Driver}" +
                            ";Server=" + server +
                            ";Port=" + port +
                            ";Database=sakila" +
                            ";User=" + user +
                            ";Password=" + password +
                            ";Option=3";
                    Cn.Open();
                }
                if (Cmd == null)
                {
                    Cmd = new OdbcCommand();
                    Cmd.Connection = Cn;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public static void Disconnect()
        {
            try
            {
                if (Cn == null) return;
                if (Cn.State == ConnectionState.Closed) return;
                Cn.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

    }
}
