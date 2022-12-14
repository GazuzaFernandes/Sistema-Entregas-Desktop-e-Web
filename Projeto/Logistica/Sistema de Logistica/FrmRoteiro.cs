
using DAL.Entities.Logistica;
using DAL.Repository.Logistica;
using DAL.Repository.SenhaRestauracao;
using Logistica.Sistema_de_Logistica;
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

namespace Projeto.Logistica.Sistema_de_Logistica
{
    public partial class FrmRoteiro : Form
    {
        public FrmRoteiro()
        {
            InitializeComponent();
        }

        private void FrmRoteiro_Load(object sender, EventArgs e)
        {
            var listaProposta = new DLRoteiroMotorista().Listar();
            CarregarGridRoteiro();
            HabilitarBotao(false);
        }

        #region Tela de Informações da obra
        private void btnGerarId_Click(object sender, EventArgs e)
        {
            try
            {
                var proposta = new RoteiroMotorista();
                var id = new DLRoteiroMotorista().Inserir(proposta);//inserir
                txtIdObra.Text = id.ToString();
                HabilitarBotao(true);
                BloquearBotao(false);
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
                    int.TryParse(txtIdObra.Text, out id);
                    if (id > 0)
                    {
                        var pAtua = new DLRoteiroMotorista().ConsultarPorId(id);
                        pAtua.DataEntrada = dtpDataSaida.Value;
                        pAtua.Proposta = txtProposta.Text;
                        pAtua.Obra = txtObra.Text;
                        pAtua.Funcionario = txtFuncionario.Text;
                        new DLRoteiroMotorista().Atualizar(pAtua);
                        MessageBox.Show("Saida Atualizada com Sucesso!");
                        LimparInformacaoObra();
                        CarregarGridRoteiro();
                        HabilitarBotao(false);
                        BloquearBotao(true);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void btnLimparEntrada_Click(object sender, EventArgs e)
        {
            LimparInformacaoObra();
            HabilitarBotao(false);
        }
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                var pergunta = "Deseja Realmente excluir esse iten do Roteiro ? ";
                if (MessageBox.Show(pergunta, "ATENÇÂO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    FrmLogin login = new FrmLogin();
                    login.ShowDialog();
                    Boolean temUsuario = false;
                    var listaUsuarios = new DLSenhaApagar().Listar();
                    for (int i = 0; i < listaUsuarios.Count; i++)
                    {
                        if (listaUsuarios[i].Senhas == login.txtSenha.Text)
                        {
                            temUsuario = true;
                        }
                    }
                    if (temUsuario == true)
                    {
                        int id = 0;
                        int.TryParse(txtIdObra.Text, out id);
                        if (id > 0)
                        {
                            new DLRoteiroMotorista().Excluir(new RoteiroMotorista { RoteiroId = id });
                            MessageBox.Show("Iten deletado com sucesso!");
                            LimparInformacaoObra();
                            HabilitarBotao(false);
                        }
                    }
                    else
                    {
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void btnEstoque_Click(object sender, EventArgs e)
        {
            FrmEstoque estoque = new FrmEstoque();
            estoque.Show();
        }
        private void dgvRoteiroMotorista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var saidaRoteiro = dgvRoteiroMotorista.Rows[e.RowIndex].DataBoundItem as RoteiroMotorista;
                if (saidaRoteiro != null)
                {
                    txtIdObra.Text = saidaRoteiro.RoteiroId.ToString();
                    txtProposta.Text = saidaRoteiro.Proposta;
                    txtObra.Text = saidaRoteiro.Obra;
                    txtFuncionario.Text = saidaRoteiro.Funcionario;
                    dtpDataSaida.Value = saidaRoteiro.DataEntrada;
                }
                HabilitarBotao(true);
                ListarGridData();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }

        #endregion,

        #region Tela de Saida de material
        private void btnPesquisarMaterial_Click(object sender, EventArgs e)
        {
            try
            {
                FrmEstoque estoque = new FrmEstoque();
                estoque.ShowDialog();
                var materialId = estoque.materialId;
                var Material = estoque.Material;
                var UndMedida = estoque.UndMedida;
                var QtdSaida = estoque.QtdSaida;
                txtCodigoInfomacao.Text = materialId.ToString();
                txtMaterialSaida.Text = Material;
                txtUndMedida.Text = UndMedida;
                txtQuantidade.Text = QtdSaida;
                estoque.Close();
                estoque.Dispose();
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
                var itencontrole = LerCampos();
                int itensControleId = 0;
                if (txtSaidaId.Text != "")
                {
                    itensControleId = Convert.ToInt32(txtSaidaId.Text);
                    MessageBox.Show("Item Atualizado com Sucesso");
                }
                int propostaid = 0;
                if (txtIdObra.Text != "")
                {
                    propostaid = Convert.ToInt32(txtIdObra.Text);
                }
                var listaProposta = new DLItenRoteiroMotorista().Listar();
                //Filtrando a lista "listaProposta" por propostaid e codigomaterial
                var prop = listaProposta.Where(ip => ip.RoteiroId == propostaid //por proppostaid
                                && ip.ItensRoteiroId == itensControleId //por ItensPropostaId
                                ).FirstOrDefault();//Primeiro que encontrar
                if (prop != null && prop.ItensRoteiroId > 0)
                {
                    prop.Codigo = Convert.ToInt32(txtCodigoInfomacao.Text);
                    prop.Material = txtMaterialSaida.Text;
                    prop.UndMedida = txtUndMedida.Text;
                    prop.QtdCaixas = Convert.ToDecimal(txtQuantidade.Text);
                    new DLItenRoteiroMotorista().Atualizar(prop);
                }
                else
                {
                    new DLItenRoteiroMotorista().Inserir(itencontrole);
                    MessageBox.Show("Item Cadastrado com Sucesso");
                }
                LimparCamposItens();
                CarregarGridMaterial();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCamposItens();
            CarregarGridMaterial();
        }

        private void btnDeletarItens_Click(object sender, EventArgs e)
        {
            try
            {
                int id = 0;
                int.TryParse(txtSaidaId.Text, out id);
                if (id > 0)
                {
                    var prop = new DLItenRoteiroMotorista().ConsultarPorId(id);
                    if (prop.ItensRoteiroId > 0)
                    {
                        new DLItenRoteiroMotorista().Excluir(prop);
                        CarregarGridMaterial();
                        LimparCamposItens();
                    }
                    else
                    {
                        MessageBox.Show("Falha ao excluir o item do roteiro");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void dgvSaidaMaterial_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var itensControle = dgvSaidaMaterial.Rows[e.RowIndex].DataBoundItem as ItenRoteiroMotorista;
                if (itensControle != null)
                {
                    txtSaidaId.Text = itensControle.ItensRoteiroId.ToString();
                    txtCodigoInfomacao.Text = itensControle.Codigo.ToString();
                    txtMaterialSaida.Text = itensControle.Material;
                    txtUndMedida.Text = itensControle.UndMedida;
                    txtQuantidade.Text = Convert.ToString(itensControle.QtdCaixas);
                }
                HabilitarBotao(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }
        #endregion

        #region Apenas Metodos
        private void CarregarGridMaterial()
        {
            ListarGridData();
        }

        private void ListarGridData()
        {
            try
            {
                var lstitensproposta = new DLItenRoteiroMotorista().Listar().Where
                    (p => p.RoteiroId == Convert.ToInt32(txtIdObra.Text)).ToList();
                dgvSaidaMaterial.DataSource = null;
                dgvSaidaMaterial.DataSource = lstitensproposta;
                dgvSaidaMaterial.Refresh();
                MontarGridMaterial(dgvSaidaMaterial);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void MontarGridMaterial(DataGridView dgvSaidaMaterial)
        {
            try
            {
                dgvSaidaMaterial.DefaultCellStyle.Font = new Font("Calibri", 20F, GraphicsUnit.Pixel);
                var objBlControleGrid = new ControleGrid(dgvSaidaMaterial);
                //Define quais colunas serão visíveis
                objBlControleGrid.DefinirVisibilidade(new List<string>() { "Material", "UndMedida", "QtdCaixas"});
                //Define quais os cabeçalhos respectivos das colunas 
                objBlControleGrid.DefinirCabecalhos(new List<string>() { "Material", "Unidade Medida", "Qtd Saida" });
                //Define quais as larguras respectivas das colunas 
                objBlControleGrid.DefinirLarguras(new List<int>() { 55, 20, 20 }, dgvSaidaMaterial.Width - 25); //O total tem que ficar em 100% 
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

        private void CarregarGridRoteiro(bool isPesquisa = false)
        {
            try
            {
                var controleEstoque = new DLRoteiroMotorista().Listar();
                if (isPesquisa) //isPesquisa == true
                {
                    var pesquisa = txtPesquisar.Text.ToLower();
                    controleEstoque = controleEstoque.Where(p => p.Obra.ToLower().Contains(pesquisa)).ToList();
                }
                dgvRoteiroMotorista.DataSource = controleEstoque.OrderByDescending(p => p.DataEntrada).ToList();
                MontarGridRoteiro(dgvRoteiroMotorista);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void MontarGridRoteiro(DataGridView dgvRoteiroMotorista)
        {
            try
            {
                dgvRoteiroMotorista.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 20F, GraphicsUnit.Pixel);
                var objBlControleGrid = new ControleGrid(dgvRoteiroMotorista);
                //Define quais colunas serão visíveis
                objBlControleGrid.DefinirVisibilidade(new List<string>() { "DataEntrada", "Proposta", "Obra", "Funcionario" });
                //Define quais os cabeçalhos respectivos das colunas 
                objBlControleGrid.DefinirCabecalhos(new List<string>() { "Data de Saida", "Proposta", "Obra", "Solicitado" });
                //Define quais as larguras respectivas das colunas 
                objBlControleGrid.DefinirLarguras(new List<int>() { 20, 20, 35, 20 }, dgvRoteiroMotorista.Width - 15); //O total tem que ficar em 100% 
                //Define quais os alinhamentos respectivos do componentes das colunas 
                objBlControleGrid.DefinirAlinhamento(new List<string>() { "centro", "centro", "centro", });
                //Define a altura das linhas respectivas da Grid 
                objBlControleGrid.DefinirAlturaLinha(30);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool Validarcampos()
        {
            if (txtObra.Text == "")
            {
                MessageBox.Show("Informe o endereço");
            }
            return true;
        }

        private ItenRoteiroMotorista LerCampos()
        {
            try
            {
                var iten = new ItenRoteiroMotorista();
                int id = 0;
                int.TryParse(txtSaidaId.Text, out id);
                if (id == 0)
                {
                    iten.Codigo = Convert.ToInt32(txtCodigoInfomacao.Text);
                    iten.Material = txtMaterialSaida.Text;
                    iten.UndMedida = txtUndMedida.Text;
                    iten.QtdCaixas = Convert.ToDecimal(txtQuantidade.Text);               
                    iten.RoteiroId = Convert.ToInt32(txtIdObra.Text);
                }
                return iten;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void LimparCamposItens()
        {
            txtSaidaId.Text = Convert.ToString(null);
            txtCodigoInfomacao.Text = Convert.ToString(null);
            txtMaterialSaida.Text = Convert.ToString("Nome do Item");
            txtUndMedida.Text = Convert.ToString("m²");
            txtQuantidade.Text = Convert.ToString(0);           
        }

        private void BloquearBotao(bool travar)
        {
            btnGerarId.Enabled = travar;
        }

        private void HabilitarBotao(bool hab)
        {
            txtProposta.Enabled = hab;
            txtObra.Enabled = hab;
            txtFuncionario.Enabled = hab;
            btnSalvar.Enabled = hab;
            btnLimparEntrada.Enabled = hab;
            btnDeletar.Enabled = hab;         
            txtCodigoInfomacao.Enabled = hab;
            btnPesquisarMaterial.Enabled = hab;          
            btnInserir.Enabled = hab;
            btnLimpar.Enabled = hab;
            btnDeletarItens.Enabled = hab;
        }

        private void LimparInformacaoObra()
        {     
            txtProposta.Text = Convert.ToString(null);
            txtObra.Text = Convert.ToString(null);
            txtFuncionario.Text = Convert.ToString(null);
            txtIdObra.Text = Convert.ToString(null);
            dgvSaidaMaterial.DataSource = null;
            CarregarGridRoteiro();
        }

        #endregion

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            CarregarGridRoteiro(true);
            MontarGridRoteiro(dgvRoteiroMotorista);
        }
    }
}
