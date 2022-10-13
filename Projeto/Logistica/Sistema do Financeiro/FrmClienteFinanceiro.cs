using DAL.Entities.Financeiro;
using DAL.Repository.Financeiro;
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

namespace Projeto.Logistica.Sistema_do_Financeiro
{
    public partial class FrmClienteFinanceiro : Form
    {
        public int idcliente;
        public string nome;
        public string email;
        public FrmClienteFinanceiro()
        {
            InitializeComponent();
        }

        private void FrmClienteFinanceiro_Load(object sender, EventArgs e)
        {
            try
            {
                CarregarGridCliente();
                BloquearInserir(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);                
            }          
        }    

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                idcliente = Convert.ToInt32(txtClienteId.Text);
                nome = txtCliente.Text;
                Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                bool camposSaoValidos = ValidarCampos();
                if (camposSaoValidos == true)
                {
                    int id = 0;
                    int.TryParse(txtClienteId.Text, out id);
                    if (id > 0)
                    {
                        var clieAtualizar = new DLCLienteFinanceiro().ConsultarPorId(id);
                        clieAtualizar.IdCliente = Convert.ToInt32(txtClienteId.Text);
                        clieAtualizar.Nome = txtCliente.Text;
                        new DLCLienteFinanceiro().Atualizar(clieAtualizar);
                        MessageBox.Show("Cliente atualizado com Sucesso ");
                    }
                    else
                    {
                        var clieBranco = new ClientesFinanceiro();
                        clieBranco.Nome = txtCliente.Text;
                        var idCliente = new DLCLienteFinanceiro().Inserir(clieBranco);
                        MessageBox.Show(" Cliente " + idCliente + " Criado com Sucesso");
                    }
                }
                LimparCampos();
                CarregarGridCliente();
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
                var pergunta = "Deseja Realmente Deletar esse Cliente ou Empresa ? ";
                if (MessageBox.Show(pergunta, "ATENÇÂO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = 0;
                    int.TryParse(txtClienteId.Text, out id);
                    if (id > 0)
                    {
                        new DLCLienteFinanceiro().Excluir(new ClientesFinanceiro { IdCliente = id });
                        MessageBox.Show("Cliente ou Empresa excluída com sucesso!");
                        CarregarGridCliente();
                        txtClienteId.Text = Convert.ToString(null);
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

        private void dgvCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var cliente = dgvCliente.Rows[e.RowIndex].DataBoundItem as ClientesFinanceiro;
                if (cliente != null)
                {
                    txtClienteId.Text = cliente.IdCliente.ToString();
                    txtCliente.Text = cliente.Nome;
                }
                BloquearInserir(true);
                CarregarGridCliente();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            CarregarGridCliente(true);
            MontarGridCliente(dgvCliente);
        }

        #region Apenas Metodos
        private void CarregarGridCliente(bool isPesquisa = false)
        {
            try
            {
                var listarCliente = new DLCLienteFinanceiro().Listar();
                if (isPesquisa) //isPesquisa == true
                {
                    var pesquisa = txtCliente.Text.ToLower();
                    listarCliente = listarCliente.Where(p => p.Nome.ToLower().Contains(pesquisa)).ToList();
                }
                dgvCliente.DataSource = listarCliente.OrderBy(p => p.Nome).ToList();
                MontarGridCliente(dgvCliente);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void MontarGridCliente(DataGridView dgvCliente)
        {
            try
            {
                dgvCliente.DefaultCellStyle.Font = new Font("Calibri", 16F, GraphicsUnit.Pixel);
                var objBlControleGrid = new ControleGrid(dgvCliente);
                //Define quais colunas serão visíveis
                objBlControleGrid.DefinirVisibilidade(new List<string>() { "Nome", });
                //Define quais os cabeçalhos respectivos das colunas 
                objBlControleGrid.DefinirCabecalhos(new List<string>() { "Cliente", });
                //Define quais as larguras respectivas das colunas 
                objBlControleGrid.DefinirLarguras(new List<int>() { 100, }, dgvCliente.Width - 15); //O total tem que ficar em 100% 
                //Define quais os alinhamentos respectivos do componentes das colunas 
                objBlControleGrid.DefinirAlinhamento(new List<string>() { "centro", "centro", "centro", "centro", "centro", });
                //Define a altura das linhas respectivas da Grid 
                objBlControleGrid.DefinirAlturaLinha(30);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void LimparCampos()
        {
            txtClienteId.Text = Convert.ToString(null);
            txtCliente.Text = Convert.ToString(null);
        }
        private bool ValidarCampos()
        {
            if (txtCliente.Text == "")
            {
                MessageBox.Show("Informe o cliente");
            }
            return true;
        }

        private void BloquearInserir(bool liberar)
        {
            btnInserir.Enabled = liberar;
        }
        #endregion

    }
}
