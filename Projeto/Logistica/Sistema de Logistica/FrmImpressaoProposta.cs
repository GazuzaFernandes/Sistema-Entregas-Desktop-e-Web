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
    public partial class FrmImpressaoProposta : Form
    {
        public FrmImpressaoProposta()
        {
            InitializeComponent();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
              
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
