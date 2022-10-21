using DAL.Entities.Engenharia;
using DAL.NHibertnate;
using DAL.Repository.Logistica;

namespace DAL.Repository.Engenharia
{
    public  class DLPropostaEngenharia : Repository<PropostaEngenharia>
    {
        public List<PropostaViewModel> ListarPropostaStatus()
        {
            try
            {
                var lstProposta = new List<PropostaViewModel>();
                var listaProposta = new DLPropostaEngenharia().Listar();
                var listaStatus = new DLStatusObra().Listar();
                var resultado = listaProposta
                   .Join(listaStatus, proposta => proposta.StatusObraId, statuss => statuss.StatusObraId, (proposta, stattuss) => new { proposta, stattuss })
                   .Select(x => new PropostaViewModel()
                   {
                       EngenhariaId = x.proposta.EngenhariaId,
                       Proposta = x.proposta.Proposta,
                       Cliente = x.proposta.Cliente,
                       Funcionario = x.proposta.Funcionario,
                       Responsavel = x.proposta.Responsavel,
                       Telefone = x.proposta.Telefone,
                       Obra = x.proposta.Obra,                   
                       Status = x.stattuss.Descricao,                      
                       DataInclusao = x.proposta.DataInclusao,
                   }).ToList();
                foreach (var proposta in resultado)
                {
                    switch (proposta.Status)
                    {
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
            public virtual int EngenhariaId { get; set; }
            public virtual string? Proposta { get; set; }
            public virtual string? Cliente { get; set; }
            public virtual string? Funcionario { get; set; }
            public virtual string? Responsavel { get; set; }
            public virtual string? Telefone { get; set; }
            public virtual string? Obra { get; set; }
            public virtual int StatusObraId { get; set; }
            public virtual DateTime DataInclusao { get; set; }
            public int OrdenacaoStatus { get; set; }
            public string? Status { get; set; }
        }

    }
}
