
using Microsoft.Reporting.WinForms;


namespace Projeto.Logistica.Sistema_de_Logistica
{
    public partial class FrmImpressaoProposta : Form
    {
        public FrmImpressaoProposta(DateTime Dataentrega, string Proposta, string Cliente, string Obra,
            ReportDataSource rs, string NotaFiscal, string Comentario, ReportDataSource hs)
        {
            try
            {
                InitializeComponent();
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.ReportEmbeddedResource = "Logistica.RelatorioPDF.rdlc";
                ReportParameter[] p = new ReportParameter[6];
                p[0] = new ReportParameter("Proposta", Proposta);
                p[1] = new ReportParameter("Cliente", Cliente);
                p[2] = new ReportParameter("Obra", Obra);
                p[3] = new ReportParameter("NotaFiscal", NotaFiscal);
                p[4] = new ReportParameter("Datentrega", Dataentrega.ToString());
                p[5] = new ReportParameter("Comentario", Comentario);
                reportViewer1.LocalReport.SetParameters(p);
                reportViewer1.LocalReport.DataSources.Add(rs);
                reportViewer1.LocalReport.DataSources.Add(hs);
                reportViewer1.LocalReport.Refresh();
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }          
        }
       
        private void FrmImpressaoProposta_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();

        }
    }
}
