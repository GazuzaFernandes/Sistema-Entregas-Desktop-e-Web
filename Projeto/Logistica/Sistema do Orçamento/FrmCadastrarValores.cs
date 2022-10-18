
using DAL.Entities.Orcamento;
using DAL.Repository.Orcamento;
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

namespace Projeto.Logistica.Sistema_do_Orçamento
{
    public partial class FrmCadastrarValores : Form
    {
        internal ProdutosOrcamento _produto;
        public FrmCadastrarValores()
        {
            InitializeComponent();
        }      

        private void FrmCadastrarValores_Load(object sender, EventArgs e)
        {
            try
            {
                HabilitarCampos(false);
                if (_produto == null)
                    _produto = new ProdutosOrcamento();
                if (_produto.ProdutoId > 0)
                {
                    HabilitarCampos(true);
                    _produto = new DLProdutosOrcamento().ConsultarPorId(_produto.ProdutoId);
                    txtIdProduto.Text = _produto.ProdutoId.ToString();
                    txtFornecedor.Text = _produto.Fornecedor;
                    txtPreco.Text = _produto.Preco;
                    txtProduto.Text = _produto.Produto;
                    rtbComentario.Text = _produto.Comentario;
                    txtRendimento.Text = _produto.Rendimento;                   
                    CarregarGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnGerarId_Click(object sender, EventArgs e)
        {
            try
            {
                HabilitarCampos(true);
                var produtos = new ProdutosOrcamento();
                var id = new DLProdutosOrcamento().Inserir(produtos);//inserir
                txtIdProduto.Text = id.ToString();
                BloquearGeradorId(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            cmsSalvarConteudos.Show(btnDeletar, 1, btnSalvar.Height);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void dgvDatas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var datas = dgvData.Rows[e.RowIndex].DataBoundItem as DataProdutoOrcamento;
            if (datas != null)
            {
                txtDataId.Text = datas.ProdutoId.ToString();
                dtpDataAtualizada.Value = datas.Data;
                txtPreco.Text = datas.Preco;
            }
        }

        private void mtSalvarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                bool camposSaoValidos = Validarcampos();
                if (camposSaoValidos == true)
                {
                    int id = 0;
                    int.TryParse(txtIdProduto.Text, out id);
                    if (id > 0)
                    {
                        var valorNovo = new DLProdutosOrcamento().ConsultarPorId(id);
                        valorNovo.Produto = txtProduto.Text;
                        valorNovo.Fornecedor = txtFornecedor.Text;
                        valorNovo.Preco = txtPreco.Text;
                        valorNovo.Rendimento = txtRendimento.Text;
                        valorNovo.Comentario = rtbComentario.Text;
                        new DLProdutosOrcamento().Atualizar(valorNovo);
                        MessageBox.Show("Material atualizado com Sucesso ");
                        LimparCampos();
                        Close();
                        dgvData.DataSource = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void mtSalvarData_Click(object sender, EventArgs e)
        {
            try
            {
                var dataproduto = LerData();
                int valorProdutoData = 0;
                if (txtDataId.Text != "")
                {
                    valorProdutoData = Convert.ToInt32(txtDataId.Text);
                    MessageBox.Show("Data Atualizado com Sucesso");
                }
                int propostaid = 0;
                if (txtIdProduto.Text != "")
                {
                    propostaid = Convert.ToInt32(txtIdProduto.Text);
                }
                var listarmadeira = new DLDataProdutoOrcamento().Listar();
                //Filtrando a lista "listaProposta" por propostaid e codigomaterial
                var prop = listarmadeira.Where(ip =>
                                ip.ProdutoId == propostaid //por proppostaid
                                && ip.DataId == valorProdutoData //por ItensPropostaId
                                ).FirstOrDefault();//Primeiro que encontrar
                if (prop != null && prop.DataId > 0)
                {
                    prop.DataId = Convert.ToInt32(txtDataId.Text);
                    prop.Data = dtpDataAtualizada.Value;
                    prop.Preco = txtPreco.Text;
                    new DLDataProdutoOrcamento().Atualizar(prop);
                }
                else
                {
                    new DLDataProdutoOrcamento().Inserir(dataproduto);
                    MessageBox.Show("Data Cadastrado com Sucesso");
                }                
                CarregarGrid();
                txtDataId.Text = Convert.ToString(null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void msDeletarData_Click(object sender, EventArgs e)
        {
            try
            {
                var pergunta = "Deseja Realmente Excluir essa Data ? ";
                if (MessageBox.Show(pergunta, "ATENÇÂO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = 0;
                    int.TryParse(txtDataId.Text, out id);
                    if (id > 0)
                    {
                        new DLDataProdutoOrcamento().Excluir(new DataProdutoOrcamento { DataId = id });
                        MessageBox.Show("Data excluída com sucesso!");
                        CarregarGrid();
                        LimparCampos();
                        txtDataId.Text = Convert.ToString(null);

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

        private void msDeletarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                var pergunta = "Deseja realmente excluir esse material ? ";
                if (MessageBox.Show(pergunta, "ATENÇÂO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = 0;
                    int.TryParse(txtIdProduto.Text, out id);
                    if (id > 0)
                    {
                        new DLProdutosOrcamento().Excluir(new ProdutosOrcamento { ProdutoId = id });
                        MessageBox.Show("Material excluído com sucesso!");
                        CarregarGrid();
                        LimparCampos();
                        txtIdProduto.Text = Convert.ToString(null);
                        Close();
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            cmsSalvarConteudos.Show(btnSalvar, 1, btnSalvar.Height);
        }

        #region Apenas Metodos
        private void CarregarGrid()
        {
            try
            {
                var listar = new DLDataProdutoOrcamento().Listar().Where(p => p.ProdutoId == Convert.ToInt32(txtIdProduto.Text)).ToList();
                dgvData.DataSource = null;
                dgvData.DataSource = listar.OrderByDescending(p => p.Data).ToList();
                dgvData.Refresh();
                MontarGridData(dgvData);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void MontarGridData(object DgvData)
        {
            dgvData.DefaultCellStyle.Font = new Font("Calibri", 20F, GraphicsUnit.Pixel);
            var objBlControleGrid = new ControleGrid(dgvData);
            //Define quais colunas serão visíveis
            objBlControleGrid.DefinirVisibilidade(new List<string>() { "Data", "Preco" });
            //Define quais os cabeçalhos respectivos das colunas 
            objBlControleGrid.DefinirCabecalhos(new List<string>() { "Data da Atualização", "Valor" });
            //Define quais as larguras respectivas das colunas 
            objBlControleGrid.DefinirLarguras(new List<int>() { 40, 50, }, dgvData.Width - 15); //O total tem que ficar em 100% 
            //Define quais os alinhamentos respectivos do componentes das colunas 
            objBlControleGrid.DefinirAlinhamento(new List<string>() { "esquerda", "esquerda", "esquerda", "esquerda", "esquerda", "esquerda", });
            //Define a altura das linhas respectivas da Grid 
            objBlControleGrid.DefinirAlturaLinha(30);
        }
        private DataProdutoOrcamento LerData()
        {
            try
            {
                var data = new DataProdutoOrcamento();
                int id = 0;
                int.TryParse(txtDataId.Text, out id);
                if (id == 0)
                {
                    data.Data = dtpDataAtualizada.Value;
                    data.Preco = txtPreco.Text;
                    data.ProdutoId = Convert.ToInt32(txtIdProduto.Text);
                }
                return data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private bool Validarcampos()
        {
            return true;
        }
        private void LimparCampos()
        {
            txtFornecedor.Text = Convert.ToString(null);
            txtDataId.Text = Convert.ToString(null);
            txtIdProduto.Text = Convert.ToString(null);
            txtPreco.Text = Convert.ToString(null);
            txtProduto.Text = Convert.ToString(null);
            txtRendimento.Text = Convert.ToString(null);
            rtbComentario.Text = Convert.ToString(null);
        }
        private void BloquearGeradorId(bool desabilitar)
        {
            btnGerarId.Enabled = desabilitar;
        }
        private void HabilitarCampos(bool habilitar)
        {
            txtFornecedor.Enabled = habilitar;
            txtPreco.Enabled = habilitar;
            txtProduto.Enabled = habilitar;
            txtRendimento.Enabled = habilitar;
            btnSalvar.Enabled = habilitar;
            btnDeletar.Enabled = habilitar;
            btnLimpar.Enabled = habilitar;
            rtbComentario.Enabled = habilitar;
        }
        #endregion
    }
}
