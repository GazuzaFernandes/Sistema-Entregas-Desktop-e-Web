using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.Logistica
{
    public class DataEstoque
    {
        public virtual int DataId { get; set; }
        public virtual DateTime? Saida { get; set; }
        public virtual DateTime? Entrada { get; set; }
        public virtual decimal MetroQuadrado { get; set; }
        public virtual int EstoqueId { get; set; }
        public virtual string? observacao { get; set; }
        public virtual int StatusObraId { get; set; }
    }
}
