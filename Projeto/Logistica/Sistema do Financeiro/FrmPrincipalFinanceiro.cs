using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logistica.Sistema_do_Financeiro
{
    public partial class FrmPrincipalFinanceiro : Form
    {
        public FrmPrincipalFinanceiro()
        {
            InitializeComponent();
        }

        private void FrmPrincipalFinanceiro_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
