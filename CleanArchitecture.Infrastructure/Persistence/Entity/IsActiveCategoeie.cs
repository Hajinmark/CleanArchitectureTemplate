using System;
using System.Collections.Generic;

namespace CleanArchitecture.Infrastructure.Persistence.Entity
{
    public partial class IsActiveCategoeie
    {
        public int Id { get; set; }
        public string? CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
    }
}
