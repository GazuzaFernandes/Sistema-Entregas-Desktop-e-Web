using DAL.Entities;
using DAL.Entities.Financeiro;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Mapping.Financeiro
{
    public class ItensMadeiraFinanceiroMap : ClassMap<ItensmadeiraFinanceiro>
    {
        public ItensMadeiraFinanceiroMap()
        {
            Id(p => p.IdMadeira).GeneratedBy.Sequence("itensmadeirafinanceiro_seq");
            Map(p => p.Codigo);
            Map(p => p.Material);
            Map(p => p.Medida);
            Map(p => p.Total);     
            Map(p => p.IdProp);            
            Table("itensmadeirafinanceiro");
        }

    }
}
