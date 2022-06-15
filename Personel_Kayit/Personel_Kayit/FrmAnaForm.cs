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
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-L3USLRR;Initial Catalog=SirketCalisanlariVeriTabani;Integrated Security=True");

        private void Btn_listele_Click(object sender, EventArgs e)
        {
            this.tbl_personelTableAdapter.Fill(this.sirketCalisanlariVeriTabaniDataSet1.Tbl_personel);
        }

        void temizle()
        {
            Txt_id.Text = "";
            Txt_ad.Text = "";
            Txt_soyad.Text = " ";
            Cmb_sehir.Text = "";
            Txt_departman.Text = "";
            Mtb_maas.Text = "";
            Rb_tik.Checked= false;
            Rb_carpi.Checked = false;
            Txt_ad.Focus();


        }





        private void Btn_kaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into Tbl_personel (Per_ad,Per_soyad,Per_sehir,Per_departman,Per_maas,Per_prim) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", Txt_ad.Text);
            komut.Parameters.AddWithValue("@p2", Txt_soyad.Text);
            komut.Parameters.AddWithValue("@p3", Cmb_sehir.Text);
            komut.Parameters.AddWithValue("@p4", Txt_departman.Text);
            komut.Parameters.AddWithValue("@p5", Mtb_maas.Text);
            komut.Parameters.AddWithValue("@p6", label8.Text);
            komut.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Yeni bir şirket çalışanı eklendi");

        }

        private void Rb_tik_CheckedChanged(object sender, EventArgs e)
        {
           if(Rb_tik.Checked==true)
            {
                label8.Text = "True";
            }

        }

        private void Rb_carpi_CheckedChanged(object sender, EventArgs e)
        {
            if (Rb_carpi.Checked == true)
            {
                label8.Text = "False";
            }
        }

        private void Btn_temizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilendeger = dataGridView1.SelectedCells[0].RowIndex;
            Txt_id.Text = dataGridView1.Rows[secilendeger].Cells[0].Value.ToString();
            Txt_ad.Text = dataGridView1.Rows[secilendeger].Cells[1].Value.ToString();
            Txt_soyad.Text = dataGridView1.Rows[secilendeger].Cells[2].Value.ToString();
            Cmb_sehir.Text = dataGridView1.Rows[secilendeger].Cells[3].Value.ToString();
            Txt_departman.Text = dataGridView1.Rows[secilendeger].Cells[4].Value.ToString();
            Mtb_maas.Text=dataGridView1.Rows[secilendeger].Cells[5].Value.ToString();
            label8.Text = dataGridView1.Rows[secilendeger].Cells[6].Value.ToString();


        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            if(label8.Text == "True")
            {
                Rb_tik.Checked = true;
            }
            if(label8.Text== "False")
            {
                Rb_carpi.Checked = true;
            }
        }

        private void Btn_sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("Delete From Tbl_personel Where Per_id= @k1", baglanti);
            komutsil.Parameters.AddWithValue("@k1", Txt_id.Text);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt silindi");


        }

        private void Btn_güncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutguncelle = new SqlCommand("Update Tbl_personel Set Per_ad = @a1, Per_soyad = @a2, Per_Sehir = @a3, Per_departman = @a4, Per_maas = @a5, Per_prim = @a6 where Per_id = @a7",baglanti);
            komutguncelle.Parameters.AddWithValue("@a1", Txt_ad.Text);
            komutguncelle.Parameters.AddWithValue("@a2", Txt_soyad.Text);
            komutguncelle.Parameters.AddWithValue("@a3", Cmb_sehir.Text);
            komutguncelle.Parameters.AddWithValue("@a4", Txt_departman.Text);
            komutguncelle.Parameters.AddWithValue("@a5", Mtb_maas.Text);
            komutguncelle.Parameters.AddWithValue("@a6",label8.Text);
            komutguncelle.Parameters.AddWithValue("@a7", Txt_id.Text);
            komutguncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel bilgisi güncellendi");
        }

        private void Btn_istatistik_Click(object sender, EventArgs e)
        {
            Frm_istatistik fr = new Frm_istatistik();
            fr.Show();
        }

        private void Btn_grafikler_Click(object sender, EventArgs e)
        {
           Frm_Grafikler frg = new Frm_Grafikler();    
            frg.Show ();
        }

        private void Btn_raporlar_Click(object sender, EventArgs e)
        {
            Frm_Raporlar frp = new Frm_Raporlar();
            frp.Show();

        }

   
    }
}
