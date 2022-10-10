using DAL.Entities.Financeiro;
using DAL.NHibertnate;

namespace DAL.Repository.Financeiro
{
    public class DLFinanceiroProposta : Repository<FinanceiroProposta>
    {
        public List<PropostaViewModel> ListarPropostaStatus()
        {
            try
            {
                var lstProposta = new List<PropostaViewModel>();
                var listaProposta = new DLFinanceiroProposta().Listar();
                var listaStatus = new DLStatusobra().Listar();

                var resultado = listaProposta
                   .Join(listaStatus, proposta => proposta.StatusObraId, statuss => statuss.StatusObraId, (proposta, stattuss) => new { proposta, stattuss })
                   .Select(x => new PropostaViewModel()
                   {
                       IdProp = x.proposta.IdProp,
                       EmissaoNf = x.proposta.EmissaoNf,
                       VencimentoNf = x.proposta.VencimentoNf,
                       Cliente = x.proposta.Cliente,                       
                       Propostas = x.proposta.Proposta,
                       Notafiscal = x.proposta.NotaFiscal,
                       Obra = x.proposta.Obra,                      
                       Cometario = x.proposta.Comentario,
                       Status = x.stattuss.Descricao,                     

                   }).ToList();

                foreach (var proposta in resultado)
                {
                    switch (proposta.Status)
                    {
                        case "RbEngenharia":
                            proposta.OrdenacaoStatus = 1;
                            break;
                        case "RbComercio":
                            proposta.OrdenacaoStatus = 2;
                            break;
                        case "RbPisos":
                            proposta.OrdenacaoStatus = 3;
                            break;

                    }
                    lstProposta.Add(proposta);
                }
                return lstProposta.OrderByDescending(p => p.Status).ToList();
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
    public class PropostaViewModel
    {
        public virtual int IdProp { get; set; }
        public virtual DateTime EmissaoNf { get; set; }
        public virtual DateTime VencimentoNf { get; set; }
        public virtual string? Cliente { get; set; }        
        public virtual string? Propostas { get; set; }
        public virtual string? Notafiscal { get; set; }
        public virtual string? Obra { get; set; }
        public virtual string? Cometario { get; set; }
        public virtual int StatusobraId { get; set; }
        public virtual int StatusObra { get; set; }
        public int OrdenacaoStatus { get; set; }
        public string? Status { get; set; }
    }
}
