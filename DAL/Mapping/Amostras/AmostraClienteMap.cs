using DAL.Entities;
using DAL.Entities.Amostras;
using FluentNHibernate.Mapping;

namespace DAL.Mapping.Amostras
{
    public class AmostraClienteMap : ClassMap<AmostraCliente>
    {        
        public AmostraClienteMap()
        {
            Id(p => p.AmostraId).GeneratedBy.Sequence("amostracliente_seq");
            Map(p => p.Construtora);
            Map(p => p.DataEntrega);
            Map(p => p.Obra);
            Map(p => p.Material);
            Map(p => p.StatusobraId);
            Table("amostracliente");
        }      
    }
}
