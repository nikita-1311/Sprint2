using System;
using System.Collections.Generic;

#nullable disable

namespace CourierSystem.Models
{
    public partial class Admin
    {
        public int AId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Mobile { get; set; }
        public string Status { get; set; }
        public string OffId { get; set; }
    }
}
