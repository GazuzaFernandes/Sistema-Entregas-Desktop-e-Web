using DAL.Repository.SenhaRestauracao;
using static Logistica.BackupAutomatico.SystemRetaguarda;

namespace Restauracao
{
    public partial class FrmRestauracao : Form
    {
        public FrmRestauracao()
        {
            InitializeComponent();
        }

        private void txtSenha_Click(object sender, EventArgs e)
        {
            txtSenha.Clear();
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            try
            {
                Boolean temUsuario = false;
                var listaUsuarios = new DLSenha().Listar();
                for (int i = 0; i < listaUsuarios.Count; i++)
                {
                    if (listaUsuarios[i].Senhas == txtSenha.Text)
                    {
                        temUsuario = true;
                    }
                }
                if (temUsuario == true)
                {
                    #region Restaura��o
                    OpenFileDialog od = new OpenFileDialog();
                    od.ShowDialog();
                    var arquivo = od.FileName;
                    FunctionsDataBase.RestoreDatabase("192.168.0.202",
                                                    "5432",
                                                    "postgres",
                                                    "q1s2e3f4t5",
                                                    "RBCOMERCIO",
                                                    arquivo);
                    MessageBox.Show("Sistema Restaurado com Sucesso !");
                    #endregion
                    Close();
                }
                else
                {
                    MessageBox.Show("Senha inv�lida!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usuario cancelou a solicita��o!");
            Close();

        }
    }
}