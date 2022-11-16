using System;
using System.Collections.Generic;

#nullable disable

namespace CourierSystem.Models
{
    public partial class Comment
    {
        public int ComId { get; set; }
        public string Docket { get; set; }
        public string Status { get; set; }
        public string Date { get; set; }
    }
}
