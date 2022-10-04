using DAL.Entities;
using DAL.Entities.Orcamento;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mapping.Orcamento
{
    public class ProdutosMap : ClassMap<Produtos>
    {
        public ProdutosMap()
        {
            Id(p => p.ProdutoId).GeneratedBy.Sequence("produtos_seq");
            Map(p => p.Fornecedor);
            Map(p => p.Produto);
            Map(p => p.Preco);
            Map(p => p.Rendimento);
            Map(p => p.Comentario);
            Table("produtos");
        }
    }
}
