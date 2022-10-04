using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.Engenharia
{
    public class HistoricoEngenharia
    {
        public virtual int HistoricoId { get; set; }
        public virtual string? Comentario { get; set; }
        public virtual DateTime DataComentario { get; set; }
        public virtual string ComentadoEng { get; set; }
        public virtual int EngenheiroId { get; set; }

    }
}
