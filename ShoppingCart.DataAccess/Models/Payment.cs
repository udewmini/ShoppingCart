using System;
using System.Collections.Generic;

namespace ShoppingCart.DataAccess.Models
{
    public partial class Payment
    {
        public int Id { get; set; }
        public int? OrderId { get; set; }
        public int? CustomerId { get; set; }
        public int? Cvv { get; set; }
        public DateTime? ExpiryDate { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Order Order { get; set; }
    }
}
