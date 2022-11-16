using System;
using System.Collections.Generic;

#nullable disable

namespace CourierSystem.Models
{
    public partial class Courier
    {
        public int CId { get; set; }
        public string Name { get; set; }
        public string Docket { get; set; }
        public string FromCity { get; set; }
        public string ToCity { get; set; }
        public string CurrentCity { get; set; }
        public string Weight { get; set; }
        public string Status { get; set; }
    }
}
