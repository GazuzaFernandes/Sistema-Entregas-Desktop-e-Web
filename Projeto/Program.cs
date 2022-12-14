using Logistica.Sistema_do_Orçamento;
using Projeto.Logistica.Sistema_de_Logistica;
using Projeto.Logistica.Sistema_do_Financeiro;
using Projeto.Logistica.Telas_Avulso;

namespace Projeto
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmInicialização());
        }
    }
}