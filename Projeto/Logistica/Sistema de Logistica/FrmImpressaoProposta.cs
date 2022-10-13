using Microsoft.Reporting.WinForms;


namespace Projeto.Logistica.Sistema_de_Logistica
{
    public partial class FrmImpressaoProposta : Form
    {
        public FrmImpressaoProposta(DateTime DataEntrega, string Proposta, string Cliente, string Obra,
            ReportDataSource itensProposta, string NotaFiscal, ReportDataSource historico)
        {
            try
            {
                InitializeComponent();
                reportViewer1.LocalReport.DataSources.Clear();

                reportViewer1.LocalReport.ReportEmbeddedResource = "Projeto.Impressao.rdlc";

                ReportParameter[] p = new ReportParameter[5];

                p[0] = new ReportParameter("Proposta", Proposta);
                p[1] = new ReportParameter("DataEntrega", DataEntrega.ToString());
                p[2] = new ReportParameter("Cliente", Cliente);
                p[3] = new ReportParameter("Obra", Obra);
                p[4] = new ReportParameter("NotaFiscal", NotaFiscal);

                reportViewer1.LocalReport.SetParameters(p);
                reportViewer1.LocalReport.DataSources.Add(itensProposta);
                reportViewer1.LocalReport.DataSources.Add(historico);
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
