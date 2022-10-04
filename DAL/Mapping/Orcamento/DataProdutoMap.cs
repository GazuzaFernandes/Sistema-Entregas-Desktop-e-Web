using DAL.Entities;
using DAL.Entities.Orcamento;
using FluentNHibernate.Mapping;

namespace DAL.Mapping.Orcamento
{
    class DataprodutoMap : ClassMap<DataProduto>
    {
        public DataprodutoMap()
        {
            Id(p => p.DataId).GeneratedBy.Sequence("dataproduto_seq");
            Map(p => p.Data);
            Map(p => p.Preco);           
            Map(p => p.ProdutoId);            
            Table("dataproduto");
        }
    }
}
