using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SakilaDBFormApp
{
    public class CategoryID
    {
        public string id { get; set; }
        public string name { get; set; }

        public CategoryID(string id, string title)
        {
            this.id = id;
            this.name = title;
        }

    }
}
    

