using System.Collections.Generic; 
namespace DAL.NHibertnate
{
    public interface IConnectionDal<T> where T : class 
        { 
            int Inserir(T entidade); 
            void Atualizar(T entidade); 
            void Excluir(T entidade); 
            T ConsultarPorId(int id); 
            List<T> Listar(); 
        } 
    } 

