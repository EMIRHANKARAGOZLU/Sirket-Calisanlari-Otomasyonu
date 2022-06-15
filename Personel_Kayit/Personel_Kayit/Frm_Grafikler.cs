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
    public partial class Frm_Grafikler : Form
    {
        public Frm_Grafikler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-L3USLRR;Initial Catalog=SirketCalisanlariVeriTabani;Integrated Security=True");

        // Şehirler Grafiği
        private void Frm_Grafikler_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutg1 = new SqlCommand("Select Per_Sehir, Count(*) From Tbl_Personel Group By Per_sehir",baglanti);
            SqlDataReader dr1 = komutg1.ExecuteReader();
            while (dr1.Read()) 
            {   
            chart1.Series["Sehirler"].Points.AddXY(dr1[0], dr1[1]);

            }
            baglanti.Close();

            // Meslek- Maaş Grafiği
            baglanti.Open();
            SqlCommand komutg2 = new SqlCommand("Select Per_Departman, Avg(Per_maas) From Tbl_Personel Group By Per_departman", baglanti);
            SqlDataReader dr2 = komutg2.ExecuteReader();
            while (dr2.Read()) 
            {
                chart2.Series["Departman-Maas"].Points.AddXY(dr2[0], dr2[1]);
                    
            }
            baglanti.Close();


        }
    }
}
