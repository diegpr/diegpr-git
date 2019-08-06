using System.Collections.Generic;
using TheProject.API.Model.DomainServices;
using TheProject.API.Model.Entities;
using TheProject.API.Model.Infra;
using TheProject.API.Model.Repository;

namespace TheProject.API.Model.AppServices
{
    public abstract class GenericService<T> : IGenericService<T> where T : BaseEntity
    {

        protected readonly GenericRepository<T> repositorio;

        public GenericService(AppDbContext ctx)
        {
            repositorio = new GenericRepository<T>(ctx);
        }
        public T Atualizar(T obj)
        {
            var result = repositorio.Atualizar(obj);
            return result;
        }

        public T Criar(T obj)
        {
            var result = repositorio.Criar(obj);
            return result;
        }

        public bool Deletar(int id)
        {
            repositorio.Deletar(id);
            return true;
        }

        public abstract IEnumerable<T> Listar(T obj);
        public T Obter(int id) => repositorio.Obter(id);
    }
}