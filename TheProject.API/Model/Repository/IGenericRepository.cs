using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using TheProject.API.Model.Entities;

namespace TheProject.API.Model.Repository
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        T Criar(T obj);
        void Deletar(int id);
        T Obter(int id);
        IEnumerable<T> Listar(Expression<Func<T, bool>> filter);
        T Atualizar(T obj);
    }
}
