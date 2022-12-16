using Logistica.Sistema_de_Amostras;
using Logistica.Sistema_de_Logistica;
using Logistica.Sistema_do_Financeiro;
using Logistica.Sistema_do_Orçamento;
using Logistica.Sistema_dos_Engenheiros;
using static Logistica.BackupAutomatico.SystemRetaguarda;
using static Projeto.Backup.Backup;

namespace Projeto
{
    public partial class FrmEscolha : Form
    {
        public FrmEscolha()
        {
            InitializeComponent();
        }

        private void FrmEscolha_Load(object sender, EventArgs e)
        {

        }

   

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            switch (cbSelecionar.Text)
            {
                case "Amostra.":
                    {
                        FrmPrincipalAmostra amostra = new FrmPrincipalAmostra();
                        amostra.Show();
                    }
                    break;

                case "Engenharia.":
                    {
                        FrmPrincipalEng eng = new FrmPrincipalEng();
                        eng.Show();
                    }
                    break;

                case "Logistica.":
                    {
                        FrmPrincipalLogistica logistica = new FrmPrincipalLogistica();
                        logistica.Show();
                    }
                    break;

                case "Financeiro.":
                    {
                        FrmPrincipalFinanceiro fin = new FrmPrincipalFinanceiro();
                        fin.Show();
                    }
                    break;

                case "Orçamento.":
                    {
                        FrmOrcamentoPrincipal orc = new FrmOrcamentoPrincipal();
                        orc.Show();
                    }
                    break;             
            }
            Hide();
        }

       

        private void FrmEscolha_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Systembackup.Restauracao();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void FrmEscolha_Click(object sender, EventArgs e)
        {
          this.WindowState = FormWindowState.Minimized;
        }

        private void btnEntrar_MouseMove(object sender, MouseEventArgs e)
        {
            
        }
    }
}
