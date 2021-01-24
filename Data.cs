using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WritingInTextDocument
{
    public static class Data
    {
        public static void Save(Customer customer)
        {
            string myDocs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string fileName = "customersProducts.txt";
            string fullName = Path.Combine(myDocs, fileName);

            using(var streamWriter = new StreamWriter(fullName, true, Encoding.UTF8))
            {
                streamWriter.WriteLine(DateTime.Now.ToString("d"));
                streamWriter.WriteLine(customer.name);
                streamWriter.WriteLine(customer.email);
                
                foreach(string product in customer.products)
                {
                    streamWriter.WriteLine(" - " + product);
                }

                streamWriter.WriteLine("---------------------");
                streamWriter.Close();
            }
        }
    }
}
