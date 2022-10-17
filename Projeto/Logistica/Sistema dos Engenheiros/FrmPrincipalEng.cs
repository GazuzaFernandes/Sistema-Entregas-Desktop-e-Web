using DAL.Entities.Engenharia;
using DAL.Entities.Logistica;
using DAL.Repository.Engenharia;
using Logistica.Sistema_de_Logistica;
using Projeto.Logistica.Sistema_de_Logistica;
using Projeto.Logistica.Sistema_dos_Engenheiros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                    case "2": dgvPrincipal.Rows[i].DefaultCellStyle.BackColor = Color.LightBlue; break;
                    case "3": dgvPrincipal.Rows[i].DefaultCellStyle.BackColor = Color.Lime; break;                    
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
                    {
                        listarEng = listarEng.Where(p => p.Cliente.ToLower().Contains(pesquisar)).ToList();
                    }
                    else if (rbEndereço.Checked)
                    {
                        listarEng = listarEng.Where(p => p.Obra.ToLower().Contains(pesquisar)).ToList();
                    }
                    else if (rbProposta.Checked)
                    {
                        listarEng = listarEng.Where(p => p.Proposta.ToLower().Contains(pesquisar)).ToList();
                    }
                }
                dgvPrincipal.DataSource = listarEng;
                MontarGrid(dgvPrincipal);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex.Message);
            }
        }

        private void MontarGrid(DataGridView dgvPrincipal)
        {
            dgvPrincipal.DefaultCellStyle.Font = new Font("Calibri", 16F, GraphicsUnit.Pixel);
            var objBlControleGrid = new ControleGrid(dgvPrincipal);
            //Define quais colunas serão visíveis
            objBlControleGrid.DefinirVisibilidade(new List<string>()
            { "Proposta", "Cliente", "Funcionario", "Responsavel", "Telefone", });
            //Define quais os cabeçalhos respectivos das colunas 
            objBlControleGrid.DefinirCabecalhos(new List<string>() 
            { "Proposta", "Cliente", "Funcionario", "Resp.", "Telefone",});
            //Define quais as larguras respectivas das colunas 
            objBlControleGrid.DefinirLarguras(new List<int>() { 20, 20,20,20,20 }, dgvPrincipal.Width - 15); //O total tem que ficar em 100% 
            objBlControleGrid.DefinirAlinhamento(new List<string>()
            { "esquerda", "esquerda", "esquerda", "esquerda", "esquerda", "esquerda", "esquerda", "esquerda", "esquerda", });
            //Define a altura das linhas respectivas da Grid 
            objBlControleGrid.DefinirAlturaLinha(30);
        }
        #endregion

    }
}
