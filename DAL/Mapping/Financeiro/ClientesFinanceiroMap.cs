using DAL.Entities;
using DAL.Entities.Financeiro;
using FluentNHibernate.Mapping;

namespace DAL.Mapping.Financeiro
{
    public class ClientesFinanceiroMap : ClassMap<ClientesFinanceiro>
    {
        public ClientesFinanceiroMap()
        {
            Id(p => p.IdCliente).GeneratedBy.Sequence("clientefinanceiro_seq");
            Map(p => p.Nome);                  
            Table("clientesfinanceiro");
        }

    }
}
