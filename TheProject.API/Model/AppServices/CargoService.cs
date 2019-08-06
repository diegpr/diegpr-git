using System;
using System.Collections.Generic;
using System.Linq;
using TheProject.API.Model.Entities;
using TheProject.API.Model.Infra;

namespace TheProject.API.Model.AppServices
{
    public class CargoService : GenericService<Cargo>
    {
        public CargoService(AppDbContext ctx) : base(ctx)
        {
        }

        public override IEnumerable<Cargo> Listar(Cargo obj)
        {
            var filtro = obj?.Nome;
            var result = repositorio.Listar(
                f => f.Ativo &&
                f.Nome.Contains(string.IsNullOrEmpty(filtro) ? f.Nome : filtro)
            );
            return result.ToList();
        }
    }
}