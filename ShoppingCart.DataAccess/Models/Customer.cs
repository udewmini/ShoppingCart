using System;
using System.Collections.Generic;

namespace ShoppingCart.DataAccess.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Order = new HashSet<Order>();
            Payment = new HashSet<Payment>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Age { get; set; }
        public bool? Gender { get; set; }
        public string Email { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string PostalCode { get; set; }
        public bool? IsActive { get; set; }
        public string Password { get; set; }
        public int UserId { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<Order> Order { get; set; }
        public virtual ICollection<Payment> Payment { get; set; }
    }
}
