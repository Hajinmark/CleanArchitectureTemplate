using System;
using System.Collections.Generic;

namespace CleanArchitecture.Infrastructure.Persistence.Entity
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int OrderId { get; set; }
        public string? OrderNumber { get; set; }
        public int? CustomerId { get; set; }
        public DateTime? OrderDate { get; set; }
        public string? ShipAddress { get; set; }
        public decimal? TotalAmount { get; set; }

        public virtual Customer? Customer { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
