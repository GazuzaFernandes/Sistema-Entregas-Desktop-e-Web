using Logistica.Sistema_de_Amostras;


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

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            switch(pesquisa = cbSelecionar.Text)
            {
                case "Amostra":
                    {

                    }
                    break;

                case "Engenharia":
                    {

                    }
                    break;

                case "Logistica":
                    {

                    }
                    break;

                case "Financeiro":
                    {

                    }
                    break;

                case "Orçamento":
                    {

                    }
                    break;
                case "Sergio":
                    {

                    }
                    break;

            }
        }
    }
}
