using MextFullStackSaaS.Domain.Entities;
using MextFullStackSaaS.Domain.Enum;
using MextFullStackSaaS.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MextFullStackSaaS.Application.Features.Orders.Queries.GetById
{
    public class OrderGetByIdDto
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }

        public string IconDescription { get; set; }
        public string ColorCode { get; set; }
        public AIModelType Model { get; set; }
        public DesignType DesignType { get; set; }
        public IconSize Size { get; set; }
        public IconShape Shape { get; set; }
        public int Quantity { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public List<string> Urls { get; set; } = new List<string>();

        public static OrderGetByIdDto MapFromOrder(Order order)
        {
            return new OrderGetByIdDto
            {
                Id = order.Id,
                UserId = order.UserId,
                IconDescription = order.IconDescription,
                ColorCode = order.ColorCode,
                Model = order.Model,
                DesignType = order.DesignType,
                Size = order.Size,
                Shape = order.Shape,
                Quantity = order.Quantity,
                Urls = order.Urls,
                CreatedOn = order.CreatedOn
            };
        }
    }
}
