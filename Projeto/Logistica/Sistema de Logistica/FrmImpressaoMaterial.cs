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
    public partial class FrmImpressaoMaterial : Form
    {
        public FrmImpressaoMaterial(DateTime Data, ReportDataSource eF)
        {
            InitializeComponent();
            rvMaterial.LocalReport.DataSources.Clear();

            rvMaterial.LocalReport.ReportEmbeddedResource =
                "Projeto.Logistica.Sistema_de_Logistica.ImpressaoMadeira.rdlc";

            ReportParameter[] p = new ReportParameter[1];

            p[0] = new ReportParameter("Data", Data.ToString());

            rvMaterial.LocalReport.SetParameters(p);
            rvMaterial.LocalReport.DataSources.Add(eF);
            rvMaterial.Refresh();
            rvMaterial.RefreshReport();
        }

        private void FrmImpressaoMaterial_Load(object sender, EventArgs e)
        {
            this.rvMaterial.RefreshReport();

        }
    }
}
