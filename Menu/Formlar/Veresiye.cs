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
    public partial class Veresiye : DevExpress.XtraEditors.XtraForm
    {
        public Veresiye()
        {
            InitializeComponent();
            Listele();
        }
        OtomasyonEntities Oe = new OtomasyonEntities();
        void Listele()
        {
            var degerler = (from x in Oe.VeresiyeListesi
                            select new
                            {
                                x.ID,
                                x.Ad,
                                x.Soyad,
                                x.Veresiye,
                                x.Telefon
                            }).ToList();
            grdVeresiye.DataSource = degerler;
        }

        private void Veresiye_Load(object sender, EventArgs e)
        {

        }

        private void btnVeresiyeYaz_Click(object sender, EventArgs e)
        {
            VeresiyeListesi Vl = new VeresiyeListesi();
            Vl.Ad = txtK_Adi.Text;
            Vl.Soyad = txtK_Soyadi.Text;
            Vl.Veresiye = txtK_Veresiye.Text;
            Vl.Telefon = txtK_Tel.Text;
            Oe.VeresiyeListesi.Add(Vl);
            Oe.SaveChanges();
            XtraMessageBox.Show("Veresiye Eklendi işlemi Başarıyla Gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void btnVeresiyeSil_Click(object sender, EventArgs e)
        {
            int s = int.Parse(txtID.Text);
            var deger = Oe.VeresiyeListesi.Find(s);
            Oe.VeresiyeListesi.Remove(deger);
            Oe.SaveChanges();
            XtraMessageBox.Show("Veresiye Silme işlemi Başarıyla Gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            Listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtID.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("ID"));
            txtK_Adi.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("Ad"));
            txtK_Soyadi.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("Soyad"));
            txtK_Veresiye.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("Veresiye"));
            txtK_Tel.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("Telefon"));
        }

        private void btnVeresiyeGüncelle_Click(object sender, EventArgs e)
        {
            int g = int.Parse(txtID.Text);
            var deger = Oe.VeresiyeListesi.Find(g);
            deger.Ad = txtK_Adi.Text;
            deger.Soyad = txtK_Soyadi.Text;
            deger.Veresiye = txtK_Veresiye.Text;
            deger.Telefon = txtK_Tel.Text;
            Oe.SaveChanges();
            XtraMessageBox.Show("Veresiye Güncelleme işlemi Başarıyla Gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Listele();
        }
    }
}