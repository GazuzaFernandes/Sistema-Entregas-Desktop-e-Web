using DAL.Entities.Financeiro;
using DAL.NHibertnate;

namespace DAL.Repository.Financeiro
{
    public class DLFinanceiroProposta : Repository<FinanceiroProposta>
    {
        public List<FinanceiroPropostaViewModel> ListarFinanceiroStatus()
        {
            try
            {
                var lstFinanceiroProposta = new List<FinanceiroPropostaViewModel>();
                var listaFinanceiroProposta = new DLFinanceiroProposta().Listar();
                var listaStatus = new DLStatusobra().Listar();
                var resultado = listaFinanceiroProposta
                   .Join(listaStatus, financeiro => financeiro.StatusObraId, statuss => statuss.StatusObraId, (financeiro, stattuss) => new { financeiro, stattuss })
                   .Select(x => new FinanceiroPropostaViewModel()
                   {
                       IdProp = x.financeiro.IdProp,
                       EmissaoNf = x.financeiro.EmissaoNf,
                       VencimentoNf = x.financeiro.VencimentoNf,
                       Cliente = x.financeiro.Cliente,                       
                       Propostas = x.financeiro.Propostas,
                       NotaFiscal = x.financeiro.NotaFiscal,
                       Obra = x.financeiro.Obra,                      
                       Cometario = x.financeiro.Comentario,
                       Status = x.stattuss.Descricao,                     

                   }).ToList();

                foreach (var fproposta in resultado)
                {
                    switch (fproposta.Status)
                    {
                        case "RbEngenharia":
                            fproposta.OrdenacaoStatus = 5;
                            break;
                        case "RbComercio":
                            fproposta.OrdenacaoStatus = 6;
                            break;
                        case "RbPisos":
                            fproposta.OrdenacaoStatus = 7;
                            break;
                    }
                    lstFinanceiroProposta.Add(fproposta);
                }
                return lstFinanceiroProposta.OrderByDescending(p => p.Status).ToList();
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
    public class FinanceiroPropostaViewModel
    {
        public virtual int IdProp { get; set; }
        public virtual DateTime EmissaoNf { get; set; }
        public virtual DateTime VencimentoNf { get; set; }
        public virtual string? Cliente { get; set; }        
        public virtual string? Propostas { get; set; }
        public virtual string? NotaFiscal { get; set; }
        public virtual string? Obra { get; set; }
        public virtual string? Cometario { get; set; }
        public virtual int StatusobraId { get; set; }
        public virtual int StatusObra { get; set; }
        public int OrdenacaoStatus { get; set; }
        public string? Status { get; set; }
    }
}
