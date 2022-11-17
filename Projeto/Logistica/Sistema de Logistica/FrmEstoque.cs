
using DAL.Entities.Financeiro;
using DAL.Entities.Logistica;
using DAL.Repository.Logistica;
using Logistica.Sistema_de_Logistica;
using Microsoft.Reporting.WinForms;
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
                    if (txtEntrada.Text != "")
                    {
                        madeiraAt.Entrada = Convert.ToDecimal(txtEntrada.Text);
                    }

                    new DLItensMaterial().Atualizar(madeiraAt);
                    MessageBox.Show("Material atualizado com Sucesso ");
                    CarregarGridSaida();
                    dgvData.DataSource = null;
                    LimparCadastro();
                    LimparSaidaMaterial();
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

            }
        }
        private void txtEntrada_TextChanged(object sender, EventArgs e)
        {
            CalcularCadastro();
        }

        #endregion

        #region Saida de Material
        private void btnImprimir_Click_1(object sender, EventArgs e)
        {
            #region Tabela Estoque
            ReportDataSource eF = new ReportDataSource();
            List<ItensMaterial> lst = new List<ItensMaterial>();
            lst.Clear();
            for (int i = 0; i < dgvSaidaMaterial.Rows.Count - 0; i++)
            {
                lst.Add(new ItensMaterial
                {
                    MaterialId = int.Parse(dgvSaidaMaterial.Rows[i].Cells[0].Value.ToString()),
                    Material = dgvSaidaMaterial.Rows[i].Cells[1].Value.ToString(),
                    UnidadeMedida = dgvSaidaMaterial.Rows[i].Cells[2].Value.ToString(),
                    Total = Convert.ToDecimal(dgvSaidaMaterial.Rows[i].Cells[3].Value.ToString()),

                });

            }
            eF.Name = "BDEstoqueProduto";
            eF.Value = lst;
            #endregion

            FrmImpressaoProduto frmImpressao = new FrmImpressaoProduto
                (dtpData.Value, eF);
            frmImpressao.rvProduto.LocalReport.DataSources.Clear();
            frmImpressao.rvProduto.LocalReport.DataSources.Add(eF);
            frmImpressao.rvProduto.LocalReport.ReportEmbeddedResource =
                   "Projeto.Logistica.Sistema_de_Logistica.ImpressaoProduto.rdlc";
            frmImpressao.ShowDialog();

        }
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
            CalcularSaida();
        }
        #endregion

        #region Metodos
        private void HabilitarCampos(bool habilitar)
        {
            txtFabrica.Enabled = habilitar;
            txtMaterial.Enabled = habilitar;

            txtEntrada.Enabled = habilitar;
            txtUnidadeMedida.Enabled = habilitar;
            txtCalcularSaida.Enabled = habilitar;
            btnDeletar.Enabled = habilitar;
            
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
                dgvSaidaMaterial.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 20F, GraphicsUnit.Pixel);
                var objBlControleGrid = new ControleGrid(dgvSaidaMaterial);
                //Define quais colunas serão visíveis
                objBlControleGrid.DefinirVisibilidade(new List<string>()
                { "Material", "UnidadeMedida", "Total", });
                //Define quais os cabeçalhos respectivos das colunas 
                objBlControleGrid.DefinirCabecalhos(new List<string>()
                { "Material", "Medida", "Estoque", });
                //Define quais as larguras respectivas das colunas 
                objBlControleGrid.DefinirLarguras(new List<int>() { 60, 15, 15 }, dgvSaidaMaterial.Width - 25); //O total tem que ficar em 100% 
                //Define quais os alinhamentos respectivos do componentes das colunas 
                objBlControleGrid.DefinirAlinhamento(new List<string>()
                { "direita", "esquerda", "esquerda", });
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
                dgvData.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 20F, GraphicsUnit.Pixel);
                var objBlControleGrid = new ControleGrid(dgvData);
                //Define quais colunas serão visíveis
                objBlControleGrid.DefinirVisibilidade(new List<string>()
                { "DataEntrada", "Entrada", "Fabrica"});
                //Define quais os cabeçalhos respectivos das colunas 
                objBlControleGrid.DefinirCabecalhos(new List<string>()
                { "Data de Entrada", "Entrada", "Fabrica"});
                //Define quais as larguras respectivas das colunas 
                objBlControleGrid.DefinirLarguras(new List<int>() { 30, 30, 32}, dgvData.Width - 25); //O total tem que ficar em 100% 
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
                #region Calcular Entrada de Estoque
                decimal entrada = 0, total = 0;
                if (decimal.TryParse(txtEntrada.Text, out entrada))
                {
                    if (decimal.TryParse(txtTotalEntrada.Text, out total))
                    {
                        total = total + entrada;
                    }

                }
                txtTotalEntrada.Text = total.ToString("N2");
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
                txtEntrada.Text = Convert.ToString(0);
                txtTotalEntrada.Text = Convert.ToString(0);
                txtUnidadeMedida.Clear();
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

        private void txtEntrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                CalcularCadastro();
                txtEntrada.Enabled = false;
            }           
        }
        private void txtCalcularSaida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                CalcularSaida();
                txtCalcularSaida.Enabled = false;
                btnInserir.Enabled = true;
            }
        }

        private void deletarDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int id = 0;
                int.TryParse(txtDataId.Text, out id);
                if (id > 0)
                {
                    new DLDataMaterial().Excluir(new DataMaterial { MaterialId = id });
                    MessageBox.Show("Data excluido com sucesso!");
                    CarregarGridData();
                    txtDataId.Text = Convert.ToString(null);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void deletarItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var pergunta = "Deseja Realmente excluir esse Item ? ";
                if (MessageBox.Show(pergunta, "ATENÇÂO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    FrmLogin login = new FrmLogin();
                    login.ShowDialog();
                    Boolean temUsuario = false;
                    var listaUsuarios = new DLUsuario().Listar();
                    for (int i = 0; i < listaUsuarios.Count; i++)
                    {
                        if (listaUsuarios[i].Senha == login.txtSenha.Text)
                        {
                            temUsuario = true;
                        }
                    }
                    if (temUsuario == true)
                    {
                        int id = 0;
                        int.TryParse(txtGerarId.Text, out id);
                        if (id > 0)
                        {
                            new DLItensMaterial().Excluir(new ItensMaterial { MaterialId = id });
                            MessageBox.Show("Item excluído com sucesso!");
                            CarregarGridSaida();
                            txtGerarId.Text = Convert.ToString(null);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCalcularSaida_TextChanged_1(object sender, EventArgs e)
        {
            CalcularSaida();
        }

        private bool Validarcampos()
        {
            if (txtMaterial.Text == "")
            {
                MessageBox.Show("Informe o material");
            }

            if (txtUnidadeMedida.Text == "")
            {
                MessageBox.Show("Informe a unidade de medida");
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
        private void CalcularSaida()
        {
            try
            {
                #region Estoque Saida
                decimal subtracaoo = 0, totall = 0;
                if (decimal.TryParse(txtCalcularSaida.Text, out subtracaoo))
                {
                    if (decimal.TryParse(txtTotalEstoqueSaida.Text, out totall))
                    {
                        totall = totall - subtracaoo;
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
