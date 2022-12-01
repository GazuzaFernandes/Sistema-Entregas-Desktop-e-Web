
using DALRestauracao.Entities.SenhaRestauracao;
using FluentNHibernate.Mapping;

namespace DALRestauracao.Mapping.SenhaRestauracao
{
    public class SenhasMap : ClassMap<Senhas>
    {
        public SenhasMap()
        {
            Id(p => p.UsuarioId);           
            Map(p => p.Senha);
            Table("senha");
        }
    }
}
