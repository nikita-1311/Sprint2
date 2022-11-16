using System;
using System.Collections.Generic;

#nullable disable

namespace CourierSystem.Models
{
    public partial class Customer
    {
        public int CustId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
    }
}
