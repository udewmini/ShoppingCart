using System;
using System.Collections.Generic;

namespace ShoppingCart.DataAccess.Models
{
    public partial class Product
    {
        public Product()
        {
            OrderItem = new HashSet<OrderItem>();
        }

        public int Id { get; set; }
        public int? CategoryId { get; set; }
        public int? ImageId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Qty { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? SellingPrice { get; set; }
        public decimal? Discount { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedUser { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual Category Category { get; set; }
        public virtual Image Image { get; set; }
        public virtual ICollection<OrderItem> OrderItem { get; set; }
    }
}
