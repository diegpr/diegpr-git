using System;
using System.Collections.Generic;
using TheProject.API.Model.Entities;
using TheProject.API.Model.Infra;

namespace TheProject.API.Model.AppServices
{
    public class ClienteService : GenericService<Cliente>
    {
        public ClienteService(AppDbContext ctx) : base(ctx)
        {
        }

        public override IEnumerable<Cliente> Listar(Cliente obj)
        {
            throw new NotImplementedException();
        }
    }
}
