using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.Financeiro
{
    public class Statusobra
    {
        public virtual int StatusObraId { get; set; }
        public virtual string Descricao { get; set; }
    }
}
