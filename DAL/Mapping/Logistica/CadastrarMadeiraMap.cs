using DAL.Entities;
using DAL.Entities.Logistica;
using FluentNHibernate.Mapping;

namespace DAL.Mapping.Logistica
{
    public class CadastrarMadeiraMap : ClassMap<CadastrarMadeira>
    {        
        public CadastrarMadeiraMap()
        {
            Id(p => p.MadeiraId).GeneratedBy.Sequence("cadastromadeira_seq");
            Map(p => p.PisoMadeira);       
            Map(p => p.M2Caixa);
            Table("cadastrarmadeira");
        }
        
    }
}

 

