using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.Logistica
{
    public class Historico
    {       
        public virtual int HistoricoId { get; set; }
        public virtual DateTime DataComentario { get; set; }
        public virtual string? Comentario { get; set; }
        public virtual int PropostaId { get; set; }
        
    }
}
