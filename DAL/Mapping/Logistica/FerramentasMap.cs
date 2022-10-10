using DAL.Entities;
using DAL.Entities.Logistica;
using FluentNHibernate.Mapping;

namespace DAL.Mapping.Logistica
{
    public class FerramentasMap : ClassMap<Ferramentas>
    {      
        public FerramentasMap()
        {
            Id(p => p.FerramentaId).GeneratedBy.Sequence("ferramentas_seq");
            Map(p => p.Funcionario);
            Map(p => p.Retirada);
            Map(p => p.Devolucao);
            Map(p => p.Material);
            Map(p => p.StatusobraId);
            Table("ferramentas");
        }
       
    }
}
