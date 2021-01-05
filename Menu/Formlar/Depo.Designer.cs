
namespace Menu.Formlar
{
    partial class Depo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Depo));
            this.grdDepo = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grpController = new DevExpress.XtraEditors.GroupControl();
            this.btnUrunGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnUrunSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnUrunEkle = new DevExpress.XtraEditors.SimpleButton();
            this.txtU_Fiyati = new DevExpress.XtraEditors.TextEdit();
            this.txtU_Miktari = new DevExpress.XtraEditors.TextEdit();
            this.txtU_Adi = new DevExpress.XtraEditors.TextEdit();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.lblU_Fiyat = new DevExpress.XtraEditors.LabelControl();
            this.lblU_Miktari = new DevExpress.XtraEditors.LabelControl();
            this.lblU_Adi = new DevExpress.XtraEditors.LabelControl();
            this.lblID = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grdDepo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpController)).BeginInit();
            this.grpController.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtU_Fiyati.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtU_Miktari.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtU_Adi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grdDepo
            // 
            this.grdDepo.Location = new System.Drawing.Point(0, 3);
            this.grdDepo.MainView = this.gridView1;
            this.grdDepo.Name = "grdDepo";
            this.grdDepo.Size = new System.Drawing.Size(700, 560);
            this.grdDepo.TabIndex = 0;
            this.grdDepo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdDepo;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // grpController
            // 
            this.grpController.Controls.Add(this.btnUrunGuncelle);
            this.grpController.Controls.Add(this.btnUrunSil);
            this.grpController.Controls.Add(this.btnUrunEkle);
            this.grpController.Controls.Add(this.txtU_Fiyati);
            this.grpController.Controls.Add(this.txtU_Miktari);
            this.grpController.Controls.Add(this.txtU_Adi);
            this.grpController.Controls.Add(this.txtID);
            this.grpController.Controls.Add(this.lblU_Fiyat);
            this.grpController.Controls.Add(this.lblU_Miktari);
            this.grpController.Controls.Add(this.lblU_Adi);
            this.grpController.Controls.Add(this.lblID);
            this.grpController.Location = new System.Drawing.Point(701, 3);
            this.grpController.Name = "grpController";
            this.grpController.Size = new System.Drawing.Size(315, 560);
            this.grpController.TabIndex = 1;
            this.grpController.Text = "Depo İşlemleri";
            // 
            // btnUrunGuncelle
            // 
            this.btnUrunGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnÜrünGuncelle.ImageOptions.Image")));
            this.btnUrunGuncelle.Location = new System.Drawing.Point(105, 380);
            this.btnUrunGuncelle.Name = "btnUrunGuncelle";
            this.btnUrunGuncelle.Size = new System.Drawing.Size(110, 45);
            this.btnUrunGuncelle.TabIndex = 10;
            this.btnUrunGuncelle.Text = "Ürün Güncelle";
            this.btnUrunGuncelle.Click += new System.EventHandler(this.btnUrunGuncelle_Click);
            // 
            // btnUrunSil
            // 
            this.btnUrunSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnÜrünSil.ImageOptions.Image")));
            this.btnUrunSil.Location = new System.Drawing.Point(180, 307);
            this.btnUrunSil.Name = "btnUrunSil";
            this.btnUrunSil.Size = new System.Drawing.Size(110, 45);
            this.btnUrunSil.TabIndex = 9;
            this.btnUrunSil.Text = "Ürün Sil";
            this.btnUrunSil.Click += new System.EventHandler(this.btnUrunSil_Click);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnÜrünEkle.ImageOptions.Image")));
            this.btnUrunEkle.Location = new System.Drawing.Point(25, 307);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(110, 45);
            this.btnUrunEkle.TabIndex = 8;
            this.btnUrunEkle.Text = "Ürün Ekle";
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // txtU_Fiyati
            // 
            this.txtU_Fiyati.Location = new System.Drawing.Point(105, 249);
            this.txtU_Fiyati.Name = "txtU_Fiyati";
            this.txtU_Fiyati.Size = new System.Drawing.Size(180, 20);
            this.txtU_Fiyati.TabIndex = 7;
            // 
            // txtU_Miktari
            // 
            this.txtU_Miktari.Location = new System.Drawing.Point(105, 184);
            this.txtU_Miktari.Name = "txtU_Miktari";
            this.txtU_Miktari.Size = new System.Drawing.Size(180, 20);
            this.txtU_Miktari.TabIndex = 6;
            // 
            // txtU_Adi
            // 
            this.txtU_Adi.Location = new System.Drawing.Point(105, 119);
            this.txtU_Adi.Name = "txtU_Adi";
            this.txtU_Adi.Size = new System.Drawing.Size(180, 20);
            this.txtU_Adi.TabIndex = 5;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(105, 52);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(180, 20);
            this.txtID.TabIndex = 4;
            // 
            // lblU_Fiyat
            // 
            this.lblU_Fiyat.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblU_Fiyat.Appearance.Options.UseFont = true;
            this.lblU_Fiyat.Location = new System.Drawing.Point(17, 250);
            this.lblU_Fiyat.Name = "lblU_Fiyat";
            this.lblU_Fiyat.Size = new System.Drawing.Size(75, 19);
            this.lblU_Fiyat.TabIndex = 3;
            this.lblU_Fiyat.Text = "Birim Fiyat";
            // 
            // lblU_Miktari
            // 
            this.lblU_Miktari.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblU_Miktari.Appearance.Options.UseFont = true;
            this.lblU_Miktari.Location = new System.Drawing.Point(5, 185);
            this.lblU_Miktari.Name = "lblU_Miktari";
            this.lblU_Miktari.Size = new System.Drawing.Size(87, 19);
            this.lblU_Miktari.TabIndex = 2;
            this.lblU_Miktari.Text = "Ürün Miktarı";
            // 
            // lblU_Adi
            // 
            this.lblU_Adi.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblU_Adi.Appearance.Options.UseFont = true;
            this.lblU_Adi.Location = new System.Drawing.Point(32, 120);
            this.lblU_Adi.Name = "lblU_Adi";
            this.lblU_Adi.Size = new System.Drawing.Size(60, 19);
            this.lblU_Adi.TabIndex = 1;
            this.lblU_Adi.Text = "Ürün Ad";
            // 
            // lblID
            // 
            this.lblID.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblID.Appearance.Options.UseFont = true;
            this.lblID.Location = new System.Drawing.Point(75, 55);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(17, 19);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // Depo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 568);
            this.Controls.Add(this.grpController);
            this.Controls.Add(this.grdDepo);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Depo.IconOptions.LargeImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Depo";
            this.Text = "Depo";
            ((System.ComponentModel.ISupportInitialize)(this.grdDepo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpController)).EndInit();
            this.grpController.ResumeLayout(false);
            this.grpController.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtU_Fiyati.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtU_Miktari.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtU_Adi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdDepo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl grpController;
        private DevExpress.XtraEditors.LabelControl lblU_Fiyat;
        private DevExpress.XtraEditors.LabelControl lblU_Miktari;
        private DevExpress.XtraEditors.LabelControl lblU_Adi;
        private DevExpress.XtraEditors.LabelControl lblID;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.TextEdit txtU_Fiyati;
        private DevExpress.XtraEditors.TextEdit txtU_Miktari;
        private DevExpress.XtraEditors.TextEdit txtU_Adi;
        private DevExpress.XtraEditors.SimpleButton btnUrunGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnUrunSil;
        private DevExpress.XtraEditors.SimpleButton btnUrunEkle;
    }
}