using DAL.Entities.Logistica;
using DAL.Repository.Logistica;
using Logistica.Sistema_de_Logistica;
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
    public partial class FrmCadastroItens : Form
    {
        public int madeiraid;
        public string material, comprimento, qtdcaixa;
        internal CadastrarMadeira _cadastro;

        public FrmCadastroItens()
        {
            InitializeComponent();
        }
        private void FrmCadastroItens_Load(object sender, EventArgs e)
        {
            BloquearBotao(false);
            CarregarGrid();
        }
        private void btnInserir_Click(object sender, EventArgs e)
        {
            madeiraid = Convert.ToInt32(txtCodigoMaterial.Text);
            material = txtMaterial.Text;
            qtdcaixa = txtQuantidadeCaixas.Text;
            Hide();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                bool camposSaoValidos = ValidarCampos();
                if (camposSaoValidos == true)
                {
                    int id = 0;
                    int.TryParse(txtCodigoMaterial.Text, out id);
                    if (id > 0)
                    {
                        var itenAtualizar = new DLCadastrarMadeira().ConsultarPorId(id);
                        itenAtualizar.MadeiraId = Convert.ToInt32(txtCodigoMaterial.Text);
                        itenAtualizar.PisoMadeira = txtMaterial.Text;
                        itenAtualizar.M2Caixa = Convert.ToDecimal(txtQuantidadeCaixas.Text);
                        new DLCadastrarMadeira().Atualizar(itenAtualizar);
                        MessageBox.Show("Material atualizado com Sucesso ");
                    }
                    else
                    {
                        var itenBranco = new CadastrarMadeira();
                        itenBranco.PisoMadeira = txtMaterial.Text;
                        itenBranco.M2Caixa = Convert.ToDecimal(txtQuantidadeCaixas.Text);
                        var idItens = new DLCadastrarMadeira().Inserir(itenBranco);
                        MessageBox.Show(" Código " + idItens + " Criado com Sucesso ");
                    }
                    LimparCampos();
                    CarregarGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }      
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                var pergunta = "Deseja Realmente excluir esse Item ? ";
                if (MessageBox.Show(pergunta, "ATENÇÂO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    FrmLogin login = new FrmLogin();
                    login.ShowDialog();
                    Boolean temUsuario = false;
                    var listaUsuarios = new DLUsuario().Listar();
                    for (int i = 0; i < listaUsuarios.Count; i++)
                    {
                        if (listaUsuarios[i].Senha == login.txtSenha.Text)
                        {
                            temUsuario = true;
                        }
                    }
                    if (temUsuario == true)
                    {
                        int id = 0;
                        int.TryParse(txtCodigoMaterial.Text, out id);
                        if (id > 0)
                        {
                            new DLCadastrarMadeira().Excluir(new CadastrarMadeira { MadeiraId = id });
                            MessageBox.Show("Item excluído com sucesso!");
                            CarregarGrid();
                            txtCodigoMaterial.Text = Convert.ToString(null);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }     
        private void txtMaterial_TextChanged(object sender, EventArgs e)
        {
            CarregarGrid(true);
        }
        private void dgvMaterial_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var madeira = dgvMaterial.Rows[e.RowIndex].DataBoundItem as CadastrarMadeira;
                if (madeira != null)
                {
                    txtCodigoMaterial.Text = madeira.MadeiraId.ToString();
                    txtMaterial.Text = madeira.PisoMadeira.ToString();
                    txtQuantidadeCaixas.Text = madeira.M2Caixa.ToString();
                }
                BloquearBotao(true);
                CarregarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }

        #region Apenas Metodos
        private bool ValidarCampos()
        {
           if(txtMaterial.Text == "")
            {
                MessageBox.Show("Informe o material");
            }
            return true;
        }
        private void CarregarGrid(bool isPesquisa = false)
        {
            try
            {
                var listarMadeira = new DLCadastrarMadeira().Listar();
                if (isPesquisa) //isPesquisa == true
                {
                    var pesquisa = txtMaterial.Text.ToLower();
                    listarMadeira = listarMadeira.Where(p => p.PisoMadeira.ToLower().Contains(pesquisa)).ToList();
                }
                dgvMaterial.DataSource = listarMadeira.OrderBy(p => p.MadeiraId).ToList();
                MontarGrid(dgvMaterial);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void MontarGrid(DataGridView dgvMaterial)
        {
            try
            {
                dgvMaterial.DefaultCellStyle.Font = new Font("Calibri", 16F, GraphicsUnit.Pixel);
                var objBlControleGrid = new ControleGrid(dgvMaterial);
                //Define quais colunas serão visíveis
                objBlControleGrid.DefinirVisibilidade(new List<string>()
                { "MadeiraId", "PisoMadeira", "M2Caixa" });
                //Define quais os cabeçalhos respectivos das colunas 
                objBlControleGrid.DefinirCabecalhos(new List<string>()
                { "CODIGO", "PISO", "UND. MEDIDA" });
                //Define quais as larguras respectivas das colunas 
                objBlControleGrid.DefinirLarguras(new List<int>() { 5, 80, 8, }, dgvMaterial.Width - 15); //O total tem que ficar em 100% 
                //Define quais os alinhamentos respectivos do componentes das colunas 
                objBlControleGrid.DefinirAlinhamento(new List<string>()
                { "centro", "centro", "centro", "centro", "centro", });
                //Define a altura das linhas respectivas da Grid 
                objBlControleGrid.DefinirAlturaLinha(30);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void BloquearBotao(bool desabilitar)
        {
            btnInserir.Enabled = desabilitar;
        }
        private void LimparCampos()
        {
            txtCodigoMaterial.Clear();
            txtMaterial.Clear();
            txtQuantidadeCaixas.Text = Convert.ToString(1);
            CarregarGrid();
        }
        #endregion
    }
}
