using System;
using System.Collections.Generic;
using static ShoppingCart.Common.Enum;

namespace ShoppingCart.Common
{
    public class OperationResult
    {
        public int StatusId { get; set; }

        public Status status { get; set; }

        public string Message { get; set; }

        public string Error { get; set; }

        public dynamic Data { get; set; }

       
    }
}
