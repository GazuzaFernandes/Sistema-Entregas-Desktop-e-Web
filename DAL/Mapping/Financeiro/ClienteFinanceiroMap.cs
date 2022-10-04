using DAL.Entities;
using DAL.Entities.Financeiro;
using FluentNHibernate.Mapping;

namespace DAL.Mapping.Financeiro
{
    public class ClientesMap : ClassMap<Clientes>
    {
        public ClientesMap()
        {
            Id(p => p.IdCliente).GeneratedBy.Sequence("cliente_seq");
            Map(p => p.Nome);                  
            Table("clientes");
        }

    }
}
