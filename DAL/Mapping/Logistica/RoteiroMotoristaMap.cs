using DALLogistica.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALLogistica.Mapping
{
  public  class RoteiroMotoristaMap : ClassMap<RoteiroMotorista>
    {
        #region Pasta - Sistema Logistica - Form Saida Estoque
        public RoteiroMotoristaMap()
        {
            Id(p => p.ControleId).GeneratedBy.Sequence("controle_seq");
            Map(p => p.Proposta);
            Map(p => p.Obra);
            Map(p => p.DataEntrada);
            Map(p => p.Funcionario);
            Table("controle");
        }
        #endregion
    }
}
