using Application.Repositories;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infastructure.Persistence.Repositories
{
    public class PingRepository : IPingRepositories
    {
        public async Task<Ping> PingAsync()
        {
            var ping = new Ping { Id = 1, Message = " Successful "};
            return ping;

        }
    }
}
