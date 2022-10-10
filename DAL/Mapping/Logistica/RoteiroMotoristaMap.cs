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
  public  class RoteiroMotoristaMap : ClassMap<RoteiroMotorista>
    {        
        public RoteiroMotoristaMap()
        {
            Id(p => p.RoteiroId).GeneratedBy.Sequence("roteiromotorista_seq");
            Map(p => p.Proposta);
            Map(p => p.Obra);
            Map(p => p.DataEntrada);
            Map(p => p.Funcionario);
            Table("roteiromotorista");
        }
   
    }
}
