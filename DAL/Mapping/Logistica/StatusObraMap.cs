using DAL.Entities;
using DAL.Entities.Logistica;
using FluentNHibernate.Mapping;

namespace DAL.Mapping.Logistica
{
    public class StatusObraMap : ClassMap<StatusObra>
    {
        public StatusObraMap()
        {
            Id(p => p.StatusObraId);
            Map(p => p.Descricao);
            Table("statusobra");
        }
    }
}
