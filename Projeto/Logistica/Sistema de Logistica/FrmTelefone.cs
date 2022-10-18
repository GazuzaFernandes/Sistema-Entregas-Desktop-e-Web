using DAL.Entities.Logistica;
using DAL.Repository.Logistica;
using DAL.Repository.SenhaRestauracao;
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
    public partial class FrmTelefone : Form
    {
        public FrmTelefone()
        {
            InitializeComponent();
        }

        private void FrmTelefone_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void btnSalvarProposta_Click(object sender, EventArgs e)
        {
            try
            {
                bool camposSaoValidos = ValidarCampos();
                if (camposSaoValidos == true)
                {
                    int id = 0;
                    int.TryParse(txtTelefoneId.Text, out id);
                    if (id > 0)
                    {
                        var atualizar = new DLTelefone().ConsultarPorId(id);
                        atualizar.TelefoneId = Convert.ToInt32(txtTelefoneId.Text);
                        atualizar.Nome = txtNome.Text;
                        atualizar.Contato = txtTelefone.Text;
                        atualizar.Observacao = rtbObs.Text;
                        new DLTelefone().Atualizar(atualizar);
                        MessageBox.Show("Contato atualizado com sucesso");
                    }
                    else
                    {
                        var branco = new Telefone();
                        branco.Nome = txtNome.Text;
                        branco.Contato = txtTelefone.Text;
                        branco.Observacao = rtbObs.Text;
                        var idContato = new DLTelefone().Inserir(branco);
                        MessageBox.Show(" Contato " + idContato + " Criado com Sucesso");
                    }
                }
                txtTelefoneId.Clear();
                txtNome.Clear();
                txtTelefone.Clear();
                rtbObs.Clear();
                CarregarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnDeletarProposta_Click(object sender, EventArgs e)
        {
            try
            {
                int id = 0;
                int.TryParse(txtTelefoneId.Text, out id);
                if (id > 0)
                {
                    new DLTelefone().Excluir(new Telefone { TelefoneId = id });
                    MessageBox.Show("Telefone excluido com sucesso!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void dvgTelefone_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var telefones = dgvTelefone.Rows[e.RowIndex].DataBoundItem as Telefone;
                if (telefones != null)
                {
                    txtTelefoneId.Text = telefones.TelefoneId.ToString();
                    txtNome.Text = telefones.Nome;
                    txtTelefone.Text = telefones.Contato;
                    rtbObs.Text = telefones.Observacao;
                }
                CarregarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            CarregarGrid(true);
        }

        private void CarregarGrid(bool isPesquisar = false)
        {
            try
            {
                var listarTelefone = new DLTelefone().Listar();
                var pesquisa = txtNome.Text.ToLower();
                listarTelefone = listarTelefone.Where(p => p.Nome.ToLower().Contains(pesquisa)).ToList();
                dgvTelefone.DataSource = listarTelefone.OrderBy(p => p.Nome).ToList();
                MontarGrid(dgvTelefone);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void MontarGrid(DataGridView dvgTelefone)
        {
            try
            {
                dvgTelefone.DefaultCellStyle.Font = new Font("Calibri", 16F, GraphicsUnit.Pixel);
                var objBlControleGrid = new ControleGrid(dvgTelefone);
                //Define quais colunas serão visíveis
                objBlControleGrid.DefinirVisibilidade(new List<string>()
                { "Nome", "Contato","Observacao" });
                //Define quais os cabeçalhos respectivos das colunas 
                objBlControleGrid.DefinirCabecalhos(new List<string>()
                { "Nome", "Telefone","Observação" });
                //Define quais as larguras respectivas das colunas 
                objBlControleGrid.DefinirLarguras(new List<int>() { 15, 15, 70 }, dvgTelefone.Width - 25); //O total tem que ficar em 100% 
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

        private bool ValidarCampos()
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Informe o nome");
            }
            return true;
        }
    }
}
