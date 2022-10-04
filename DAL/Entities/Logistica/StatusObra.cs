using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.Logistica
{
    public class StatusObra
    {
        public virtual int StatusObraId { get; set; }
        public virtual string? Descricao { get; set; }
    }
}
