
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
    public partial class FrmEstoque : Form
    {
        public int materialId;
        public string Material, UndMedida, QtdSaida, QtdCaixa;

        public FrmEstoque()
        {
            InitializeComponent();
        }

        private void FrmEstoque_Load(object sender, EventArgs e)
        {
            CarregarGridSaida();
            HabilitarCampos(false);
        }

        #region Entrada de Material

        private void btnGerarId_Click(object sender, EventArgs e)
        {
            try
            {
                HabilitarCampos(true);
                var itens = new ItensMaterial();
                var id = new DLItensMaterial().Inserir(itens);//inserir
                txtGerarId.Text = id.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void btnLimparEntrada_Click(object sender, EventArgs e)
        {
            LimparCadastro();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            cmsSalvarConteudos.Show(btnSalvar, 1, btnSalvar.Height);

        }
        private void msSalvarEntrada_Click(object sender, EventArgs e)
        {
            #region Salvar tudo e fechar
            bool camposSaoValidos = Validarcampos();
            if (camposSaoValidos == true)
            {
                int id = 0;
                int.TryParse(txtGerarId.Text, out id);
                if (id > 0)
                {
                    var madeiraAt = new DLItensMaterial().ConsultarPorId(id);
                    madeiraAt.MaterialId = Convert.ToInt32(txtGerarId.Text);
                    madeiraAt.Material = txtMaterial.Text;
                    madeiraAt.UnidadeMedida = txtUnidadeMedida.Text;
                    madeiraAt.Total = Convert.ToDecimal(txtTotalEntrada.Text);
                    madeiraAt.Entrada = Convert.ToDecimal(txtEntrada.Text);
                    madeiraAt.Quantidade = Convert.ToDecimal(txtQuantidadePct.Text);
                    new DLItensMaterial().Atualizar(madeiraAt);
                    MessageBox.Show("Material atualizado com Sucesso ");
                    CarregarGridSaida();
                    dgvData.DataSource = null;
                    LimparCadastro();
                    HabilitarCampos(false);
                }
            }
            #endregion
        }
        private void msSalvarData_Click(object sender, EventArgs e)
        {
            #region Salvar Datas
            var dataMaterial = LerData();
            int dataId = 0;
            if (txtDataId.Text != "")
            {
                dataId = Convert.ToInt32(txtDataId.Text);
                MessageBox.Show("Data Atualizado com Sucesso");
            }

            int estoqueId = 0;
            if (txtGerarId.Text != "")
            {
                estoqueId = Convert.ToInt32(txtGerarId.Text);
            }

            var listaDataMaterial = new DLDataMaterial().Listar();
            //Filtrando a lista "listaProposta" por propostaid e codigomaterial
            var prop = listaDataMaterial.Where(ip =>
                            ip.MaterialId == estoqueId //por proppostaid
                            && ip.DataId == dataId //por ItensPropostaId
                            ).FirstOrDefault();//Primeiro que encontrar
            if (prop != null && prop.DataId > 0)
            {
                prop.DataId = Convert.ToInt32(txtDataId.Text);
                prop.DataEntrada = dtpData.Value;
                prop.Fabrica = txtFabrica.Text;
                prop.Obra = txtDevolucao.Text;
                prop.Entrada = Convert.ToDecimal(txtEntrada.Text);
                new DLDataMaterial().Atualizar(prop);
            }
            else
            {
                new DLDataMaterial().Inserir(dataMaterial);
                MessageBox.Show("Data Cadastrado com Sucesso");
            }
            txtDataId.Text = Convert.ToString(null);
            CarregarGridData();
            #endregion
        }
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            cmsDeletar.Show(btnDeletar, 0, btnDeletar.Height);
        }
        private void cmsDeletar_Opening(object sender, CancelEventArgs e)
        {
            try
            {
                switch (cmsDeletar.Text)
                {
                    case "Deletar Data":
                        {
                            int id = 0;
                            int.TryParse(txtDataId.Text, out id);
                            if (id > 0)
                            {
                                new DLDataMaterial().Excluir(new DataMaterial { DataId = id });
                                MessageBox.Show("Madeira excluída com sucesso!");
                                LimparCadastro();
                                txtDataId.Text = Convert.ToString(null);
                            }
                        }
                        break;
                    case "Deletar Item":
                        {
                            int id = 0;
                            int.TryParse(txtGerarId.Text, out id);
                            if (id > 0)
                            {
                                new DLItensMaterial().Excluir(new ItensMaterial { MaterialId = id });
                                MessageBox.Show("Material excluído com sucesso!");
                                txtDataId.Text = Convert.ToString(null);
                                CarregarGridSaida();
                                LimparCadastro();
                                HabilitarCampos(false);
                            }

                        }
                        break;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var data = dgvData.Rows[e.RowIndex].DataBoundItem as DataMaterial;
            if (data != null)
            {
                txtDataId.Text = data.DataId.ToString();
                dtpData.Value = data.DataEntrada;
                txtFabrica.Text = data.Fabrica;
                txtEntrada.Text = Convert.ToString(data.Entrada);
                txtDevolucao.Text = data.Obra;
            }
        }
        private void txtEntrada_TextChanged(object sender, EventArgs e)
        {
            CalcularCadastro();
        }

        #endregion

        #region Saida de Material
        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                var pergunta = "Deseja  Realmente Inseir o Material ? ";
                if (MessageBox.Show(pergunta, "ATENÇÂO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    materialId = Convert.ToInt32(txtCodigoMaterial.Text);
                    Material = txtSaidaMaterial.Text;
                    UndMedida = txtMedidaSaida.Text;
                    QtdSaida = txtCalcularSaida.Text;

                    int id = 0;
                    int.TryParse(txtCodigoMaterial.Text, out id);
                    if (id > 0)
                    {
                        var madeiraAt = new DLItensMaterial().ConsultarPorId(id);
                        madeiraAt.Total = Convert.ToDecimal(txtTotalEstoqueSaida.Text);
                        new DLItensMaterial().Atualizar(madeiraAt);
                    }
                    LimparSaidaMaterial();
                    Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void btnLimparSaida_Click(object sender, EventArgs e)
        {
            LimparSaidaMaterial();
        }
        private void txtSaidaMaterial_TextChanged(object sender, EventArgs e)
        {
            CarregarGridSaida(true);
            MontarGridSaida(dgvSaidaMaterial);
        }
        private void dgvSaidaMaterial_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var material = dgvSaidaMaterial.Rows[e.RowIndex].DataBoundItem as ItensMaterial;
                if (material != null)
                {
                    #region Tela de Cadastro de Material
                    txtGerarId.Text = material.MaterialId.ToString();
                    txtMaterial.Text = material.Material;
                    txtUnidadeMedida.Text = material.UnidadeMedida;
                    txtQuantidadePct.Text = Convert.ToString(material.Quantidade);
                    txtEntrada.Text = Convert.ToString(material.Entrada);
                    txtTotalEntrada.Text = Convert.ToString(material.Total);
                    #endregion

                    #region Tela de Saida de Material
                    txtCodigoMaterial.Text = material.MaterialId.ToString();
                    txtSaidaMaterial.Text = material.Material;
                    txtMedidaSaida.Text = material.UnidadeMedida;
                    txtTotalEstoqueSaida.Text = Convert.ToString(material.Total);
                    #endregion
                }
                HabilitarCampos(true);
                CarregarGridData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }
        private void txtCalcularSaida_TextChanged(object sender, EventArgs e)
        {
            CadastrarSaida();
        }
        #endregion

        #region Metodos
        private void HabilitarCampos(bool habilitar)
        {
            txtFabrica.Enabled = habilitar;
            txtMaterial.Enabled = habilitar;
            txtQuantidadePct.Enabled = habilitar;
            txtEntrada.Enabled = habilitar;
            txtUnidadeMedida.Enabled = habilitar;
            txtCalcularSaida.Enabled = habilitar;
            btnDeletar.Enabled = habilitar;
            btnInserir.Enabled = habilitar;
            btnLimparEntrada.Enabled = habilitar;
            btnLimparSaida.Enabled = habilitar;
            btnSalvar.Enabled = habilitar;
        }
        private void CarregarGridSaida(bool isPesquisa = false)
        {
            try
            {
                var listaEstoque = new DLItensMaterial().Listar();
                if (isPesquisa) //isPesquisa == true
                {
                    var pesquisa = txtSaidaMaterial.Text.ToLower();
                    listaEstoque = listaEstoque.Where(p => p.Material.ToLower().Contains(pesquisa)).ToList();
                }
                dgvSaidaMaterial.DataSource = listaEstoque.OrderBy(p => p.Material).ToList();
                MontarGridSaida(dgvSaidaMaterial);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void MontarGridSaida(DataGridView dgvSaidaMaterial)
        {
            try
            {
                dgvSaidaMaterial.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 16F, GraphicsUnit.Pixel);
                var objBlControleGrid = new ControleGrid(dgvSaidaMaterial);
                //Define quais colunas serão visíveis
                objBlControleGrid.DefinirVisibilidade(new List<string>()
                { "Material", "UnidadeMedida", "Total", });
                //Define quais os cabeçalhos respectivos das colunas 
                objBlControleGrid.DefinirCabecalhos(new List<string>()
                { "Material", "Unidade de Medida", "Estoque", });
                //Define quais as larguras respectivas das colunas 
                objBlControleGrid.DefinirLarguras(new List<int>() { 30, 30, 33 }, dgvSaidaMaterial.Width - 15); //O total tem que ficar em 100% 
                //Define quais os alinhamentos respectivos do componentes das colunas 
                objBlControleGrid.DefinirAlinhamento(new List<string>()
                { "centro", "centro", "centro", "centro", "centro", "centro", "centro", });
                //Define a altura das linhas respectivas da Grid 
                objBlControleGrid.DefinirAlturaLinha(30);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void CarregarGridData()
        {
            try
            {
                var listaDataMaterial = new DLDataMaterial().Listar().Where(p => p.MaterialId == Convert.ToInt32(txtGerarId.Text)).ToList();
                dgvData.DataSource = null;
                dgvData.DataSource = listaDataMaterial.OrderByDescending(p => p.DataEntrada).ToList(); ;
                dgvData.Refresh();
                MontarGridCadastro(dgvData);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void MontarGridCadastro(DataGridView dgvData)
        {
            try
            {
                dgvData.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 16F, GraphicsUnit.Pixel);
                var objBlControleGrid = new ControleGrid(dgvData);
                //Define quais colunas serão visíveis
                objBlControleGrid.DefinirVisibilidade(new List<string>()
                { "DataEntrada", "Entrada", "Fabrica", "Obra", });
                //Define quais os cabeçalhos respectivos das colunas 
                objBlControleGrid.DefinirCabecalhos(new List<string>()
                { "Data de Entrada", "Quantidade de Entrada", "Fabrica", "Devolução" });
                //Define quais as larguras respectivas das colunas 
                objBlControleGrid.DefinirLarguras(new List<int>() { 20, 20, 20, 30 }, dgvData.Width - 15); //O total tem que ficar em 100% 
                //Define quais os alinhamentos respectivos do componentes das colunas 
                objBlControleGrid.DefinirAlinhamento(new List<string>()
                { "centro", "centro", "centro", "centro", "centro", "centro", "centro", });
                //Define a altura das linhas respectivas da Grid 
                objBlControleGrid.DefinirAlturaLinha(30);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private DataMaterial LerData()
        {
            try
            {
                var data = new DataMaterial();
                int id = 0;
                int.TryParse(txtDataId.Text, out id);
                if (id == 0)
                {
                    data.DataEntrada = dtpData.Value;
                    data.Fabrica = txtFabrica.Text;
                    data.Obra = txtDevolucao.Text;
                    data.Entrada = Convert.ToDecimal(txtEntrada.Text);
                    data.MaterialId = Convert.ToInt32(txtGerarId.Text);
                }
                return data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void CalcularCadastro()
        {
            try
            {
                #region Calcular Quantidade de Caixa no pedido
                decimal pacote = 0, entrada = 0, caixas = 0;
                if (decimal.TryParse(txtQuantidadePct.Text, out pacote))
                {
                    if (decimal.TryParse(txtEntrada.Text, out entrada))
                    {
                        caixas = entrada / pacote;
                    }
                    txtTotalCaixas.Text = caixas.ToString("N2");
                }
                #endregion

                #region Calcular Entrada de Estoque
                decimal entradaa = 0, total = 0;
                if (decimal.TryParse(txtEntrada.Text, out entradaa))
                {
                    total = entradaa + total;
                }
                txtTotalEntrada.Text = total.ToString("N2");
                #endregion

                #region Calcular Quantidade no Pacote
                decimal pacotee = 0, somaa = 0, totall = 0;
                if (decimal.TryParse(txtQuantidadePct.Text, out pacotee))
                {
                    if (decimal.TryParse(txtTotalEntrada.Text, out somaa))
                    {
                        totall = somaa / pacotee;
                    }
                    txtTotalCaixas.Text = total.ToString("N2");
                }
                #endregion
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void LimparCadastro()
        {
            try
            {
                txtFabrica.Clear();
                txtMaterial.Clear();
                txtQuantidadePct.Text = Convert.ToString(0);
                txtTotalCaixas.Text = Convert.ToString(0);
                txtEntrada.Text = Convert.ToString(0);
                txtTotalEntrada.Text = Convert.ToString(0);
                txtUnidadeMedida.Text = Convert.ToString("M²");
                txtDevolucao.Clear();
                txtGerarId.Clear();
                dgvData.DataSource = null;
                HabilitarCampos(false);
                CarregarGridSaida();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private bool Validarcampos()
        {
            if (txtMaterial.Text == "")
            {
                MessageBox.Show("Informe o material");
            }
            return true;
        }
        private void LimparSaidaMaterial()
        {
            txtCodigoMaterial.Clear();
            txtSaidaMaterial.Clear();
            txtMedidaSaida.Clear();
            txtCalcularSaida.Text = Convert.ToString(0);
            txtTotalEstoqueSaida.Text = Convert.ToString(0);
            txtGerarId.Clear();
            CarregarGridSaida();
        }
        private void CadastrarSaida()
        {
            try
            {
                #region Estoque Saida
                decimal subtracaoo = 0, totall = 0;
                if (decimal.TryParse(txtCalcularSaida.Text, out subtracaoo))
                {
                    if (decimal.TryParse(txtTotalEstoqueSaida.Text, out subtracaoo))
                    {
                        totall = subtracaoo - totall;
                    }
                    txtTotalEstoqueSaida.Text = totall.ToString("N2");
                }
                #endregion
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

    }
}
