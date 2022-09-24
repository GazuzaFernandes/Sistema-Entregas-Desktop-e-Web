using Logistica.Sistema_de_Amostras;
using Logistica.Sistema_de_Logistica;
using Logistica.Sistema_do_Financeiro;
using Logistica.Sistema_do_Orçamento;
using Logistica.Sistema_do_Sergio;
using Logistica.Sistema_dos_Engenheiros;

namespace Projeto
{
    public partial class FrmEscolha : Form
    { static public string pesquisa;
        public FrmEscolha()
        {
            InitializeComponent();
        }

        private void FrmEscolha_Load(object sender, EventArgs e)
        {
            BloquearBotao(true); 
        }

        private void BloquearBotao(bool habilitar)
        {
            cbSelecionar.Enabled = habilitar;
            btnEntrar.Enabled = habilitar;
        }      

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            switch(pesquisa = cbSelecionar.Text)
            {
                case "Amostra":
                    {
                        FrmPrincipalAmostra amostra = new FrmPrincipalAmostra();
                        amostra.Show();
                    }
                    break;

                case "Engenharia":
                    {
                        FrmPrincipalEng eng = new FrmPrincipalEng();
                        eng.Show();
                    }
                    break;

                case "Logistica":
                    {
                        FrmPrincipalLogistica logistica = new FrmPrincipalLogistica();
                        logistica.Show();
                    }
                    break;

                case "Financeiro":
                    {
                        FrmPrincipalFinanceiro fin = new FrmPrincipalFinanceiro();
                        fin.Show();
                    }
                    break;

                case "Orçamento":
                    {
                        FrmOrcamentoPrincipal orc = new FrmOrcamentoPrincipal();
                            orc.Show();
                    }
                    break;
                case "Sergio":
                    {
                        FrmPrincipalSergio sergio = new FrmPrincipalSergio();
                        sergio.Show();
                    }
                    break;
            }
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
