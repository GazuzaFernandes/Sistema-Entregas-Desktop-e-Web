using DAL.Entities.Logistica;
using FluentNHibernate.Mapping;

namespace DAL.Mapping.Logistica
{
    public class CadastrarEmpresaMap : ClassMap<CadastrarEmpresa>
    {       
        public CadastrarEmpresaMap()
        {
            Id(p => p.EmpresaId).GeneratedBy.Sequence("cadastrarempresa_seq");
            Map(p => p.Empresa);
            Table("cadastrarempresa");
        }        
    }
}
