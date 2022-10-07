using DAL.Entities.Logistica;
using DAL.Repository.Logistica;
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
            CarregarGridEstoque();
            HabilitarCampos(false);
        }

        #region Tela Entrada Material
        private void btnGerarId_Click(object sender, EventArgs e)
        {
            try
            {
                HabilitarCampos(true);
                var estoque = new EstoqueMadeira();
                var id = new DLEstoqueMadeira().Inserir(estoque);
                txtIdEntrada.Text = id.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);

            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            cmsSalvar.Show(btnSalvar, 1, btnSalvar.Height);
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            cmsDeletar.Show(btnDeletar, 1, btnDeletar.Height);
        }

        private void bntLimparEntrada_Click(object sender, EventArgs e)
        {
            LimparCamposEntrada();
        }

        private void cmsSalvarDatas_Click(object sender, EventArgs e)
        {
            try
            {
                var dataEstoque = LerData();
                int dataId = 0;
                if (txtDataId.Text != "")
                {
                    dataId = Convert.ToInt32(txtDataId.Text);
                    MessageBox.Show("Data atualizada com sucesso !!");
                }

                int estoqueId = 0;
                if (txtIdEntrada.Text != "")
                {
                    estoqueId = Convert.ToInt32(txtIdEntrada.Text);
                }

                var listaDataMadeira = new DLDataEstoque().Listar();
                var data = listaDataMadeira.Where(ip => ip.EstoqueId == estoqueId && ip.DataId == dataId).FirstOrDefault();
                if (data != null && data.DataId > 0)
                {
                    data.DataId = Convert.ToInt32(txtDataId.Text);
                    data.Entrada = dtpEntrada.Value;
                    data.Saida = dtpSaida.Value;
                    data.MetroQuadrado = Convert.ToDecimal(txtTotalM3Saida.Text);
                    new DLDataEstoque().Atualizar(data);
                }
                else
                {
                    new DLDataEstoque().Inserir(dataEstoque);
                    MessageBox.Show("Data cadastrado com sucesso !");
                }
                txtDataId.Clear();
                CarregarGridData();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);

            }

        }

        private void cmSalvarMaterial_Click(object sender, EventArgs e)
        {
            try
            {
                bool camposSaoValidos = ValidarCampo();
                if (camposSaoValidos == true)
                {
                    int id = 0;
                    int.TryParse(txtIdEntrada.Text, out id);
                    if (id > 0)
                    {
                        var entrada = new DLEstoqueMadeira().ConsultarPorId(id);
                        entrada.EstoqueId = Convert.ToInt32(txtIdEntrada);
                        entrada.Madeira = txtMaterialEntrada.Text;
                        entrada.Espessura = Convert.ToDecimal(txtEspessuraEntrada.Text);
                        entrada.Largura = Convert.ToDecimal(txtLarguraEntrada.Text);
                        entrada.MetroLinear = Convert.ToDecimal(txtMetroEntrada.Text);
                        entrada.MetroQuadrado = Convert.ToDecimal(txtTotalM2Entrada.Text);
                        entrada.MetroCubico = Convert.ToDecimal(txtTotalM3Entrada.Text);

                        new DLEstoqueMadeira().Atualizar(entrada);
                        MessageBox.Show("Entrada atualizado co sucesso !!");
                        CarregarGridEstoque();
                        dgvData.DataSource = null;
                        LimparCamposEntrada();
                        HabilitarCampos(false);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro " + ex.Message);
            }
        }

        private void cmsDeletarData_Click(object sender, EventArgs e)
        {
            int id = 0;
            int.TryParse(txtDataId.Text, out id);
            if (id > 0)
            {
                new DLDataEstoque().Excluir(new DataEstoque { DataId = id });
                MessageBox.Show("Data excluida com sucesso");
                LimparCamposEntrada();
                txtDataId.Clear();
            }
        }

        private void cmsDeletarMaterial_Click(object sender, EventArgs e)
        {
            int id = 0;
            int.TryParse(txtIdEntrada.Text, out id);
            if (id > 0)
            {
                new DLEstoqueMadeira().Excluir(new EstoqueMadeira { EstoqueId = id });
                MessageBox.Show("Material excluido com sucesso");
                LimparCamposEntrada();
                txtIdEntrada.Clear();
            }
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
            for (int i = 0; i < dgvData.Rows.Count; i++)
            {
                var valor = Convert.ToString(dgvData.Rows[i].Cells[4].Value);
                switch (valor)
                {
                    case "Finalizado":
                        dgvData.Rows[i].DefaultCellStyle.BackColor = Color.Lime;
                        break;
                    case "Pendente":
                        dgvData.Rows[i].DefaultCellStyle.BackColor = Color.Red; break;
                }
            }
        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var data = dgvData.Rows[e.RowIndex].DataBoundItem as DataEstoque;
            if (data != null)
            {
                data.EstoqueId = Convert.ToInt32(txtDataId.Text);
                data.Entrada = dtpEntrada.Value;
                data.Saida = dtpSaida.Value;
                data.MetroQuadrado = Convert.ToDecimal(txtTotalM2Entrada.Text);
                data.MetroQuadrado = Convert.ToDecimal(txtTotalM2Saida.Text);
            }
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
            try
            {
                bool camposSaoValidos = ValidarCampo();
                if (camposSaoValidos == true)
                {
                    int id = 0;
                    int.TryParse(txtIdSaida.Text, out id);
                    if (id > 0)
                    {
                        var saida = new DLEstoqueMadeira().ConsultarPorId(id);
                        saida.EstoqueId = Convert.ToInt32(txtIdSaida);
                        saida.Madeira = txtMaterialSaida.Text;
                        saida.Espessura = Convert.ToDecimal(txtEspessuraSaida.Text);
                        saida.Largura = Convert.ToDecimal(txtLarguraSaida.Text);
                        saida.MetroLinear = Convert.ToDecimal(txtMetroSaida.Text);
                        saida.MetroQuadrado = Convert.ToDecimal(txtTotalM2Saida.Text);
                        saida.MetroCubico = Convert.ToDecimal(txtTotalM3Saida.Text);

                        new DLEstoqueMadeira().Atualizar(saida);
                        MessageBox.Show("Saida atualizado co sucesso !!");
                        CarregarGridEstoque();
                        dgvData.DataSource = null;
                        LimparCamposEntrada();
                        HabilitarCampos(false);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro " + ex.Message);
            }
        }

        private void btnLimparSaida_Click(object sender, EventArgs e)
        {
            LimparCamposSaida();
        }

        private void dgvSaidaMaterial_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var saida = dgvSaidaMaterial.Rows[e.RowIndex].DataBoundItem as EstoqueMadeira;
            if (saida != null)
            {
                #region Entrada Material
                saida.EstoqueId = Convert.ToInt32(txtIdEntrada.Text);
                saida.Espessura = Convert.ToDecimal(txtEspessuraEntrada.Text);
                saida.Largura = Convert.ToDecimal(txtLarguraEntrada);
                saida.Madeira = txtMaterialEntrada.Text;
                saida.MetroLinear = Convert.ToDecimal(txtMetroEntrada.Text);
                saida.MetroQuadrado = Convert.ToDecimal(txtTotalM2Entrada.Text);
                saida.MetroCubico = Convert.ToDecimal(txtTotalM3Entrada.Text);
                #endregion

                #region Saida Material
                saida.EstoqueId = Convert.ToInt32(txtIdSaida.Text);
                saida.Espessura = Convert.ToDecimal(txtEspessuraSaida.Text);
                saida.Largura = Convert.ToDecimal(txtLarguraSaida);
                saida.Madeira = txtMaterialSaida.Text;
                saida.MetroLinear = Convert.ToDecimal(txtMetroSaida.Text);
                saida.MetroQuadrado = Convert.ToDecimal(txtTotalM2Saida.Text);
                saida.MetroCubico = Convert.ToDecimal(txtTotalM3Saida.Text);
                #endregion
            }
        }

        #endregion

        #region Apenas Metodos
        private void LimparCamposSaida()
        {
            #region Saida Material
            txtIdSaida.Clear();
            txtEspessuraSaida.Clear();
            txtLarguraSaida.Clear();
            txtMaterialSaida.Clear();
            txtMetroSaida.Clear();
            txtTotalM3Saida.Clear();
            txtTotalM2Saida.Clear();
            #endregion
        }

        private void CarregarGridData()
        {
            throw new NotImplementedException();
        }
        private DataEstoque LerData()
        {
            throw new NotImplementedException();
        }

        private void HabilitarCampos(bool habilitar)
        {
            btnBaixarEstoque.Enabled = habilitar;
            btnDeletar.Enabled = habilitar;
            btnLimparSaida.Enabled = habilitar;
            btnLimparEntrada.Enabled = habilitar;
            btnSalvar.Enabled = habilitar;

            #region Entrada Material          
            txtEspessuraEntrada.Enabled = habilitar;
            txtLarguraEntrada.Enabled = habilitar;
            txtMaterialEntrada.Enabled = habilitar;
            txtMetroEntrada.Enabled = habilitar;          
            dtpEntrada.Enabled = habilitar;
            #endregion

            #region Saida Material
            txtMaterialSaida.Enabled = habilitar;
            txtMetroSaida.Enabled = habilitar;
            dtpSaida.Enabled = habilitar;
            #endregion

        }

        private void CarregarGridEstoque()
        {
            throw new NotImplementedException();
        }

        private void CalcularEntradaM2()
        {
            throw new NotImplementedException();
        }
        private void CalcularSaidaM2()
        {
            throw new NotImplementedException();
        }

        private void LimparCamposEntrada()
        {
            #region Entrada Material
            txtIdEntrada.Clear();
            txtEspessuraEntrada.Clear();
            txtLarguraEntrada.Clear();
            txtMaterialEntrada.Clear();
            txtMetroEntrada.Clear();
            txtTotalM2Entrada.Clear();
            txtTotalM3Entrada.Clear();
            #endregion           
        }

        private bool ValidarCampo()
        {
            if (txtMaterialEntrada.Text == "")
            {
                MessageBox.Show("Informe o nome da madeira");
            }
            return true;
        }

        #endregion

        private void FrmEstoqueMadeira_Click(object sender, EventArgs e)
        {

        }
    }
}
