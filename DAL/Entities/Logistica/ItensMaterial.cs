using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.Logistica
{
    public class ItensMaterial
    {        
        public virtual int MaterialId { get; set; }
        public virtual string? Material { get; set; }
        public virtual string? UnidadeMedida { get; set; }
        public virtual decimal Total { get; set; }
        public virtual decimal Entrada { get; set; }
        public virtual decimal Quantidade { get; set; }
      
    }
}
