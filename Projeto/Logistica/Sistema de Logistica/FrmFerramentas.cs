
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
    public partial class FrmFerramentas : Form
    {
        internal Ferramentas _ferramentas;
        public FrmFerramentas()
        {
            InitializeComponent();
        }

        private void FrmFerramentas_Load(object sender, EventArgs e)
        {
            try
            {
                CarregarGrid();

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
                    int.TryParse(txtFerramentaId.Text, out id);
                    if (id > 0)
                    {
                        var atualizar = new DLFerramentas().ConsultarPorId(id);
                        atualizar.Devolucao = dtpDevolucao.Value;
                        atualizar.Retirada = dtpRetirada.Value;
                        atualizar.Funcionario = txtNome.Text;
                        atualizar.Material = rtbEquipamento.Text;
                        switch (cbSelecionar.Text)//escolha
                        {
                            case "Pendente":
                                {
                                    cbSelecionar.Sorted = true;
                                    atualizar.StatusobraId = 1;
                                }
                                break;
                            case "Devolvido":
                                {
                                    cbSelecionar.Sorted = true;
                                    atualizar.StatusobraId = 10;
                                }
                                break;
                        }

                        new DLFerramentas().Atualizar(atualizar);
                        MessageBox.Show("Material devolvido com Sucesso!");
                    }
                    else
                    {
                        var novo = new Ferramentas();
                        novo.Devolucao = dtpDevolucao.Value;
                        novo.Retirada = dtpRetirada.Value;
                        novo.Funcionario = txtNome.Text;
                        novo.Material = rtbEquipamento.Text;
                        switch (cbSelecionar.Text)//escolha
                        {
                            case "Pendente":
                                {
                                    cbSelecionar.Sorted = true;
                                    novo.StatusobraId = 1;
                                }
                                break;
                            case "Devolvido":
                                {
                                    cbSelecionar.Sorted = true;
                                    novo.StatusobraId = 10;
                                }
                                break;
                        }
                        var idferramentas = new DLFerramentas().Inserir(novo);
                        MessageBox.Show(" Material " + idferramentas + " Retirado com Sucesso! ");
                    }
                    LimparCampos();
                    
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
                var pergunta = "Deseja realmente deletar o material que o funcionario retirou ? ";
                if (MessageBox.Show(pergunta, "ATENÇÂO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = 0;
                    int.TryParse(txtFerramentaId.Text, out id);
                    if (id > 0)
                    {
                        new DLFerramentas().Excluir(new Ferramentas { FerramentaId = id });
                        MessageBox.Show("Ferramenta excluída com sucesso!");
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

        private void dgvFerramentas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var ferramenta = dgvFerramentas.Rows[e.RowIndex].DataBoundItem as Ferramentas;
            if (ferramenta != null)
            {
                txtFerramentaId.Text = ferramenta.FerramentaId.ToString();
                txtNome.Text = ferramenta.Funcionario;
                rtbEquipamento.Text = ferramenta.Material;
                dtpRetirada.Value = ferramenta.Retirada;
                dtpDevolucao.Value = ferramenta.Devolucao;
                switch (ferramenta.StatusobraId)//escolha
                {
                    case 3:
                        {
                            cbSelecionar.Text = "Pendente";
                        }
                        break;
                    case 10:
                        {
                            cbSelecionar.Text = "Devolvido";
                        }
                        break;
                }
            }
        }

        #region Campo de Metodos
        private void LimparCampos()
        {
            dtpRetirada.Value = DateTime.Now;
            dtpDevolucao.Value = DateTime.Now;
            txtNome.Clear();
            rtbEquipamento.Clear();
            cbSelecionar.Text = Convert.ToString(null);
            txtFerramentaId.Clear();
            CarregarGrid();
        }

        private bool ValidarCampos()
        {
            if (txtNome.Text == "")
            {
                throw new Exception(" Informe quem Retirou ");
            }
            return true;
        }

        private void CarregarGrid()
        {
            try
            {
                var listarFerramentas = new DLFerramentas().Listar();
                dgvFerramentas.DataSource = listarFerramentas;
                MontarGrid(dgvFerramentas);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void MontarGrid(DataGridView dgvFerramentas)
        {
            try
            {
                dgvFerramentas.DefaultCellStyle.Font = new Font("Calibri", 20F, GraphicsUnit.Pixel);
                var objBlControleGrid = new ControleGrid(dgvFerramentas);
                //Define quais colunas serão visíveis
                objBlControleGrid.DefinirVisibilidade(new List<string>()
                { "Funcionario", "Retirada", "Devolucao", "Material"});
                //Define quais os cabeçalhos respectivos das colunas 
                objBlControleGrid.DefinirCabecalhos(new List<string>()
                {  "Funcionario", "Data retirada", "Data Devolução", "Material" });
                //Define quais as larguras respectivas das colunas 
                objBlControleGrid.DefinirLarguras(new List<int>() { 15, 15, 20,45 }, dgvFerramentas.Width - 25); //O total tem que ficar em 100% 
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
        #endregion

        private void dgvFerramentas_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < dgvFerramentas.Rows.Count; i++)
            {
                var valor = Convert.ToString(dgvFerramentas.Rows[i].Cells[5].Value);
                switch (valor)
                {
                    case "10":
                        dgvFerramentas.Rows[i].DefaultCellStyle.BackColor = Color.Lime;
                        break;
                    case "3":
                        dgvFerramentas.Rows[i].DefaultCellStyle.BackColor = Color.Yellow; break;

                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
    }
}
