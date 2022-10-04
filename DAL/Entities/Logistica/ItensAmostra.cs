namespace DAL.Entities.Logistica
{
    public class ItensAmostra
    {      
        public virtual int ItensamostraId { get; set; }
        public virtual int Codigo { get; set; }
        public virtual string? Material { get; set; }
        public virtual decimal Quantidade { get; set; }
        public virtual string? Observacao { get; set; }
        public virtual int AmostraId { get; set; }
    
    }
}
