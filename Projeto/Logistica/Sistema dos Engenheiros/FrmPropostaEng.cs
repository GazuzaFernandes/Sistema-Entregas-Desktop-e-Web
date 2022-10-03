using DALLogistica.Entities;
using DALLogistica.Repository;
using DALSenhas.Repository;
using Logistica.Sistema_de_Logistica;
using Projeto.Logistica.Sistema_de_Logistica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto.Logistica.Sistema_dos_Engenheiros
{
    public partial class FrmPropostaEng : Form
    {
        public FrmPropostaEng()
        {
            InitializeComponent();
        }

        private void FrmPropostaEng_Load(object sender, EventArgs e)
        {
            try
            {
                HabilitarCampos(false);
                #region _proposta
                if (_proposta == null)
                    _proposta = new Proposta();
                if (_proposta.PropostaId > 0)
                {
                    HabilitarCampos(true);
                    #region Codigos
                    _proposta = new DLProposta().ConsultarPorId(_proposta.PropostaId);
                    txtPropostId.Text = _proposta.PropostaId.ToString();
                    dtpDataPedido.Value = _proposta.DataPrevista;
                    dtpDataPedido.Value = _proposta.DataPedido;
                    txtEmpresa.Text = _proposta.Fabrica;
                    cbComentado.Text = _proposta.Faturado;
                    txtFormaPagamento.Text = _proposta.FormaPag;
                    txtEngResponsavel.Text = _proposta.EngResp;
                    txtTelefone.Text = _proposta.Telefone;
                    txtPdRb.Text = _proposta.PdRb;
                    txtPdVenda.Text = _proposta.PdVenda;
                    txtProposta.Text = _proposta.Propostaa;
                    txtEmpresa.Text = _proposta.Construtora;
                    txtObra.Text = _proposta.Obra;
                    dtpDataEntrega.Value = _proposta.DataEntrega;
                    txtRecebido.Text = _proposta.RecebidoPor;
                    txtNotaFiscal.Text = _proposta.NotaFiscal;
                    txtCarreto.Text = _proposta.Carreto;
                    rtbMaterial.Text = _proposta.Material;
                    #endregion
                    switch (_proposta.StatusobraId)//escolha
                    {
                        case 1:
                            {
                                rbImediato.Checked = true;
                            }
                            break;
                        case 2:
                            {
                                rbPendente.Checked = true;
                            }
                            break;
                        case 3:
                            {
                                rbFinalizado.Checked = true;
                            }
                            break;
                        case 4:
                            {
                                rbCancelado.Checked = true;
                            }
                            break;
                    }
                    CarregarGridItensProposta();
                    CarregarGridHistorico();
                    BloquearBotao(false);
                }
                else
                {
                    rbImediato.Checked = true;
                }
                #endregion
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
                var proposta = new Proposta();
                proposta.StatusobraId = 2;//Pendente
                var id = new DLProposta().Inserir(proposta);//inserir
                txtPropostId.Text = id.ToString();
                BloquearBotao(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnSalvarProposta_Click(object sender, EventArgs e)
        {
            cmsSalvarConteudos.Show(btnSalvarProposta, 1, btnSalvarProposta.Height);
        }

        private void btnDeletarProposta_Click(object sender, EventArgs e)
        {
            try
            {
                var pergunta = "Deseja Realmente excluir essa proposta ? ";
                if (MessageBox.Show(pergunta, "ATENÇÂO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    FrmLogin login = new FrmLogin();
                    login.ShowDialog();
                    Boolean temUsuario = false;
                    var listaUsuarios = new DLSenha().Listar();
                    for (int i = 0; i < listaUsuarios.Count; i++)
                    {
                        if (listaUsuarios[i].Senhas == login.txtSenha.Text)
                        {
                            temUsuario = true;
                        }
                    }
                    if (temUsuario == true)
                    {
                        int ide = 0;
                        int.TryParse(txtPropostId.Text, out ide);
                        if (ide > 0)
                        {
                            new DLProposta().Excluir(new Proposta { PropostaId = ide });
                            MessageBox.Show("Proposta excluída com sucesso!");
                            Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnLimparComentario_Click(object sender, EventArgs e)
        {
            txtIdHistorico.Clear();
            rtbComentario.Clear();
            CarregarGridHistorico();
        }

        private void btnDeletarComentario_Click(object sender, EventArgs e)
        {
            try
            {
                int id = 0;
                int.TryParse(txtIdHistorico.Text, out id);
                if (id > 0)
                {
                    var prop = new DLHistorico().ConsultarPorId(id);
                    if (prop.HistoricoId > 0)
                    {
                        new DLHistorico().Excluir(prop);
                        txtIdHistorico.Clear();
                        CarregarGridHistorico();
                    }
                    else
                    {
                        MessageBox.Show("Falha ao excluir o item da proposta");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void mtSalvarProposta_Click(object sender, EventArgs e)
        {
            try
            {
                bool camposSaoValidos = ValidarCampos();
                if (camposSaoValidos == true)
                {
                    int id = 0;
                    int.TryParse(txtPropostId.Text, out id);
                    if (id > 0)
                    {
                        var pAtua = new DLProposta().ConsultarPorId(id);
                        pAtua.DataPrevista = dtpDataPedido.Value;
                        pAtua.DataPedido = dtpDataPedido.Value;
                        pAtua.Fabrica = txtEmpresa.Text;
                        pAtua.FormaPag = txtFormaPagamento.Text;
                        pAtua.EngResp = txtEngResponsavel.Text;
                        pAtua.Telefone = txtTelefone.Text;
                        pAtua.PdRb = txtPdRb.Text;
                        pAtua.PdVenda = txtPdVenda.Text;
                        pAtua.Propostaa = txtProposta.Text;
                        pAtua.Construtora = txtEmpresa.Text;
                        pAtua.Obra = txtObra.Text;
                        pAtua.DataEntrega = dtpDataEntrega.Value;
                        pAtua.RecebidoPor = txtRecebido.Text;
                        pAtua.NotaFiscal = txtNotaFiscal.Text;
                        pAtua.Carreto = txtCarreto.Text;
                        pAtua.Material = rtbMaterial.Text;
                        switch (cbComentado.Text)
                        {
                            case "Rb Comercio":
                                {
                                    cbComentado.Sorted = true;
                                }
                                break;
                            case "Rb Engenharia":
                                {
                                    cbComentado.Sorted = true;
                                }
                                break;
                            case "Rb Pisos":
                                {
                                    cbComentado.Sorted = true;
                                }
                                break;
                            case "Nome do Cliente":
                                {
                                    cbComentado.Sorted = true;
                                }
                                break;
                        }
                        if (rbImediato.Checked == true)
                            pAtua.StatusobraId = 1;
                        else if (rbPendente.Checked == true)
                            pAtua.StatusobraId = 2;
                        else if (rbFinalizado.Checked == true)
                            pAtua.StatusobraId = 3;
                        else if (rbCancelado.Checked == true)
                            pAtua.StatusobraId = 4;
                        new DLProposta().Atualizar(pAtua);
                        MessageBox.Show("Proposta Atualizada com Sucesso!");
                        LimparDadosProposta();
                    }
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void mtSalvarComentario_Click(object sender, EventArgs e)
        {
            try
            {
                bool validarComentario = ValidarComentario();
                if (validarComentario == true)
                {
                    if (rtbComentario.Text != "")
                    {
                        var comentario = LerComentario();
                        int historicoComentario = 0;
                        if (txtIdHistorico.Text != "")
                        {
                            historicoComentario = Convert.ToInt32(txtIdHistorico.Text);
                        }
                        int propostaid = 0;
                        if (txtPropostId.Text != "")
                        {
                            propostaid = Convert.ToInt32(txtPropostId.Text);
                        }
                        var listaHistorico = new DLHistorico().Listar();
                        //Filtrando a lista "listaProposta" por propostaid e codigomaterial
                        var prop = listaHistorico.Where(ip => ip.PropostaId == propostaid //por proppostaid
                                        && ip.HistoricoId == historicoComentario //por ItensPropostaId
                                        ).FirstOrDefault();//Primeiro que encontrar
                        if (prop != null && prop.HistoricoId > 0)
                        {
                            prop.Comentario = rtbComentario.Text;
                            prop.DataComentario = dtpHistorico.Value;
                            new DLHistorico().Atualizar(prop);
                        }
                        else
                        {
                            new DLHistorico().Inserir(comentario);
                        }
                        CarregarGridHistorico();
                        rtbComentario.Clear();
                        txtIdHistorico.Clear();
                    }
                }

                else
                {
                    MessageBox.Show("Insiera algum comentario para salvar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        #region Campo de Metodos
        private bool ValidarComentario()
        {
            if (cbComentado.Text == "")
            {
                MessageBox.Show("Informe o Engenheiro que fez a visita.")
            }
            return true;
        }
        private void CarregarGridHistorico()
        {
            try
            {
                var listarHistorico = new DLHistorico().Listar().Where(p => p.PropostaId == Convert.ToInt32(txtPropostId.Text)).ToList();
                dgvHistorico.DataSource = null;
                dgvHistorico.DataSource = listarHistorico.OrderByDescending(p => p.DataComentario).ToList();
                dgvHistorico.Refresh();
                MontarGridHistorico();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void MontarGridHistorico()
        {
            try
            {
                dgvHistorico.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 16F, GraphicsUnit.Pixel);
                var objBlControleGrid = new ControleGrid(dgvHistorico);
                //Define quais colunas serão visíveis
                objBlControleGrid.DefinirVisibilidade(new List<string>() { "DataComentario", "Comentario", });
                //Define quais os cabeçalhos respectivos das colunas 
                objBlControleGrid.DefinirCabecalhos(new List<string>() { "Data do Comentario", "Comentario", });
                //Define quais as larguras respectivas das colunas 
                objBlControleGrid.DefinirLarguras(new List<int>() { 20, 80 }, dgvHistorico.Width - 15); //O total tem que ficar em 100% 
                //Define quais os alinhamentos respectivos do componentes das colunas 
                objBlControleGrid.DefinirAlinhamento(new List<string>() { "esquerda", "centro", });
                //Define a altura das linhas respectivas da Grid 
                objBlControleGrid.DefinirAlturaLinha(30);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void BloquearBotao(bool desabilitar)
        {
            btnGerarId.Enabled = desabilitar;
        }
        private void CarregarGridItensProposta()
        {
            try
            {
                var listaItensProposta = new DLItensProposta().Listar().Where(p => p.PropostaId == Convert.ToInt32(txtPropostId.Text)).ToList();
                dgvitensProposta.DataSource = null;
                dgvitensProposta.DataSource = listaItensProposta;
                dgvitensProposta.Refresh();
                MontarGridItensProposta(dgvitensProposta);
                txtCustoMaterial.Text = listaItensProposta.Sum(p => p.Total).ToString("C");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void MontarGridItensProposta(DataGridView dgvmaterial)
        {
            try
            {
                dgvitensProposta.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 16F, GraphicsUnit.Pixel);
                var objBlControleGrid = new ControleGrid(dgvitensProposta);
                //Define quais colunas serão visíveis
                objBlControleGrid.DefinirVisibilidade(new List<string>() { "Material", "UndMedida", "Quantidade", "Preco", "M2NotaFiscal", "ObsMaterial", "Total", });
                //Define quais os cabeçalhos respectivos das colunas 
                objBlControleGrid.DefinirCabecalhos(new List<string>() { "Material", "Und Medida", "Quantidade", "Valor", "Qtd Caixa", "Obs Material", "Total" });
                //Define quais as larguras respectivas das colunas 
                objBlControleGrid.DefinirLarguras(new List<int>() { 51, 5, 8, 7, 5, 10, 10 }, dgvitensProposta.Width - 15); //O total tem que ficar em 100% 
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
        private void HabilitarCampos(bool Habilitar)
        {
            txtCodigoFabrica.Enabled = Habilitar;
            txtFormaPagamento.Enabled = Habilitar;
            txtEngResponsavel.Enabled = Habilitar;
            txtTelefone.Enabled = Habilitar;
            txtPdRb.Enabled = Habilitar;
            txtPdVenda.Enabled = Habilitar;
            txtCodigoCliente.Enabled = Habilitar;
            txtProposta.Enabled = Habilitar;
            txtObra.Enabled = Habilitar;
            rtbComentario.Enabled = Habilitar;
            txtCarreto.Enabled = Habilitar;
            txtNotaFiscal.Enabled = Habilitar;
            txtRecebido.Enabled = Habilitar;
            txtCodigoItensMaterial.Enabled = Habilitar;
            txtQuantidade.Enabled = Habilitar;
            txtPreco.Enabled = Habilitar;
            txtUndMedida.Enabled = Habilitar;
            txtQtdCaixas.Enabled = Habilitar;
            rtbObservacao.Enabled = Habilitar;
            rtbMaterial.Enabled = Habilitar;
            btnInserir.Enabled = Habilitar;
            btnLimpar.Enabled = Habilitar;
            btnDeletarItens.Enabled = Habilitar;
            btnSalvarProposta.Enabled = Habilitar;
            btnImprimir.Enabled = Habilitar;
            btnDeletarProposta.Enabled = Habilitar;
        }
        public void PegarDados_FormCadastroEmpresa()
        {
            try
            {
                FrmCadastraEmpresa cadasEmpr = new FrmCadastraEmpresa();
                cadasEmpr.ShowDialog();
                var id = cadasEmpr.empresaid;
                var empresa = cadasEmpr.empresa;
                switch (pesquisar)
                {
                    case 1:
                        {
                            txtCodigoFabrica.Text = id.ToString();
                            txtEmpresa.Text = empresa;
                        }
                        break;
                    case 2:
                        {
                            txtCodigoCliente.Text = id.ToString();
                            txtEmpresa.Text = empresa;
                        }
                        break;
                }
                cadasEmpr.Close();
                cadasEmpr.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void LimparDadosProposta()
        {
            txtCodigoFabrica.Text = Convert.ToString(null);
            txtFormaPagamento.Text = Convert.ToString(null);
            txtEngResponsavel.Text = Convert.ToString(null);
            txtTelefone.Text = Convert.ToString(null);
            txtPdRb.Text = Convert.ToString(null);
            txtPdVenda.Text = Convert.ToString(null);
            txtCodigoCliente.Text = Convert.ToString(null);
            txtProposta.Text = Convert.ToString(null);
            txtObra.Text = Convert.ToString(null);
            rtbComentario.Text = Convert.ToString(null);
            txtCarreto.Text = Convert.ToString(null);
            txtNotaFiscal.Text = Convert.ToString(null);
            txtRecebido.Text = Convert.ToString(null);
            txtCodigoItensMaterial.Text = Convert.ToString(null);
            txtQuantidade.Text = Convert.ToString(null);
            txtPreco.Text = Convert.ToString(null);
            txtUndMedida.Text = Convert.ToString(null);
            txtQtdCaixas.Text = Convert.ToString(null);
            rtbObservacao.Text = Convert.ToString(null);
            rtbMaterial.Text = Convert.ToString(null);
            dtpDataEntrega.Value = DateTime.Now;
            dtpDataPedido.Value = DateTime.Now;
            dtpDataPedido.Value = DateTime.Now;
        }
        private bool ValidarCampos()
        {
            if (txtProposta.Text == "")
            {
                throw new Exception(" Informe a Proposta ");
            }
            else if (rtbMaterial.Text == "")
            {
                throw new Exception("Informe o Material");
            }
            return true;
        }
        private void LimparCamposItens()
        {
            try
            {
                txtItensPropostaId.Text = Convert.ToString(null);
                txtCodigoItensMaterial.Text = Convert.ToString(null);
                txtMaterial.Text = Convert.ToString(null);
                txtQuantidade.Text = Convert.ToString(1);
                txtPreco.Text = Convert.ToString(0);
                txtQtdUndCaixa.Text = Convert.ToString(1);
                txtUndMedida.Text = Convert.ToString("m²");
                txtQtdCaixas.Text = Convert.ToString(1);
                rtbObservacao.Text = Convert.ToString(null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private ItensProposta LerCampos()
        {
            try
            {
                var iten = new ItensProposta();
                int id = 0;
                int.TryParse(txtItensPropostaId.Text, out id);
                if (id == 0)
                {
                    iten.CodigoMaterial = Convert.ToInt32(txtCodigoItensMaterial.Text);
                    iten.Material = txtMaterial.Text;
                    iten.ObsMaterial = rtbObservacao.Text;
                    iten.Quantidade = Convert.ToDecimal(txtQuantidade.Text);
                    iten.Preco = Convert.ToDecimal(txtPreco.Text);
                    iten.qtdcaixal = Convert.ToDecimal(txtQtdCaixas.Text);
                    iten.UndMedida = txtUndMedida.Text;
                    iten.M2caixa = Convert.ToDecimal(txtQtdUndCaixa.Text);
                    iten.Total = Convert.ToDecimal(txtTotal.Text);
                    iten.PropostaId = Convert.ToInt32(txtPropostId.Text);
                }
                return iten;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void MetragemCaixas()
        {
            try
            {
                decimal qtd = 1;
                decimal caixa = 1;
                decimal total = 0;

                if (decimal.TryParse(txtQuantidade.Text, out caixa))
                {
                    if (decimal.TryParse(txtQtdUndCaixa.Text, out qtd))
                    {
                        total = caixa / qtd;
                    }
                    else
                    {
                        MessageBox.Show("Quantidade inválida");
                    }
                    txtQtdCaixas.Text = total.ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void ValorMaterial()
        {
            try
            {
                decimal qtd = 1, valor = 1, total = 0;

                if (decimal.TryParse(txtPreco.Text, out valor))
                {
                    if (decimal.TryParse(txtQuantidade.Text, out qtd))
                    {
                        total = qtd * valor;
                    }
                    else
                    {
                        MessageBox.Show("Quantidade inválida");
                    }
                }
                txtTotal.Text = total.ToString("N2");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private Historico LerComentario()
        {
            try
            {
                var historico = new Historico();
                int id = 0;
                int.TryParse(txtIdHistorico.Text, out id);
                if (id == 0)
                {
                    historico.Comentario = rtbComentario.Text;
                    historico.DataComentario = dtpHistorico.Value;
                    historico.PropostaId = Convert.ToInt32(txtPropostId.Text);
                }
                return historico;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        private void dgvHistorico_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var historico = dgvHistorico.Rows[e.RowIndex].DataBoundItem as Historico;
                if (historico != null)
                {
                    txtIdHistorico.Text = historico.HistoricoId.ToString();
                    rtbComentario.Text = historico.Comentario;
                    dtpHistorico.Value = historico.DataComentario;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }
    }
}
