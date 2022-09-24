using Logistica.Sistema_de_Amostras;
using Logistica.Sistema_de_Logistica;
using Logistica.Sistema_do_Financeiro;
using Logistica.Sistema_do_Orçamento;
using Logistica.Sistema_do_Sergio;
using Logistica.Sistema_dos_Engenheiros;

namespace Projeto
{
    public partial class FrmEscolha : Form
    {
        static public string pesquisa;
        public FrmEscolha()
        {
            InitializeComponent();
        }

        private void FrmEscolha_Load(object sender, EventArgs e)
        {
            BloquearBotao(false);
        }

        private void BloquearBotao(bool habilitar)
        {
            cbSelecionar.Enabled = habilitar;
            btnEntrar.Enabled = habilitar;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            switch (pesquisa = cbSelecionar.Text)
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

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            try
            {
                progressBar1.Increment(1);

                if (progressBar1.Value == 10)
                {
                    timer1.Stop();
                    lblMessageLoad.Text = "Pegando informações...";
                    timer1.Start();
                }

                if (progressBar1.Value == 25)
                {
                    timer1.Stop();
                    lblMessageLoad.Text = "Validando serviços...";
                    Application.DoEvents();
                    timer1.Start();
                }

                if (progressBar1.Value == 40)
                {
                    timer1.Stop();

                    lblMessageLoad.Text = "Validando banco de dados...";
                    Application.DoEvents();
                    timer1.Start();
                }

                if (progressBar1.Value == 55)
                {
                    timer1.Stop();

                    lblMessageLoad.Text = "Validando a licença do sistema...";
                    Application.DoEvents();
                    timer1.Start();
                }

                if (progressBar1.Value == 65)
                {
                    timer1.Stop();

                    lblMessageLoad.Text = "Validando permissões...";
                    Application.DoEvents();
                    Thread.Sleep(1500);

                    timer1.Start();
                }

                if (progressBar1.Value == 75)
                {
                    timer1.Stop();
                    lblMessageLoad.Text = "Carregando Tabelas...";

                    for (int i = 90; i < 99; i++)
                        progressBar1.Value = i;
                    timer1.Start();
                }

                if (progressBar1.Value == 100)
                {
                    lblMessageLoad.Text = "Sistema liberado para uso...";
                    Application.DoEvents();

                    timer1.Stop();
                    BloquearBotao(true);
                }
            }
            catch (Exception ex)
            {
                timer1.Stop();
                Application.Exit();
            }

        }
    }
}
