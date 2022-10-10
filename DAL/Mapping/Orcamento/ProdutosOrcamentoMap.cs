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
    public class ProdutosOrcamentoMap : ClassMap<ProdutosOrcamento>
    {
        public ProdutosOrcamentoMap()
        {
            Id(p => p.ProdutoId).GeneratedBy.Sequence("produtosorcamento_seq");
            Map(p => p.Fornecedor);
            Map(p => p.Produto);
            Map(p => p.Preco);
            Map(p => p.Rendimento);
            Map(p => p.Comentario);
            Table("produtosorcamento");
        }
    }
}
