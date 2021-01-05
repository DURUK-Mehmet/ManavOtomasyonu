
namespace Menu.Formlar
{
    partial class AnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            this.grdAnasayfa = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grpController = new DevExpress.XtraEditors.GroupControl();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.lblID = new DevExpress.XtraEditors.LabelControl();
            this.btnUrunİade = new DevExpress.XtraEditors.SimpleButton();
            this.btnUrunHesapla = new DevExpress.XtraEditors.SimpleButton();
            this.txtMiktar = new DevExpress.XtraEditors.TextEdit();
            this.lueUrunAdi = new DevExpress.XtraEditors.LookUpEdit();
            this.txtToplamFiyat = new DevExpress.XtraEditors.TextEdit();
            this.btnUrunSat = new DevExpress.XtraEditors.SimpleButton();
            this.lblUrunFiyatı = new DevExpress.XtraEditors.LabelControl();
            this.lblUrunMiktari = new DevExpress.XtraEditors.LabelControl();
            this.lblUrunAdi = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grdAnasayfa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpController)).BeginInit();
            this.grpController.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMiktar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueUrunAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToplamFiyat.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grdAnasayfa
            // 
            this.grdAnasayfa.Location = new System.Drawing.Point(0, 3);
            this.grdAnasayfa.MainView = this.gridView1;
            this.grdAnasayfa.Name = "grdAnasayfa";
            this.grdAnasayfa.Size = new System.Drawing.Size(700, 560);
            this.grdAnasayfa.TabIndex = 0;
            this.grdAnasayfa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdAnasayfa;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // grpController
            // 
            this.grpController.Controls.Add(this.txtID);
            this.grpController.Controls.Add(this.lblID);
            this.grpController.Controls.Add(this.btnUrunİade);
            this.grpController.Controls.Add(this.btnUrunHesapla);
            this.grpController.Controls.Add(this.txtMiktar);
            this.grpController.Controls.Add(this.lueUrunAdi);
            this.grpController.Controls.Add(this.txtToplamFiyat);
            this.grpController.Controls.Add(this.btnUrunSat);
            this.grpController.Controls.Add(this.lblUrunFiyatı);
            this.grpController.Controls.Add(this.lblUrunMiktari);
            this.grpController.Controls.Add(this.lblUrunAdi);
            this.grpController.Location = new System.Drawing.Point(701, 3);
            this.grpController.Name = "grpController";
            this.grpController.Size = new System.Drawing.Size(315, 560);
            this.grpController.TabIndex = 1;
            this.grpController.Text = "Anasayfa İşlemleri";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(134, 44);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(99, 20);
            this.txtID.TabIndex = 12;
            // 
            // lblID
            // 
            this.lblID.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblID.Appearance.Options.UseFont = true;
            this.lblID.Location = new System.Drawing.Point(80, 45);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(17, 19);
            this.lblID.TabIndex = 11;
            this.lblID.Text = "ID";
            // 
            // btnUrunİade
            // 
            this.btnUrunİade.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnİade.ImageOptions.Image")));
            this.btnUrunİade.Location = new System.Drawing.Point(178, 315);
            this.btnUrunİade.Name = "btnUrunİade";
            this.btnUrunİade.Size = new System.Drawing.Size(90, 40);
            this.btnUrunİade.TabIndex = 10;
            this.btnUrunİade.Text = "Geri İade";
            this.btnUrunİade.Click += new System.EventHandler(this.btnUrunİade_Click);
            // 
            // btnUrunHesapla
            // 
            this.btnUrunHesapla.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunHesapla.Appearance.Options.UseFont = true;
            this.btnUrunHesapla.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHesapla.ImageOptions.Image")));
            this.btnUrunHesapla.Location = new System.Drawing.Point(134, 169);
            this.btnUrunHesapla.Name = "btnUrunHesapla";
            this.btnUrunHesapla.Size = new System.Drawing.Size(99, 49);
            this.btnUrunHesapla.TabIndex = 3;
            this.btnUrunHesapla.Text = "Hesapla";
            this.btnUrunHesapla.Click += new System.EventHandler(this.btnUrunHesapla_Click);
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(134, 134);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(99, 20);
            this.txtMiktar.TabIndex = 2;
            // 
            // lueUrunAdi
            // 
            this.lueUrunAdi.EditValue = "";
            this.lueUrunAdi.Location = new System.Drawing.Point(134, 89);
            this.lueUrunAdi.Name = "lueUrunAdi";
            this.lueUrunAdi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueUrunAdi.Size = new System.Drawing.Size(144, 20);
            this.lueUrunAdi.TabIndex = 1;
            // 
            // txtToplamFiyat
            // 
            this.txtToplamFiyat.Enabled = false;
            this.txtToplamFiyat.Location = new System.Drawing.Point(134, 247);
            this.txtToplamFiyat.Name = "txtToplamFiyat";
            this.txtToplamFiyat.Size = new System.Drawing.Size(100, 20);
            this.txtToplamFiyat.TabIndex = 4;
            // 
            // btnUrunSat
            // 
            this.btnUrunSat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUrunSat.ImageOptions.Image")));
            this.btnUrunSat.Location = new System.Drawing.Point(37, 315);
            this.btnUrunSat.Name = "btnUrunSat";
            this.btnUrunSat.Size = new System.Drawing.Size(90, 40);
            this.btnUrunSat.TabIndex = 2;
            this.btnUrunSat.Text = "Sat";
            this.btnUrunSat.Click += new System.EventHandler(this.btnButtonSat_Click);
            // 
            // lblUrunFiyatı
            // 
            this.lblUrunFiyatı.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunFiyatı.Appearance.Options.UseFont = true;
            this.lblUrunFiyatı.Location = new System.Drawing.Point(5, 250);
            this.lblUrunFiyatı.Name = "lblUrunFiyatı";
            this.lblUrunFiyatı.Size = new System.Drawing.Size(92, 19);
            this.lblUrunFiyatı.TabIndex = 2;
            this.lblUrunFiyatı.Text = "Toplam Fiyat";
            // 
            // lblUrunMiktari
            // 
            this.lblUrunMiktari.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunMiktari.Appearance.Options.UseFont = true;
            this.lblUrunMiktari.Location = new System.Drawing.Point(14, 132);
            this.lblUrunMiktari.Name = "lblUrunMiktari";
            this.lblUrunMiktari.Size = new System.Drawing.Size(87, 19);
            this.lblUrunMiktari.TabIndex = 1;
            this.lblUrunMiktari.Text = "Ürün Miktarı";
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunAdi.Appearance.Options.UseFont = true;
            this.lblUrunAdi.Location = new System.Drawing.Point(37, 90);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(64, 19);
            this.lblUrunAdi.TabIndex = 0;
            this.lblUrunAdi.Text = "Ürün Adı";
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 568);
            this.Controls.Add(this.grpController);
            this.Controls.Add(this.grdAnasayfa);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("AnaSayfa.IconOptions.LargeImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AnaSayfa";
            this.ShowInTaskbar = false;
            this.Text = "AnaSayfa";
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdAnasayfa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpController)).EndInit();
            this.grpController.ResumeLayout(false);
            this.grpController.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMiktar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueUrunAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToplamFiyat.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdAnasayfa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl grpController;
        private DevExpress.XtraEditors.LabelControl lblUrunFiyatı;
        private DevExpress.XtraEditors.LabelControl lblUrunMiktari;
        private DevExpress.XtraEditors.LabelControl lblUrunAdi;
        private DevExpress.XtraEditors.SimpleButton btnUrunSat;
        private DevExpress.XtraEditors.TextEdit txtToplamFiyat;
        private DevExpress.XtraEditors.LookUpEdit lueUrunAdi;
        private DevExpress.XtraEditors.TextEdit txtMiktar;
        private DevExpress.XtraEditors.SimpleButton btnUrunHesapla;
        private DevExpress.XtraEditors.SimpleButton btnUrunİade;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.LabelControl lblID;
    }
}