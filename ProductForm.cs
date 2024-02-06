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
    public partial class ProductForm : Form
    {


        OrderManagementSystemEntities entities = new OrderManagementSystemEntities();
       

        public ProductForm()
        {
            InitializeComponent();
        }

        private void btnPlist_Click(object sender, EventArgs e)
        {
            AllProductList();
        }

        private void AllProductList()
        {
            var product = entities.Urun.ToList();
            dataGridView1.DataSource = product;
            dataGridView1.ClearSelection();
            ClearTextbox();
        }

        private void ClearTextbox()
        {
            txtPid.Text = "0";
            txtPName.Clear();
            txtPprice.Clear();
          
        }

        private void btnPAdd_Click(object sender, EventArgs e)
        {
            Urun urun = new Urun();
            urun.Adi =  txtPName.Text;
            urun.Fiyat = Convert.ToInt32(txtPprice.Text);
           

            try
            {

                entities.Urun.Add(urun);
                entities.SaveChanges();
                MessageBox.Show("Product Added");
                AllProductList();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR !! \n" + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int SecilenSatir = dataGridView1.SelectedCells[0].RowIndex;
            txtPid.Text = dataGridView1.Rows[SecilenSatir].Cells[0].Value.ToString();
            txtPName.Text = dataGridView1.Rows[SecilenSatir].Cells[1].Value.ToString();
            txtPprice.Text = dataGridView1.Rows[SecilenSatir].Cells[2].Value.ToString();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            AllProductList();
            txtPid.Text = "0";
        }

        private void btnPDelete_Click(object sender, EventArgs e)
        {
            try
            {

                int productId = Convert.ToInt32(txtPid.Text);
                var product = entities.Urun.Find(productId);
                entities.Urun.Remove(product);
                entities.SaveChanges();
                MessageBox.Show("Product Data Has Been Deleted");
                AllProductList();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR DELETE !! \n" + ex.Message);
            }
        }

        private void btnPupdate_Click(object sender, EventArgs e)
        {
            try
            {

                int productId = Convert.ToInt32(txtPid.Text);
                var product = entities.Urun.Find(productId);
                product.Adi =txtPName.Text;
                product.Fiyat = Convert.ToInt32(txtPprice.Text);
                entities.SaveChanges();
                MessageBox.Show("Product Data Has Been Update");
                AllProductList();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR UPDATE !! \n" + ex.Message);
            }
        }
    }
}
