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
                rvProposta.LocalReport.DataSources.Clear();

                rvProposta.LocalReport.ReportEmbeddedResource = "Projeto.Logistica.Sistema_de_Logistica.Impressao.rdlc";

                ReportParameter[] p = new ReportParameter[5];

                p[0] = new ReportParameter("Proposta", Proposta);
                p[1] = new ReportParameter("DataEntrega", DataEntrega.ToString());
                p[2] = new ReportParameter("Cliente", Cliente);
                p[3] = new ReportParameter("Obra", Obra);
                p[4] = new ReportParameter("NotaFiscal", NotaFiscal);

                rvProposta.LocalReport.SetParameters(p);
                rvProposta.LocalReport.DataSources.Add(itensProposta);
                rvProposta.LocalReport.DataSources.Add(historico);
                rvProposta.LocalReport.Refresh();
                rvProposta.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void FrmImpressaoProposta_Load(object sender, EventArgs e)
        {
            this.rvProposta.RefreshReport();

        }
    }
}
