
using DAL.Entities.Logistica;
using DAL.Repository.Logistica;
using DAL.Repository.SenhaRestauracao;
using Logistica.Sistema_de_Logistica;
using Projeto.Util;
using System.Data;


namespace Projeto.Logistica.Sistema_de_Logistica
{
    public partial class FrmCadastraEmpresa : Form
    {
        public int empresaid;
        public string empresa;
        public string construtora;
        public FrmCadastraEmpresa()
        {
            InitializeComponent();
        }

        private void FrmCadastraEmpresa_Load(object sender, EventArgs e)
        {
            BloquearBotao(false);
            CarregarGrid();
        }

        #region Apenas Metodos
        private void HabilitarBotao(bool habilitar)
        {
            btnInserir.Enabled = habilitar;
        }
        private void LimparCampos()
        {
            txtCodigoId.Clear();
            txtEmpresaCliente.Clear();
            CarregarGrid();
        }
        private void CarregarGrid(bool isPesquisa = false)
        {
            try
            {
                var listarEmpresa = new DLCadastrarEmpresa().Listar();
                var pesquisa = txtEmpresaCliente.Text.ToLower();
                listarEmpresa = listarEmpresa.Where(p => p.Empresa.ToLower().Contains(pesquisa)).ToList();
                dgvCadastrarEmpresa.DataSource = listarEmpresa.OrderBy(p => p.EmpresaId).ToList();
                MontarGrid(dgvCadastrarEmpresa);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void MontarGrid(DataGridView dgvCadastrarEmpresa)
        {
            try
            {
                dgvCadastrarEmpresa.DefaultCellStyle.Font = new Font("Calibri", 20F, GraphicsUnit.Pixel);
                var objBlControleGrid = new ControleGrid(dgvCadastrarEmpresa);
                //Define quais colunas serão visíveis
                objBlControleGrid.DefinirVisibilidade(new List<string>()
                { "EmpresaId", "Empresa", });
                //Define quais os cabeçalhos respectivos das colunas 
                objBlControleGrid.DefinirCabecalhos(new List<string>()
                { "id", "Empresa, Construtora, Cliente, Fabricas", });
                //Define quais as larguras respectivas das colunas 
                objBlControleGrid.DefinirLarguras(new List<int>() { 15, 75, }, dgvCadastrarEmpresa.Width - 25); //O total tem que ficar em 100% 
                //Define quais os alinhamentos respectivos do componentes das colunas 
                objBlControleGrid.DefinirAlinhamento(new List<string>()
                { "centro", "centro", "centro", "centro", "centro", });
                //Define a altura das linhas respectivas da Grid 
                objBlControleGrid.DefinirAlturaLinha(30);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void BloquearBotao(bool desabilitar)
        {
            btnInserir.Enabled = desabilitar;
        }
        private bool ValidarCampos()
        {
            if(txtEmpresaCliente.Text == "")
            {
                MessageBox.Show("Informe o cliente ou a empresa");
            }
            return true;
        }
        #endregion

        private void txtEmpresaCliente_TextChanged(object sender, EventArgs e)
        {
            CarregarGrid(true);       
        }
        private void btnInserir_Click(object sender, EventArgs e)
        {
            empresaid = Convert.ToInt32(txtCodigoId.Text);
            empresa = txtEmpresaCliente.Text;
            Hide();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                bool camposSaoValidos = ValidarCampos();
                if (camposSaoValidos == true)
                {
                    int id = 0;
                    int.TryParse(txtCodigoId.Text, out id);
                    if (id > 0)
                    {
                        var clieAtualizar = new DLCadastrarEmpresa().ConsultarPorId(id);
                        clieAtualizar.EmpresaId = Convert.ToInt32(txtCodigoId.Text);
                        clieAtualizar.Empresa = txtEmpresaCliente.Text;
                        new DLCadastrarEmpresa().Atualizar(clieAtualizar);
                        MessageBox.Show("Empresa/Cliente atualizado com Sucesso ");
                    }
                    else
                    {
                        var clientBranco = new CadastrarEmpresa();
                        clientBranco.Empresa = txtEmpresaCliente.Text;
                        var idempresa = new DLCadastrarEmpresa().Inserir(clientBranco);
                        MessageBox.Show(" Codigo Empresa/Cliente " + idempresa + " Criado com Sucesso");
                    }
                }
                LimparCampos();
                CarregarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                var pergunta = "Deseja Realmente excluir esse Cadastro ? ";
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
                        int.TryParse(txtCodigoId.Text, out id);
                        if (id > 0)
                        {
                            new DLCadastrarEmpresa().Excluir(new CadastrarEmpresa { EmpresaId = id });
                            MessageBox.Show("Empresa ou Cliente excluído com sucesso!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        private void dgvFabricas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var cadastroEmpresa = dgvCadastrarEmpresa.Rows[e.RowIndex].DataBoundItem as CadastrarEmpresa;
                if (cadastroEmpresa != null)
                {
                    txtCodigoId.Text = cadastroEmpresa.EmpresaId.ToString();
                    txtEmpresaCliente.Text = cadastroEmpresa.Empresa;
                }
                HabilitarBotao(true);
                CarregarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }

    }
}
