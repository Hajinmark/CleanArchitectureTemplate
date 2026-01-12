using System;
using System.Collections.Generic;

namespace CleanArchitecture.Infrastructure.Persistence.Entity
{
    public partial class Product
    {
        public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int Id { get; set; }
        public string ProductId { get; set; } = null!;
        public string ProductName { get; set; } = null!;
        public string? Description { get; set; }
        public int? CategoryId { get; set; }
        public int? SupplierId { get; set; }
        public int? Quantity { get; set; }
        public decimal? Price { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual Category? Category { get; set; }
        public virtual Supplier? Supplier { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
