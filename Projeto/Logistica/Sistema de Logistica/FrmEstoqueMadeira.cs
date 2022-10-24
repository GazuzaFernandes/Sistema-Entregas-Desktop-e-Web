using DAL.Entities.Financeiro;
using DAL.Entities.Logistica;
using DAL.Repository.Financeiro;
using DAL.Repository.Logistica;
using Logistica.Sistema_de_Logistica;
using Microsoft.Reporting.WinForms;
using Projeto.Logistica.Sistema_do_Financeiro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto.Logistica.Sistema_de_Logistica
{
    public partial class FrmEstoqueMadeira : Form
    {
        public FrmEstoqueMadeira()
        {
            InitializeComponent();
        }
        private void FrmEstoqueMadeira_Load(object sender, EventArgs e)
        {
            CarregarGridEstoque();        
            HabilitarCampos(false);
            MontarGridData(dgvData);
        }

        #region Tela Entrada Material 
        private void txtEntradaMetroLinear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtEntradaMetroLinear.Text != null)
                {
                    rbEntrada.Checked = true;
                    CalcularEntradaEstoque();
                }               
            }
        }

        private void txtConversorTotalM2_TextChanged(object sender, EventArgs e)
        {
            ConverterM2ParaM();
        }

        private void txtConversorLargura_TextChanged(object sender, EventArgs e)
        {
            ConverterM2ParaM();
        }
        private void txtConverterM2_TextChanged(object sender, EventArgs e)
        {
            ConversorDeMetragem();
        }

        private void txtConverterLargura_TextChanged(object sender, EventArgs e)
        {
            ConversorDeMetragem();
        }
   
        private void btnGerarId_Click(object sender, EventArgs e)
        {
            try
            {
                HabilitarCampos(true);
                var estoque = new EstoqueMadeira();
                var id = new DLEstoqueMadeira().Inserir(estoque);
                txtIdEntrada.Text = id.ToString();
                BloquearBotao(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void BloquearBotao(bool desabilitar)
        {
            btnGerarId.Enabled = desabilitar;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            cmsSalvar.Show(btnSalvar, 1, btnSalvar.Height);
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            cmsDeletar.Show(btnDeletar, 1, btnDeletar.Height);
        }

        private void bntLimparEntrada_Click(object sender, EventArgs e)
        {
            LimparCamposEntrada();
        }

        private void cmsSalvarDatas_Click(object sender, EventArgs e)
        {
            try
            {
                var dataEstoque = LerDataEntrada();
                int dataId = 0;
                if (txtDataId.Text != "")
                {
                    dataId = Convert.ToInt32(txtDataId.Text);
                    MessageBox.Show("Data atualizada com sucesso !!");
                }

                int estoqueId = 0;
                if (txtIdEntrada.Text != "")
                {
                    estoqueId = Convert.ToInt32(txtIdEntrada.Text);
                }

                var listaDataMadeira = new DLDataEstoque().Listar();
                var data = listaDataMadeira.Where(ip => ip.EstoqueId == estoqueId && ip.DataId == dataId).FirstOrDefault();
                if (data != null && data.DataId > 0)
                {
                    data.DataId = Convert.ToInt32(txtDataId.Text);
                    data.Entrada = dtpEntrada.Value;
                    data.Saida = dtpSaida.Value;
                    data.MetroQuadrado = Convert.ToDecimal(txtTotalM3Saida.Text);
                     if (rbEntrada.Checked == true)
                        data.StatusObraId = 8;
                    new DLDataEstoque().Atualizar(data);
                }
                else
                {
                    new DLDataEstoque().Inserir(dataEstoque);
                    MessageBox.Show("Data cadastrado com sucesso !");
                }
                txtDataId.Clear();
                CarregarGridData();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);

            }
        }

        private void cmSalvarMaterial_Click(object sender, EventArgs e)
        {
            try
            {
                SalvarMaterial();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro " + ex.Message);
            }
        }

        private void cmsDeletarData_Click(object sender, EventArgs e)
        {
            int id = 0;
            int.TryParse(txtDataId.Text, out id);
            if (id > 0)
            {
                new DLDataEstoque().Excluir(new DataEstoque { DataId = id });
                MessageBox.Show("Data excluida com sucesso");
                LimparCamposEntrada();
                txtDataId.Clear();
            }
        }

        private void cmsDeletarMaterial_Click(object sender, EventArgs e)
        {
            int id = 0;
            int.TryParse(txtIdEntrada.Text, out id);
            if (id > 0)
            {
                new DLEstoqueMadeira().Excluir(new EstoqueMadeira { EstoqueId = id });
                MessageBox.Show("Material excluido com sucesso");
                LimparCamposEntrada();
                txtIdEntrada.Clear();
            }
        }

        private void txtEspessuraEntrada_TextChanged(object sender, EventArgs e)
        {
            CalcularEntrada();
        }

        private void txtLarguraEntrada_TextChanged(object sender, EventArgs e)
        {
            CalcularEntrada();
        }

        private void txtMetroEntrada_TextChanged(object sender, EventArgs e)
        {
            CalcularEntrada();
        }

        private void txtTotalM2Entrada_TextChanged(object sender, EventArgs e)
        {
            CalcularEntrada();
        }

        private void dgvData_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < dgvData.Rows.Count; i++)
            {
                var valor = Convert.ToString(dgvData.Rows[i].Cells[5].Value);
                switch (valor)
                {
                    case "8":
                        dgvData.Rows[i].DefaultCellStyle.BackColor = Color.Lime;
                        break;
                    case "9":
                        dgvData.Rows[i].DefaultCellStyle.BackColor = Color.Red; break;
                }
            }
        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var data = dgvData.Rows[e.RowIndex].DataBoundItem as DataEstoque;
            if (data != null)
            {
                txtDataId.Text = data.EstoqueId.ToString();
                dtpEntrada.Value = Convert.ToDateTime(data.Entrada);
                dtpSaida.Value = Convert.ToDateTime(data.Saida);
                txtTotalM2Entrada.Text = Convert.ToString(data.MetroQuadrado);
                txtTotalM2Saida.Text = Convert.ToString(data.MetroQuadrado);
            }
        }

        #endregion

        #region Tela Saida Material
        private void btnImprimir_Click_1(object sender, EventArgs e)
        {
            try
            {
                #region Tabela Estoque
                ReportDataSource eF = new ReportDataSource();
                List<EstoqueMadeira> lst = new List<EstoqueMadeira>();
                lst.Clear();
                for (int i = 0; i < dgvSaidaMaterial.Rows.Count - 0; i++)
                {
                    lst.Add(new EstoqueMadeira
                    {
                        EstoqueId = int.Parse(dgvSaidaMaterial.Rows[i].Cells[0].Value.ToString()),
                        Madeira = dgvSaidaMaterial.Rows[i].Cells[1].Value.ToString(),
                        Espessura = Convert.ToDecimal(dgvSaidaMaterial.Rows[i].Cells[2].Value.ToString()),
                        Largura = Convert.ToDecimal(dgvSaidaMaterial.Rows[i].Cells[3].Value.ToString()),
                        MetroLinear = Convert.ToDecimal(dgvSaidaMaterial.Rows[i].Cells[4].Value.ToString()),
                        MetroQuadrado = Convert.ToDecimal(dgvSaidaMaterial.Rows[i].Cells[5].Value.ToString()),
                        MetroCubico = Convert.ToDecimal(dgvSaidaMaterial.Rows[i].Cells[6].Value.ToString()),

                    });
                }
                eF.Name = "BDEstoqueMadeira";
                eF.Value = lst;
                #endregion

                FrmImpressaoMaterial estoqueMaterial = new FrmImpressaoMaterial
                    (dtpEntrada.Value, eF);
                estoqueMaterial.rvMaterial.LocalReport.DataSources.Clear();
                estoqueMaterial.rvMaterial.LocalReport.DataSources.Add(eF);
                estoqueMaterial.rvMaterial.LocalReport.ReportEmbeddedResource =
                      "Projeto.Logistica.Sistema_de_Logistica.ImpressaoMadeira.rdlc";
                estoqueMaterial.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);
            }
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            CarregarGridEstoque(true);
        }


        private void txtCalcularSaida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtCalcularSaida.Text != null)
                {
                    rbSaida.Checked = true;
                }
                CalcularSaidaMaterial();
            }

        }

        private void txtMaterialSaida_TextChanged(object sender, EventArgs e)
        {
            CarregarGridEstoque(true);
        }

        private void txtEspessuraSaida_TextChanged(object sender, EventArgs e)
        {
            CalcularSaidaM2();
        }

        private void txtLarguraSaida_TextChanged(object sender, EventArgs e)
        {
            CalcularSaidaM2();
        }

        private void txtMetroSaida_TextChanged(object sender, EventArgs e)
        {
            CalcularSaidaM2();
        }

        private void btnBaixarEstoque_Click(object sender, EventArgs e)
        {
            try
            {
                var lerDataSaida = LerDataSaida();
                int dataId = 0;
                if (txtDataId.Text != "")
                {
                    dataId = Convert.ToInt32(txtDataId.Text);
                    MessageBox.Show("Data atualizada com sucesso !!");
                }

                int estoqueId = 0;
                if (txtIdSaida.Text != "")
                {
                    estoqueId = Convert.ToInt32(txtIdEntrada.Text);
                }

                var listaDataMadeira = new DLDataEstoque().Listar();
                var dataSaida = listaDataMadeira.Where(ip => ip.EstoqueId == estoqueId && ip.DataId == dataId).FirstOrDefault();
                if (dataSaida != null && dataSaida.DataId > 0)
                {
                    dataSaida.DataId = Convert.ToInt32(txtDataId.Text);
                    dataSaida.Saida = dtpSaida.Value;
                    dataSaida.MetroQuadrado = Convert.ToDecimal(txtTotalM3Saida.Text);
                    dataSaida.observacao = rtbSaida.Text;
                    if (rbSaida.Checked == true)
                        dataSaida.StatusObraId = 9;
                    new DLDataEstoque().Atualizar(dataSaida);
                }
                else
                {
                    new DLDataEstoque().Inserir(dataSaida);
                    MessageBox.Show("Saida de material com sucesso !");
                }
                txtDataId.Clear();
                CarregarGridData();
                SalvarMaterial();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro " + ex.Message);
            }
        }

        private void btnLimparSaida_Click(object sender, EventArgs e)
        {
            LimparCamposSaida();
            CarregarGridEstoque();
        }

        private void dgvSaidaMaterial_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var saida = dgvSaidaMaterial.Rows[e.RowIndex].DataBoundItem as EstoqueMadeira;
            if (saida != null)
            {
                #region Entrada Material
                txtIdEntrada.Text = saida.EstoqueId.ToString();
                txtEspessuraEntrada.Text = Convert.ToString(saida.Espessura);
                txtLarguraEntrada.Text = Convert.ToString(saida.Largura);
                txtMaterialEntrada.Text = Convert.ToString(saida.Madeira);
                txtMetroEntrada.Text = Convert.ToString(saida.MetroLinear);
                txtTotalM2Entrada.Text = Convert.ToString(saida.MetroQuadrado);
                txtTotalM3Entrada.Text = Convert.ToString(saida.MetroCubico);
                #endregion
                #region Saida Material
                txtIdSaida.Text = saida.EstoqueId.ToString();
                txtEspessuraSaida.Text = Convert.ToString(saida.Espessura);
                txtLarguraSaida.Text = Convert.ToString(saida.Largura);
                txtMaterialSaida.Text = Convert.ToString(saida.Madeira);
                txtMetroSaida.Text = Convert.ToString(saida.MetroLinear);
                txtTotalM2Saida.Text = Convert.ToString(saida.MetroQuadrado);
                txtTotalM3Saida.Text = Convert.ToString(saida.MetroCubico);
                #endregion
                HabilitarCampos(true);
                BloquearBotao(false);
                CarregarGridData();
                BloququearMetro(false);
            }
        }

        private void BloququearMetro(bool habilitar)
        {
            txtMetroEntrada.Enabled = habilitar;
            txtMetroSaida.Enabled = habilitar;
        }

        #endregion

        #region Apenas Metodos
        private void SalvarMaterial()
        {
            try
            {
                bool camposSaoValidos = ValidarCampo();
                if (camposSaoValidos == true)
                {
                    int id = 0;
                    int.TryParse(txtIdEntrada.Text, out id);
                    if (id > 0)
                    {
                        var entrada = new DLEstoqueMadeira().ConsultarPorId(id);      
                        entrada.Madeira = txtMaterialEntrada.Text;
                        entrada.Espessura = Convert.ToDecimal(txtEspessuraEntrada.Text);
                        entrada.Largura = Convert.ToDecimal(txtLarguraEntrada.Text);
                        entrada.MetroLinear = Convert.ToDecimal(txtMetroEntrada.Text);
                        entrada.MetroQuadrado = Convert.ToDecimal(txtTotalM2Entrada.Text);
                        entrada.MetroCubico = Convert.ToDecimal(txtTotalM3Entrada.Text);                                       
                        new DLEstoqueMadeira().Atualizar(entrada);
                        MessageBox.Show("Proposta Atualizada com Sucesso!");
                        LimparCamposEntrada();
                        dgvData.DataSource = null;
                        CarregarGridEstoque();
                        BloquearBotao(true);
                        HabilitarCampos(false);                            

                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void CalcularSaidaMaterial()
        {
            #region Calcular Saida Material
            decimal saidaEstoque = 0, SaidaMetro = 0, totalM = 0;

            if (decimal.TryParse(txtCalcularSaida.Text, out saidaEstoque))
            {
                if (decimal.TryParse(txtMetroSaida.Text, out SaidaMetro))
                {
                    totalM = SaidaMetro - saidaEstoque;

                }
            }
            txtMetroSaida.Text = totalM.ToString("N2");
            #endregion
        }

        private void CalcularSaidaM2()
        {
            #region Calcular Saida
            decimal totalm2 = 0, largura = 0, totalM = 0;

            if (decimal.TryParse(txtConverterM2.Text, out totalm2))
            {
                if (decimal.TryParse(txtConverterLargura.Text, out largura))
                {
                    if (largura > 0)
                    {
                        totalM = totalm2 / largura;
                    }
                }
            }
            txtTotalM.Text = totalM.ToString("N2");
            #endregion
        }

        private bool ValidarCampo()
        {
            if (txtMaterialEntrada.Text == "")
            {
                MessageBox.Show("Informe o nome da madeira");
            }
            return true;
        }

        private void LimparCamposEntrada()
        {
            #region Entrada Material
            txtIdEntrada.Clear();
            txtEntradaMetroLinear.Clear();
            txtEspessuraEntrada.Text = Convert.ToString("0,");
            txtLarguraEntrada.Text = Convert.ToString("0,");
            txtMaterialEntrada.Clear();
            txtMetroEntrada.Clear();
            txtTotalM2Entrada.Clear();
            txtTotalM3Entrada.Clear();
            txtIdSaida.Clear();
            dgvData.DataSource = null;
        
            #endregion          

        }

        private void LimparCamposSaida()
        {
            #region Saida Material
            txtIdSaida.Clear();
            txtEspessuraSaida.Clear();
            txtLarguraSaida.Clear();
            txtMaterialSaida.Clear();
            txtMetroSaida.Clear();
            txtTotalM3Saida.Clear();
            txtTotalM2Saida.Clear();
            txtIdEntrada.Clear();
           
            #endregion
        }

        private void CarregarGridData()
        {
            try
            {
                var listarData = new DLDataEstoque().Listar().Where(p => p.EstoqueId == Convert.ToInt32(txtIdEntrada.Text)).ToList();
                dgvData.DataSource = null;
                dgvData.DataSource = listarData.OrderByDescending(p => p.Entrada).ToList();
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
            dgvData.DefaultCellStyle.Font = new Font("Calibri", 20F, GraphicsUnit.Pixel);
            var objBlControleGrid = new ControleGrid(dgvData);
            //Define quais colunas serão visíveis
            objBlControleGrid.DefinirVisibilidade(new List<string>() { "Saida", "Entrada", "MetroQuadrado" });
            //Define quais os cabeçalhos respectivos das colunas 
            objBlControleGrid.DefinirCabecalhos(new List<string>() { "Data Saida", "Data Entrada", "M2" });
            //Define quais as larguras respectivas das colunas 
            objBlControleGrid.DefinirLarguras(new List<int>() { 35, 38, 19 }, dgvData.Width - 20); //O total tem que ficar em 100% 
                                                                                                   //Define quais os alinhamentos respectivos do componentes das colunas 
            objBlControleGrid.DefinirAlinhamento(new List<string>() { "centro", "centro", "centro", "centro", "centro", });
            //Define a altura das linhas respectivas da Grid 
            objBlControleGrid.DefinirAlturaLinha(30);
        }

        private DataEstoque LerDataSaida()
        {
            try
            {
                var saida = new DataEstoque();
                int id = 0;
                int.TryParse(txtDataId.Text, out id);
                if (id == 0)
                {
                    saida.Saida = dtpSaida.Value;
                    saida.MetroQuadrado = Convert.ToDecimal(txtTotalM2Saida.Text);
                    saida.EstoqueId = Convert.ToInt32(txtIdSaida.Text);
                    saida.observacao = rtbSaida.Text;
                    if (rbSaida.Checked == true)
                        saida.StatusObraId = 9;
                }
                return saida;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private DataEstoque LerDataEntrada()
        {
            try
            {
                var entrada = new DataEstoque();
                int id = 0;
                int.TryParse(txtDataId.Text, out id);
                if (id == 0)
                {
                    entrada.Entrada = dtpEntrada.Value;
                    entrada.MetroQuadrado = Convert.ToDecimal(txtTotalM2Entrada.Text);
                    entrada.Saida = dtpSaida.Value;
                    entrada.EstoqueId = Convert.ToInt32(txtIdEntrada.Text);
                    if (rbEntrada.Checked == true)
                        entrada.StatusObraId = 8;
                    
                }
                return entrada;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void HabilitarCampos(bool habilitar)
        {
            btnBaixarEstoque.Enabled = habilitar;
            btnDeletar.Enabled = habilitar;
            btnLimparSaida.Enabled = habilitar;
            btnLimparEntrada.Enabled = habilitar;
            btnSalvar.Enabled = habilitar;
            rtbSaida.Enabled = habilitar;

            #region Entrada Material          
            txtEspessuraEntrada.Enabled = habilitar;
            txtLarguraEntrada.Enabled = habilitar;
            txtMaterialEntrada.Enabled = habilitar;            
            dtpEntrada.Enabled = habilitar;
            #endregion

            #region Saida Material         
            dtpSaida.Enabled = habilitar;
            #endregion

        }

        private void CarregarGridEstoque(bool isPesquisa = false)
        {
            try
            {
                var listarMadeira = new DLEstoqueMadeira().Listar();
                if (isPesquisa) //isPesquisa == true
                {
                    var pesquisa = txtPesquisar.Text.ToLower();
                    listarMadeira = listarMadeira.Where(p => p.Madeira.ToLower().Contains(pesquisa)).ToList();
                }
                dgvSaidaMaterial.DataSource = listarMadeira.OrderBy(p => p.Madeira).ToList();
                MontarGridMaterial(dgvSaidaMaterial);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void MontarGridMaterial(DataGridView dgvSaidaMaterial)
        {
            dgvSaidaMaterial.DefaultCellStyle.Font = new Font("Calibri", 20F, GraphicsUnit.Pixel);
            var objBlControleGrid = new ControleGrid(dgvSaidaMaterial);
            //Define quais colunas serão visíveis
            objBlControleGrid.DefinirVisibilidade(new List<string>() { "Madeira", "Espessura", "Largura", "MetroLinear", "MetroQuadrado", "MetroCubico", });
            //Define quais os cabeçalhos respectivos das colunas 
            objBlControleGrid.DefinirCabecalhos(new List<string>() { "Madeira", "Espessura", "Largura", "ML", "M2", "M3", });
            //Define quais as larguras respectivas das colunas 
            objBlControleGrid.DefinirLarguras(new List<int>() { 45, 10, 10, 10, 10, 10, }, dgvSaidaMaterial.Width - 25); //O total tem que ficar em 100% 
                                                                                                                         //Define quais os alinhamentos respectivos do componentes das colunas 
            objBlControleGrid.DefinirAlinhamento(new List<string>() { "esquerda", "centro", "centro", "centro", "centro", });
            //Define a altura das linhas respectivas da Grid 
            objBlControleGrid.DefinirAlturaLinha(30);
        }

        private void ConversorDeMetragem()
        {
            #region Calcular Entrada
            decimal totalm2 = 0, largura = 0, totalM = 0;

            if (decimal.TryParse(txtConverterM2.Text, out totalm2))
            {
                if (decimal.TryParse(txtConverterLargura.Text, out largura))
                {
                    if (largura > 0)
                    {
                        totalM = totalm2 / largura;
                    }
                }
            }
            txtTotalM.Text = totalM.ToString("N2");
            #endregion
        }

        private void CalcularEntrada()
        {
            try
            {
                #region Calcular Metro Quadrado
                decimal largura = 0, comprimento = 0, totalm2 = 0;

                if (decimal.TryParse(txtLarguraEntrada.Text, out largura))
                {
                    if (decimal.TryParse(txtMetroEntrada.Text, out comprimento))
                    {
                        totalm2 = comprimento * largura;
                    }
                }
                txtTotalM2Entrada.Text = totalm2.ToString("N2");
                #endregion

                #region Calcular Metro Cubico
                decimal espessura = 0, metroQuadrado = 0, totalm3 = 0;
                if (decimal.TryParse(txtEspessuraEntrada.Text, out espessura))
                {
                    if (decimal.TryParse(txtTotalM2Entrada.Text, out metroQuadrado))
                    {
                        totalm3 = metroQuadrado * espessura;
                    }
                }
                txtTotalM3Entrada.Text = totalm3.ToString("N2");
                #endregion
            }
            catch (Exception)
            {

                throw;
            }
        }


        private void CalcularEntradaEstoque()
        {
            #region Calcular Entrada
            decimal entradaEstoque = 0, comprimentoEstoque = 0, totalM = 0;

            if (decimal.TryParse(txtEntradaMetroLinear.Text, out entradaEstoque))
            {
                if (decimal.TryParse(txtMetroEntrada.Text, out comprimentoEstoque))
                {
                    totalM = comprimentoEstoque + entradaEstoque;
                }
            }
            txtMetroEntrada.Text = totalM.ToString("N2");
            #endregion

            CalcularEntrada();
        }

        private void ConverterM2ParaM()
        {
            #region Converter M2 para M.
            decimal metroQuadrado = 0, Largura = 0, totalM = 0;

            if (decimal.TryParse(txtConversorTotalM2.Text, out metroQuadrado))
            {
                if (decimal.TryParse(txtConversorLargura.Text, out Largura))
                {
                    if (Largura > 0)
                    {
                        totalM = metroQuadrado / +Largura;
                    }
                }
            }
            txtConversorTotalM.Text = totalM.ToString("N2");
            #endregion
        }
        #endregion
        private void FrmEstoqueMadeira_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

    }
}
