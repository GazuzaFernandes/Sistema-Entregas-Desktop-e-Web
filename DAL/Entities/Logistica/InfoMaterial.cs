using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.Logistica
{
    public class InfoMaterial
    {      
        public virtual int MaterialId { get; set; }
        public virtual string? Material { get; set; }
        public virtual string? Utilidade { get; set; }
      
    }
}

