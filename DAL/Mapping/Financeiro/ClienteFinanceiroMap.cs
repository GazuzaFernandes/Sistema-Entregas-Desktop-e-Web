using DAL.Entities;
using DAL.Entities.Financeiro;
using FluentNHibernate.Mapping;

namespace DAL.Mapping.Financeiro
{
    public class ClientesFInanceiroMap : ClassMap<ClientesFInanceiro>
    {
        public ClientesFInanceiroMap()
        {
            Id(p => p.IdCliente).GeneratedBy.Sequence("clientefinanceiro_seq");
            Map(p => p.Nome);                  
            Table("clientefinanceiro");
        }

    }
}
