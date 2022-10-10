using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.Logistica
{
    public class ItenRoteiro
    {
        public virtual int ItensRoteiroId { get; set; }
        public virtual int Codigo { get; set; }
        public virtual string? Material { get; set; }
        public virtual string? UndMedida { get; set; }
        public virtual decimal QtdCaixas { get; set; }
        public virtual decimal QtdSaida { get; set; }
        public virtual int RoteiroId { get; set; }
     
    }
}
