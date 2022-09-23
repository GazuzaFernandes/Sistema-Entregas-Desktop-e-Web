using Logistica.Sistema_de_Amostras;
using Logistica.Sistema_de_Logistica;
using Logistica.Sistema_do_Financeiro;
using Logistica.Sistema_do_Orçamento;
using Logistica.Sistema_do_Sergio;
using Logistica.Sistema_dos_Engenheiros;

namespace Logistica
{
    public partial class FrmEscolha : Form
    {
        static string pesquisar = "";

        public FrmEscolha()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(100);
            if (progressBar1.Value != 10)
            {    
                timer1.Start();
                labelProgressBar.Text = "Validando login.....";
            }
            if (progressBar1.Value != 35)
            {
                timer1.Start();
                labelProgressBar.Text = "Carregando Banco de dados.....";

            }
            if (progressBar1.Value != 80)
            {
                timer1.Start();
                labelProgressBar.Text = "Configurando Sistema.....";

            }
            if (progressBar1.Value != 90)
            {
                timer1.Start();
                labelProgressBar.Text = "Abrindo Sistema.....";
                timer1.Stop();
            }
        }
      
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            switch( pesquisar = cbSelecionar.Text)
            {
                case "Amostra":
                    {
                        timer1.Start();                        
                        FrmPrincipalAmostra amostra = new FrmPrincipalAmostra();
                        amostra.Show();
                        this.WindowState = FormWindowState.Minimized;
                    }
                    break;
                case "Engenharia":
                    {
                        FrmPrincipalEng eng = new FrmPrincipalEng();
                        eng.Show();
                        this.WindowState= FormWindowState.Minimized;
                    }break;
                case "Financeiro":
                    {
                        FrmPrincipalFinanceiro financeiro = new FrmPrincipalFinanceiro();
                        financeiro.Show();
                        this.WindowState = FormWindowState.Minimized;
                    }break;                 
                case "Logistica":
                    {
                        FrmPrincipalLogistica principal = new FrmPrincipalLogistica();
                        principal.Show();
                        this.WindowState = FormWindowState.Minimized;
                    }
                    break;
                case "Orçamento":
                    {
                        FrmOrcamentoPrincipal orca = new FrmOrcamentoPrincipal();
                        orca.Show();
                        this.WindowState = FormWindowState.Minimized;
                    }
                    break;
                case "Sergio":
                    {
                        FrmPrincipalSergio sergio = new FrmPrincipalSergio();
                        sergio.Show();
                        this.WindowState = FormWindowState.Minimized;
                    }break;
            }
        }

        private void FrmEscolha_Load(object sender, EventArgs e)
        {

        }
    }
}