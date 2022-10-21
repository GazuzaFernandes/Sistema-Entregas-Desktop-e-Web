using DAL.Entities.Logistica;
using DAL.NHibertnate;


namespace DAL.Repository.Logistica
{
    public class DLDadosProposta : Repository<DadosProposta>
    {
        public List<PropostaViewModel> ListarPropostaStatus()
        {
            try
            {
                var lstProposta = new List<PropostaViewModel>();
                var listaProposta = new DLDadosProposta().Listar();
                var listaStatus = new DLStatusObra().Listar();
                var resultado = listaProposta
                   .Join(listaStatus, proposta => proposta.StatusObraId, statuss => statuss.StatusObraId, (proposta, stattuss) => new { proposta, stattuss })
                   .Select(x => new PropostaViewModel()
                   {
                       PropostaId = x.proposta.PropostaId,
                       DataPrevista = x.proposta.DataPrevista,
                       DataPedido = x.proposta.DataPedido,
                       Fabrica = x.proposta.Fabrica,
                       Faturado = x.proposta.Faturado,
                       FormaPag = x.proposta.FormaPag,
                       EngResp = x.proposta.EngResp,
                       Telefone = x.proposta.Telefone,
                       PdRb = x.proposta.PdRb,
                       PdVenda = x.proposta.PdVenda,
                       Proposta = x.proposta.Proposta,
                       Construtora = x.proposta.Construtora,
                       Obra = x.proposta.Obra,                  
                       DataEntrega = x.proposta.DataEntrega,
                       Status = x.stattuss.Descricao,
                       Material = x.proposta.Material,
                       RecebidoPor = x.proposta.RecebidoPor,
                       NotaFiscal = x.proposta.NotaFiscal,
                       Carreto = x.proposta.Carreto,
                   }).ToList();
                foreach (var proposta in resultado)
                {
                    switch (proposta.Status)
                    {
                        case "Imediato":
                            proposta.OrdenacaoStatus = 1;
                            break;

                        case "Pendente":
                            proposta.OrdenacaoStatus = 2;
                            break;

                        case "Finalizado":
                            proposta.OrdenacaoStatus = 3;
                            break;

                        case "Cancelado":
                            proposta.OrdenacaoStatus = 4;
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
        public class PropostaViewModel
        {
            public virtual int PropostaId { get; set; }
            public virtual DateTime DataPrevista { get; set; }
            public virtual DateTime DataPedido { get; set; }
            public virtual string? Fabrica { get; set; }
            public virtual string? Faturado { get; set; }
            public virtual string? FormaPag { get; set; }
            public virtual string? EngResp { get; set; }
            public virtual string? Telefone { get; set; }
            public virtual string? PdRb { get; set; }
            public virtual string? PdVenda { get; set; }
            public virtual string? Material { get; set; }
            public virtual string? Proposta { get; set; }
            public virtual string? Construtora { get; set; }
            public virtual string? Obra { get; set; }
            public virtual DateTime DataEntrega { get; set; }
            public virtual string? RecebidoPor { get; set; }
            public virtual string? NotaFiscal { get; set; }
            public virtual string? Carreto { get; set; }
            public int OrdenacaoStatus { get; set; }
            public string? Status { get; set; }
        }
        
    }

}
