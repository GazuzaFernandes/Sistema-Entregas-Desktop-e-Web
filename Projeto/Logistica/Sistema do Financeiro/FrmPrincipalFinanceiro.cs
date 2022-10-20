using DAL.Entities.Financeiro;
using DAL.Entities.Logistica;
using DAL.Repository.Financeiro;
using DAL.Repository.Logistica;
using Logistica.Sistema_de_Logistica;
using Projeto.Logistica.Sistema_do_Financeiro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logistica.Sistema_do_Financeiro
{
    public partial class FrmPrincipalFinanceiro : Form
    {
        public FrmPrincipalFinanceiro()
        {
            InitializeComponent();
        }

        private void FrmPrincipalFinanceiro_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void FrmPrincipalFinanceiro_Load(object sender, EventArgs e)
        {
            try
            {
                Carregargrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            Carregargrid(true);
            MontarGrid(dgvNotaFiscais);
        }

        private void txtPesquisar_Click(object sender, EventArgs e)
        {
            txtPesquisar.Clear();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Carregargrid(true);
            MontarGrid(dgvNotaFiscais);
        }

        private void btnLimparPesquisa_Click(object sender, EventArgs e)
        {
            txtPesquisar.Clear();
            rbEndereco.Checked = false;
            rbNotaFiscal.Checked = false;
            rbProposta.Checked = false;
            cbEmpresas.Text = Convert.ToString(null);
        }

        private void msInserir_Click(object sender, EventArgs e)
        {
            FrmNotaFiscalFinanceiro lancarNotaFiscal = new FrmNotaFiscalFinanceiro();
            lancarNotaFiscal.ShowDialog();
            Carregargrid();
        }

        private void msEstoque_Click(object sender, EventArgs e)
        {
            FrmEstoqueFinanceiro material = new FrmEstoqueFinanceiro();
            material.ShowDialog();
        }

        private void msCliente_Click(object sender, EventArgs e)
        {
            FrmClienteFinanceiro cliente = new FrmClienteFinanceiro();
            cliente.ShowDialog();
        }

        private void dgvNotaFiscais_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var prop = new FinanceiroProposta();
                prop.IdProp = Convert.ToInt32(dgvNotaFiscais.Rows[e.RowIndex].Cells[0].Value);
                FrmNotaFiscalFinanceiro propFinanceiro = new FrmNotaFiscalFinanceiro();
                propFinanceiro._notafiscal = prop;
                propFinanceiro.ShowDialog();
                Carregargrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }

        private void dgvNotaFiscais_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < dgvNotaFiscais.Rows.Count; i++)
            {
                var valor = Convert.ToString(dgvNotaFiscais.Rows[i].Cells[8].Value);
                switch (valor)
                {
                    case "5": dgvNotaFiscais.Rows[i].DefaultCellStyle.BackColor = Color.Turquoise; break;
                    case "6": dgvNotaFiscais.Rows[i].DefaultCellStyle.BackColor = Color.Lime; break;
                    case "7": dgvNotaFiscais.Rows[i].DefaultCellStyle.BackColor = Color.Yellow; break;
                }
            }
        }

        #region Apenas Metodos
        private void Carregargrid(bool isPesquisa = false)
        {
            try
            {
                var listarFinanceiro = new DLFinanceiroProposta().Listar();
                if (isPesquisa) //isPesquisa == true
                {
                    var pesquisa = txtPesquisar.Text.ToLower();
                    if (rbEndereco.Checked)
                        listarFinanceiro = listarFinanceiro.Where(p => p.Obra.ToLower().Contains(pesquisa)).ToList();
                    else if (rbProposta.Checked)
                        listarFinanceiro = listarFinanceiro.Where(p => p.Propostas.ToLower().Contains(pesquisa)).ToList();
                    else if (rbNotaFiscal.Checked)
                        listarFinanceiro = listarFinanceiro.Where(p => p.NotaFiscal.ToLower().Contains(pesquisa)).ToList();
                    switch (cbEmpresas.Text)
                    {
                        case "Rb Engenharia":
                            {
                                listarFinanceiro = listarFinanceiro.Where(p => p.StatusObraId.Equals(5)).ToList();
                            }
                            break;
                        case "Rb Pisos":
                            {
                                listarFinanceiro = listarFinanceiro.Where(p => p.StatusObraId.Equals(7)).ToList();
                            }
                            break;
                        case "Rb Comercio":
                            {
                                listarFinanceiro = listarFinanceiro.Where(p => p.StatusObraId.Equals(6)).ToList();
                            }
                            break;
                    }

                }
                dgvNotaFiscais.DataSource = listarFinanceiro.OrderByDescending(p => p.StatusObraId).ToList();
                MontarGrid(dgvNotaFiscais);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void MontarGrid(DataGridView dgvNotaFiscais)
        {
            dgvNotaFiscais.DefaultCellStyle.Font = new Font("Calibri", 20F, GraphicsUnit.Pixel);
            var objBlControleGrid = new ControleGrid(dgvNotaFiscais);
            //Define quais colunas serão visíveis
            objBlControleGrid.DefinirVisibilidade(new List<string>()
            { "EmissaoNf", "VencimentoNf", "Cliente", "Propostas", "NotaFiscal", "Obra", });
            //Define quais os cabeçalhos respectivos das colunas 
            objBlControleGrid.DefinirCabecalhos(new List<string>() { "Emissão da NF", "Vencimento da NF", "Cliente", "Propostas", "Nota Fiscal", "Obra", });
            //Define quais as larguras respectivas das colunas 
            objBlControleGrid.DefinirLarguras(new List<int>() { 10, 15, 10, 10, 10, 40, }, dgvNotaFiscais.Width - 25); //O total tem que ficar em 100% 
            //Define quais os alinhamentos respectivos do componentes das colunas 
            objBlControleGrid.DefinirAlinhamento(new List<string>() { "esquerda", "esquerda", "esquerda", "esquerda", "esquerda", "esquerda", });
            //Define a altura das linhas respectivas da Grid 
            objBlControleGrid.DefinirAlturaLinha(30);
        }
        #endregion
    }
}
