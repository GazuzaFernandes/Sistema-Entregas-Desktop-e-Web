using DAL.Entities.Logistica;
using DAL.NHibertnate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Logistica
{
    public class DLDataEstoque : Repository<DataEstoque>
    {
        public List<DataViewModel> ListarData()
        {
            try
            {
                var lstData = new List<DataViewModel>();
                var listarData = new DLDataEstoque().Listar();
                var listarStatus = new DLStatusObra().Listar();
                var resultado = listarData
                    .Join(listarStatus, dataEstoque =>
                    dataEstoque.StatusObraId, statuss => statuss.StatusObraId, (dataEstoque, statuss) => new { dataEstoque, statuss })
                    .Select(x => new DataViewModel()
                    {
                        DataId = x.dataEstoque.DataId,
                        Saida = x.dataEstoque.Saida,
                        Entrada = x.dataEstoque.Entrada,
                        EstoqueId = x.dataEstoque.EstoqueId,
                        MetroQuadrado = x.dataEstoque.MetroQuadrado,
                        Status = x.statuss.Descricao,
                    }).ToList();
                foreach(var dataEstoque in resultado)
                {
                    switch (dataEstoque.Status)
                    {
                        case "Entrada": //informando que a madeira deu entrada no estoque na Cor Verde
                            {
                                dataEstoque.OrdenacaoStatus = 8;
                            }break;
                        case "Saida": // Informando que o material deu Saida do estoque na cor Vermelha
                            {
                                dataEstoque.OrdenacaoStatus = 9;
                            }break;
                            lstData.Add(dataEstoque);
                    }
                }
                return lstData.OrderByDescending(p => p.Status).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public class DataViewModel
        {
            public virtual int DataId { get; set; }
            public virtual DateTime? Saida { get; set; }
            public virtual DateTime? Entrada { get; set; }
            public virtual int EstoqueId { get; set; }
            public virtual decimal MetroQuadrado { get; set; }
            public virtual int StatusObraId { get; set; }
            public int OrdenacaoStatus { get; set; }
            public string? Status { get; set; }
        }
    }




}
