
namespace Menu
{
    partial class Giris
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnAnaSayfa = new DevExpress.XtraBars.BarButtonItem();
            this.btnHesapMakinasi = new DevExpress.XtraBars.BarButtonItem();
            this.btnVeresiyeListesi = new DevExpress.XtraBars.BarButtonItem();
            this.btnDepoListesi = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnAnaSayfa,
            this.btnHesapMakinasi,
            this.btnVeresiyeListesi,
            this.btnDepoListesi});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 15;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3});
            this.ribbonControl1.Size = new System.Drawing.Size(1022, 158);
            // 
            // btnAnaSayfa
            // 
            this.btnAnaSayfa.Caption = "Ana Sayfa";
            this.btnAnaSayfa.Id = 4;
            this.btnAnaSayfa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAnaSayfa.ImageOptions.Image")));
            this.btnAnaSayfa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAnaSayfa.ImageOptions.LargeImage")));
            this.btnAnaSayfa.Name = "btnAnaSayfa";
            this.btnAnaSayfa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAnaSayfa_ItemClick);
            // 
            // btnHesapMakinasi
            // 
            this.btnHesapMakinasi.Caption = "Hesap Makinası";
            this.btnHesapMakinasi.Id = 5;
            this.btnHesapMakinasi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHesapMakinasi.ImageOptions.Image")));
            this.btnHesapMakinasi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHesapMakinasi.ImageOptions.LargeImage")));
            this.btnHesapMakinasi.Name = "btnHesapMakinasi";
            this.btnHesapMakinasi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHesapMakinasi_ItemClick);
            // 
            // btnVeresiyeListesi
            // 
            this.btnVeresiyeListesi.Caption = "Veresiye Listesi";
            this.btnVeresiyeListesi.Id = 7;
            this.btnVeresiyeListesi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnVeresiyeListesi.ImageOptions.Image")));
            this.btnVeresiyeListesi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnVeresiyeListesi.ImageOptions.LargeImage")));
            this.btnVeresiyeListesi.Name = "btnVeresiyeListesi";
            this.btnVeresiyeListesi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnVeresiyeListesi_ItemClick);
            // 
            // btnDepoListesi
            // 
            this.btnDepoListesi.Caption = "Depo Listele";
            this.btnDepoListesi.Id = 11;
            this.btnDepoListesi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("DepoListesi.ImageOptions.Image")));
            this.btnDepoListesi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("DepoListesi.ImageOptions.LargeImage")));
            this.btnDepoListesi.Name = "btnDepoListesi";
            this.btnDepoListesi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDepoListesi_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup4});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Ana Sayfa";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnAnaSayfa);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnHesapMakinasi);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Veresiye";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnVeresiyeListesi);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup7});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Depo";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.btnDepoListesi);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 749);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Giris";
            this.Ribbon = this.ribbonControl1;
            this.Text = "---Market---";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnAnaSayfa;
        private DevExpress.XtraBars.BarButtonItem btnHesapMakinasi;
        private DevExpress.XtraBars.BarButtonItem btnVeresiyeListesi;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnDepoListesi;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}

