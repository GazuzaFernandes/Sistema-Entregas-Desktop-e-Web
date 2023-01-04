using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistica.Backup
{
   public class CriacaoLicensa
    {
       // #region Codigo de Licenças
       // public static void WriteRegisterSystem(string companyName, string cnpj, TipoLicenca tipoLicenca, int prazoLicenca = 0)
       // {
       //     try
       //     {
       //         cnpj = Formatacao.FormatarCpfCnpj(cnpj);

       //         if (tipoLicenca == TipoLicenca.Determined && prazoLicenca == 0)
       //         {
       //             Mensagem.Alert("Para licença de prazo determinado, é necessário informar o prazo de validade da licença!");
       //             return;
       //         }

       //         string serialNumberMotherBoard = String.Empty;
       //         string idComputador = String.Empty;

       //         Try get motherboard's serial number 
       //         try
       //         {
       //             using (ManagementObjectSearcher mbs = new ManagementObjectSearcher("Select * From Win32_BaseBoard"))
       //             {
       //                 foreach (ManagementObject mo in mbs.Get())
       //                     serialNumberMotherBoard += mo["SerialNumber"].ToString();
       //             }
       //         }
       //         catch (Exception exMB)
       //         {
       //             throw new Exception("Erro ao ler número de série da placa mãe", exMB);
       //         }


       //         Try get Id Computer
       //         try
       //         {
       //             using (RegistryKey rk = Registry.CurrentUser.OpenSubKey("WinSystem", true))
       //             {
       //                 idComputador = rk.GetValue("IdComputador").ToString();
       //                 rk.Close();
       //             }
       //         }
       //         catch (Exception exIDPC)
       //         {
       //             throw new Exception("Erro ao capturar ID Computador!", exIDPC);
       //         }


       //         var licenca = "";
       //         switch (tipoLicenca)
       //         {
       //             case TipoLicenca.Full:
       //                 licenca = "FULL";
       //                 break;
       //             case TipoLicenca.Trial30:
       //                 licenca = "TRIAL_30_DAYS";
       //                 break;
       //             case TipoLicenca.Determined:
       //                 licenca = $"DETERMINED_{ prazoLicenca.ToString() }_DAYS";
       //                 break;
       //         }

       //         var data = DateTime.Now.ToShortDateString();
       //         var tipoLicencaCriptografada = LibrarySystem.Encripta(licenca);//Criptografa o Tipo de licença
       //         var idComputadorCriptografada = LibrarySystem.Encripta(idComputador); //Criptografa a data da instalação
       //         var empresaCriptografada = LibrarySystem.Encripta(companyName);//Criptografa a empresa
       //         var dataInstalacaoCriptografada = LibrarySystem.Encripta(data); //Criptografa a data da instalação
       //         var nrSerieMotherBoardCriptografada = LibrarySystem.Encripta(serialNumberMotherBoard); //Criptografa o núemro de série da placa mãe
       //         var cnpjCriptografado = LibrarySystem.Encripta(cnpj);

       //         try
       //         {
       //             RegistryKey rk = Registry.CurrentUser.OpenSubKey("Software", true);
       //             rk = rk.CreateSubKey("AMS");

       //             rk.SetValue("dtitcstm", dataInstalacaoCriptografada);//dtitcstm : Data Instalação Sistema
       //             rk.SetValue("idcptd", idComputadorCriptografada);//idcptd : Id Computador
       //             rk.SetValue("nsmb", nrSerieMotherBoardCriptografada);//nsmb : Número de série da placa mãe
       //             rk.SetValue("emp", empresaCriptografada);//emp : Pessoa
       //             rk.SetValue("tplcc", tipoLicencaCriptografada);//tplcc : Tipo Licemça (FULL, TRIAL 30 Dias, ou DETERMINADA X DIAS)
       //             rk.SetValue("ce", cnpjCriptografado);//ce: CNPJ Criptografado
       //             rk.Close();
       //             rk.Dispose();
       //             ValidarLicenca();
       //         }
       //         catch (Exception exGD)
       //         {
       //             throw new Exception("Erro ao registrar os dados do sistema!", exGD);
       //         }

       //     }
       //     catch (Exception ex)
       //     {
       //         throw new Exception("Erro ao gravar registro do sistema!", ex);
       //     }
       // }
       // public static bool ValidateLicense()
       // {
       //     return true;
       // }
       // public static Dictionary<string, string> ReadRegistrySystem()
       // {

       //     Dictionary<string, string> registros = new Dictionary<string, string>();
       //     try
       //     {
       //         cria uma referêcnia para a chave de registro Software
       //        RegistryKey rk = Registry.CurrentUser.OpenSubKey("Software", true);

       //         var ams = rk.OpenSubKey("AMS", true);

       //         if (ams == null)
       //             throw new Exception("Sistema não licenciado!\n\nEntre em contato com a AG Técnica Sistemas.");

       //         realiza a leitura do registro
       //        var cnpj = LibrarySystem.Desencripta(rk.OpenSubKey("AMS", true).GetValue("ce").ToString());//ce: CNPJ Criptografado
       //         var empresa = LibrarySystem.Desencripta(rk.OpenSubKey("AMS", true).GetValue("emp").ToString());//emp : Pessoa
       //         var licenca = LibrarySystem.Desencripta(rk.OpenSubKey("AMS", true).GetValue("tplcc").ToString());//tplcc : Tipo Licemça (FULL, TRIAL 30 Dias, ou DETERMINADA X DIAS)

       //         var dataInstalacao = LibrarySystem.Desencripta(rk.OpenSubKey("AMS", true).GetValue("dtitcstm").ToString());//dtitcstm : Data Instalação Sistema
       //         var idComputador = LibrarySystem.Desencripta(rk.OpenSubKey("AMS", true).GetValue("idcptd").ToString());//idcptd : Id Computador
       //         var nrSerieMotherBoard = LibrarySystem.Desencripta(rk.OpenSubKey("AMS", true).GetValue("nsmb").ToString());//nsmb : Número de série da placa mãe

       //         var lic = licenca.Split('_');
       //         var tipoLicenca = lic[0];
       //         var prazoLicenca = "";

       //         if (tipoLicenca != "FULL")
       //             prazoLicenca = lic[1];

       //         registros = new Dictionary<string, string>
       // {
       //     { "dataInstalacaoCriptografada", dataInstalacao },
       //     { "idComputador", idComputador },
       //     { "nrSerieMotherBoardCriptografada", nrSerieMotherBoard },
       //     { "empresa", empresa },
       //     { "tipoLicenca", tipoLicenca },
       //     { "prazoLicenca", prazoLicenca },
       //     { "cnpj", cnpj }
       // };
       //     }
       //     catch (Exception ex)
       //     {
       //         throw new Exception("Erro na leitura do registro do sistema!", ex);
       //     }
       //     return registros;
       // }
       // <summary>
       // Atualiza os dados da licença, exceto Data da Instalação.Insere data de atualizaç~~
       //</summary>
       // <param name = "empresa" ></ param >
       // / < param name="cnpj"></param>
       // / <param name = "tipoLicenca" ></ param >
       // / < param name="prazoLicenca"></param>
       // public static List<string> ConsultFileLicense(string arquivo)
       // {
       //     int counter = 0;
       //     string line;
       //     var registros = new List<string>();

       //     try
       //     {
       //         using (TextReader file = new StreamReader(arquivo))
       //         {
       //             while ((line = file.ReadLine()) != null)
       //             {
       //                 registros.Add(line);
       //                 counter++;
       //             }
       //         }
       //     }
       //     catch (Exception ex)
       //     {
       //         throw ex;
       //     }
       //     return registros;
       // }
       // public static bool ValidarLicenca()
       // {
       //     DateTime DataInstalacao = DateTime.MinValue;
       //     String NumeroSerieMB = null;
       //     String IdComputador = null;
       //     String Pessoa = null;
       //     String TipoLicenca = null;
       //     String Cnpj = null;
       //     int PrazoLicenca = 0;
       //     string arquivo = null;

       //     var dlConfig = new DLConfiguracaoGeral();

       //     try
       //     {
       //         var registro = Sistema.LerRegistroSistema();


       //         foreach (var item in registro)
       //         {
       //             switch (item.Key)
       //             {
       //                 case "dataInstalacaoCriptografada":
       //                     DateTime.TryParse(item.Value.ToString(), out DataInstalacao); break;
       //                 case "idComputador":
       //                     IdComputador = item.Value.ToString(); break;
       //                 case "nrSerieMotherBoardCriptografada":
       //                     NumeroSerieMB = item.Value.ToString(); break;
       //                 case "empresa":
       //                     Pessoa = item.Value.ToString(); break;
       //                 case "tipoLicenca":
       //                     TipoLicenca = item.Value.ToString(); break;
       //                 case "cnpj":
       //                     Cnpj = item.Value.ToString(); break;
       //                 case "prazoLicenca":
       //                     {
       //                         if (TipoLicenca != "FULL")
       //                             PrazoLicenca = Convert.ToInt32(item.Value);
       //                     }
       //                     break;
       //             }
       //         }
       //         int PrazoValidadeMes = 0;

       //         if ((PrazoLicenca % 30) == 0)
       //             PrazoValidadeMes = PrazoLicenca / 30;

       //         DateTime dataExpiracaoLIcenca;

       //         if (PrazoValidadeMes > 0)
       //         {
       //             if (DataInstalacao.AddMonths(PrazoValidadeMes) < DateTime.Now.Date)
       //             {
       //                 Mensagem.Alert("Sua licença expirou!\n\nContate a AG Técnica para regularizar a situação ou importe uma nova licença.");

       //                 if (Mensagem.Alert("Deseja importar uma nova licença?", "AMS", "", MessageIcon.Question, MessageButton.YesNo) == System.Windows.Forms.DialogResult.Yes)
       //                 {
       //                     ImportarLicenca(ref arquivo);
       //                     if (arquivo.Substring(arquivo.Length - 4, 4) != ".eal")
       //                         return false;
       //                 }

       //                 return false;
       //             }
       //             if (DataInstalacao.AddMonths(PrazoValidadeMes) == DateTime.Now.Date && TipoLicenca != "FULL")
       //                 Mensagem.Alert("Sua licença expira hoje. Contate a AG Técnica para regularizar a situação");

       //             if ((DataInstalacao.AddMonths(PrazoLicenca) == DateTime.Now.Date.AddDays(1)) && TipoLicenca != "FULL")
       //                 Mensagem.Alert("Sua licença expira amanhã. Contate a AG Técnica para regularizar a situação");

       //             if ((DataInstalacao.AddMonths(PrazoLicenca) == DateTime.Now.Date.AddDays(2)) && TipoLicenca != "FULL")
       //                 Mensagem.Alert("Sua licença expira daqui 2 dias. Contate a AG Técnica para regularizar a situação");

       //             if ((DataInstalacao.AddMonths(PrazoLicenca) == DateTime.Now.Date.AddDays(5)) && TipoLicenca != "FULL")
       //                 Mensagem.Alert("Sua licença expira daqui 5 dias. Contate a AG Técnica para regularizar a situação");

       //             if (TipoLicenca == "FULL")
       //                 dataExpiracaoLIcenca = DateTime.MaxValue;
       //             else
       //                 dataExpiracaoLIcenca = DataInstalacao.AddMonths(PrazoValidadeMes);
       //         }
       //         else
       //         {
       //             if (DataInstalacao.AddDays(PrazoLicenca) < DateTime.Now.Date)
       //             {
       //                 Mensagem.Alert("Licença expirada. Contate a AG Técnica para regularizar a situação");

       //                 if (Mensagem.Alert("Deseja importar uma nova licença?", "AMS", "", MessageIcon.Question, MessageButton.YesNo) == System.Windows.Forms.DialogResult.Yes)
       //                 {
       //                     System.Windows.Forms.OpenFileDialog dlg = new System.Windows.Forms.OpenFileDialog();
       //                     dlg.DefaultExt = ".eal";

       //                     var result = dlg.ShowDialog();
       //                     if (result == DialogResult.OK)
       //                     {
       //                         arquivo = dlg.FileName;
       //                         var licenca = Sistema.ConsultarArquivoLicenca(arquivo);
       //                         var cnpjLicenca = licenca[2];
       //                     }
       //                 }
       //                 return false;
       //             }

       //             if (DataInstalacao.AddDays(PrazoLicenca) == DateTime.Now.Date && TipoLicenca != "FULL")
       //                 Mensagem.Alert("Sua licença expira hoje. Contate a AG Técnica para regularizar a situação");

       //             if ((DataInstalacao.AddDays(PrazoLicenca) == DateTime.Now.Date.AddDays(1)) && TipoLicenca != "FULL")
       //                 Mensagem.Alert("Sua licença expira amanhã. Contate a AG Técnica para regularizar a situação");

       //             if ((DataInstalacao.AddDays(PrazoLicenca) == DateTime.Now.Date.AddDays(2)) && TipoLicenca != "FULL")
       //                 Mensagem.Alert("Sua licença expira daqui 2 dias. Contate a AG Técnica para regularizar a situação");

       //             if ((DataInstalacao.AddDays(PrazoLicenca) == DateTime.Now.Date.AddDays(5)) && TipoLicenca != "FULL")
       //                 Mensagem.Alert("Sua licença expira daqui 5 dias. Contate a AG Técnica para regularizar a situação");

       //             if (TipoLicenca == "FULL")
       //                 dataExpiracaoLIcenca = DateTime.MaxValue;
       //             else
       //                 dataExpiracaoLIcenca = DataInstalacao.AddDays(PrazoLicenca);
       //         }

       //         var config = dlConfig.Listar().SingleOrDefault();

       //         config.DataExpiracaoLicenca = dataExpiracaoLIcenca;
       //         config.ComputadorId = IdComputador;
       //         config.NumeroSeriePlacaMae = NumeroSerieMB;
       //         config.LicencaNome = TipoLicenca;

       //         dlConfig.Atualizar(config);


       //         Sessao.Instance.Configuracao.LicencaNome = TipoLicenca;
       //         Sessao.Instance.Configuracao.DataExpiracaoLicenca = dataExpiracaoLIcenca;
       //         Sessao.Instance.Configuracao.ComputadorId = IdComputador;
       //     }
       //     catch (Exception ex)
       //     {
       //         throw ex;
       //     }
       //     finally
       //     {
       //         dlConfig = null;
       //     }
       //     return true;
       // }
       // public static void ImportLicense(ref string arquivo)
       // {
       //     try
       //     {
       //         OpenFileDialog dlg = new OpenFileDialog();

       //         dlg.DefaultExt = ".eal";
       //         var result = dlg.ShowDialog();

       //         if (result == DialogResult.OK)
       //         {
       //             arquivo = dlg.FileName;
       //             bool importarLicenca = true;

       //             while (importarLicenca)
       //             {
       //                 if (arquivo.Substring(arquivo.Length - 4, 4) != ".eal")
       //                 {
       //                     Mensagem.Alert("Licença inválida!");

       //                     if (Mensagem.Alert("Deseja importar novamente?", "AMS", MessageIcon.Question, MessageButton.YesNo) == DialogResult.Yes)
       //                     {
       //                         result = dlg.ShowDialog();
       //                         arquivo = dlg.FileName;
       //                     }
       //                     else
       //                     {
       //                         importarLicenca = false;
       //                         return;
       //                     }
       //                 }
       //                 else
       //                 {
       //                     importarLicenca = false;
       //                 }
       //             }

       //             var licenca = SystemConfiguration.ConsultFileLicense(arquivo);
       //             var cnpjLicenca = LibrarySystem.Desencripta(licenca[0]);
       //             var empresaLicenca = LibrarySystem.Desencripta(licenca[1]);
       //             var tipoLicenca = LibrarySystem.Desencripta(licenca[2]);

       //             var prazoLicenca = 0;

       //             if (tipoLicenca.Equals("FULL"))
       //             {
       //                 SystemConfiguration.WriteRegisterSystem(empresaLicenca, cnpjLicenca, Enums.TipoLicenca.Full);
       //             }
       //             else if (tipoLicenca.Contains("TRIAL"))
       //             {
       //                 SystemConfiguration.WriteRegisterSystem(empresaLicenca, cnpjLicenca, Enums.TipoLicenca.Trial30, 30);
       //             }
       //             else if (tipoLicenca.Contains("DETERMINED"))
       //             {
       //                 var lic = tipoLicenca.Split('_');
       //                 var prazo = lic[1].Trim();

       //                 int.TryParse(prazo, out prazoLicenca);

       //                 SystemConfiguration.WriteRegisterSystem(empresaLicenca, cnpjLicenca, Enums.TipoLicenca.Determined, prazoLicenca);
       //             }

       //             Mensagem.Alert("Licença atualizada com sucesso!", "AMS", MessageIcon.Information, MessageButton.OK);
       //         }
       //     }
       //     catch (Exception ex)
       //     {
       //         throw ex;
       //     }
       // }
       // [DllImport("wininet.dll")]
       // private extern static Boolean InternetGetConnectedState(out int Description, int ReservedValue);
       // public static Boolean IsConnected()
       // {
       //     int Description;

       //     return InternetGetConnectedState(out Description, 0);
       // }

       // / <summary>
       // / Retorna uma instância de um serviço inicializado na classe program.cs
       // / Exemplo de uso: var systemService = Sistema.GetServices<SystemService>(typeof(ISystemService));
       // / </summary>
       // / <typeparam name = "T" ></ typeparam >
       // / < param name="tipo"></param>
       // / <returns></returns>
       // public static T GetServices<T>(Type tipo)
       // {
       //     return (T)Sessao.Instance.ServiceCollection.GetService(tipo);
       // }
       // public static string GetPathPostgreSQL()
       // {
       //     return "C:\\Program Files\\PostgreSQL\\14\\bin\\";
       // }
       // #endregion
    }
}
