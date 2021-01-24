using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WritingInTextDocument
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            productsListBox.Items.Add(productTextBox.Text);

            productTextBox.Clear();
            productTextBox.Focus();

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var customer = new Customer();

            customer.name = nameTextBox.Text;
            customer.email = emailTextBox.Text;

            foreach (string item in productsListBox.Items)
            {
                customer.products.Add(item);
            }

            Data.Save(customer);

            nameTextBox.Clear();
            emailTextBox.Clear();
            productsListBox.Items.Clear();

            nameTextBox.Focus();
        }

    }
}
