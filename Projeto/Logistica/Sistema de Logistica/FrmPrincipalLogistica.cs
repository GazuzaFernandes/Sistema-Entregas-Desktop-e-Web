using DALLogistica.Repository;
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

namespace Logistica.Sistema_de_Logistica
{
    public partial class FrmPrincipalLogistica : Form
    {
        public FrmPrincipalLogistica()
        {
            InitializeComponent();
        }
        private void FrmPrincipalLogistica_Load(object sender, EventArgs e)
        {

        }

        #region Abertura de Form's
        private void msInserir_Click(object sender, EventArgs e)
        {
            FrmProposta proposta = new FrmProposta();
            proposta.Show();
        }

        private void msFerramentas_Click(object sender, EventArgs e)
        {
            FrmFerramentas ferramentas = new FrmFerramentas();
            ferramentas.Show();
        }

        private void msNotaFiscal_Click(object sender, EventArgs e)
        {
            FrmNotaFiscal notaFiscal = new FrmNotaFiscal();
            notaFiscal.Show();
        }

        private void msArt_Click(object sender, EventArgs e)
        {
            FrmArt art = new FrmArt();
            art.Show();
        }

        private void msRoteiro_Click(object sender, EventArgs e)
        {
            FrmRoteiro roteiro = new FrmRoteiro();
            roteiro.Show();
        }

        #endregion

        #region Apenas Text Box
        private void txtPesquisar_Click(object sender, EventArgs e)
        {
            txtPesquisar.Clear();
        }
        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtLarguraMdf_TextChanged(object sender, EventArgs e)
        {
            ValorMdf();
        }
        private void txtAlturaMdf_TextChanged(object sender, EventArgs e)
        {
            ValorMdf();
        }
        private void txtComprimentoMdf_TextChanged(object sender, EventArgs e)
        {
            ValorMdf();
        }
        private void txtComprimentoM2_TextChanged(object sender, EventArgs e)
        {
            CalcularM2();
        }
        private void txtLarguraM2_TextChanged(object sender, EventArgs e)
        {
            CalcularM2();
        }
        private void txtCalcularm2_TextChanged(object sender, EventArgs e)
        {
            CalcularM3();
        }
        private void TxtEspessuraM3_TextChanged(object sender, EventArgs e)
        {
            CalcularM3();
        }
        private void txtAreaVerniz_TextChanged(object sender, EventArgs e)
        {
            CalcularVerniz();
        }
        private void txtVerniz_TextChanged(object sender, EventArgs e)
        {
            CalcularVerniz();
        }
        private void txtAreaBase_TextChanged(object sender, EventArgs e)
        {
            CalcularVerniz();
        }
        private void txtBase_TextChanged(object sender, EventArgs e)
        {
            CalcularVerniz();
        }
        private void txtAreaCetol_TextChanged(object sender, EventArgs e)
        {
            CalcularCetol();
        }
        private void txtRendimentoCetol_TextChanged(object sender, EventArgs e)
        {
            CalcularCetol();
        }
        private void txtAreaTerreo_TextChanged(object sender, EventArgs e)
        {
            CalcularWakol();
        }
        private void txtWakolTerreo_TextChanged(object sender, EventArgs e)
        {
            CalcularWakol();
        }
        private void txtAreaSuperior_TextChanged(object sender, EventArgs e)
        {
            CalcularWakol();
        }
        private void txtWakolSuperior_TextChanged(object sender, EventArgs e)
        {
            CalcularWakol();
        }
        private void txtM2Presilhas_TextChanged(object sender, EventArgs e)
        {
            CalcuparPresilha();
        }
        private void txtLarguraDeck_TextChanged(object sender, EventArgs e)
        {
            CalcuparPresilha();
        }
        private void txtTotalLinha1_TextChanged(object sender, EventArgs e)
        {
            CalcuparPresilha();
        }
        private void txtTotalLinha2_TextChanged(object sender, EventArgs e)
        {
            CalcuparPresilha();
        }
        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            CalcuparPresilha();
        }
        private void txtPresilhasM2_TextChanged(object sender, EventArgs e)
        {
            CalcuparPresilha();
        }
        private void txtPedidoM2_TextChanged(object sender, EventArgs e)
        {
            CalcuparPresilha();
        }
        #endregion

