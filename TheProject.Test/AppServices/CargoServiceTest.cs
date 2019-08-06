using System;
using System.Collections.Generic;
using System.Linq;
using TheProject.API.Model.AppServices;
using TheProject.API.Model.Entities;
using Xunit;

namespace TheProject.Test.AppServices
{
    public class CargoServiceTest : GenericServiceTest<Cargo>
    {
        public CargoServiceTest():base()
        {
            svc = new CargoService(dbContext);
            testObjectCreate = new Cargo { Id = 1, Nome = "Jovem Aprendiz", Ativo = true, DataCriacao = DateTime.Now, DataUltimaAlteracao = null };
            testObjectList = new Cargo();
        }

        public override void DeveListar()
        {
            var result = svc.Listar(testObjectList);
            Assert.IsAssignableFrom<IEnumerable<Cargo>>(result);
            
        }
    }
}