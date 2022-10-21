using Microsoft.Reporting.WinForms;

namespace Projeto.Logistica.Sistema_do_Financeiro
{
    public partial class FrmImpressaoEstoqueFinanceiro : Form
    {
        public FrmImpressaoEstoqueFinanceiro(DateTime Data, ReportDataSource eF)
        {
            try
            {
                InitializeComponent();
                rvFinanceiro.LocalReport.DataSources.Clear();

                rvFinanceiro.LocalReport.ReportEmbeddedResource =
                    "Projeto.Logistica.Sistema_do_Financeiro.RelatorioEstoque.rdlc";

                ReportParameter[] p = new ReportParameter[1];

                p[0] = new ReportParameter("Data", Data.ToString());

                rvFinanceiro.LocalReport.SetParameters(p);
                rvFinanceiro.LocalReport.DataSources.Add(eF);
                rvFinanceiro.LocalReport.Refresh();
                rvFinanceiro.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void FrmImpressaoEstoqueFinanceiro_Load(object sender, EventArgs e)
        {
            this.rvFinanceiro.RefreshReport();
        }
    }
}
