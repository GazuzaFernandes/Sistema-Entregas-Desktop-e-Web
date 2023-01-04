
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
                #region Restaura��o
                OpenFileDialog od = new OpenFileDialog();
                od.ShowDialog();
                var arquivo = od.FileName;
                FunctionsDataBase.RestoreDatabase("localhost",
                                                "5432",
                                                "postgres",
                                                "q1s2e3f4t5",
                                                "RbDesktop",
                                                arquivo);
                FrmInicioRestauracao rest = new FrmInicioRestauracao();
                rest.Show();
                Hide();
              
                #endregion

             
                
          
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