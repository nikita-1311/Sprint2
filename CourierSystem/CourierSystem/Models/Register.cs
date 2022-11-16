using System;
using System.Collections.Generic;

#nullable disable

namespace CourierSystem.Models
{
    public partial class Register
    {
        public int RId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
    }
}
