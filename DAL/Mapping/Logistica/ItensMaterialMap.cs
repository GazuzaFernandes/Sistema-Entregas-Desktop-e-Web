using DAL.Entities.Logistica;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mapping.Logistica
{
    public class ItensMaterialMap :ClassMap<ItensMaterial>
    {
        public ItensMaterialMap()
        {
            Id(p => p.MaterialId).GeneratedBy.Sequence("itensmaterial_seq");
            Map(p => p.Material);
            Map(p => p.UnidadeMedida);
            Map(p => p.Total);
            Map(p => p.Entrada);
            Map(p => p.Quantidade);       
            Table("itensmaterial");
        }
    }
}
