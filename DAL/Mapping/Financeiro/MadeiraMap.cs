using DAL.Entities;
using DAL.Entities.Financeiro;
using FluentNHibernate.Mapping;

namespace DAL.Mapping.Financeiro
{
    public class MadeiraMap : ClassMap<Madeira>
    {
        public MadeiraMap()
        {
            Id(p => p.IdMadeiras).GeneratedBy.Sequence("madeira_seq");            
            Map(p => p.Madeiras);
            Map(p => p.UnidadeMedida);
            Map(p => p.Total);
            Map(p => p.Fabrica);           
            Map(p => p.Entrada);
            Map(p => p.StatusObraId);
            Table("madeira");
        }
    }
}
