using System;
using System.Collections.Generic;

namespace ShoppingCart.DataAccess.Models
{
    public partial class Image
    {
        public Image()
        {
            Product = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string ImagePath { get; set; }

        public virtual ICollection<Product> Product { get; set; }
    }
}
