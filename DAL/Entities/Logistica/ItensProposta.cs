
namespace DAL.Entities.Logistica
{
    public class ItensProposta
    {  
        public virtual int ItenId { get; set; }
        public virtual string? Material { get; set; }      
        public virtual string? UndMedida { get; set; }       
        public virtual decimal Quantidade { get; set; }
        public virtual decimal Preco { get; set; }
        public virtual decimal QtdCaixa { get; set; }
        public virtual string? ObsMaterial { get; set; }
        public virtual decimal Total { get; set; }
        public virtual decimal M2Caixa { get; set; }
        public virtual int PropostaId { get; set; }
        public virtual int CodigoMaterial { get; set; }       
    }
}
