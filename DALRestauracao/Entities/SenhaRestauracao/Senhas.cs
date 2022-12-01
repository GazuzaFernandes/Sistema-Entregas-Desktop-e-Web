using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALRestauracao.Entities.SenhaRestauracao
{
    public class Senhas
    {
        public virtual int UsuarioId { get; set; }    
        public virtual string Senha { get; set; }
        public virtual bool Ativo { get; set; }
    
    }
}
