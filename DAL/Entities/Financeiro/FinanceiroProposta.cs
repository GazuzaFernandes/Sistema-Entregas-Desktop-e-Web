using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities.Financeiro
{
   public class FinanceiroProposta
    {
        public virtual int IdProp { get; set; }
        public virtual DateTime EmissaoNf { get; set; }
        public virtual DateTime VencimentoNf { get; set; }
        public virtual string? Cliente { get; set; }    
        public virtual string? Propostas { get; set; }
        public virtual string? NotaFiscal { get; set; }
        public virtual string? Obra { get; set; } 
        public virtual string? Comentario { get; set; }
        public virtual int StatusObraId { get; set; }
    }
}
