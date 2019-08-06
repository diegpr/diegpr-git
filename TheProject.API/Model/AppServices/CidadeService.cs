using System;
using System.Collections.Generic;
using TheProject.API.Model.Entities;
using TheProject.API.Model.Infra;

namespace TheProject.API.Model.AppServices
{
    public class CidadeService : GenericService<Cidade>
    {
        public CidadeService(AppDbContext ctx) : base(ctx)
        {
        }

        public override IEnumerable<Cidade> Listar(Cidade obj)
        {
            throw new NotImplementedException();
        }
    }
}
