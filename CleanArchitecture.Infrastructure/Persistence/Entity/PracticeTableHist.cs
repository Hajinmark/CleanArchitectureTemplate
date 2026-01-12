using System;
using System.Collections.Generic;

namespace CleanArchitecture.Infrastructure.Persistence.Entity
{
    public partial class PracticeTableHist
    {
        public int? Id { get; set; }
        public string? Username { get; set; }
        public string? SampleValue { get; set; }
        public int HistId { get; set; }
        public string? HistRefNo { get; set; }
    }
}
