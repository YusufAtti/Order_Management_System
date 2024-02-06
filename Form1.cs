using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Order_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
               OrderForm orderForm = new OrderForm();
               orderForm.Show();
        }
    }
}
