using DAL.Entities;
using DAL.Entities.Financeiro;
using FluentNHibernate.Mapping;

namespace DAL.Mapping.Financeiro
{
    public class ItensDataFinanceiroMap : ClassMap<ItensDataFinanceiro>
    {
        public ItensDataFinanceiroMap()
        {
            Id(p => p.IdDatas).GeneratedBy.Sequence("itensdatafinanceiro_seq");
            Map(p => p.Fabrica);
            Map(p => p.Datas);
            Map(p => p.IdMadeiras);      
            Map(p => p.Entrada);
            Table("itensdatafinanceiro");
        }

    }
}
