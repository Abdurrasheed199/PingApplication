using Application.Repositories;
using Application.Services;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infastructure.Persistence.Services
{
    public class PingService : IPingService
    {
        private readonly IPingRepositories _pingRepositories;

        public PingService(IPingRepositories pingRepositories)
        {
            _pingRepositories = pingRepositories;
        }

        public async Task<Ping> GetPingAsync()
        {
            return await _pingRepositories.PingAsync();
        }
    }
}
