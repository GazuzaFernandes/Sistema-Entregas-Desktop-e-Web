using DAL.Entities.Logistica;
using Microsoft.Reporting.WinForms;
using Projeto.Logistica.Sistema_de_Logistica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto.Logistica.Sistema_do_Financeiro
{
    public partial class FrmImpressaoEstoqueFinanceiro : Form
    {
        public FrmImpressaoEstoqueFinanceiro(DateTime Data, ReportDataSource estoqueFinanceiro)
        {
            try
            {
                InitializeComponent();
                rvFinanceiro.LocalReport.DataSources.Clear();
                rvFinanceiro.LocalReport.ReportEmbeddedResource =
                    "Projeto.Logistica.Sistema_do_Financeiro.Report1.rdlc";
                ReportParameter[] p = new ReportParameter[1];

                p[0] = new ReportParameter("Data", Data.ToString());
                rvFinanceiro.LocalReport.SetParameters(p);
                rvFinanceiro.LocalReport.DataSources.Add(estoqueFinanceiro);
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
