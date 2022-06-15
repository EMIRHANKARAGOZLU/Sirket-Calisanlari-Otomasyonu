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
    public partial class Frm_istatistik : Form
    {
        public Frm_istatistik()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-L3USLRR;Initial Catalog=SirketCalisanlariVeriTabani;Integrated Security=True");

        private void Frm_istatistik_Load(object sender, EventArgs e)
        {



            // Toplam Personel Sayısı
            baglanti.Open();

            SqlCommand komut1 = new SqlCommand("Select Count(*) From Tbl_Personel", baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while(dr1.Read())
            {
                lbl_toplampersonel.Text = dr1[0].ToString();
            }
            baglanti.Close();


            // Prim alan Personel Sayısı
            baglanti.Open();

            SqlCommand komut2 = new SqlCommand("Select Count (*) From Tbl_Personel where Per_prim = 1", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                lbl_prim.Text = dr2[0].ToString();
            }


            baglanti.Close();

            //Prim almayan Personel Sayısı
            baglanti.Open();

            SqlCommand komut3 = new SqlCommand("Select Count (*) From Tbl_Personel where Per_prim = 0", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                lbl_primalmayan.Text = dr3[0].ToString();
            }

            baglanti.Close();

            // Şehir sayısı
            baglanti.Open();

            SqlCommand komut4 = new SqlCommand("Select Count (distinct(Per_sehir)) From Tbl_Personel ", baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                lbl_sehir.Text = dr4[0].ToString();
            }

            baglanti.Close();

            //Toplam maaş
            baglanti.Open();

            SqlCommand komut5 = new SqlCommand("Select Sum(Per_maas) From Tbl_Personel", baglanti);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                lbl_toplam_maas.Text = dr5[0].ToString();
            }

            baglanti.Close();

            // Ortalama maaş
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("Select Avg(Per_maas) From Tbl_Personel", baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                lbl_ortmaas.Text = dr6[0].ToString();
            }

            baglanti.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

       
    }
}
