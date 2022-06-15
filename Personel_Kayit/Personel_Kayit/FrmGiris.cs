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

namespace Personel_Kayit
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-L3USLRR;Initial Catalog=SirketCalisanlariVeriTabani;Integrated Security=True");

        private void Btn_giris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Tbl_Yonetici where Kullanici_ad = @p1 and Sifre = @p2", baglanti);
            komut.Parameters.AddWithValue("@p1", Txt_username.Text);
            komut.Parameters.AddWithValue("@p2", Txt_sifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmAnaForm frm = new FrmAnaForm();
                frm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı giriş yaptınız tekrar deneyin");
            }
            baglanti.Close();
        }

        
    }
}