        #region Apenas Metodos
        private void CarregarFerramenta(bool isPesquisa = false)
        {
            try
            {
                var listarFerramentas = new DLFerramentas().Listarferramenta();
                if (isPesquisa) //isPesquisa == true
                {
                    var pesquisa = txtPesquisar.Text.ToLower();
                    if (rbCliente.Checked)
                        listarFerramentas = listarFerramentas.Where(p => p.funcionario.ToLower().Contains(pesquisa)).ToList();
                }
                dgvFerramenta.DataSource = listarFerramentas;
                MontarFerramentas(dgvFerramenta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void MontarFerramentas(DataGridView dgvFerramentas)
        {
            dgvFerramenta.DefaultCellStyle.Font = new Font("Calibri", 16F, GraphicsUnit.Pixel);
            var objBlControleGrid = new ControleGrid(dgvFerramenta);
            //Define quais colunas serão visíveis
            objBlControleGrid.DefinirVisibilidade(new List<string>()
            { "funcionario", "retirada", "devolucao", "material", });
            //Define quais os cabeçalhos respectivos das colunas 
            objBlControleGrid.DefinirCabecalhos(new List<string>()
            { "FUNCIONARIO", "RETIRADA", "DEVOLUÇÃO", "MATERIAL", });
            //Define quais as larguras respectivas das colunas 
            objBlControleGrid.DefinirLarguras(new List<int>() { 25, 15, 10, 50, }, dgvFerramenta.Width - 15); //O total tem que ficar em 100% 
            //Define quais os alinhamentos respectivos do componentes das colunas 
            objBlControleGrid.DefinirAlinhamento(new List<string>()
            { "esquerda", "esquerda", "esquerda", "esquerda", "esquerda", });
            //Define a altura das linhas respectivas da Grid 
            objBlControleGrid.DefinirAlturaLinha(30);
        }
        private void CarregarPrincipal(bool isPesquisa = false)
        {
            try
            {
                var listaPropostaStatus = new DLProposta().ListarPropostaStatus();
                if (isPesquisa) //isPesquisa == true
                {
                    #region Pesquisa
                    var pesquisa = txtPesquisar.Text.ToLower();
                    if (rbFabrica.Checked)
                        listaPropostaStatus = listaPropostaStatus.Where(p => p.fabrica.ToLower().Contains(pesquisa)).ToList();
                    else if (rbMaterial.Checked)
                        listaPropostaStatus = listaPropostaStatus.Where(x => x.material.ToLower().Contains(pesquisa)).ToList();
                    else if (rbEng.Checked)
                        listaPropostaStatus = listaPropostaStatus.Where(p => p.engresp.ToLower().Contains(pesquisa)).ToList();
                    else if (rbPedidoRb.Checked)
                        listaPropostaStatus = listaPropostaStatus.Where(p => p.pdrb.ToLower().Contains(pesquisa)).ToList();
                    else if (rbPedidoVenda.Checked)
                        listaPropostaStatus = listaPropostaStatus.Where(p => p.pdvenda.ToLower().Contains(pesquisa)).ToList();
                    else if (rbProposta.Checked)
                        listaPropostaStatus = listaPropostaStatus.Where(p => p.propostaa.ToLower().Contains(pesquisa)).ToList();
                    else if (rbCliente.Checked)
                        listaPropostaStatus = listaPropostaStatus.Where(p => p.construtora.ToLower().Contains(pesquisa)).ToList();
                    else if (rbEndereco.Checked)
                        listaPropostaStatus = listaPropostaStatus.Where(p => p.obra.ToLower().Contains(pesquisa)).ToList();
                    else if (rbNotaFiscal.Checked)
                        listaPropostaStatus = listaPropostaStatus.Where(p => p.notafiscal.ToLower().Contains(pesquisa)).ToList();
                    #endregion

                    #region Status
                    if (cbFinalizado.Checked)//==
                        listaPropostaStatus = listaPropostaStatus.Where(p => p.Status.Equals("Finalizado")).ToList();
                    else if (cbPendente.Checked)
                        listaPropostaStatus = listaPropostaStatus.Where(p => p.Status.Equals("Pendente")).ToList();
                    else if (cbImediato.Checked)
                        listaPropostaStatus = listaPropostaStatus.Where(p => p.Status.Equals("Imediato")).ToList();
                    else if (cbCancelado.Checked)
                        listaPropostaStatus = listaPropostaStatus.Where(p => p.Status.Equals("Cancelado")).ToList();
                    #endregion
                }
                dgvPrincipal.DataSource = listaPropostaStatus;
                MontarProposta(dgvPrincipal);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void MontarProposta(DataGridView dgvPrincipal)
        {
            dgvPrincipal.DefaultCellStyle.Font = new Font("Calibri", 16F, GraphicsUnit.Pixel);
            var objBlControleGrid = new ControleGrid(dgvPrincipal);
            //Define quais colunas serão visíveis
            objBlControleGrid.DefinirVisibilidade(new List<string>()
            { "dataprevista", "fabrica", "engresp", "pdrb", "pdvenda", "propostaa", "construtora", "obra", "notafiscal", });
            //Define quais os cabeçalhos respectivos das colunas 
            objBlControleGrid.DefinirCabecalhos(new List<string>()
            { "DATA PREVISTA", "FABRICA", "RESP.", "PD RB", "PD VENDA", "PROPOSTA", "CLIENTE", "OBRA", "NF", });
            //Define quais as larguras respectivas das colunas 
            objBlControleGrid.DefinirLarguras(new List<int>() { 9, 9, 7, 8, 8, 8, 12, 27, 7, }, dgvPrincipal.Width - 15); //O total tem que ficar em 100% 
            objBlControleGrid.DefinirAlinhamento(new List<string>()
            { "esquerda", "esquerda", "esquerda", "esquerda", "esquerda", "esquerda", "esquerda", "esquerda", "esquerda", });
            //Define a altura das linhas respectivas da Grid 
            objBlControleGrid.DefinirAlturaLinha(30);
        }
        private void ReducaoCodigoPesquisar()
        {
            CarregarFerramenta(true);
            MontarFerramentas(dgvFerramenta);
            CarregarPrincipal(true);
            MontarProposta(dgvPrincipal);
        }
        private void ReducaoCodigoLimpeza()
        {
            try
            {
                txtPesquisar.Text = Convert.ToString("Digite para Pesquisar:");
                rbFabrica.Checked = false;
                rbEng.Checked = false;
                rbPedidoRb.Checked = false;
                rbEndereco.Checked = false;
                rbPedidoVenda.Checked = false;
                rbNotaFiscal.Checked = false;
                rbMaterial.Checked = false;
                rbProposta.Checked = false;
                rbCliente.Checked = false;
                cbCancelado.Checked = false;
                cbFinalizado.Checked = false;
                cbPendente.Checked = false;
                cbImediato.Checked = false;
                CarregarFerramenta();
                CarregarPrincipal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

        }
        private void CalcularVerniz()
        {
            try
            {
                #region Calcular Verniz
                decimal areaVerniz = 0, verniz = 0, totalVerniz = 0;
                if (decimal.TryParse(txtAreaVerniz.Text, out areaVerniz))
                {
                    if (decimal.TryParse(txtVerniz.Text, out verniz))
                    {
                        totalVerniz = areaVerniz / verniz;
                    }
                }
                txtGalaoVerniz.Text = totalVerniz.ToString("N2");
                #endregion

                #region Calcular Base
                decimal areaBase = 0, bases = 0, totalbase = 0;
                if (decimal.TryParse(txtAreaBase.Text, out areaBase))
                {
                    if (decimal.TryParse(txtBase.Text, out bases))
                    {
                        totalbase = areaBase / bases;
                    }
                }
                txtGalaoBase.Text = totalVerniz.ToString("N2");
                #endregion

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void CalcularCetol()
        {
            try
            {
                decimal areaCetol = 0, rendimento = 0, totalcetol = 0;

                if (decimal.TryParse(txtAreaCetol.Text, out areaCetol))
                {
                    if (decimal.TryParse(txtRendimentoCetol.Text, out rendimento))
                    {
                        totalcetol = areaCetol / rendimento;
                    }
                    txtLataCetol.Text = totalcetol.ToString("N2");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void CalcularWakol()
        {
            try
            {
                #region Calculo Wakol Superior
                decimal areaSuperior = 0, superio = 0, totalSuperio = 0;
                if (decimal.TryParse(txtAreaSuperior.Text, out areaSuperior))
                {
                    if (decimal.TryParse(txtWakolSuperior.Text, out superio))
                    {
                        totalSuperio = areaSuperior / superio;
                    }
                }
                txtGalaoSuperior.Text = totalSuperio.ToString("N2");
                #endregion

                #region Calcular Wakol Terreo
                decimal areaTerreo = 0, terreo = 0, totalTerreo = 0;
                if (decimal.TryParse(txtAreaTerreo.Text, out areaTerreo))
                {
                    if (decimal.TryParse(txtWakolTerreo.Text, out terreo))
                    {
                        totalTerreo = areaTerreo / terreo;
                    }
                }
                txtGalaoTerreo.Text = totalTerreo.ToString("N2");
                #endregion          
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void CalcuparPresilha()
        {
            try
            {                  
                #region Calculo do Deck Presilhas
                decimal LarDeck = 0;
                decimal m2Presilha = 0;
                decimal totaldeck = 0;
                if (decimal.TryParse(txtM2Presilhas.Text, out m2Presilha))
                {
                    if(LarDeck != Convert.ToDecimal(txtLarguraDeck.Text))
                    {
                        if (decimal.TryParse(txtLarguraDeck.Text, out LarDeck))
                        {
                            totaldeck = m2Presilha / LarDeck;
                        }
                    }                   
                    txtTotalDeck.Text = totaldeck.ToString("N2");
                }
                #endregion

                #region Calculo Linha 2
                decimal totalLinha1 = 0;
                decimal totalLinha2 = 1;
                decimal totallColuna3 = 0;
                decimal totallinha2 = 0;
                if (decimal.TryParse(txtTotalCaibro.Text, out totalLinha1))
                {
                    if (decimal.TryParse(txtTotalLinha2.Text, out totalLinha2))
                    {
                        if (decimal.TryParse(txtTotal.Text, out totallColuna3))
                        {
                            totallinha2 = totalLinha1 * totalLinha2 / totallColuna3;
                        }
                    }
                }
                txtTotalPresilha.Text = totallinha2.ToString("N2");
                #endregion

                #region Linha 3 Final
                decimal PresilhaM2 = 0;
                decimal M2Pedido = 0;
                decimal totalpresilha = 0;
                if (decimal.TryParse(txtPresilhasM2.Text, out PresilhaM2))
                {
                    if (decimal.TryParse(txtPedidoM2.Text, out M2Pedido))
                    {
                        totalpresilha = PresilhaM2 * M2Pedido;
                    }

                }
                txtTotalPresilha.Text = totalpresilha.ToString("N2");
                #endregion

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void ValorMdf()
        {
            try
            {
                decimal altura = 0;
                decimal larguraMdf = 0;
                decimal comprimento = 0;
                decimal total = 0;

                if (decimal.TryParse(txtAlturaMdf.Text, out altura))
                {
                    if (decimal.TryParse(txtLarguraMdf.Text, out larguraMdf))
                    {
                        if (decimal.TryParse(txtComprimentoMdf.Text, out comprimento))

                            total = larguraMdf / altura * comprimento;
                    }
                }               
                txtTotalChapa.Text = total.ToString("N2");
            }
            catch (Exception ex)
            {
            }
        }
        private void CalcularM2()
        {
            try
            {
                decimal comprimento = 0;
                decimal largura = 0;
                decimal total = 0;
                if (decimal.TryParse(txtComprimentoM2.Text, out comprimento))
                {
                    if (decimal.TryParse(txtLarguraM2.Text, out largura))
                    {
                        total = largura * comprimento;
                    }
                }
                else
                {
                    MessageBox.Show("Valor Invalido");
                }
                txtTotalm2.Text = total.ToString("N2");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void CalcularM3()
        {
            try
            {
                decimal totalm2 = 0;
                decimal espessura = 0;
                decimal total = 0;
                if (decimal.TryParse(txtCalcularm2.Text, out totalm2))
                {
                    if (decimal.TryParse(TxtEspessuraM3.Text, out espessura))
                    {
                        total = totalm2 * espessura;
                    }
                    else
                    {
                        MessageBox.Show("Quantidade inválida");
                    }
                }
                txtTotalm3.Text = total.ToString("N2");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Apenas Grid
        private void dgvPrincipal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvPrincipal_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
        }

        private void dgvFerramenta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvFerramenta_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

        }


        #endregion

        #region Apenas Botões
        private void btnLimparCalculos_Click(object sender, EventArgs e)
        {
          //teste
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }
        private void btnLimparPesquisa_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
