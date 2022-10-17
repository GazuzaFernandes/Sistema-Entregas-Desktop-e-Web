using DAL.Entities.Logistica;
using DAL.NHibertnate;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repository.Logistica
{
    public class DLFerramentas : Repository<Ferramentas>
    {
        #region Pasta - Sistema Logistica - Form Ferramentas
        public List<Ferramentasview> Listarferramenta()
        {
            try
            {
                var lstferramenta = new List<Ferramentasview>();

                var listarferramentas = new DLFerramentas().Listar();
                var listaStatus = new DLStatusObra().Listar();

                var resultado = listarferramentas
                   .Join(listaStatus, ferramentas => ferramentas.StatusobraId, statuss => statuss.StatusObraId, (ferramentas, stattuss) => new { ferramentas, stattuss })
                   .Select(x => new
                   {
                       x.ferramentas.FerramentaId,
                       x.ferramentas.Retirada,
                       x.ferramentas.Devolucao,
                       x.ferramentas.Funcionario,
                       x.ferramentas.Material,
                       x.stattuss.Descricao,
                   }).ToList();


                foreach (var ferramentaclie in resultado)
                {
                    var ferra = new Ferramentasview();

                    ferra.ferramentaid = ferramentaclie.FerramentaId;
                    ferra.retirada = ferramentaclie.Retirada;
                    ferra.devolucao = ferramentaclie.Devolucao;
                    ferra.funcionario = ferramentaclie.Funcionario;
                    ferra.material = ferramentaclie.Material;
                    ferra.Status = ferramentaclie.Descricao;

                    switch (ferra.Status)
                    {
                        case "Pedente":
                            ferra.OrdenacaoStatus = 2;
                            break;
                        case "Devolvido":
                            ferra.OrdenacaoStatus = 10;
                            break;
                    }

                    lstferramenta.Add(ferra);
                }

                return lstferramenta.OrderByDescending(p => p.Status).ToList();
            }
            catch (System.Exception)
            {
                throw;
            }
        }
        public class Ferramentasview
        {
            public virtual int ferramentaid { get; set; }
            public virtual string funcionario { get; set; }
            public virtual DateTime retirada { get; set; }
            public virtual DateTime devolucao { get; set; }
            public virtual string material { get; set; }
            public virtual int statusobraid { get; set; }
            public virtual int OrdenacaoStatus { get; set; }
            public string Status { get; set; }

        }
        #endregion
    }
}
