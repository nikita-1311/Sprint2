using System;
using System.Collections.Generic;

#nullable disable

namespace CourierSystem.Models
{
    public partial class Contact
    {
        public int ContId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public string Message { get; set; }
    }
}
