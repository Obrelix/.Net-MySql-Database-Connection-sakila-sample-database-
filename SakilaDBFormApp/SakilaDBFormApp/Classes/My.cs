using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SakilaDBFormApp
{
    public static class My
    {

        public static string Quote(string s)
        {

            string retv;

            retv = s.Replace("'", "''").Replace("\"", @"""").Replace("--", "");

            return "'" + @retv + "'";

        }

    }
}
