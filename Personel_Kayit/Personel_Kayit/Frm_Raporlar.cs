using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel_Kayit
{
    public partial class Frm_Raporlar : Form
    {
        public Frm_Raporlar()
        {
            InitializeComponent();
        }

        private void Frm_Raporlar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sirketCalisanlariVeriTabaniDataSet4.Tbl_personel' table. You can move, or remove it, as needed.
            this.tbl_personelTableAdapter.Fill(this.sirketCalisanlariVeriTabaniDataSet4.Tbl_personel);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

    }
}
