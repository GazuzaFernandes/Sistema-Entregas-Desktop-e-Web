using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Logistica.BackupAutomatico.SystemRetaguarda;

namespace Projeto.Backup
{
    public class Backup
    {
        public class Systembackup
        {
            public static void Restauracao()
            {
                try
                {
                    FunctionsDataBase.BackupDatabase(
                                                    "localhost",
                                                    "5432",
                                                    "postgres",
                                                    "q1s2e3f4t5",
                                                    "RbDesktop",
                                                 $@"F:\_LOGISTICA\Restaurar\Rb\{DateTime.Now.ToShortDateString().Replace(":", "").Replace("/", "_").Replace(" ", "")}\",
                                                   @"RbDesktop");
                    Application.Exit();


                }
                catch (Exception ex)
                {
                    throw new Exception("Um erro desconhecido ocorreu ao tentar executar a operação de restauração do banco de dados.", ex);
                }
            }
        }
    }
}
