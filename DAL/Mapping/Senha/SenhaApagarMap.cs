
using DAL.Entities.SenhaRestauracao;
using FluentNHibernate.Mapping;

namespace DAL.Mapping.SenhaRestauracao
{
    public class SenhaApagarMap : ClassMap<SenhaApagar>
    {
        public SenhaApagarMap()
        {
            Id(p => p.UsuarioId);           
            Map(p => p.Senhas);
            Table("senhaapagar");
        }
    }
}
