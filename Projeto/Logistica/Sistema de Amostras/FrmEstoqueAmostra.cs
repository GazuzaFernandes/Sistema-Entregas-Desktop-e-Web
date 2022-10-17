
using DAL.Entities.Amostras;
using DAL.Repository.Amostras;
using Logistica.Sistema_de_Logistica;

using System.Data;


namespace Projeto.Logistica.Sistema_de_Amostras
{
    public partial class FrmEstoqueAmostra : Form
    {
        public FrmEstoqueAmostra()
        {
            InitializeComponent();
        }

        private void FrmEstoqueAmostra_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                bool camposSaoValidos = ValidarCampos();
                if (camposSaoValidos == true)
                {
                    int id = 0;
                    int.TryParse(txtEstoqueId.Text, out id);
                    if (id > 0)
                    {
                        var estoqueAt = new DLEstoqueAmostra().ConsultarPorId(id);
                        estoqueAt.EstoqueId = Convert.ToInt32(txtEstoqueId.Text);
                        estoqueAt.Amostra = txtAmostra.Text;
                        estoqueAt.Entrada = Convert.ToDecimal(txtEntrada.Text);
                        estoqueAt.Total = Convert.ToDecimal(txtTotal.Text);
                        new DLEstoqueAmostra().Atualizar(estoqueAt);
                        MessageBox.Show("Estoque atualizado com Sucesso ");
                        LimparCampos();
                        CarregarGrid();                       
                    }
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
                var pergunta = "Deseja Realmente Excluir esse material ? ";
                if (MessageBox.Show(pergunta, "ATENÇÂO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = 0;
                    int.TryParse(txtEstoqueId.Text, out id);
                    if (id > 0)
                    {
                        new DLEstoqueAmostra().Excluir(new EstoqueAmostra { EstoqueId = id });
                        MessageBox.Show("Material excluída com sucesso!");
                        CarregarGrid();
                        LimparCampos();
                        txtEstoqueId.Text = Convert.ToString(null);
                    }
                    else
                    {
                        MessageBox.Show("id Invalido");
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

        private void txtAmostra_TextChanged(object sender, EventArgs e)
        {
            CarregarGrid(true);
            MontarGrid(dgvEstoqueAmostra);
        }

        private void txtEntrada_TextChanged(object sender, EventArgs e)
        {
            CalculoEntradaEstoque();
        }
        private void dgvEstoqueAmostra_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var amostras = dgvEstoqueAmostra.Rows[e.RowIndex].DataBoundItem as EstoqueAmostra;
                if (amostras != null)
                {
                    #region Cadastro de Amostra
                    txtEstoqueId.Text = amostras.EstoqueId.ToString();
                    txtAmostra.Text = amostras.Amostra;
                    txtTotal.Text = Convert.ToString(amostras.Total);
                    #endregion

                }              
                CarregarGrid();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }

        #region Apenas Metodos
        private void CarregarGrid(bool isPesquisa = false)
        {
            try
            {
                var estoqueAmostras = new DLEstoqueAmostra().Listar();
                if (isPesquisa) //isPesquisa == true
                {
                    var pesquisa = txtAmostra.Text.ToLower();
                    estoqueAmostras = estoqueAmostras.Where(p => p.Amostra.ToLower().Contains(pesquisa)).ToList();
                }
                dgvEstoqueAmostra.DataSource = estoqueAmostras.OrderBy(p => p.Total).ToList();
                MontarGrid(dgvEstoqueAmostra);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void MontarGrid(DataGridView dgvEstoqueAmostra)
        {
            try
            {
                dgvEstoqueAmostra.DefaultCellStyle.Font = new Font("Calibri", 20F, GraphicsUnit.Pixel);
                var objBlControleGrid = new ControleGrid(dgvEstoqueAmostra);
                //Define quais colunas serão visíveis
                objBlControleGrid.DefinirVisibilidade(new List<string>() { "Amostra", "Total", });
                //Define quais os cabeçalhos respectivos das colunas 
                objBlControleGrid.DefinirCabecalhos(new List<string>() { "Amostra", "Total" });
                //Define quais as larguras respectivas das colunas 
                objBlControleGrid.DefinirLarguras(new List<int>() { 82, 10 }, dgvEstoqueAmostra.Width - 15); //O total tem que ficar em 100% 
                //Define quais os alinhamentos respectivos do componentes das colunas 
                objBlControleGrid.DefinirAlinhamento(new List<string>() { "centro", "centro", "centro", "centro", "centro", });
                //Define a altura das linhas respectivas da Grid 
                objBlControleGrid.DefinirAlturaLinha(30);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void LimparCampos()
        {
            txtEstoqueId.Text = Convert.ToString(null);
            txtAmostra.Text = Convert.ToString(null);
            txtEntrada.Text = Convert.ToString(0);
            txtTotal.Text = Convert.ToString(0);
            CarregarGrid();
        }
        private bool ValidarCampos()
        {
            if (txtAmostra.Text == "")
            {
                MessageBox.Show("Informe a amostra");
            }
            return true;
        }
        private void CalculoEntradaEstoque()
        {
            try
            {
                decimal entrada = 0, total = 0, atualizarEstoque = 0;
                if (decimal.TryParse(txtEntrada.Text, out entrada))
                {
                    if (decimal.TryParse(txtTotal.Text, out total))
                    {
                        atualizarEstoque = entrada + total;
                    }
                    txtTotal.Text = atualizarEstoque.ToString("N2");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

    }
}
