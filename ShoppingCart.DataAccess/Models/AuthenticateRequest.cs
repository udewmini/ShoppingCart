using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.DataAccess.Models
{
    public class AuthenticateRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
