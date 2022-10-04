using DAL.Entities;
using DAL.Entities.Logistica;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mapping.Logistica
{
   public class HistoricoMap : ClassMap<Historico>
    {
        #region  Pasta - Sistema Logistica -  Form Logistica
        public HistoricoMap()
        {
            Id(p => p.HistoricoId).GeneratedBy.Sequence("historico_seq");
            Map(p => p.DataComentario);
            Map(p => p.Comentario);
           
            Map(p => p.PropostaId);         
            Table("historico");
        }
        #endregion
    }
}
