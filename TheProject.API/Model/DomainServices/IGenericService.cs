using System.Collections.Generic;
using TheProject.API.Model.Entities;

namespace TheProject.API.Model.DomainServices
{
    public interface IGenericService<T> where T : BaseEntity
    {
        T Criar(T obj);
        T Obter(int id);
        IEnumerable<T> Listar(T obj);
        T Atualizar(T obj);
        bool Deletar(int id);
    }
}