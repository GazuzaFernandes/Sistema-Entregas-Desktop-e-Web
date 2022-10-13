using DAL.Entities;
using DAL.Entities.Logistica;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mapping.Logistica
{
    public class ItenControleMap : ClassMap<ItenRoteiroMotorista>
    {        
        public ItenControleMap()
        {
            Id(p => p.ItensRoteiroId).GeneratedBy.Sequence("itenroteiro_seq");
            Map(p => p.Codigo);
            Map(p => p.Material);
            Map(p => p.UndMedida);
            Map(p => p.QtdCaixas);
            Map(p => p.QtdSaida);
            Map(p => p.RoteiroId);
            Table("itenroteiro");
        }
        
    }
}
