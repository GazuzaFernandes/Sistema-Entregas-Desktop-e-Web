using DAL.Entities.Engenharia;
using DAL.Entities.Logistica;
using DAL.Repository.Engenharia;
using Logistica.Sistema_de_Logistica;
using Projeto;
using Projeto.Logistica.Sistema_de_Logistica;
using Projeto.Logistica.Sistema_dos_Engenheiros;
using Projeto.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Projeto.Backup.Backup;

namespace Logistica.Sistema_dos_Engenheiros
{
    public partial class FrmPrincipalEng : Form
    {
        public FrmPrincipalEng()
        {
            InitializeComponent();
        }

        private void FrmPrincipalEng_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CarregarGrid(true);
        }

        private void btnLimparPesquisa_Click(object sender, EventArgs e)
        {
            txtPesquisar.Text = Convert.ToString("Digite para pesquisa:");
            rbCliente.Checked = false;
            rbEndereço.Checked = false;
            rbProposta.Checked = false;
            cbEmpresas.Text = Convert.ToString(null);
            CarregarGrid();
        }

        private void dgvPrincipal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var prop = new PropostaEngenharia();
            prop.EngenhariaId = Convert.ToInt32(dgvPrincipal.Rows[e.RowIndex].Cells[0].Value);
            FrmPropostaEng principalEng = new FrmPropostaEng();
            principalEng._propostaEng = prop;
            principalEng.ShowDialog();
            CarregarGrid();
        }

        private void dgvPrincipal_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < dgvPrincipal.Rows.Count; i++)
            {
                var valor = Convert.ToString(dgvPrincipal.Rows[i].Cells[7].Value);
                switch (valor)
                {
                    case "1" : dgvPrincipal.Rows[i].DefaultCellStyle.BackColor = Color.Yellow; break;
                    case "2": dgvPrincipal.Rows[i].DefaultCellStyle.BackColor = Color.Lime; break;
                    case "3": dgvPrincipal.Rows[i].DefaultCellStyle.BackColor = Color.Red; break;                    
                }
            }
        }

        private void btnProposta_Click(object sender, EventArgs e)
        {
            FrmPropostaEng principalEng = new FrmPropostaEng();
            principalEng.Show();
            CarregarGrid();
        }
        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            CarregarGrid(true);
        }

        private void txtPesquisar_Click(object sender, EventArgs e)
        {
            txtPesquisar.Clear();
        }


        #region Apenas Metodos

        private void CarregarGrid(bool isPesquisa = false)
        {
            try
            {
                var listarEng = new DLPropostaEngenharia().Listar();
                if (isPesquisa)
                {
                    var pesquisar = txtPesquisar.Text.ToLower();
                    if (rbCliente.Checked)                    
                        listarEng = listarEng.Where(p => p.Cliente.ToLower().Contains(pesquisar)).ToList();                   
                    else if (rbEndereço.Checked)                    
                        listarEng = listarEng.Where(p => p.Obra.ToLower().Contains(pesquisar)).ToList();                   
                    else if (rbProposta.Checked)                    
                      listarEng = listarEng.Where(p => p.Proposta.ToLower().Contains(pesquisar)).ToList();
                    switch (cbEmpresas.Text)
                    {
                        case "Em Obra.":
                            {

                                listarEng = listarEng.Where(p => p.StatusObraId.Equals(1)).ToList();
                            }
                            break;
                        case "Finalizado.":
                            {
                                listarEng = listarEng.Where(p => p.StatusObraId.Equals(2)).ToList();
                            }
                            break;
                        case "Cancelado.":
                            {
                                listarEng = listarEng.Where(p => p.StatusObraId.Equals(3)).ToList();
                            }
                            break;
                    }
                }
                dgvPrincipal.DataSource = listarEng.OrderBy(p => p.StatusObraId).ToList(); ;
                MontarGrid(dgvPrincipal);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex.Message);
            }
        }

        private void MontarGrid(DataGridView dgvPrincipal)
        {
            dgvPrincipal.DefaultCellStyle.Font = new Font("Calibri", 20F, GraphicsUnit.Pixel);
            var objBlControleGrid = new ControleGrid(dgvPrincipal);
            //Define quais colunas serão visíveis
            objBlControleGrid.DefinirVisibilidade(new List<string>()
            { "Proposta", "Cliente", "Funcionario", "Responsavel", "Telefone", });
            //Define quais os cabeçalhos respectivos das colunas 
            objBlControleGrid.DefinirCabecalhos(new List<string>() 
            { "Proposta", "Cliente", "Funcionario", "Resp.", "Telefone",});
            //Define quais as larguras respectivas das colunas 
            objBlControleGrid.DefinirLarguras(new List<int>() { 20, 20,20,20,20 }, dgvPrincipal.Width - 25); //O total tem que ficar em 100% 
            objBlControleGrid.DefinirAlinhamento(new List<string>()
            { "esquerda", "esquerda", "esquerda", "esquerda", "esquerda", "esquerda", "esquerda", "esquerda", "esquerda", });
            //Define a altura das linhas respectivas da Grid 
            objBlControleGrid.DefinirAlturaLinha(30);
        }
        #endregion

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmEscolha escolha = new FrmEscolha();
            escolha.ShowDialog();
        }

        private void FrmPrincipalEng_FormClosing(object sender, FormClosingEventArgs e)
        { 

        }

        private void FrmPrincipalEng_FormClosed(object sender, FormClosedEventArgs e)
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
                        Systembackup.Restauracao();
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
