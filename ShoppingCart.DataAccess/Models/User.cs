using System;
using System.Collections.Generic;

namespace ShoppingCart.DataAccess.Models
{
    public partial class User
    {
        public User()
        {
            Customer = new HashSet<Customer>();
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Customer> Customer { get; set; }
    }
}
