using DAL.Entities.Engenharia;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mapping.Engenharia
{
    public class HistoricoEngenhariaMap : ClassMap<HistoricoEngenharia>
    {
        public HistoricoEngenhariaMap()
        {
            Id(p => p.HistoricoId).GeneratedBy.Sequence("historicoengenharia_seq");
            Map(p => p.Comentario);
            Map(p => p.DataComentario);
            Map(p => p.ComentadoEng);
            Map(p => p.EngenheiroId);    
            Table("historicoengenharia");
        }
    }
}
