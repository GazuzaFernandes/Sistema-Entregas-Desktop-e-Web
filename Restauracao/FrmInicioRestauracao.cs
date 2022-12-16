using Projeto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restauracao
{
    public partial class FrmInicioRestauracao : Form
    {
        public FrmInicioRestauracao()
        {
            InitializeComponent();
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
                    lblMessageLoad.Text = "Criando serviços...";
                    Application.DoEvents();
                    timer1.Start();
                }

                if (progressBar1.Value == 40)
                {
                    timer1.Stop();

                    lblMessageLoad.Text = "Criando banco de dados...";
                    Application.DoEvents();
                    timer1.Start();
                }

                if (progressBar1.Value == 55)
                {
                    timer1.Stop();

                    lblMessageLoad.Text = "Criando a licença do sistema...";
                    Application.DoEvents();
                    timer1.Start();
                }

                if (progressBar1.Value == 65)
                {
                    timer1.Stop();

                    lblMessageLoad.Text = "Criando permissões...";
                    Application.DoEvents();
                    Thread.Sleep(1500);

                    timer1.Start();
                }

                if (progressBar1.Value == 75)
                {
                    timer1.Stop();
                    lblMessageLoad.Text = "Criando Tabelas...";

                    for (int i = 90; i < 99; i++)
                        progressBar1.Value = i;
                    timer1.Start();
                }

                if (progressBar1.Value == 100)
                {
                  
                    Application.DoEvents();

                    timer1.Stop();
                    MessageBox.Show("Restauração criada com Sucesso");
                    Application.Exit();
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
