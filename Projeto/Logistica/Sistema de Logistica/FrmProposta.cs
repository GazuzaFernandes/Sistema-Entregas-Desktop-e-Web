using DAL.Entities.Logistica;
using DAL.Repository.Logistica;
using DAL.Repository.SenhaRestauracao;
using Logistica.Sistema_de_Logistica;

using Microsoft.Reporting.WinForms;
using Projeto.Logistica.Sistema_do_Financeiro;
using System.Data;

namespace Projeto.Logistica.Sistema_de_Logistica
{
    public partial class FrmProposta : Form
    {
        #region Classes para Form
        static int pesquisar = 1;
        internal DadosProposta _proposta;
        internal ItensProposta _itensProposta;
        internal CadastrarEmpresa _fabrica;
        internal CadastrarMadeira _madeira;
        #endregion

        public FrmProposta()
        {
            InitializeComponent();
        }

        private void FrmProposta_Load(object sender, EventArgs e)
        {
            try
            {              
                HabilitarCampos(false);
                #region _proposta
                if (_proposta == null)
                    _proposta = new DadosProposta();
                if (_proposta.PropostaId > 0)
                {
                    HabilitarCampos(true);
                    #region Codigos
                    _proposta = new DLDadosProposta().ConsultarPorId(_proposta.PropostaId);
                    txtPropostId.Text = _proposta.PropostaId.ToString();
                    dtpDataPedido.Value = _proposta.DataPrevista;
                    dtpDataPrevista.Value = _proposta.DataPedido;
                    txtEmpresa.Text = _proposta.Fabrica;
                    cbEmpresaFaturar.Text = _proposta.Faturado;
                    txtFormaPagamento.Text = _proposta.FormaPag;
                    txtEngResponsavel.Text = _proposta.EngResp;
                    txtTelefone.Text = _proposta.Telefone;
                    txtPdRb.Text = _proposta.PdRb;
                    txtPdVenda.Text = _proposta.PdVenda;
                    txtProposta.Text = _proposta.Proposta;
                    txtCliente.Text = _proposta.Construtora;
                    txtObra.Text = _proposta.Obra;
                    dtpDataEntrega.Value = _proposta.DataEntrega;
                    txtRecebido.Text = _proposta.RecebidoPor;
                    txtNotaFiscal.Text = _proposta.NotaFiscal;
                    txtCarreto.Text = _proposta.Carreto;
                    rtbMaterial.Text = _proposta.Material;
                    #endregion
                    switch (_proposta.StatusObraId)//escolha
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

        #region Tela Dados da Proposta
        private void btnSalvarProposta_Click(object sender, EventArgs e)
        {
            cmsSalvarConteudos.Show(btnSalvarProposta, 1, btnSalvarProposta.Height);
        }

        private void btnGerarId_Click(object sender, EventArgs e)
        {
            try
            {
                HabilitarCampos(true);
                var proposta = new DadosProposta();
                proposta.StatusObraId = 2;//Pendente
                var id = new DLDadosProposta().Inserir(proposta);//inserir
                txtPropostId.Text = id.ToString();
                BloquearBotao(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void btnPesquisaFabrica_Click(object sender, EventArgs e)
        {
            pesquisar = 1;
            PegarDados_FormCadastroEmpresa();
        }
        private void txtCodigoFabrica_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int ide = 1;
                int.TryParse(txtCodigoFabrica.Text, out ide);
                if (ide > 1)
                {
                    _fabrica = new DLCadastrarEmpresa().ConsultarPorId(Convert.ToInt32(txtCodigoFabrica.Text));
                    txtCodigoFabrica.Text = _fabrica.EmpresaId.ToString();
                    txtEmpresa.Text = _fabrica.Empresa;
                }
                else if (ide == 1)
                {
                    MessageBox.Show("Cliente não cadastrado, use a lupa para pesquisar o cliente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void txtCodigoCliente_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int ide = 1;
                int.TryParse(txtCodigoCliente.Text, out ide);
                if (ide > 1)
                {
                    _fabrica = new DLCadastrarEmpresa().ConsultarPorId(Convert.ToInt32(txtCodigoCliente.Text));
                    txtCodigoCliente.Text = _fabrica.EmpresaId.ToString();
                    txtEmpresa.Text = _fabrica.Empresa;
                }
                else if (ide == 1)
                {
                    MessageBox.Show("Cliente não cadastrado, use a lupa para pesquisar o cliente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnPesquisarCliente_Click(object sender, EventArgs e)
        {
            pesquisar = 2;
            PegarDados_FormCadastroEmpresa();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                #region Tabela Itens Proposta
                ReportDataSource itensProposta = new ReportDataSource();
                List<ItensProposta> lst = new List<ItensProposta>();
                lst.Clear();
                for (int i = 0; i < dgvitensProposta.Rows.Count - 0; i++)
                {
                    lst.Add(new ItensProposta
                    {
                        ItenId = int.Parse(dgvitensProposta.Rows[i].Cells[0].Value.ToString()),
                        Material = dgvitensProposta.Rows[i].Cells[1].Value.ToString(),
                        UndMedida = dgvitensProposta.Rows[i].Cells[2].Value.ToString(),
                        Quantidade = Convert.ToDecimal(dgvitensProposta.Rows[i].Cells[4].Value.ToString()),
                        QtdCaixa = Convert.ToDecimal(dgvitensProposta.Rows[i].Cells[5].Value.ToString()),
                    });
                }
                itensProposta.Name = "DsItensProposta";
                itensProposta.Value = lst;
                #endregion

                #region Tabela Historico de Comentario
                ReportDataSource historico = new ReportDataSource();
                List<Historico> histo = new List<Historico>();
                histo.Clear();
                for (int i = 0; i < dgvHistorico.Rows.Count - 0; i++)
                {
                    histo.Add(new Historico
                    {
                        HistoricoId = int.Parse(dgvHistorico.Rows[i].Cells[0].Value.ToString()),
                        Comentario = dgvHistorico.Rows[i].Cells[2].Value.ToString(),
                        DataComentario = Convert.ToDateTime(dgvHistorico.Rows[i].Cells[1].Value.ToString()),
                    });
                }
                historico.Name = "DsHistorico";
                historico.Value = histo;
                #endregion

                FrmImpressaoProposta frmImpressao = new FrmImpressaoProposta
                    (dtpDataEntrega.Value, txtProposta.Text, txtEmpresa.Text, 
                    txtObra.Text, itensProposta, txtNotaFiscal.Text, historico);

                frmImpressao.reportViewer1.LocalReport.DataSources.Clear();
                frmImpressao.reportViewer1.LocalReport.DataSources.Add(itensProposta);
                frmImpressao.reportViewer1.LocalReport.DataSources.Add(historico);
                frmImpressao.reportViewer1.LocalReport.ReportEmbeddedResource = "Projeto.Impressao.rdlc";
                frmImpressao.ShowDialog();
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
                            new DLDadosProposta().Excluir(new DadosProposta { PropostaId = ide });
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
                        var pAtua = new DLDadosProposta().ConsultarPorId(id);
                        pAtua.DataPrevista = dtpDataPedido.Value;
                        pAtua.DataPedido = dtpDataPedido.Value;
                        pAtua.Fabrica = txtEmpresa.Text;                       
                        pAtua.FormaPag = txtFormaPagamento.Text;
                        pAtua.EngResp = txtEngResponsavel.Text;
                        pAtua.Telefone = txtTelefone.Text;
                        pAtua.PdRb = txtPdRb.Text;
                        pAtua.PdVenda = txtPdVenda.Text;
                        pAtua.Proposta = txtProposta.Text;
                        pAtua.Construtora = txtCliente.Text;
                        pAtua.Obra = txtObra.Text;
                        pAtua.DataEntrega = dtpDataEntrega.Value;
                        pAtua.RecebidoPor = txtRecebido.Text;
                        pAtua.NotaFiscal = txtNotaFiscal.Text;
                        pAtua.Carreto = txtCarreto.Text;
                        pAtua.Material = rtbMaterial.Text;
                        pAtua.Faturado = cbEmpresaFaturar.Text;
                        if (rbImediato.Checked == true)
                            pAtua.StatusObraId = 1;
                        else if (rbPendente.Checked == true)
                            pAtua.StatusObraId = 2;
                        else if (rbFinalizado.Checked == true)
                            pAtua.StatusObraId = 3;
                        else if (rbCancelado.Checked == true)
                            pAtua.StatusObraId = 4;
                        new DLDadosProposta().Atualizar(pAtua);
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

        #endregion

        #region Tela Itens da Proposta
        private void txtCodigoItensMaterial_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int ide = 0;
                int.TryParse(txtCodigoItensMaterial.Text, out ide);
                if (ide > 1)
                {
                    _madeira = new DLCadastrarMadeira().ConsultarPorId(Convert.ToInt32(txtCodigoItensMaterial.Text));
                    txtCodigoItensMaterial.Text = _madeira.MadeiraId.ToString();
                    txtMaterial.Text = _madeira.PisoMadeira;
                    txtQtdUndCaixa.Text = Convert.ToString(_madeira.M2Caixa);
                }
                else if (ide == 1)
                {
                    MessageBox.Show("Material não cadastrado, use a lupa para pesquisar o material.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnPesquisarMaterial_Click(object sender, EventArgs e)
        {
            try
            {
                FrmCadastroItens cadastroItens = new FrmCadastroItens();
                cadastroItens.ShowDialog();
                var id = cadastroItens.madeiraid;
                var material = cadastroItens.material;
                var comprimento = cadastroItens.comprimento;
                var qtdcaixa = cadastroItens.qtdcaixa;
                txtCodigoItensMaterial.Text = id.ToString();
                txtMaterial.Text = material;
                txtQtdUndCaixa.Text = qtdcaixa;
                cadastroItens.Close();
                cadastroItens.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnAtualizarEstoque_Click(object sender, EventArgs e)
        {
            FrmEstoqueFinanceiro financeiro = new FrmEstoqueFinanceiro();
            financeiro.ShowDialog();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                var itenProposta = LerCampos();
                int ItensPropostaId = 0;
                if (txtItensPropostaId.Text != "")
                {
                    ItensPropostaId = Convert.ToInt32(txtItensPropostaId.Text);
                }
                int propostaid = 0;
                if (txtPropostId.Text != "")
                {
                    propostaid = Convert.ToInt32(txtPropostId.Text);
                }
                var listaProposta = new DLItensProposta().Listar();
                //Filtrando a lista "listaProposta" por propostaid e codigomaterial
                var prop = listaProposta.Where(ip => ip.PropostaId == propostaid //por proppostaid
                                && ip.ItenId == ItensPropostaId //por ItensPropostaId
                                ).FirstOrDefault();//Primeiro que encontrar
                if (prop != null && prop.ItenId > 0)
                {
                    prop.M2Caixa = Convert.ToDecimal(txtQtdUndCaixa.Text);
                    prop.QtdCaixa = Convert.ToDecimal(txtQtdCaixas.Text);
                    prop.Material = txtMaterial.Text;
                    prop.Preco = Convert.ToDecimal(txtPreco.Text);
                    prop.Quantidade = Convert.ToDecimal(txtQuantidade.Text);
                    prop.ObsMaterial = rtbObservacao.Text;
                    prop.UndMedida = txtUndMedida.Text;
                    prop.Total = Convert.ToDecimal(txtTotal.Text);
                    new DLItensProposta().Atualizar(prop);
                }
                else
                {
                    new DLItensProposta().Inserir(itenProposta);
                }
                LimparCamposItens();
                CarregarGridItensProposta();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCamposItens();
        }

        private void btnDeletarItens_Click(object sender, EventArgs e)
        {
            try
            {
                int id = 0;
                int.TryParse(txtItensPropostaId.Text, out id);
                if (id > 0)
                {
                    var prop = new DLItensProposta().ConsultarPorId(id);
                    if (prop.ItenId > 0)
                    {
                        new DLItensProposta().Excluir(prop);
                        CarregarGridItensProposta();
                        LimparCamposItens();
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

        private void dgvitensProposta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var itensProposta = dgvitensProposta.Rows[e.RowIndex].DataBoundItem as ItensProposta;
                if (itensProposta != null)
                {
                    txtItensPropostaId.Text = itensProposta.ItenId.ToString();
                    txtMaterial.Text = itensProposta.Material;
                    txtUndMedida.Text = itensProposta.UndMedida;
                    txtQtdUndCaixa.Text = Convert.ToString(itensProposta.M2Caixa);
                    txtQuantidade.Text = Convert.ToString(itensProposta.Quantidade);
                    txtPreco.Text = Convert.ToString(itensProposta.Preco);
                    txtQtdCaixas.Text = Convert.ToString(itensProposta.QtdCaixa);
                    rtbObservacao.Text = itensProposta.ObsMaterial;
                    txtTotal.Text = Convert.ToString(itensProposta.Total);
                    txtCodigoItensMaterial.Text = Convert.ToString(itensProposta.CodigoMaterial);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
            MetragemCaixas();
        }
        private void txtPreco_TextChanged(object sender, EventArgs e)
        {
            ValorMaterial();
        }
        private void txtQtdCaixas_TextChanged(object sender, EventArgs e)
        {
            ValorMaterial();
            MetragemCaixas();
        }
        #endregion

        #region Tela Historico de Comentario
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
      
        #endregion

        #region Campo de Metodos
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
                dgvHistorico.DefaultCellStyle.Font = new System.Drawing.Font("Calibri",20F, GraphicsUnit.Pixel);
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
                dgvitensProposta.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 19F, GraphicsUnit.Pixel);
                var objBlControleGrid = new ControleGrid(dgvitensProposta);
                //Define quais colunas serão visíveis
                objBlControleGrid.DefinirVisibilidade(new List<string>()
                { "Material", "UndMedida", "Quantidade", "Preco", "QtdCaixa", "ObsMaterial", "Total", });
                //Define quais os cabeçalhos respectivos das colunas 
                objBlControleGrid.DefinirCabecalhos(new List<string>() 
                { "Material", "Und Medida", "Qtd", "Valor", "Qtd Caixa", "Obs Material", "Total" });
                //Define quais as larguras respectivas das colunas 
                objBlControleGrid.DefinirLarguras(new List<int>() 
                { 41, 10, 8, 7, 5, 15, 10 }, dgvitensProposta.Width - 15); //O total tem que ficar em 100% 
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
            dtpDataEntrega.Enabled = Habilitar;
            dtpDataPedido.Enabled = Habilitar;
            dtpDataPrevista.Enabled = Habilitar;
            btnLimparComentario.Enabled = Habilitar;
            btnDeletarComentario.Enabled = Habilitar;
            dtpHistorico.Enabled = Habilitar;
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
                var cliente = cadasEmpr.empresa;
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
                            txtCliente.Text = cliente;
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
            else if (cbEmpresaFaturar.Text == "")
            {
                throw new Exception("Informe a empresa de faturamento");
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
                txtQuantidade.Text = Convert.ToString(0);
                txtPreco.Text = Convert.ToString(0);
                txtQtdUndCaixa.Text = Convert.ToString(1);
                txtUndMedida.Text = Convert.ToString("m²");
                txtQtdCaixas.Text = Convert.ToString(0);
                rtbObservacao.Text = Convert.ToString(null);
                CarregarGridItensProposta();
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
                    iten.QtdCaixa = Convert.ToDecimal(txtQtdCaixas.Text);
                    iten.UndMedida = txtUndMedida.Text;
                    iten.M2Caixa = Convert.ToDecimal(txtQtdUndCaixa.Text);
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

        private void imprimir_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           
        }
    }
}
