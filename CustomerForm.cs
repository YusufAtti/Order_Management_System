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
    public partial class CustomerForm : Form
    {



        OrderManagementSystemEntities entities = new OrderManagementSystemEntities();

        public CustomerForm()
        {
            InitializeComponent();
        }

        private void btnClist_Click(object sender, EventArgs e)
        {
            AllUserList();
        }

        private void AllUserList()
        {
            var musterileri = entities.Customer.ToList();
            dataGridView1.DataSource = musterileri;
            dataGridView1.ClearSelection();
            ClearTextbox();
        }

        private void ClearTextbox()
        {
            txtCid.Text = "0";
            txtCname.Clear();
            txtCsurname.Clear();
            txtCcity.Clear();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            AllUserList();
            txtCid.Text = "0";
        }

        private void btnCAdd_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Ad = txtCname.Text;
            customer.Soyad = txtCsurname.Text;
            customer.Sehir = txtCcity.Text;

            try
            {

                entities.Customer.Add(customer);
                entities.SaveChanges();
                MessageBox.Show("Customer Added");
                AllUserList();

            }
            catch ( Exception ex)
            {
                MessageBox.Show("ERROR !! \n" + ex.Message);
            }

            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int SecilenSatir = dataGridView1.SelectedCells[0].RowIndex;
            txtCid.Text = dataGridView1.Rows[SecilenSatir].Cells[0].Value.ToString();
            txtCname.Text = dataGridView1.Rows[SecilenSatir].Cells[1].Value.ToString();
            txtCsurname.Text = dataGridView1.Rows[SecilenSatir].Cells[2].Value.ToString();
            txtCcity.Text = dataGridView1.Rows[SecilenSatir].Cells[3].Value.ToString();
        }

        private void btnCDelete_Click(object sender, EventArgs e)
        {
            try
            {

               int musteriId = Convert.ToInt32(txtCid.Text);
                var musteri = entities.Customer.Find(musteriId);
                entities.Customer.Remove(musteri);  
                entities.SaveChanges();
                MessageBox.Show("Customer Data Has Been Deleted");
                AllUserList();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR DELETE !! \n" + ex.Message);
            }
        }

        private void btnCupdate_Click(object sender, EventArgs e)
        {
            try
            {

                int musteriNo = Convert.ToInt32(txtCid.Text);
                var musteri = entities.Customer.Find(musteriNo);
                musteri.Ad = txtCname.Text;
                musteri.Soyad = txtCsurname.Text;
                musteri.Sehir = txtCcity.Text;
                entities.SaveChanges();
                MessageBox.Show("Customer Data Has Been Update");
                AllUserList();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR UPDATE !! \n" + ex.Message);
            }
        }
    }
}
