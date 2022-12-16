using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto.Logistica.Telas_Avulso
{
    public partial class FrmInicialização : Form
    {
        public FrmInicialização()
        {
            InitializeComponent();
        }

        private void lblMessageLoad_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                progressBar1.Increment(1);

                if (progressBar1.Value == 10)
                {
                    timer1.Stop();
                    lblMessageLoad.Text = "Obtendo informações...";
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
                    FrmEscolha escolha = new FrmEscolha();
                    escolha.Show();
                    Hide();
                }
            }
            catch (Exception ex)
            {
                timer1.Stop();
                Application.Exit();
            }
        }

        private void FrmInicialização_Load(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
