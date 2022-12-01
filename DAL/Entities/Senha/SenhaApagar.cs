using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.SenhaRestauracao
{
    public class SenhaApagar
    {
        public virtual int UsuarioId { get; set; }    
        public virtual string Senhas { get; set; }
        public virtual bool Ativo { get; set; }
    
    }
}
