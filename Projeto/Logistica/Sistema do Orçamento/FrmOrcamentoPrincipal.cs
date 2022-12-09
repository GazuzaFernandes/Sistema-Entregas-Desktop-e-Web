
using DAL.Entities.Orcamento;
using DAL.Repository.Orcamento;
using Logistica.Sistema_de_Logistica;
using Projeto;
using Projeto.Logistica.Sistema_do_Orçamento;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logistica.Sistema_do_Orçamento
{
    public partial class FrmOrcamentoPrincipal : Form
    {
        public FrmOrcamentoPrincipal()
        {
            InitializeComponent();
        }

        private void FrmOrcamentoPrincipal_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void FrmOrcamentoPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                var listaProp = new DLProdutosOrcamento().Listar();
                CarregarGridProdutos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            FrmCadastrarValores cadastrar = new FrmCadastrarValores();
            cadastrar.ShowDialog();
            CarregarGridProdutos();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CarregarGridProdutos(true);
            MontarGridProdutos(dgvValores);
        }

        private void btnLimparPesquisa_Click(object sender, EventArgs e)
        {
            txtPesquisar.Text = Convert.ToString(null);
            CarregarGridProdutos();
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            CarregarGridProdutos(true);
            MontarGridProdutos(dgvValores);
        }

        private void dgvValores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var produtos = new ProdutosOrcamento();
                produtos.ProdutoId = Convert.ToInt32(dgvValores.Rows[e.RowIndex].Cells[0].Value);
                FrmCadastrarValores vaalores = new FrmCadastrarValores();
                vaalores._produto = produtos;
                vaalores.ShowDialog();
                CarregarGridProdutos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }

        private void txtPesquisar_Click(object sender, EventArgs e)
        {
            txtPesquisar.Clear();
        }

        #region Apenas Metodos
        private void CarregarGridProdutos(bool isPesquisa = false)
        {
            try
            {
                var listarProdutos = new DLProdutosOrcamento().Listar();
                var pesquisa = txtPesquisar.Text;

                listarProdutos = listarProdutos.Where(p => p.Produto.ToLower().Contains(pesquisa)).ToList();

                dgvValores.DataSource = listarProdutos.OrderBy(p => p.Fornecedor).ToList();
                MontarGridProdutos(dgvValores);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void MontarGridProdutos(DataGridView dgvValores)
        {
            dgvValores.DefaultCellStyle.Font = new Font("Calibri", 20F, GraphicsUnit.Pixel);
            var objBlControleGrid = new ControleGrid(dgvValores);
            //Define quais colunas serão visíveis
            objBlControleGrid.DefinirVisibilidade(new List<string>() { "Fornecedor", "Produto", "Preco", "Rendimento", "Comentario" });
            //Define quais os cabeçalhos respectivos das colunas 
            objBlControleGrid.DefinirCabecalhos(new List<string>() { "Fornecedor", "Produto", "Preço", "Rendimento", "Descrição" });
            //Define quais as larguras respectivas das colunas 
            objBlControleGrid.DefinirLarguras(new List<int>() { 10, 35, 20, 10, 20 }, dgvValores.Width - 15); //O total tem que ficar em 100% 
            //Define quais os alinhamentos respectivos do componentes das colunas 
            objBlControleGrid.DefinirAlinhamento(new List<string>() { "esquerda", "esquerda", "esquerda", "esquerda", "esquerda", "esquerda", });
            //Define a altura das linhas respectivas da Grid 
            objBlControleGrid.DefinirAlturaLinha(30);
        }
        #endregion

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmEscolha escolha = new FrmEscolha();
            escolha.ShowDialog();
        }

        private void FrmOrcamentoPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {

            try
            {
                var pergunta = "Deseja abrir a tela de escolha de sistema ?";
                if (MessageBox.Show(pergunta, "ATENÇÂO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Hide();
                    FrmEscolha escolha = new FrmEscolha();
                    escolha.ShowDialog();
                }
                else
                {
                    var novaPergunta = "Deseja finalizar o sistema ?";
                    if (MessageBox.Show(novaPergunta, "ATEÇÃO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Application.Exit();
                    }
                    else
                    {
                        Hide();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }
}
