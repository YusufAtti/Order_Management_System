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
    public partial class OrderForm : Form
    {

        OrderManagementSystemEntities entities = new OrderManagementSystemEntities();

        public OrderForm()
        {
            InitializeComponent();
        }

        private void btnOlist_Click(object sender, EventArgs e)
        {
            AllList();
        }

        private void AllList()
        {
            var siparisler = (from siparis in entities.Siparis
                              select new
                              {
                                  siparis.SiparisNo,
                                  siparis.Tarih,
                                  siparis.MusteriId,
                                  siparis.UrunId,
                                  siparis.Adet
                              }).ToList();
            dataGridView1.DataSource = siparisler;
        }

        private void btnOAdd_Click(object sender, EventArgs e)
        {

 

                Siparis siparis = new Siparis();
                siparis.Tarih = dateTimePicker1.Value;
                siparis.MusteriId = Convert.ToInt32(cmbCusId.SelectedValue.ToString());
                siparis.UrunId = Convert.ToInt32(cmbProdctId.SelectedValue.ToString());
                siparis.Adet = Convert.ToInt32(txtPpiece.Text);
                entities.Siparis.Add(siparis);
                entities.SaveChanges();
                AllList();

      

        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            var musteriler = (from musteri in entities.Customer
                              select new
                              {
                                  musteri.MusteriID,
                                  musteri.Ad,
                                  musteri.Soyad
                              }).ToList();
            cmbCusId.ValueMember = "CustomerID";
            cmbCusId.DisplayMember = "Ad" + " - " + "Soyad";
            cmbCusId.DataSource = musteriler;



            var urunler = (from urun in entities.Urun
                              select new
                              {
                                  urun.UrunID,
                                  urun.Adi,
                                  urun.Fiyat
                              }).ToList();
            cmbProdctId.ValueMember = "ProductID";
            cmbProdctId.DisplayMember = "Adi" + " - " + "Fiyat";
            cmbProdctId.DataSource = urunler;

        }
    }
}
