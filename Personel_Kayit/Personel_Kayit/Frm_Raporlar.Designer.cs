namespace Personel_Kayit
{
    partial class Frm_Raporlar
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tblpersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sirketCalisanlariVeriTabaniDataSet4 = new Personel_Kayit.SirketCalisanlariVeriTabaniDataSet4();
            this.sirketCalisanlariVeriTabaniDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sirketCalisanlariVeriTabaniDataSet = new Personel_Kayit.SirketCalisanlariVeriTabaniDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbl_personelTableAdapter = new Personel_Kayit.SirketCalisanlariVeriTabaniDataSet4TableAdapters.Tbl_personelTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblpersonelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sirketCalisanlariVeriTabaniDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sirketCalisanlariVeriTabaniDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sirketCalisanlariVeriTabaniDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tblpersonelBindingSource
            // 
            this.tblpersonelBindingSource.DataMember = "Tbl_personel";
            this.tblpersonelBindingSource.DataSource = this.sirketCalisanlariVeriTabaniDataSet4;
            // 
            // sirketCalisanlariVeriTabaniDataSet4
            // 
            this.sirketCalisanlariVeriTabaniDataSet4.DataSetName = "SirketCalisanlariVeriTabaniDataSet4";
            this.sirketCalisanlariVeriTabaniDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sirketCalisanlariVeriTabaniDataSetBindingSource
            // 
            this.sirketCalisanlariVeriTabaniDataSetBindingSource.DataSource = this.sirketCalisanlariVeriTabaniDataSet;
            this.sirketCalisanlariVeriTabaniDataSetBindingSource.Position = 0;
            // 
            // sirketCalisanlariVeriTabaniDataSet
            // 
            this.sirketCalisanlariVeriTabaniDataSet.DataSetName = "SirketCalisanlariVeriTabaniDataSet";
            this.sirketCalisanlariVeriTabaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.DocumentMapWidth = 85;
            this.reportViewer1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tblpersonelBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Personel_Kayit.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ServerReport.ReportServerUrl = new System.Uri("", System.UriKind.Relative);
            this.reportViewer1.Size = new System.Drawing.Size(1089, 450);
            this.reportViewer1.TabIndex = 1;
            // 
            // tbl_personelTableAdapter
            // 
            this.tbl_personelTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_Raporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Raporlar";
            this.Text = "Frm_Raporlar";
            this.Load += new System.EventHandler(this.Frm_Raporlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblpersonelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sirketCalisanlariVeriTabaniDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sirketCalisanlariVeriTabaniDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sirketCalisanlariVeriTabaniDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sirketCalisanlariVeriTabaniDataSetBindingSource;
        private SirketCalisanlariVeriTabaniDataSet sirketCalisanlariVeriTabaniDataSet;
        private SirketCalisanlariVeriTabaniDataSet4 sirketCalisanlariVeriTabaniDataSet4;
        private System.Windows.Forms.BindingSource tblpersonelBindingSource;
        private SirketCalisanlariVeriTabaniDataSet4TableAdapters.Tbl_personelTableAdapter tbl_personelTableAdapter;
    }
}