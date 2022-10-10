using DAL.Entities;
using DAL.Entities.Logistica;
using FluentNHibernate.Mapping;

namespace DAL.Mapping.Logistica
{
    public class ItensPropostaMap : ClassMap<ItensProposta>
    {      
        public ItensPropostaMap()
        {
            Id(p => p.ItenId).GeneratedBy.Sequence("itenproposta_seq");
            Map(p => p.Material);
            Map(p => p.ObsMaterial);
            Map(p => p.Quantidade);
            Map(p => p.Preco);
            Map(p => p.Total);
            Map(p => p.qtdcaixa);
            Map(p => p.UndMedida);            
            Map(p => p.M2caixa);
            Map(p => p.PropostaId);
            Map(p => p.CodigoMaterial);
            Table("itensproposta");
        }
        
    }
}
