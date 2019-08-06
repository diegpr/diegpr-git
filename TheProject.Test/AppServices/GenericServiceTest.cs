using Microsoft.EntityFrameworkCore;
using TheProject.API.Model.DomainServices;
using TheProject.API.Model.Entities;
using TheProject.API.Model.Infra;
using Xunit;

namespace TheProject.Test.AppServices
{
    public abstract class GenericServiceTest<T> where T: BaseEntity
    {
        private readonly DbContextOptions options;
        protected readonly AppDbContext dbContext;
        protected IGenericService<T> svc;

        protected T testObjectCreate;
        protected T testObjectList;
        protected int testIdForDelete;
        protected int testIdForGet;
        protected T testObjectForUpdate;

        public GenericServiceTest()
        {
            options = new DbContextOptionsBuilder<AppDbContext>().
                   UseInMemoryDatabase(databaseName: "TestDb")
                   .Options;
            dbContext = new AppDbContext(options);
            //dbContext.Database.Migrate();
                
        }

        [Fact]
        public virtual void DeveIncluir()
        {
            var result = svc.Criar(testObjectCreate);
            Assert.Equal(testObjectCreate, result);
        }

        [Fact]
        public abstract void DeveListar();
    }
}
