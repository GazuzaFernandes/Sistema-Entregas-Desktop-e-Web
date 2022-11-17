using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.Logistica
{
    public class EstoqueMadeira
    {
        public virtual int EstoqueId { get; set; }
        public virtual string? Madeira { get; set; }
        public virtual decimal Espessura { get; set; }
        public virtual decimal Largura { get; set; }
        public virtual decimal MetroLinear { get; set; }
        public virtual decimal MetroQuadrado { get; set; }
        public virtual decimal MetroCubico { get; set; }
        public virtual string? observacao { get; set; }

    }
}
