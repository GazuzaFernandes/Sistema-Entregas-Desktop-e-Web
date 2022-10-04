using DAL.Entities;
using DAL.Entities.Logistica;
using FluentNHibernate.Mapping;

namespace DAL.Mapping.Logistica
{
    public class InfoMaterialMap : ClassMap<InfoMaterial>
    {
        #region Pasta - Sistema Logistica - Form Material
        public InfoMaterialMap()
        {
            Id(p => p.MaterialId).GeneratedBy.Sequence("infomaterial_seq");
            Map(p => p.Material);
            Map(p => p.Utilidade);
            Table("InfoMaterial");
        }
        #endregion
    }
}
