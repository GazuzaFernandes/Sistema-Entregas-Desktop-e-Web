using DAL.Entities.Logistica;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mapping.Logistica
{
    public class TelefoneMap : ClassMap<Telefone>
    {
        public TelefoneMap()
        {
            Id(p => p.TelefoneId).GeneratedBy.Sequence("telefone_seq");
            Map(p => p.Contato);
            Map(p => p.Nome);
            Map(p => p.Observacao);
            Table("telefone");
        }
    }
}
