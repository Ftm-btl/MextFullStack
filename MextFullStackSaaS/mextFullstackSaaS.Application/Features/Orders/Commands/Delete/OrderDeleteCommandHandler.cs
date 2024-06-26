﻿using MediatR;
using MextFullStackSaaS.Application.Common.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MextFullStackSaaS.Application.Features.Orders.Commands.Delete
{
    public class OrderDeleteCommandHandler : IRequestHandler<OrderDeleteCommand, Guid>
    {
        private readonly IApplicationDbContext _dbContext;
        public OrderDeleteCommandHandler(IApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Guid> Handle(OrderDeleteCommand request, CancellationToken cancellationToken)
        {
            var order = await _dbContext
                .Orders
                .FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
           
            _dbContext.Orders.Remove(order);
            await _dbContext.SaveChangesAsycn(cancellationToken);

            return order.Id;
        }
    }
}
