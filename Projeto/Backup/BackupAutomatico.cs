using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Logistica
{
    public class BackupAutomatico
    {
        public class SystemRetaguarda
        {
            private static string pastaBinPostgres = @"C:\Program Files\PostgreSQL\15\bin";
            public static string GetPathApplicationConfiguration()
            {
                var path = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory.Replace("bin\\Debug\\", "Settings\\").Replace("bin\\Release\\", "Settings\\"));
                path = path.Replace("net5.0-windows", "");
               
                return path;
            }
            public static string GetFileNameConfiguration()
            {
                return @"settings.txt";
            }
            public class FunctionsDataBase
            {
                public static string BackupDatabase(
                    string endereco_servidor,
                    string port,
                    string user,
                    string password,
                    string nome_banco_dados,
                    string pasta_salvamentto_arquivo_backup,
                    string backupFileName)
                {
                    if (string.IsNullOrEmpty(endereco_servidor))
                        return string.Empty;

                    try
                    {
                        Environment.SetEnvironmentVariable("PGPASSWORD", password);

                        if (!pasta_salvamentto_arquivo_backup.EndsWith("\\"))

                            pasta_salvamentto_arquivo_backup = pasta_salvamentto_arquivo_backup + "\\";

                        if (!Directory.Exists(pasta_salvamentto_arquivo_backup))

                            Directory.CreateDirectory(pasta_salvamentto_arquivo_backup);

                        string backupFile = pasta_salvamentto_arquivo_backup + backupFileName 
                            + "_" + DateTime.Now.ToString().Replace(":", "_").Replace("/", "_").Replace(" ", "_") + ".rar";

                        string BackupString = $" --file={ backupFile} " +
                            $"--format=tar --host={ endereco_servidor } --username={ user } --port={ port } --dbname={ nome_banco_dados } -b --encoding utf8";

                        Process proc = new System.Diagnostics.Process();

                        proc.StartInfo.FileName = pastaBinPostgres + "\\pg_dump.exe";
                        //PASTA BIN DO POSTGRESQL*************-C:\Program Files\PostgreSQL\15\bin
                        proc.StartInfo.Arguments = BackupString;
                        proc.StartInfo.RedirectStandardOutput = true;//for error checks BackupString
                        proc.StartInfo.RedirectStandardError = true;
                        proc.StartInfo.UseShellExecute = false;//use for not opening cmd screen
                        proc.StartInfo.CreateNoWindow = true;//use for not opening cmd screen

                        proc.Start();
                        proc.WaitForExit();
                        proc.Close();

                        return backupFile;

                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Um erro desconhecido ocorreu ao tentar executar a operação de backup do banco de dados.", ex);
                    }
                }
                public static string RestoreDatabase(
                            string host,
                            string port,
                            string user,
                            string password,
                            string database,
                            string backupFileName)
                {
                    try
                    {
                        string Set = RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? "set " : "export ";

                        Environment.SetEnvironmentVariable("PGPASSWORD", password);

                        string dumpCommand = $"{Set}PGPASSWORD={password}\n" +
                                       //mata as conexoes abertas
                                       $"psql -h {host} -p {port} -U {user} -d {database} -c \"select pg_terminate_backend(pid) from pg_stat_activity where datname = '{database}'\"\n" +
                                       //exclui o blanco
                                       $"dropdb -h { host } -p " + port + " -U " + user + $" {database}\n" +
                                       //criar um novo banco vazio
                                       $"createdb -h " + host + " -p " + port + " -U " + user + $" {database}\n" +
                                       //restaura o banco através de um arquivo de backup
                                       "pg_restore -h " + host + " -p " + port + " -d " + database + " -U " + user + "";

                        //psql command disconnect database
                        //dropdb and createdb  remove database and create.
                        //pg_restore restore database with file create with pg_dump command
                        dumpCommand = $"{dumpCommand} {backupFileName}";

                        Execute(dumpCommand);

                        return backupFileName;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Um erro desconhecido ocorreu ao tentar executar a operação de restauração do banco de dados.", ex);
                    }
                }
            }
            private static void Execute(string dumpCommand)
            {
                Task.Run(() =>
                {

                    //string batFilePath = Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}." + (RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? "bat" : "sh"));
                    string batFilePath = Path.Combine(pastaBinPostgres, $"{Guid.NewGuid()}." + (RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? "bat" : "sh"));
                    try
                    {
                        string batchContent = "";
                        batchContent += $"{dumpCommand}";
                        File.WriteAllText(batFilePath, batchContent, Encoding.ASCII);
                        ProcessStartInfo info = ProcessInfoByOS(batFilePath);
                        using (System.Diagnostics.Process proc = System.Diagnostics.Process.Start(info))
                        {
                            proc.WaitForExit();
                            var exit = proc.ExitCode;
                            //... ommit error handler code ...
                            proc.Close();
                        }
                    }
                    catch (Exception e)
                    {
                        // Your exception handler here.
                    }
                    finally
                    {
                        if (File.Exists(batFilePath)) File.Delete(batFilePath);
                    }
                });
            }
            private static ProcessStartInfo ProcessInfoByOS(string batFilePath)
            {
                ProcessStartInfo info;
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    info = new ProcessStartInfo(batFilePath) { };
                }
                else
                {
                    info = new ProcessStartInfo("sh") { Arguments = $"{batFilePath}" };
                }

                info.CreateNoWindow = true;//true para nao abrir CMD- ficar em segundo plano
                info.UseShellExecute = false;
                info.WorkingDirectory = @"C:\Program Files\PostgreSQL\15\bin\";
                info.RedirectStandardError = true;
                return info;
            }

        
           
        }
    }
}



