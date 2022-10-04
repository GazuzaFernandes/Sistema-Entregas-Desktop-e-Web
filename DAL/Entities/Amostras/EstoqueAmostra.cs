using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.Amostras
{
    public class EstoqueAmostra
    {     
        public virtual int EstoqueId { get; set; }
        public virtual string? Amostra { get; set; }
        public virtual decimal Entrada { get; set; }
        public virtual decimal Total { get; set; }
    
    }
}
