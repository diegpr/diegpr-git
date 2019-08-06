using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using TheProject.API.Model.Entities;
using TheProject.API.Model.Infra;

namespace TheProject.API.Model.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        readonly AppDbContext dbContext;
        public GenericRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public T Criar(T obj)
        {
            dbContext.Add(obj);
            dbContext.SaveChanges();
            return obj;
        }
        public void Deletar(int id)
        {
            var toDelete = GetById(id);
            if (toDelete == null)
                return;
            toDelete.Ativo = false;
            toDelete.DataUltimaAlteracao = DateTime.Now;
            dbContext.Entry(toDelete).State = EntityState.Modified;
            dbContext.SaveChanges();
        }
        public T Obter(int id) => GetById(id);
        private T GetById(int id) => dbContext.Set<T>().FirstOrDefault(f => f.Id == id && f.Ativo);
        public IEnumerable<T> Listar(Expression<Func<T, bool>> filter) => dbContext.Set<T>().Where(filter);
        public T Atualizar(T obj)
        {
            var toUpdate = GetById(obj.Id);
            if (toUpdate == null)
                return null;
            toUpdate.Merge(obj);
            toUpdate.DataUltimaAlteracao = DateTime.Now;
            dbContext.Entry(toUpdate).State = EntityState.Modified;
            dbContext.SaveChanges();
            return toUpdate;
        }
    }
}