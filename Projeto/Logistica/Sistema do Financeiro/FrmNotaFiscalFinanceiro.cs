using DAL.Entities.Financeiro;
using DAL.Entities.Logistica;
using DAL.Repository.Financeiro;
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

namespace Projeto.Logistica.Sistema_do_Financeiro
{
    public partial class FrmNotaFiscalFinanceiro : Form
    {
        internal FinanceiroProposta _notafiscal;
        public FrmNotaFiscalFinanceiro()
        {
            InitializeComponent();
        }
        private void FrmNotaFiscalFinanceiro_Load(object sender, EventArgs e)
        {
            try
            {
                HabilitarCampos(false);
                if (_notafiscal == null)
                    _notafiscal = new FinanceiroProposta();
                if (_notafiscal.IdProp > 0)
                {
                    HabilitarCampos(true);
                    _notafiscal = new DLFinanceiroProposta().ConsultarPorId(_notafiscal.IdProp);
                    txtGerarId.Text = _notafiscal.IdProp.ToString();
                    dtpDataEmissao.Value = _notafiscal.EmissaoNf;
                    dtpDataVencimento.Value = _notafiscal.VencimentoNf;
                    txtEndereco.Text = _notafiscal.Obra;
                    txtCliente.Text = _notafiscal.Cliente;
                    txtProposta.Text = _notafiscal.Proposta;
                    txtNotaFiscal.Text = _notafiscal.NotaFiscal;
                    rtbObeservacao.Text = _notafiscal.Comentario;
                    switch (_notafiscal.StatusObraId)//escolha
                    {
                        case 1:
                            {
                                rbEngenharia.Checked = true;
                            }
                            break;
                        case 2:
                            {
                                rbComercio.Checked = true;
                            }
                            break;
                        case 3:
                            {
                                rbPisos.Checked = true;
                            }
                            break;
                    }
                    CarregarMadeira();
                }
                else
                {
                    rbComercio.Checked = true;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        #region Tela Dados da Nota Fiscal    

        private void btnGerarId_Click(object sender, EventArgs e)
        {
            try
            {
                HabilitarCampos(true);
                var proposta = new FinanceiroProposta();
                proposta.StatusObraId = 2;//Pendente
                var id = new DLFinanceiroProposta().Inserir(proposta);//inserir
                txtGerarId.Text = id.ToString();
                Bloquear(false);
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
                bool camposSaoValidos = Validarcampos();
                if (camposSaoValidos == true)
                {
                    int id = 0;
                    int.TryParse(txtGerarId.Text, out id);
                    if (id > 0)
                    {
                        var atualizar = new DLFinanceiroProposta().ConsultarPorId(id);
                        atualizar.EmissaoNf = dtpDataEmissao.Value;
                        atualizar.VencimentoNf = dtpDataVencimento.Value;
                        atualizar.Cliente = txtCliente.Text;
                        atualizar.Proposta = txtProposta.Text;
                        atualizar.NotaFiscal = txtNotaFiscal.Text;
                        atualizar.Obra = txtEndereco.Text;
                        atualizar.Comentario = rtbObeservacao.Text;

                        if (rbEngenharia.Checked == true)
                            atualizar.StatusObraId = 1;
                        else if (rbComercio.Checked == true)
                            atualizar.StatusObraId = 2;
                        else if (rbPisos.Checked == true)
                            atualizar.StatusObraId = 3;

                        new DLFinanceiroProposta().Atualizar(atualizar);
                        MessageBox.Show("Informações Atualizada com Sucesso!");
                        LimparSalvar();
                    }
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnDeletarDados_Click(object sender, EventArgs e)
        {
            try
            {
                var pergunta = "Deseja Realmente deletar a Proposta ? ";
                if (MessageBox.Show(pergunta, "ATENÇÂO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = 0;
                    int.TryParse(txtGerarId.Text, out id);
                    if (id > 0)
                    {
                        new DLFinanceiroProposta().Excluir(new FinanceiroProposta { IdProp = id });
                        MessageBox.Show("Proposta excluída com sucesso!");
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

        private void bntLimparDados_Click(object sender, EventArgs e)
        {
            LimparSalvar();
        }

        private void txtCodigoCliente_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FrmClienteFinanceiro cliente = new FrmClienteFinanceiro();
                cliente.ShowDialog();
                var idcliente = cliente.idcliente;
                var nome = cliente.nome;
                txtCodigoCliente.Text = idcliente.ToString();
                txtCliente.Text = nome.ToString();
                cliente.Close();
                cliente.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        #endregion

        #region Tela Material nota fiscal

        private void btnPesquisarMaterial_Click(object sender, EventArgs e)
        {
            try
            {
                FrmEstoqueFinanceiro Fmadeira = new FrmEstoqueFinanceiro();
                Fmadeira.ShowDialog();
                var id = Fmadeira.idmadeira;
                var material = Fmadeira.material;
                var medida = Fmadeira.medida;
                var total = Fmadeira.total;
                txtCodigoMaterial.Text = id.ToString();
                txtMaterial.Text = material;
                txtUndMedida.Text = medida;
                txtQuantidade.Text = Convert.ToString(total);
                Fmadeira.Close();
                Fmadeira.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                var itensMaterialNovo = LerCamposMaterial();
                int itensMaterialAtualizar = 0;
                if (txtIdMaterial.Text != "")
                {
                    itensMaterialAtualizar = Convert.ToInt32(txtIdMaterial.Text);
                    MessageBox.Show("Item Atualizado com Sucesso");
                }
                int propostaid = 0;
                if (txtGerarId.Text != "")
                {
                    propostaid = Convert.ToInt32(txtGerarId.Text);
                }
                var listarmadeira = new DLItensMadeiraFinanceiro().Listar();
                var prop = listarmadeira.Where(ip =>
                                ip.IdProp == propostaid //por proppostaid
                                && ip.IdMadeira == itensMaterialAtualizar //por ItensPropostaId
                                ).FirstOrDefault();//Primeiro que encontrar
                if (prop != null && prop.IdMadeira > 0)
                {
                    prop.Codigo = Convert.ToInt32(txtCodigoMaterial.Text);
                    prop.Material = txtMaterial.Text;
                    prop.Medida = txtUndMedida.Text;
                    prop.Total = Convert.ToDecimal(txtQuantidade.Text);
                    new DLItensMadeiraFinanceiro().Atualizar(prop);
                }
                else
                {
                    new DLItensMadeiraFinanceiro().Inserir(itensMaterialNovo);
                }
                LimparMadeira();
                CarregarMadeira();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnLimparMaterial_Click(object sender, EventArgs e)
        {
            LimparMadeira();
        }

        private void btnDeletarMaterial_Click(object sender, EventArgs e)
        {
            try
            {
                var pergunta = "Deseja Realmente deletar o Material ? ";
                if (MessageBox.Show(pergunta, "ATENÇÂO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = 0;
                    int.TryParse(txtIdMaterial.Text, out id);
                    if (id > 0)
                    {
                        var prop = new DLItensMadeiraFinanceiro().ConsultarPorId(id);
                        if (prop.IdMadeira > 0)
                        {
                            new DLItensMadeiraFinanceiro().Excluir(prop);
                            CarregarMadeira();
                            LimparMadeira();
                        }
                        else
                        {
                            MessageBox.Show("id Invalido");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void dgvMaterial_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var listarMadeira = dgvMaterial.Rows[e.RowIndex].DataBoundItem as ItensmadeiraFinanceiro;
                if (listarMadeira != null)
                {
                    txtIdMaterial.Text = listarMadeira.IdMadeira.ToString();
                    txtMaterial.Text = listarMadeira.Material;
                    txtUndMedida.Text = listarMadeira.Medida;
                    txtQuantidade.Text = listarMadeira.Total.ToString();
                    txtCodigoMaterial.Text = listarMadeira.Codigo.ToString();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }

        #endregion

        #region Apenas Metodos

        private void CarregarMadeira()
        {
            try
            {
                var listarMadeira = new DLItensMadeiraFinanceiro().Listar().Where(p => p.IdProp == Convert.ToInt32(txtGerarId.Text)).ToList();
                dgvMaterial.DataSource = null;
                dgvMaterial.DataSource = listarMadeira;
                dgvMaterial.Refresh();
                MontarGridMadeira(dgvMaterial);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void MontarGridMadeira(DataGridView dgvMadeiras)
        {
            try
            {
                dgvMaterial.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 16F, GraphicsUnit.Pixel);
                var objBlControleGrid = new ControleGrid(dgvMaterial);
                //Define quais colunas serão visíveis
                objBlControleGrid.DefinirVisibilidade(new List<string>() { "Madeiras", "Medida", "Total", });
                //Define quais os cabeçalhos respectivos das colunas 
                objBlControleGrid.DefinirCabecalhos(new List<string>() { "Madeiras", "Unidade de Medida", "Saida Total", });
                //Define quais as larguras respectivas das colunas 
                objBlControleGrid.DefinirLarguras(new List<int>() { 60, 20, 20, }, dgvMaterial.Width - 15); //O total tem que ficar em 100% 
                //Define quais os alinhamentos respectivos do componentes das colunas 
                objBlControleGrid.DefinirAlinhamento(new List<string>() { "centro", "centro", "centro", "centro", "centro", "centro", "centro", });
                //Define a altura das linhas respectivas da Grid 
                objBlControleGrid.DefinirAlturaLinha(30);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void HabilitarCampos(bool habilitar)
        {
            dtpDataEmissao.Enabled = habilitar;
            dtpDataVencimento.Enabled = habilitar;
            txtProposta.Enabled = habilitar;
            txtNotaFiscal.Enabled = habilitar;
            txtEndereco.Enabled = habilitar;
            rtbObeservacao.Enabled = habilitar;
            btnDeletarDados.Enabled = habilitar;
            btnSalvar.Enabled = habilitar;
            btnInserir.Enabled = habilitar;
            btnLimparMaterial.Enabled = habilitar;
            bntLimparDados.Enabled = habilitar;
            btnPesquisarCliente.Enabled = habilitar;
            btnPesquisarMaterial.Enabled = habilitar;
        }

        private void Bloquear(bool desabilitar)
        {
            btnGerarId.Enabled = desabilitar;
        }

        private void LimparSalvar()
        {
            txtCliente.Text = Convert.ToString(null);
            txtProposta.Text = Convert.ToString(null);
            txtNotaFiscal.Text = Convert.ToString(null);
            txtEndereco.Text = Convert.ToString(null);
            rtbObeservacao.Text = Convert.ToString(null);
        }

        private bool Validarcampos()
        {
            if(txtNotaFiscal.Text == "")
            {
                MessageBox.Show("Informar a nota fiscal digitada.");
            }
            return true;
        }

        private ItensmadeiraFinanceiro LerCamposMaterial()
        {
            try
            {
                var iten = new ItensmadeiraFinanceiro();
                int id = 0;
                int.TryParse(txtIdMaterial.Text, out id);
                if (id == 0)
                {
                    iten.Material = txtMaterial.Text;
                    iten.Medida = txtUndMedida.Text;
                    iten.Total = Convert.ToDecimal(txtQuantidade.Text);
                    iten.IdProp = Convert.ToInt32(txtGerarId.Text);
                }
                return iten;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void LimparMadeira()
        {
            txtMaterial.Text = Convert.ToString(null);
            txtUndMedida.Text = Convert.ToString(null);
            txtQuantidade.Text = Convert.ToString(null);
            txtIdMaterial.Text = Convert.ToString(null);
            txtCodigoMaterial.Text = Convert.ToString(null);
        }

        #endregion

    }
}
