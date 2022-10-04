using DAL.Entities;
using DAL.Entities.SenhaRestauracao;
using FluentNHibernate.Mapping;

namespace DAL.Mapping.SenhaRestauracao
{
    public class SenhaMap : ClassMap<Senha>
    {
        public SenhaMap()
        {
            Id(p => p.UsuarioId);           
            Map(p => p.Senhas);
            Table("senha");
        }
    }
}
