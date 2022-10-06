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
    public partial class FrmEstoqueMadeira : Form
    {
        public FrmEstoqueMadeira()
        {
            InitializeComponent();
        }  
        private void FrmEstoqueMadeira_Load(object sender, EventArgs e)
        {

        }

        #region Tela Entrada Material
        private void btnGerarId_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {

        }

        private void bntLimparEntrada_Click(object sender, EventArgs e)
        {

        }

        private void cmsSalvarDatas_Click(object sender, EventArgs e)
        {

        }

        private void cmSalvarMaterial_Click(object sender, EventArgs e)
        {

        }

        private void cmsDeletarData_Click(object sender, EventArgs e)
        {

        }

        private void cmsDeletarMaterial_Click(object sender, EventArgs e)
        {

        }

        private void txtEspessuraEntrada_TextChanged(object sender, EventArgs e)
        {
            CalcularEntradaM2();
        }

        private void txtLarguraEntrada_TextChanged(object sender, EventArgs e)
        {
            CalcularEntradaM2();
        }

        private void txtMetroEntrada_TextChanged(object sender, EventArgs e)
        {
            CalcularEntradaM2();
        }

     

        private void dgvData_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        #endregion

        #region Tela Saida Material
           
        private void txtMaterialSaida_TextChanged(object sender, EventArgs e)
        {
            CalcularSaidaM2();
        }

        private void txtEspessuraSaida_TextChanged(object sender, EventArgs e)
        {
            CalcularSaidaM2();
        }

        private void txtLarguraSaida_TextChanged(object sender, EventArgs e)
        {
            CalcularSaidaM2();
        }

        private void txtMetroSaida_TextChanged(object sender, EventArgs e)
        {
            CalcularSaidaM2();
        }

       

        private void btnBaixarEstoque_Click(object sender, EventArgs e)
        {

        }

        private void btnLimparSaida_Click(object sender, EventArgs e)
        {

        }

        private void dgvSaidaMaterial_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        #endregion

        #region Apenas Metodos

        private void CalcularEntradaM2()
        {
            throw new NotImplementedException();
        }
        private void CalcularSaidaM2()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
