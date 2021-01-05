using Menu.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Menu
{
    public partial class Giris : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void btnHesapMakinasi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\WINDOWS\SYSTEM32\calc.exe");
        }

        private void btnAnaSayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.AnaSayfa frm = new Formlar.AnaSayfa();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnVeresiyeListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Veresiye frm = new Formlar.Veresiye();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnDepoListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Depo frm = new Formlar.Depo();
            frm.MdiParent = this;
            frm.Show();
        }
 
    }
}
