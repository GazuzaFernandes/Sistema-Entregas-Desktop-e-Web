using DAL.Entities;
using DAL.Entities.Financeiro;
using FluentNHibernate.Mapping;

namespace DAL.Mapping.Financeiro
{
    public class FinanceiroPropostaMap : ClassMap<FinanceiroProposta>
    {
        public FinanceiroPropostaMap()
        {
            Id(p => p.IdProp).GeneratedBy.Sequence("proposta_seq");
            Map(p => p.EmissaoNf);
            Map(p => p.VencimentoNf);
            Map(p => p.Cliente);           
            Map(p => p.Proposta);
            Map(p => p.Notafiscal);
            Map(p => p.Obra);
            Map(p => p.Email);
            Map(p => p.Cometario);
            Map(p => p.StatusobraId);       
            Table("FinanceiroProposta");
        }
    }
}
