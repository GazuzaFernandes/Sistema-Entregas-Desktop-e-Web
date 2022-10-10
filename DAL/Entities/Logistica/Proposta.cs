using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.Logistica
{
    public class DadosProposta
    {
        public virtual int PropostaId { get; set; }
        public virtual DateTime DataPrevista { get; set; }
        public virtual DateTime DataPedido { get; set; }
        public virtual string? Fabrica { get; set; }
        public virtual string? Faturado { get; set; }
        public virtual string? FormaPag { get; set; }
        public virtual string? EngResp { get; set; }
        public virtual string? Telefone { get; set; }
        public virtual string? PdRb { get; set; }
        public virtual string? PdVenda { get; set; }
        public virtual string? Material { get; set; }
        public virtual string? Proposta { get; set; }
        public virtual string? Construtora { get; set; }
        public virtual string? Obra { get; set; }   
        public virtual DateTime DataEntrega { get; set; }
        public virtual string? RecebidoPor { get; set; }
        public virtual string? NotaFiscal { get; set; }
        public virtual string? Carreto { get; set; }
        public virtual int StatusObraId { get; set; }

    }
}
