using DAL.Entities.Logistica;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mapping.Logistica
{
    public class EstoqueMadeiraMap : ClassMap<EstoqueMadeira>
    {
        public EstoqueMadeiraMap()
        {
            Id(p=> p.EstoqueId).GeneratedBy.Sequence("estoquemadeira_seq");
            Map(p => p.Madeira);          
            Map(p => p.Espessura);
            Map(p => p.Largura);
            Map(p => p.MetroLinear);
            Map(p => p.MetroQuadrado);
            Map(p => p.MetroCubico);
            Table("EstoqueMadeira");
        }
    }
}
