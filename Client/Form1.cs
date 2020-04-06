using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.ServiceClientProduct;
using Data;

namespace Client
{
    public partial class Form1 : Form
    {
        int secid;
        Urunler Securun;
        ServiceProductClient service = new ServiceProductClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)        
        {           
            dataGridView1.DataSource = service.GetProductsWin().ToList();
        }            

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            secid = (int)dataGridView1.CurrentRow.Cells[0].Value;
            Securun = service.FindProducts(secid);
            txt_id.Text = Securun.UrunId.ToString();
            txt_ad.Text = Securun.UrunAd;
            txt_bf.Text = Securun.BirimFiyat.ToString();
            cmb_kat.Text = Securun.KategoriAd.ToString();
    
            cmb_ted.Text = Securun.TedarikciAd.ToString();
            check_satilamaz.Checked = Securun.Satılamaz;
        }
        private void btn_sikl_Click(object sender, EventArgs e)
        {
            service.DeleteProducts(secid);
            button1_Click(null,null);
        }

        private void btn_guncel_Click(object sender, EventArgs e)
        {
            Securun.UrunAd = txt_ad.Text;
            Securun.KategoriId = (int)cmb_kat.SelectedValue;
            Securun.TedarikciId = (int)cmb_ted.SelectedValue;
            Securun.BirimFiyat = decimal.Parse(txt_bf.Text);
            service.Update(Securun.UrunId, Securun);          
            button1_Click(null, null);
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            Urunler yeniurun = new Urunler();
            yeniurun.UrunAd = txt_ad.Text;
            yeniurun.KategoriId = (int)cmb_kat.SelectedValue;
            yeniurun.TedarikciId = (int)cmb_ted.SelectedValue;
            yeniurun.BirimFiyat = decimal.Parse(txt_bf.Text);
             service.EntryProduct(yeniurun);
            button1_Click(null, null);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Urunler> liste = service.GetProductsWin().ToList();
            dataGridView1.DataSource = liste;

            cmb_kat.DataSource = service.DoldurCombo().CatDropDown.Select(x => new
            {
                x.KategoriId,
                x.KategoriAd
            }).ToList();
            cmb_kat.ValueMember = "KategoriId";
            cmb_kat.DisplayMember = "KategoriAd";

            cmb_ted.DataSource = service.DoldurCombo().SupDropDown.Select(x => new
            {
                x.TedarikciAd,
                x.TedarikciId
            }).ToList();
            cmb_ted.ValueMember = "TedarikciId";
            cmb_ted.DisplayMember = "TedarikciAd";
        }

        /*
         * 1)comboboxa selecte için değer atama
         * 2) web için droplist den caregory cekme
         * 3) cekilenleri categories içinden mi products içinde mi atıcaz?
         * 4)constroctor önemi
         * 5).SelectedValue kulanımı veya selectedındexden
         */
    }
}
