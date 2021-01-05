
namespace Menu.Formlar
{
    partial class Veresiye
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Veresiye));
            this.grdVeresiye = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grpController = new DevExpress.XtraEditors.GroupControl();
            this.btnVeresiyeGüncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnVeresiyeSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnVeresiyeYaz = new DevExpress.XtraEditors.SimpleButton();
            this.txtK_Tel = new DevExpress.XtraEditors.TextEdit();
            this.txtK_Veresiye = new DevExpress.XtraEditors.TextEdit();
            this.txtK_Soyadi = new DevExpress.XtraEditors.TextEdit();
            this.txtK_Adi = new DevExpress.XtraEditors.TextEdit();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.lblK_Tel = new DevExpress.XtraEditors.LabelControl();
            this.lblK_Veresiye = new DevExpress.XtraEditors.LabelControl();
            this.lblK_Soyadi = new DevExpress.XtraEditors.LabelControl();
            this.lblK_Adi = new DevExpress.XtraEditors.LabelControl();
            this.lblID = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grdVeresiye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpController)).BeginInit();
            this.grpController.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtK_Tel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtK_Veresiye.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtK_Soyadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtK_Adi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grdVeresiye
            // 
            this.grdVeresiye.Location = new System.Drawing.Point(0, 3);
            this.grdVeresiye.MainView = this.gridView1;
            this.grdVeresiye.Name = "grdVeresiye";
            this.grdVeresiye.Size = new System.Drawing.Size(700, 560);
            this.grdVeresiye.TabIndex = 0;
            this.grdVeresiye.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdVeresiye;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // grpController
            // 
            this.grpController.Controls.Add(this.btnVeresiyeGüncelle);
            this.grpController.Controls.Add(this.btnVeresiyeSil);
            this.grpController.Controls.Add(this.btnVeresiyeYaz);
            this.grpController.Controls.Add(this.txtK_Tel);
            this.grpController.Controls.Add(this.txtK_Veresiye);
            this.grpController.Controls.Add(this.txtK_Soyadi);
            this.grpController.Controls.Add(this.txtK_Adi);
            this.grpController.Controls.Add(this.txtID);
            this.grpController.Controls.Add(this.lblK_Tel);
            this.grpController.Controls.Add(this.lblK_Veresiye);
            this.grpController.Controls.Add(this.lblK_Soyadi);
            this.grpController.Controls.Add(this.lblK_Adi);
            this.grpController.Controls.Add(this.lblID);
            this.grpController.Location = new System.Drawing.Point(701, 3);
            this.grpController.Name = "grpController";
            this.grpController.Size = new System.Drawing.Size(315, 560);
            this.grpController.TabIndex = 1;
            this.grpController.Text = "Veresiye İşlemleri";
            // 
            // btnVeresiyeGüncelle
            // 
            this.btnVeresiyeGüncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ButtonVeresiyeGüncelle.ImageOptions.Image")));
            this.btnVeresiyeGüncelle.Location = new System.Drawing.Point(93, 392);
            this.btnVeresiyeGüncelle.Name = "btnVeresiyeGüncelle";
            this.btnVeresiyeGüncelle.Size = new System.Drawing.Size(130, 45);
            this.btnVeresiyeGüncelle.TabIndex = 12;
            this.btnVeresiyeGüncelle.Text = "Veresiye Güncelle";
            this.btnVeresiyeGüncelle.Click += new System.EventHandler(this.btnVeresiyeGüncelle_Click);
            // 
            // btnVeresiyeSil
            // 
            this.btnVeresiyeSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ButtonVeresiyeSil.ImageOptions.Image")));
            this.btnVeresiyeSil.Location = new System.Drawing.Point(185, 324);
            this.btnVeresiyeSil.Name = "btnVeresiyeSil";
            this.btnVeresiyeSil.Size = new System.Drawing.Size(110, 45);
            this.btnVeresiyeSil.TabIndex = 11;
            this.btnVeresiyeSil.Text = "Veresiye Sil";
            this.btnVeresiyeSil.Click += new System.EventHandler(this.btnVeresiyeSil_Click);
            // 
            // btnVeresiyeYaz
            // 
            this.btnVeresiyeYaz.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ButtonVeresiyeYaz.ImageOptions.Image")));
            this.btnVeresiyeYaz.Location = new System.Drawing.Point(20, 324);
            this.btnVeresiyeYaz.Name = "btnVeresiyeYaz";
            this.btnVeresiyeYaz.Size = new System.Drawing.Size(110, 45);
            this.btnVeresiyeYaz.TabIndex = 10;
            this.btnVeresiyeYaz.Text = "Veresiye Yaz";
            this.btnVeresiyeYaz.Click += new System.EventHandler(this.btnVeresiyeYaz_Click);
            // 
            // txtK_Tel
            // 
            this.txtK_Tel.Location = new System.Drawing.Point(105, 259);
            this.txtK_Tel.Name = "txtK_Tel";
            this.txtK_Tel.Size = new System.Drawing.Size(180, 20);
            this.txtK_Tel.TabIndex = 5;
            // 
            // txtK_Veresiye
            // 
            this.txtK_Veresiye.Location = new System.Drawing.Point(105, 209);
            this.txtK_Veresiye.Name = "txtK_Veresiye";
            this.txtK_Veresiye.Size = new System.Drawing.Size(180, 20);
            this.txtK_Veresiye.TabIndex = 4;
            // 
            // txtK_Soyadi
            // 
            this.txtK_Soyadi.Location = new System.Drawing.Point(105, 159);
            this.txtK_Soyadi.Name = "txtK_Soyadi";
            this.txtK_Soyadi.Size = new System.Drawing.Size(180, 20);
            this.txtK_Soyadi.TabIndex = 3;
            // 
            // txtK_Adi
            // 
            this.txtK_Adi.Location = new System.Drawing.Point(105, 109);
            this.txtK_Adi.Name = "txtK_Adi";
            this.txtK_Adi.Size = new System.Drawing.Size(180, 20);
            this.txtK_Adi.TabIndex = 2;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(105, 59);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(180, 20);
            this.txtID.TabIndex = 1;
            // 
            // lblK_Tel
            // 
            this.lblK_Tel.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblK_Tel.Appearance.Options.UseFont = true;
            this.lblK_Tel.Location = new System.Drawing.Point(5, 260);
            this.lblK_Tel.Name = "lblK_Tel";
            this.lblK_Tel.Size = new System.Drawing.Size(78, 19);
            this.lblK_Tel.TabIndex = 4;
            this.lblK_Tel.Text = "Telefon No";
            // 
            // lblK_Veresiye
            // 
            this.lblK_Veresiye.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblK_Veresiye.Appearance.Options.UseFont = true;
            this.lblK_Veresiye.Location = new System.Drawing.Point(24, 210);
            this.lblK_Veresiye.Name = "lblK_Veresiye";
            this.lblK_Veresiye.Size = new System.Drawing.Size(59, 19);
            this.lblK_Veresiye.TabIndex = 3;
            this.lblK_Veresiye.Text = "Veresiye";
            // 
            // lblK_Soyadi
            // 
            this.lblK_Soyadi.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblK_Soyadi.Appearance.Options.UseFont = true;
            this.lblK_Soyadi.Location = new System.Drawing.Point(7, 160);
            this.lblK_Soyadi.Name = "lblK_Soyadi";
            this.lblK_Soyadi.Size = new System.Drawing.Size(76, 19);
            this.lblK_Soyadi.TabIndex = 2;
            this.lblK_Soyadi.Text = "Kişi Soyadı";
            // 
            // lblK_Adi
            // 
            this.lblK_Adi.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblK_Adi.Appearance.Options.UseFont = true;
            this.lblK_Adi.Location = new System.Drawing.Point(30, 112);
            this.lblK_Adi.Name = "lblK_Adi";
            this.lblK_Adi.Size = new System.Drawing.Size(53, 19);
            this.lblK_Adi.TabIndex = 1;
            this.lblK_Adi.Text = "Kişi Adı";
            // 
            // lblID
            // 
            this.lblID.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblID.Appearance.Options.UseFont = true;
            this.lblID.Location = new System.Drawing.Point(66, 62);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(17, 19);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // Veresiye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 568);
            this.Controls.Add(this.grpController);
            this.Controls.Add(this.grdVeresiye);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Veresiye.IconOptions.LargeImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Veresiye";
            this.Text = "Veresiye";
            this.Load += new System.EventHandler(this.Veresiye_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdVeresiye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpController)).EndInit();
            this.grpController.ResumeLayout(false);
            this.grpController.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtK_Tel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtK_Veresiye.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtK_Soyadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtK_Adi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdVeresiye;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl grpController;
        private DevExpress.XtraEditors.LabelControl lblK_Tel;
        private DevExpress.XtraEditors.LabelControl lblK_Veresiye;
        private DevExpress.XtraEditors.LabelControl lblK_Soyadi;
        private DevExpress.XtraEditors.LabelControl lblK_Adi;
        private DevExpress.XtraEditors.LabelControl lblID;
        private DevExpress.XtraEditors.TextEdit txtK_Tel;
        private DevExpress.XtraEditors.TextEdit txtK_Veresiye;
        private DevExpress.XtraEditors.TextEdit txtK_Soyadi;
        private DevExpress.XtraEditors.TextEdit txtK_Adi;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.SimpleButton btnVeresiyeGüncelle;
        private DevExpress.XtraEditors.SimpleButton btnVeresiyeSil;
        private DevExpress.XtraEditors.SimpleButton btnVeresiyeYaz;
    }
}