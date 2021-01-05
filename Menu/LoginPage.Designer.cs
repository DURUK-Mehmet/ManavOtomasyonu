
namespace Menu
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.lblK_Adi = new DevExpress.XtraEditors.LabelControl();
            this.lblK_Sifre = new DevExpress.XtraEditors.LabelControl();
            this.txtGirisAd = new DevExpress.XtraEditors.TextEdit();
            this.btnGiris = new DevExpress.XtraEditors.SimpleButton();
            this.txtGirisSifre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtGirisAd.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblK_Adi
            // 
            this.lblK_Adi.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblK_Adi.Appearance.Options.UseFont = true;
            this.lblK_Adi.Location = new System.Drawing.Point(93, 29);
            this.lblK_Adi.Name = "lblK_Adi";
            this.lblK_Adi.Size = new System.Drawing.Size(87, 19);
            this.lblK_Adi.TabIndex = 0;
            this.lblK_Adi.Text = "Kullanıcı Adı";
            // 
            // lblK_Sifre
            // 
            this.lblK_Sifre.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblK_Sifre.Appearance.Options.UseFont = true;
            this.lblK_Sifre.Location = new System.Drawing.Point(85, 76);
            this.lblK_Sifre.Name = "lblK_Sifre";
            this.lblK_Sifre.Size = new System.Drawing.Size(95, 19);
            this.lblK_Sifre.TabIndex = 1;
            this.lblK_Sifre.Text = "Kullanıcı Şifre";
            // 
            // txtGirisAd
            // 
            this.txtGirisAd.Location = new System.Drawing.Point(218, 28);
            this.txtGirisAd.Name = "txtGirisAd";
            this.txtGirisAd.Size = new System.Drawing.Size(150, 20);
            this.txtGirisAd.TabIndex = 1;
            // 
            // btnGiris
            // 
            this.btnGiris.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGiris.ImageOptions.Image")));
            this.btnGiris.Location = new System.Drawing.Point(231, 114);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(120, 46);
            this.btnGiris.TabIndex = 3;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // txtGirisSifre
            // 
            this.txtGirisSifre.Location = new System.Drawing.Point(218, 74);
            this.txtGirisSifre.Name = "txtGirisSifre";
            this.txtGirisSifre.Size = new System.Drawing.Size(150, 21);
            this.txtGirisSifre.TabIndex = 2;
            this.txtGirisSifre.UseSystemPasswordChar = true;
            // 
            // LoginPage
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 268);
            this.Controls.Add(this.txtGirisSifre);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtGirisAd);
            this.Controls.Add(this.lblK_Sifre);
            this.Controls.Add(this.lblK_Adi);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("LoginPage.IconOptions.LargeImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginPage";
            this.Text = "Kullanıcı Girişi";
            ((System.ComponentModel.ISupportInitialize)(this.txtGirisAd.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblK_Adi;
        private DevExpress.XtraEditors.LabelControl lblK_Sifre;
        private DevExpress.XtraEditors.TextEdit txtGirisAd;
        private DevExpress.XtraEditors.SimpleButton btnGiris;
        private System.Windows.Forms.TextBox txtGirisSifre;
    }
}