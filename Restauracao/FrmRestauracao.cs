
using static Logistica.BackupAutomatico.SystemRetaguarda;

namespace Restauracao
{
    public partial class FrmRestauracao : Form
    {
        public FrmRestauracao()
        {
            InitializeComponent();
        }


        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            try
            {
                #region Restauração
                OpenFileDialog od = new OpenFileDialog();
                od.ShowDialog();
                var arquivo = od.FileName;
                FunctionsDataBase.RestoreDatabase("192.168.0.114",
                                                "5432",
                                                "postgres",
                                                "q1s2e3f4t5",
                                                "RbDesktop",
                                                arquivo);
                MessageBox.Show("Sistema Restaurado com Sucesso !");
                #endregion
                Close();
          
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usuario cancelou a solicitação!");
            Close();

        }
    }
}