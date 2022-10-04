

namespace DAL.Entities.Engenharia
{
    public class PropostaEngenharia
    {
        public virtual int EngenhariaId { get; set; }
        public virtual string? Proposta { get; set; }
        public virtual string? Cliente { get; set; }
        public virtual string? Funcionario { get; set; }
        public virtual string? Responsavel { get; set; }
        public virtual string? Telefone { get; set; }
        public virtual string? Obra { get; set; }
        public virtual int StatusEng { get; set; }
        public virtual DateTime DataInclusao { get; set; }



    }
}
