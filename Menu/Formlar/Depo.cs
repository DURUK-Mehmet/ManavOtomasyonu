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

namespace Menu.Formlar
{
    public partial class Depo : DevExpress.XtraEditors.XtraForm
    {
        public Depo()
        {
            InitializeComponent();
            Listele();
        }
        OtomasyonEntities Oe = new OtomasyonEntities();

        void Listele()
        {
            var degerler = (from x in Oe.UrunListesi
                            select new
                            {
                                x.ID,
                                x.Ad,
                                x.Miktar,
                                x.Fiyat
                            }).ToList();
            grdDepo.DataSource = degerler.ToList();
        }
        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            UrunListesi Ul = new UrunListesi();
            Ul.Ad = txtU_Adi.Text;
            Ul.Miktar = txtU_Miktari.Text;
            Ul.Fiyat = txtU_Fiyati.Text;
            Oe.UrunListesi.Add(Ul);
            Oe.SaveChanges();
            XtraMessageBox.Show("Ürün Başarıyla Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            int s = int.Parse(txtID.Text);
            var deger = Oe.UrunListesi.Find(s);
            Oe.UrunListesi.Remove(deger);
            Oe.SaveChanges();
            XtraMessageBox.Show("Ürün Silme işlemi Başarıyla Gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            Listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtID.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("ID"));
            txtU_Adi.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("Ad"));
            txtU_Miktari.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("Miktar"));
            txtU_Fiyati.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("Fiyat"));
        }

        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            int g = int.Parse(txtID.Text);
            var deger = Oe.UrunListesi.Find(g);
            deger.Ad = txtU_Adi.Text;
            deger.Miktar = txtU_Miktari.Text;
            deger.Fiyat = txtU_Fiyati.Text;
            Oe.SaveChanges();
            XtraMessageBox.Show("Ürün Güncelleme işlemi Başarıyla Gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Listele();
        }
    }
}