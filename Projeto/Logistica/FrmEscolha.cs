using Logistica.Sistema_de_Amostras;


namespace Projeto
{
    public partial class FrmEscolha : Form
    {
        public FrmEscolha()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmPrincipalAmostra amostra = new FrmPrincipalAmostra();
                amostra.Show();
        }

        private void FrmEscolha_Load(object sender, EventArgs e)
        {

        }
    }
}
