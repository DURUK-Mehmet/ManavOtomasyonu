using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menu.Entity;
using DevExpress.Utils.Extensions;

namespace Menu.Formlar
{
    public partial class AnaSayfa : DevExpress.XtraEditors.XtraForm
    {
        public AnaSayfa()
        {
            InitializeComponent();
            Listele();
        }
        OtomasyonEntities Oe = new OtomasyonEntities();
        void Listele()
        {
            var degerler = (from x in Oe.SonSatisler
                            select new
                            {
                                x.ID,
                                x.Ad,
                                x.Miktar,
                                x.Fiyat
                            }).ToList();
            grdAnasayfa.DataSource = degerler;
        }
        static int fiyat;
        static public int Hesaplama(int adet, int birimFiyat)
        {
            fiyat = adet * birimFiyat;
            return fiyat;
        }
        private void btnButtonSat_Click(object sender, EventArgs e)
        {
            int Miktar = Convert.ToInt32(txtMiktar.Text);
            int g = int.Parse(lueUrunAdi.EditValue.ToString());
            var deger = Oe.UrunListesi.Find(g);
            int birimFiyat = Convert.ToInt32(deger.Fiyat);
            SonSatisler u = new SonSatisler();
            String urunAdi = deger.Ad;
            u.Ad = urunAdi;
            u.Miktar = Miktar;
            Hesaplama(Miktar, birimFiyat);
            u.Fiyat = Convert.ToString(fiyat);
            Oe.SonSatisler.Add(u);
            Oe.SaveChanges();
            XtraMessageBox.Show("İşlem başarıyla gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


            Listele();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            var urunAd = (from x in Oe.UrunListesi
                          select new
                          {
                              x.ID,
                              x.Ad
                          }).ToList();
            lueUrunAdi.Properties.ValueMember = "ID";
            lueUrunAdi.Properties.DisplayMember = "Ad";
            lueUrunAdi.Properties.DataSource = urunAd;

        }

        private void btnUrunHesapla_Click(object sender, EventArgs e)
        {
            SonSatisler u = new SonSatisler();
            int Miktar = Convert.ToInt32(txtMiktar.Text);
            int g = int.Parse(lueUrunAdi.EditValue.ToString());
            var deger = Oe.UrunListesi.Find(g);
            int birimFiyat = Convert.ToInt32(deger.Fiyat);
            Hesaplama(Miktar, birimFiyat);
            txtToplamFiyat.Text = Convert.ToString(fiyat);
        }

        private void btnUrunİade_Click(object sender, EventArgs e)
        {

            int s = int.Parse(txtID.Text);
            var deger = Oe.SonSatisler.Find(s);
            Oe.SonSatisler.Remove(deger);
            Oe.SaveChanges();
            XtraMessageBox.Show("Geri İade işlemi Başarıyla Gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            Listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtID.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("ID"));
            txtMiktar.Text =Convert.ToString(gridView1.GetFocusedRowCellValue("Miktar"));
            txtToplamFiyat.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("Fiyat"));
        }
    }
}