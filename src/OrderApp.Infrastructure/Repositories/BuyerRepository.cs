using OrderApp.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderApp.Infrastructure.Repositories
{
    public class BuyerRepository : IBuyerRepository
    {
        public Task<int> SaveChangeAsync()
        {
            return Task.FromResult(1);
        }
    }
}
