using DAL.Entities.Amostras;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mapping.Amostras
{
    public class EstoqueAmostraMap : ClassMap<EstoqueAmostra>
    {   
        public EstoqueAmostraMap()
        {
            Id(p => p.EstoqueId).GeneratedBy.Sequence("estoqueamostra_seq");
            Map(p => p.Amostra);
            Map(p => p.Entrada);
            Map(p => p.Total);            
            Table("estoqueamostra");
        }
    }
}
