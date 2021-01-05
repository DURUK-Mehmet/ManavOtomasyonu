using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Menu
{
    public partial class LoginPage : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-UJKRJQO;  Initial Catalog=Otomasyon; Integrated Security=TRUE");
        public LoginPage()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            String K_Adi =txtGirisAd.Text;
            String K_Sifre =txtGirisSifre.Text;
            bool kontrol = false;
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Login", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (K_Adi == dr["K_Adi"].ToString() && K_Sifre == dr["K_Sifre"].ToString())
                {
                    kontrol = true;
                    break;
                }
            }
            if (kontrol == true)
            {
                MessageBox.Show("Giriş Başarılı");
                Giris form = new Giris();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı Veya Şifre Hatalı");
            }
        }
    }
}