using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WritingInTextDocument
{
    public class Customer
    {
        public string name { get; set; }
        public string email { get; set; }
        public List<string> products { get; set; }

        public Customer()
        {
            products = new List<string>();
        }

    }
}
