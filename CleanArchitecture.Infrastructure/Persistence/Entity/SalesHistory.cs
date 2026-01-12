using System;
using System.Collections.Generic;

namespace CleanArchitecture.Infrastructure.Persistence.Entity
{
    public partial class SalesHistory
    {
        public int HistoryId { get; set; }
        public int? SaleId { get; set; }
        public string? TransactionNo { get; set; }
        public int? CustomerId { get; set; }
        public DateTime? SaleDate { get; set; }
        public decimal? TotalAmount { get; set; }
    }
}
