using DAL.Entities.Financeiro;
using DAL.Repository.Financeiro;
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
    public partial class FrmEstoqueFinanceiro : Form
    {
        public int idmadeira;
        public string material;
        public string medida;
        public decimal total;
        internal MadeiraFinanceiro listarmadeiras;
        public FrmEstoqueFinanceiro()
        {
            InitializeComponent();
        }

        private void FrmEstoqueFinanceiro_Load(object sender, EventArgs e)
        {
            CarregarGridMaterial();
            HabilitarCampos(false);
            BloquearInserir(false);
        }

        #region Tela Entrada de Material     
        private void bntLimparEntrada_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnGerarId_Click(object sender, EventArgs e)
        {
            try
            {
                HabilitarCampos(true);
                var madeiras = new MadeiraFinanceiro();
                madeiras.StatusObraId = 2;//Pendente
                var id = new DLMadeiraFinanceiro().Inserir(madeiras);//inserir
                txtIdEntrada.Text = id.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            cmsSalvar.Show(btnSalvar, 1, btnSalvar.Height);
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            cmsDeletar.Show(btnDeletar, 1, btnDeletar.Height);
        }

        private void btnLiparEntrada_Click(object sender, EventArgs e)
        {
            LimparCampos();
            txtDataId.Text = Convert.ToString(null);
            dgvData.DataSource = null;
        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var datas = dgvData.Rows[e.RowIndex].DataBoundItem as ItensDataFinanceiro;
            if (datas != null)
            {
                txtDataId.Text = datas.IdDatas.ToString();
                dtpDataPedido.Value = datas.Datas;
                txtEntradaEstoque.Text = datas.Entrada.ToString();
            }
        }

        private void cmsSalvarDatas_Click(object sender, EventArgs e)
        {
            try
            {
                var itenProposta = lerdata();
                int ItensPropostaId = 0;
                if (txtDataId.Text != "")
                {
                    ItensPropostaId = Convert.ToInt32(txtDataId.Text);
                    MessageBox.Show("Data Atualizado com Sucesso");
                }
                int propostaid = 0;
                if (txtIdEntrada.Text != "")
                {
                    propostaid = Convert.ToInt32(txtIdEntrada.Text);
                }
                var listarmadeira = new DLItensDataFinanceiro().Listar();
                //Filtrando a lista "listaProposta" por propostaid e codigomaterial
                var prop = listarmadeira.Where(ip =>
                                ip.IdMadeiras == propostaid //por proppostaid
                                && ip.IdDatas == ItensPropostaId //por ItensPropostaId
                                ).FirstOrDefault();//Primeiro que encontrar
                if (prop != null && prop.IdDatas > 0)
                {
                    prop.IdDatas = Convert.ToInt32(txtDataId.Text);
                    prop.Datas = dtpDataPedido.Value;
                    prop.Fabrica = txtFabrica.Text;
                    prop.Entrada = Convert.ToDecimal(txtEntradaEstoque.Text);
                    new DLItensDataFinanceiro().Atualizar(prop);
                }
                else
                {
                    new DLItensDataFinanceiro().Inserir(itenProposta);
                    MessageBox.Show("Data Cadastrado com Sucesso");
                }              
                txtEntradaEstoque.Text = Convert.ToString(0);
                txtDataId.Text = Convert.ToString(0);
                CarregarGridData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void cmSalvarMaterial_Click(object sender, EventArgs e)
        {
            try
            {
                bool camposSaoValidos = Validarcampos();
                if (camposSaoValidos == true)
                {
                    int id = 0;
                    int.TryParse(txtIdEntrada.Text, out id);
                    if (id > 0)
                    {
                        var entrada = new DLMadeiraFinanceiro().ConsultarPorId(id);
                        entrada.IdMadeiras = Convert.ToInt32(txtIdEntrada.Text);
                        entrada.Fabrica = txtFabrica.Text;
                        entrada.Madeiras = txtMaterialEntrada.Text;
                        entrada.UnidadeMedida = txtUndMedidaEntrada.Text;
                        entrada.Entrada = Convert.ToDecimal(txtEntradaEstoque.Text);
                        entrada.Total = Convert.ToDecimal(txtTotalEntrada.Text);
                        if (rbEngenharia.Checked == true)
                            entrada.StatusObraId = 1;
                        else if (rbComercio.Checked == true)
                            entrada.StatusObraId = 2;
                        else if (rbPisos.Checked == true)
                            entrada.StatusObraId = 3;
                        new DLMadeiraFinanceiro().Atualizar(entrada);
                        MessageBox.Show("Material atualizado com Sucesso ");
                        LimparCampos();
                        CarregarGridMaterial();
                        dgvData.DataSource = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void cmsDeletarData_Click(object sender, EventArgs e)
        {
            try
            {
                var pergunta = "Deseja Realmente Excluir esse Data ? ";
                if (MessageBox.Show(pergunta, "ATENÇÂO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = 0;
                    int.TryParse(txtDataId.Text, out id);
                    if (id > 0)
                    {
                        new DLItensDataFinanceiro().Excluir(new ItensDataFinanceiro { IdDatas = id });
                        MessageBox.Show("Data excluída com sucesso!");
                        txtDataId.Text = Convert.ToString(null);
                        CarregarGridData();
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

        private void cmsDeletarMaterial_Click(object sender, EventArgs e)
        {
            try
            {
                var pergunta = "Deseja Realmente Excluir esse material ? ";
                if (MessageBox.Show(pergunta, "ATENÇÂO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = 0;
                    int.TryParse(txtIdEntrada.Text, out id);
                    if (id > 0)
                    {
                        new DLMadeiraFinanceiro().Excluir(new MadeiraFinanceiro { IdMadeiras = id });
                        MessageBox.Show("Madeira excluída com sucesso!");
                        CarregarGridMaterial();
                        LimparCampos();
                        txtIdEntrada.Text = Convert.ToString(null);
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
        #endregion

        #region Tela Saida de Material      

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                idmadeira = Convert.ToInt32(txtIdSaida.Text);
                material = txtMaterialSaida.Text;
                medida = txtUndMedidaSaida.Text;
                total = Convert.ToDecimal(txtSaidaEstoque.Text);
                int id = 0;
                int.TryParse(txtIdSaida.Text, out id);
                if (id > 0)
                {
                    var madeiraAt = new DLMadeiraFinanceiro().ConsultarPorId(id);
                    madeiraAt.Total = Convert.ToDecimal(txtTotalEstoqueSaida.Text);
                    new DLMadeiraFinanceiro().Atualizar(madeiraAt);
                }
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnLimparSaida_Click(object sender, EventArgs e)
        {
            txtIdSaida.Text = Convert.ToString(null);
            txtMaterialEntrada.Text = Convert.ToString(null);
            txtUndMedidaSaida.Text = Convert.ToString(null);
            txtSaidaEstoque.Text = Convert.ToString(null);
            txtTotalEstoqueSaida.Text = Convert.ToString(null);           
            CarregarGridMaterial();
        }

        private void txtMaterialSaida_TextChanged(object sender, EventArgs e)
        {
            CarregarGridMaterial(true);
        }

        private void txtSaidaEstoque_TextChanged(object sender, EventArgs e)
        {
            CalcularSaida();
        }
        private void dgvSaidaMaterial_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < dgvSaidaMaterial.Rows.Count; i++)
            {
                var valor = Convert.ToString(dgvSaidaMaterial.Rows[i].Cells[6].Value);
                switch (valor)
                {
                    case "1": dgvSaidaMaterial.Rows[i].DefaultCellStyle.BackColor = Color.Turquoise; break;
                    case "2": dgvSaidaMaterial.Rows[i].DefaultCellStyle.BackColor = Color.Lime; break;
                    case "3": dgvSaidaMaterial.Rows[i].DefaultCellStyle.BackColor = Color.Yellow; break;
                }
            }
        }

        private void dgvSaidaMaterial_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var ListarMadeiraStatus = dgvSaidaMaterial.Rows[e.RowIndex].DataBoundItem as MadeiraFinanceiro;
                if (ListarMadeiraStatus != null)
                {
                    #region Cadastro Estoque
                    txtIdEntrada.Text = ListarMadeiraStatus.IdMadeiras.ToString();
                    txtFabrica.Text = ListarMadeiraStatus.Fabrica;
                    txtMaterialEntrada.Text = ListarMadeiraStatus.Madeiras;
                    txtTotalEntrada.Text = ListarMadeiraStatus.Total.ToString();
                    txtUndMedidaEntrada.Text = ListarMadeiraStatus.UnidadeMedida;
                    #endregion

                    #region Saida Estoque
                    txtIdSaida.Text = ListarMadeiraStatus.IdMadeiras.ToString();
                    txtMaterialSaida.Text = ListarMadeiraStatus.Madeiras;
                    txtUndMedidaSaida.Text = ListarMadeiraStatus.UnidadeMedida;
                    txtTotalEstoqueSaida.Text = ListarMadeiraStatus.Total.ToString();
                    #endregion

                    switch (ListarMadeiraStatus.StatusObraId)//escolha
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
                }
                HabilitarCampos(true);
                BloquearInserir(true);
                CarregarGridData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }


        #endregion

        #region Apenas Metodos 
        private void BloquearInserir(bool liberar)
        {
            btnInserir.Enabled = liberar;
        }

        private void CarregarGridMaterial(bool isPesquisa = false)
        {
            try
            {
                var listarMadeira = new DLMadeiraFinanceiro().Listar();
                if (isPesquisa) //isPesquisa == true
                {
                    var pesquisa = txtMaterialSaida.Text.ToLower();
                    listarMadeira = listarMadeira.Where(p => p.Madeiras.ToLower().Contains(pesquisa)).ToList();
                }
                dgvSaidaMaterial.DataSource = listarMadeira.OrderByDescending(p => p.StatusObraId).ToList(); 
                MontarGridMaterial(dgvSaidaMaterial);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void MontarGridMaterial(DataGridView dgvMaterial)
        {
            try
            {
                dgvSaidaMaterial.DefaultCellStyle.Font = new Font("Calibri", 20F, GraphicsUnit.Pixel);
                var objBlControleGrid = new ControleGrid(dgvSaidaMaterial);
                //Define quais colunas serão visíveis
                objBlControleGrid.DefinirVisibilidade(new List<string>() { "Madeiras", "UnidadeMedida", "Total", });
                //Define quais os cabeçalhos respectivos das colunas 
                objBlControleGrid.DefinirCabecalhos(new List<string>() { "Madeiras", "Unid Medida", "Total" });
                //Define quais as larguras respectivas das colunas 
                objBlControleGrid.DefinirLarguras(new List<int>() { 70, 10, 15 }, dgvSaidaMaterial.Width - 15); //O total tem que ficar em 100% 
                //Define quais os alinhamentos respectivos do componentes das colunas 
                objBlControleGrid.DefinirAlinhamento(new List<string>() { "centro", "centro", "centro", "centro", "centro", });
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
           
            txtFabrica.Enabled = habilitar;
            txtMaterialEntrada.Enabled = habilitar;
            txtEntradaEstoque.Enabled = habilitar;
            txtUndMedidaEntrada.Enabled = habilitar;
            btnSalvar.Enabled = habilitar;
            btnDeletar.Enabled = habilitar;
            btnLimparSaida.Enabled = habilitar;
            bntLimparEntrada.Enabled = habilitar;          
        
        }

        private void CarregarGridData()
        {
            try
            {
                var listarData = new DLItensDataFinanceiro().Listar().Where(p => p.IdMadeiras == Convert.ToInt32(txtIdEntrada.Text)).ToList();
                dgvData.DataSource = null;
                dgvData.DataSource = listarData.OrderByDescending(p => p.Datas).ToList();
                dgvData.Refresh(); 
                MontarGridData(dgvData);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void MontarGridData(DataGridView dgvData)
        {
            try
            {
                dgvData.DefaultCellStyle.Font = new Font("Calibri", 20F, GraphicsUnit.Pixel);
                var objBlControleGrid = new ControleGrid(dgvData);
                //Define quais colunas serão visíveis
                objBlControleGrid.DefinirVisibilidade(new List<string>() { "Fabrica", "Datas", "Entrada", });
                //Define quais os cabeçalhos respectivos das colunas 
                objBlControleGrid.DefinirCabecalhos(new List<string>() { "Fabrica", "Data", "Entrada" });
                //Define quais as larguras respectivas das colunas 
                objBlControleGrid.DefinirLarguras(new List<int>() { 25, 25, 50 }, dgvData.Width - 25); //O total tem que ficar em 100% 
                //Define quais os alinhamentos respectivos do componentes das colunas 
                objBlControleGrid.DefinirAlinhamento(new List<string>() { "centro", "centro", "centro", "centro", "centro", });
                //Define a altura das linhas respectivas da Grid 
                objBlControleGrid.DefinirAlturaLinha(30);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
      
        private ItensDataFinanceiro lerdata()
        {
            try
            {
                var iten = new ItensDataFinanceiro();
                int id = 0;
                int.TryParse(txtDataId.Text, out id);
                if (id == 0)
                {
                    iten.Datas = dtpDataPedido.Value;
                    iten.Fabrica = txtFabrica.Text;
                    iten.Entrada = Convert.ToDecimal(txtEntradaEstoque.Text);
                    iten.IdMadeiras = Convert.ToInt32(txtIdEntrada.Text);
                }
                return iten;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool Validarcampos()
        {
            if(txtMaterialEntrada.Text == "")
            {
                MessageBox.Show("Informe o material");
            }
            return true;
        }

        private void LimparCampos()
        {
            txtIdEntrada.Text = Convert.ToString(null);
            txtFabrica.Text = Convert.ToString(null);
            txtMaterialEntrada.Text = Convert.ToString(null);
            txtUndMedidaEntrada.Text = Convert.ToString("m²");
            txtEntradaEstoque.Text = Convert.ToString(0);
            txtTotalEntrada.Text = Convert.ToString(null);
            txtDataId.Text = Convert.ToString(null);
        }

        private void CalcularSaida()
        {
            try
            {
                int id = 0;
                int.TryParse(txtSaidaEstoque.Text, out id);
                if (id > 0)
                {
                    SaidadeMaterial();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void SaidadeMaterial()
        {
            try
            {
                decimal saida = 0, subtraindo = 0, total = 0;
                if (decimal.TryParse(txtSaidaEstoque.Text, out saida))
                {
                    if (decimal.TryParse(txtTotalEstoqueSaida.Text, out subtraindo))
                    {
                        total = subtraindo - saida;
                    }
                }
                txtTotalEstoqueSaida.Text = total.ToString("N2");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CalcularEntrada()
        {
            try
            {
                decimal entrada = 0, adicao = 0, total2 = 0;
                if (decimal.TryParse(txtEntradaEstoque.Text, out entrada))
                {
                    if (decimal.TryParse(txtTotalEntrada.Text, out adicao))
                    {
                        total2 = entrada + adicao;
                    }
                    txtTotalEntrada.Text = total2.ToString("N2");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        private void txtEntradaEstoque_TextChanged(object sender, EventArgs e)
        {
            CalcularEntrada();
        }
    }
}
