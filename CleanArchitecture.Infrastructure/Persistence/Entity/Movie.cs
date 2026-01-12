using System;
using System.Collections.Generic;

namespace CleanArchitecture.Infrastructure.Persistence.Entity
{
    public partial class Movie
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal? Cost { get; set; }
    }
}
