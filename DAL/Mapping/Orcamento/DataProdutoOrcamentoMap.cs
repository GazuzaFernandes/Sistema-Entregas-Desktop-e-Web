using DAL.Entities;
using DAL.Entities.Orcamento;
using FluentNHibernate.Mapping;

namespace DAL.Mapping.Orcamento
{
    class DataProdutoOrcamentoMap : ClassMap<DataProdutoOrcamento>
    {
        public DataProdutoOrcamentoMap()
        {
            Id(p => p.DataId).GeneratedBy.Sequence("dataprodutoorcamento_seq");
            Map(p => p.Data);
            Map(p => p.Preco);           
            Map(p => p.ProdutoId);            
            Table("dataprodutoorcamento");
        }
    }
}
