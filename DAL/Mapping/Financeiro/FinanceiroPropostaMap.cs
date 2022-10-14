using DAL.Entities;
using DAL.Entities.Financeiro;
using FluentNHibernate.Mapping;

namespace DAL.Mapping.Financeiro
{
    public class FinanceiroPropostaMap : ClassMap<FinanceiroProposta>
    {
        public FinanceiroPropostaMap()
        {
            Id(p => p.IdProp).GeneratedBy.Sequence("financeiroproposta_seq");
            Map(p => p.EmissaoNf);
            Map(p => p.VencimentoNf);
            Map(p => p.Cliente);           
            Map(p => p.Propostas);
            Map(p => p.NotaFiscal);
            Map(p => p.Obra);           
            Map(p => p.Comentario);
            Map(p => p.StatusObraId);       
            Table("financeiroproposta");
        }
    }
}
