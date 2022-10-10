using DAL.Entities.Engenharia;
using FluentNHibernate.Mapping;


namespace DAL.Mapping.Engenharia
{
    public  class PropostaEngenhariaMap : ClassMap<PropostaEngenharia>
    {       
        public PropostaEngenhariaMap()
        {
            Id(p => p.EngenhariaId).GeneratedBy.Sequence("propostaengenharia_seq");
            Map(p => p.Proposta);
            Map(p => p.Cliente);
            Map(p => p.Funcionario);
            Map(p => p.Responsavel);
            Map(p => p.Telefone);
            Map(p => p.Obra);
            Map(p => p.StatusObraId);
            Map(p => p.DataInclusao);
            Table("propostaengenharia");
        }    

    }
}
