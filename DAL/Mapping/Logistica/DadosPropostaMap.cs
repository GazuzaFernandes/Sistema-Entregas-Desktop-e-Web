using DAL.Entities;
using DAL.Entities.Logistica;
using FluentNHibernate.Mapping;

namespace DAL.Mapping.Logistica
{
    public class DadosPropostaMap : ClassMap<DadosProposta>
    {       
        public DadosPropostaMap()
        {
            Id(p => p.PropostaId).GeneratedBy.Sequence("dadosproposta_seq");
            Map(p => p.DataPrevista);
            Map(p => p.Fabrica);
            Map(p => p.DataPedido);
            Map(p => p.Faturado);
            Map(p => p.FormaPag);
            Map(p => p.EngResp);
            Map(p => p.Telefone);
            Map(p => p.PdRb);
            Map(p => p.PdVenda);
            Map(p => p.Proposta);
            Map(p => p.Construtora);
            Map(p => p.Material);
            Map(p => p.Obra);      
            Map(p => p.DataEntrega);
            Map(p => p.RecebidoPor);
            Map(p => p.NotaFiscal);
            Map(p => p.Carreto);
            Map(p => p.StatusObraId);
            Table("dadosproposta");
        }      
    }
}
