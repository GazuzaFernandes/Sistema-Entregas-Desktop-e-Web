using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto.Logistica.Sistema_de_Logistica
{
    public partial class FrmImpressaoProduto : Form
    {
        public FrmImpressaoProduto(DateTime Data, ReportDataSource eF)
        {
            InitializeComponent();
            rvProduto.LocalReport.DataSources.Clear();

            rvProduto.LocalReport.ReportEmbeddedResource =
               "Projeto.Logistica.Sistema_de_Logistica.ImpressaoProduto.rdlc";

            ReportParameter[] p = new ReportParameter[1];

            p[0] = new ReportParameter("Data", Data.ToString());

            rvProduto.LocalReport.SetParameters(p);
            rvProduto.LocalReport.DataSources.Add(eF);
            rvProduto.LocalReport.Refresh();
            rvProduto.RefreshReport();
        }

        private void FrmImpressaoProduto_Load(object sender, EventArgs e)
        {
            this.rvProduto.RefreshReport();

        }
    }
}
