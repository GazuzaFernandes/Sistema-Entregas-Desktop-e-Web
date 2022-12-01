using DAL.Entities.Engenharia;
using DAL.Entities.Logistica;
using DAL.Repository.Engenharia;
using DAL.Repository.Logistica;

using Logistica.Sistema_de_Logistica;
using Projeto.Logistica.Sistema_de_Logistica;
using System.Data;


namespace Projeto.Logistica.Sistema_dos_Engenheiros
{
    public partial class FrmPropostaEng : Form
    {
        internal PropostaEngenharia _propostaEng;
        public FrmPropostaEng()
        {
            InitializeComponent();
        }

        private void FrmPropostaEng_Load(object sender, EventArgs e)
        {
            try
            {
                HabilitarCampos(false);
                #region _propostaEng
                if (_propostaEng == null)
                    _propostaEng = new PropostaEngenharia();
                if (_propostaEng.EngenhariaId > 0)
                {
                    HabilitarCampos(true);
                    #region Codigos
                    _propostaEng = new DLPropostaEngenharia().ConsultarPorId(_propostaEng.EngenhariaId);
                    txtPropostId.Text = _propostaEng.EngenhariaId.ToString();
                    dtpDataIncluido.Value = _propostaEng.DataInclusao;
                    txtProposta.Text = _propostaEng.Proposta;
                    txtCliente.Text = _propostaEng.Cliente;
                    txtFuncionario.Text = _propostaEng.Funcionario;
                    txtEngResponsavel.Text = _propostaEng.Responsavel;
                    txtTelefone.Text = _propostaEng.Telefone;
                    txtObra.Text = _propostaEng.Obra;
                    #endregion
                    switch (_propostaEng.StatusObraId)//escolha
                    {
                        case 1:
                            {
                                rbPendente.Checked = true;
                            }
                            break;
                        case 2:
                            {
                                rbFinalizado.Checked = true;
                            }
                            break;
                        case 3:
                            {
                                rbCancelado.Checked = true;
                            }
                            break;
                    }
                    CarregarGridHistorico();
                    BloquearBotao(false);
                }
                else
                {
                    rbPendente.Checked = true;
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
                var proposta = new PropostaEngenharia();
                proposta.StatusObraId = 2;//Pendente
                var id = new DLPropostaEngenharia().Inserir(proposta);//inserir
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
                int ide = 0;
                int.TryParse(txtPropostId.Text, out ide);
                if (ide > 0)
                {
                    new DLDadosProposta().Excluir(new DadosProposta { PropostaId = ide });
                    MessageBox.Show("Proposta excluída com sucesso!");
                    Close();
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
                    var prop = new DLHistoricoEngenharia().ConsultarPorId(id);
                    if (prop.HistoricoId > 0)
                    {
                        new DLHistoricoEngenharia().Excluir(prop);
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
                        var pAtua = new DLPropostaEngenharia().ConsultarPorId(id);
                        pAtua.Proposta = txtProposta.Text;
                        pAtua.Cliente = txtCliente.Text;
                        pAtua.Funcionario = txtFuncionario.Text;
                        pAtua.Responsavel = txtEngResponsavel.Text;
                        pAtua.Telefone = txtTelefone.Text;
                        pAtua.Obra = txtObra.Text;
                        pAtua.DataInclusao = dtpDataIncluido.Value;
                        if (rbPendente.Checked == true)
                            pAtua.StatusObraId = 1;
                        else if (rbPendente.Checked == true)
                            pAtua.StatusObraId = 2;
                        else if (rbFinalizado.Checked == true)
                            pAtua.StatusObraId = 3;
                        new DLPropostaEngenharia().Atualizar(pAtua);
                        MessageBox.Show("Proposta Atualizada com Sucesso!");
                        LimparDadosProposta();
                        Close();
                    }
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
                        int historicoId = 0;
                        if (txtIdHistorico.Text != "")
                        {
                            historicoId = Convert.ToInt32(txtIdHistorico.Text);
                        }
                        int engId = 0;
                        if (txtPropostId.Text != "")
                        {
                            engId = Convert.ToInt32(txtPropostId.Text);
                        }
                        var listaProposta = new DLHistoricoEngenharia().Listar();             
                        var prop = listaProposta.Where(ip => ip.EngenheiroId == engId 
                                        && ip.HistoricoId == historicoId
                                        ).FirstOrDefault();
                        if (prop != null && prop.HistoricoId > 0)
                        {
                            prop.Comentario = rtbComentario.Text;
                            prop.DataComentario = dtpHistorico.Value;
                            prop.ComentadoEng = cbComentado.Text;
                            prop.EngenheiroId = Convert.ToInt32(txtPropostId.Text);
                            new DLHistoricoEngenharia().Atualizar(prop);
                        }
                        else
                        {
                            new DLHistoricoEngenharia().Inserir(comentario);
                        }
                        CarregarGridHistorico();
                        rtbComentario.Clear();
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
                var historico = dgvHistorico.Rows[e.RowIndex].DataBoundItem as HistoricoEngenharia;
                if (historico != null)
                {
                    txtIdHistorico.Text = historico.HistoricoId.ToString();
                    rtbComentario.Text = historico.Comentario;
                    dtpHistorico.Value = historico.DataComentario;
                    cbComentado.Text = historico.ComentadoEng;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }

        #region Campo de Metodos

        private bool ValidarComentario()
        {
            if (cbComentado.Text == "")
            {
                MessageBox.Show("Informe o Engenheiro que fez a visita.");
            }
            return true;
        }
        private void CarregarGridHistorico()
        {
            try
            {
                var listarHistorico = new DLHistoricoEngenharia().Listar().Where(p => p.EngenheiroId == Convert.ToInt32(txtPropostId.Text)).ToList();
                dgvHistorico.DataSource = null;
                dgvHistorico.DataSource = listarHistorico.OrderByDescending(p => p.DataComentario).ToList();
                dgvHistorico.Refresh();
                MontarGridHistorico();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void MontarGridHistorico()
        {
            try
            {
                dgvHistorico.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 20F, GraphicsUnit.Pixel);
                var objBlControleGrid = new ControleGrid(dgvHistorico);
                //Define quais colunas serão visíveis
                objBlControleGrid.DefinirVisibilidade(new List<string>() { "Comentario", "DataComentario", "ComentadoEng" });
                //Define quais os cabeçalhos respectivos das colunas 
                objBlControleGrid.DefinirCabecalhos(new List<string>() { "Comentario", "Data do Comentario","Responsavel Rb" });
                //Define quais as larguras respectivas das colunas 
                objBlControleGrid.DefinirLarguras(new List<int>() { 77, 10, 10 }, dgvHistorico.Width - 25); //O total tem que ficar em 100% 
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
        private void HabilitarCampos(bool Habilitar)
        {
            txtProposta.Enabled = Habilitar;
            txtCliente.Enabled = Habilitar;
            txtFuncionario.Enabled = Habilitar;
            txtEngResponsavel.Enabled = Habilitar;
            txtTelefone.Enabled = Habilitar;
            txtObra.Enabled = Habilitar;
            btnSalvarProposta.Enabled = Habilitar;
            btnDeletarProposta.Enabled = Habilitar;
            cbComentado.Enabled = Habilitar;
            rtbComentario.Enabled = Habilitar;
            dtpDataIncluido.Enabled = Habilitar;
            dtpHistorico.Enabled = Habilitar;
            btnLimparComentario.Enabled = Habilitar;
            btnDeletarComentario.Enabled = Habilitar;
        }
        private void LimparDadosProposta()
        {
            txtProposta.Text = Convert.ToString(null);
            txtCliente.Text = Convert.ToString(null);
            txtFuncionario.Text = Convert.ToString(null);
            txtEngResponsavel.Text = Convert.ToString(null);
            txtTelefone.Text = Convert.ToString(null);
            txtObra.Text = Convert.ToString(null);
        }
        private bool ValidarCampos()
        {
            if (txtProposta.Text == "")
            {
                throw new Exception(" Informe a Proposta ");
            }
            return true;
        }
        private HistoricoEngenharia LerComentario()
        {
            try
            {
                var historico = new HistoricoEngenharia();
                int id = 0;
                int.TryParse(txtIdHistorico.Text, out id);
                if (id == 0)
                {
                    historico.Comentario = rtbComentario.Text;
                    historico.DataComentario = dtpHistorico.Value;
                    historico.ComentadoEng = cbComentado.Text;
                    historico.EngenheiroId = Convert.ToInt32(txtPropostId.Text);
                }
                return historico;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        private void mtSalvarProposta_Click_1(object sender, EventArgs e)
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
                        var pAtua = new DLPropostaEngenharia().ConsultarPorId(id);
                        pAtua.Proposta = txtProposta.Text;
                        pAtua.Cliente = txtCliente.Text;
                        pAtua.Funcionario = txtFuncionario.Text;
                        pAtua.Responsavel = txtEngResponsavel.Text;
                        pAtua.Telefone = txtTelefone.Text;
                        pAtua.Obra = txtObra.Text;
                        pAtua.DataInclusao = dtpDataIncluido.Value;
                        if (rbPendente.Checked == true)
                            pAtua.StatusObraId = 1;
                        else if (rbFinalizado.Checked == true)
                            pAtua.StatusObraId = 2;
                        else if (rbCancelado.Checked == true)
                            pAtua.StatusObraId = 3;
                        new DLPropostaEngenharia().Atualizar(pAtua);
                        MessageBox.Show("Proposta Atualizada com Sucesso!");
                        LimparDadosProposta();
                        Close();
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
