using System;
using System.Collections.Generic;

namespace ShoppingCart.DataAccess.Models
{
    public partial class Category
    {
        public Category()
        {
            Product = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedUser { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual ICollection<Product> Product { get; set; }
    }
}
