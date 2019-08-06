using AutoFixture;
using Moq;
using Moq.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using TheProject.API.Model.Entities;
using TheProject.API.Model.Infra;
using TheProject.API.Model.Repository;
using Xunit;

namespace TheProject.Test.Repository
{
    public abstract class GenericRepositoryTest<T> where T : BaseEntity
    {
        public Mock<AppDbContext> dbContext = new Mock<AppDbContext>(MockBehavior.Loose);
        protected IGenericRepository<T> repository;

        private static readonly Fixture Fixture = new Fixture();

        protected T testObjectCreate;
        protected T testObjectList;
        protected int testIdForDelete;
        protected int testIdForGet;
        protected T testObjectForUpdate;
        protected IList<T> setMock;

        protected abstract void GenerateSet();
        protected virtual void Setup()
        {

            dbContext.Setup(s => s.Set<T>()).ReturnsDbSet(setMock);
            repository = new GenericRepository<T>(dbContext.Object);
        }

        public GenericRepositoryTest()
        {
            setMock = new List<T>();
            Setup();

            testObjectCreate = Fixture.Build<T>()
                .With(w => w.Ativo, true)
                .With(w => w.DataCriacao, DateTime.Now)
                .With(w => w.Id, new Random().Next())
                .Create();
        }

        [Fact]
        public void DeveAdicionar()
        {
            repository.Criar(testObjectCreate);
            Assert.NotEqual(0, testObjectCreate.Id);
        }
    }
}
