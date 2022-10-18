using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.Logistica
{
    public class Telefone
    {
        public virtual int TelefoneId { get; set; }
        public virtual string? Nome { get; set; }
        public virtual string? Contato { get; set; }
        public virtual string? Observacao { get; set; }
    }
}
