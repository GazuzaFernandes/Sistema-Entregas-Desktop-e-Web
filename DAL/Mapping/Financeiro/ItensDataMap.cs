using DAL.Entities;
using DAL.Entities.Financeiro;
using FluentNHibernate.Mapping;

namespace DAL.Mapping.Financeiro
{
    public class ItensdataMap : ClassMap<Itensdata>
    {
        public ItensdataMap()
        {
            Id(p => p.IdDatas).GeneratedBy.Sequence("itensdata_seq");
            Map(p => p.Fabrica);
            Map(p => p.Datas);
            Map(p => p.IdMadeiras);
            Map(p => p.IdMaterial);          
            Map(p => p.Entrada);
            Table("itensdata");
        }

    }
}
