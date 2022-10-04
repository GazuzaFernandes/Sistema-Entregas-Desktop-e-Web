using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.Logistica
{
    public class Ferramentas
    {
               public virtual int FerramentaId { get; set; }
        public virtual string? Funcionario { get; set; }
        public virtual DateTime Retirada { get; set; }
        public virtual DateTime Devolucao { get; set; }
        public virtual string? Material { get; set; }
        public virtual int StatusobraId { get; set; }
        

    }
}
