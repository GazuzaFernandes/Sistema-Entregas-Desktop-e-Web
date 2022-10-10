using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto.Logistica.Sistema_de_Logistica
{
    public partial class FrmImpressaoProposta : Form
    {
        public FrmImpressaoProposta()
        {
            InitializeComponent();
        }
        #region Utilizando comandos para impressão
        /*
        PageSetupDialog – Este controle representa uma caixa de dialogo na qual o usuário pode definir 
        propriedades do documento a ser impresso tais como tamanho do papel, tipo de papel, margens etc.

        PrintDialog – Este controle representa uma caixa de dialogo na qual permite o usuário definir 
        a impressora na qual quer imprimir a página, bem como outras configurações.

        PrintDocument – Este representa o documento a ser impresso, tratasse do controle chave para o processo de impressão.

        PrintPreviewDialog – Este controle representa uma caixa de dialogo na qual o documento pode ser visualizado.
        
        PrintPreviewControl – Este representa um contêiner de visualização de documentos,
        permitindo ao desenvolvedor personalizar a forma de visualização do documento.

        Para realizar qualquer impressão é necessário entender o funcionamento do  controle PrintDocument.
        Este controle possui os seguintes eventos.

        BeginPrint – Este evento é ativado uma única vez quando o processo de impressão inicia.

        EndPrint – Este evento é ativado uma única vez quando a impressão é finalizada. 
        Isto é, quando não existe mais documento a ser impresso.

        QueryPageSettings – Este evento é disparado logo antes do evento PrintPage. 
        Neste evento é possível fazer alterações na configuração de uma pagina particular.

        PrintPage – Este evento é disparado para toda pagina a ser impressa. 
        Na assinatura deste evento é passado como parâmetro um objeto da classe PrintPageEventArgs, 
        este objeto tem uma propriedade denominada  hasmorepage. Esta propriedade recebe um valor verdadeiro 
        ou falso na qual o se pode definir a continuidade da impressão.

        O objeto da classe PrintPageEventArgs possui também uma propriedade Graphics que retorna um 
        objecto da classe Graphics, esta propriedade permiti efetivamente que seja desenhado o conteúdo do 
        documento a ser impresso. A classe Graphis possui metodos para desenhar linhas, texto, curvas etc. A classe  
        */
        #endregion
        private void FrmImpressaoProposta_Load(object sender, EventArgs e)
        {

        }
    }
}
