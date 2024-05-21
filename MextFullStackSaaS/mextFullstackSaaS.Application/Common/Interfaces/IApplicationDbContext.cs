using Microsoft.EntityFrameworkCore;
using MextFullStackSaaS.Domain.Identity;
using MextFullStackSaaS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MextFullStackSaaS.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Order> Orders { get; set; }
        DbSet<UserBalance> UserBalances { get; set; }
        DbSet<UserBalanceHistory> UserBalanceHistories { get; set; }

        Task<int> SaveChangesAsycn(CancellationToken cancellationToken)

        int SaveChanges();
    }
}
