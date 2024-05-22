using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MextFullStackSaaS.Application.Features.Orders.Commands.Delete
{
    public class OrderDeleteCommand :IRequest<Guid>
    {
        public Guid Id { get; set; }
        public OrderDeleteCommand(Guid id)
        {
            Id = id;
        }
    }
}
