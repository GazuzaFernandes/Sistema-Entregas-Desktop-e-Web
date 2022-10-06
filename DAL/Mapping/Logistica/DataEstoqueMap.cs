using DAL.Entities.Logistica;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mapping.Logistica
{
    public class DataEstoqueMap : ClassMap<DataEstoque>
    {
        public DataEstoqueMap()
        {
            Id(p => p.DataId).GeneratedBy.Sequence("dataestoque_seq");
            Map(p => p.Saida);
            Map(p => p.Entrada);
            Map(p => p.EstoqueId);
            Map(p => p.MetroQuadrado);
            Map(p => p.StatusObraId);
            Table("DataEstoque");
        }
    }
}
