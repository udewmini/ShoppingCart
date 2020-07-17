using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Business.ManagerClasses;
using ShoppingCart.Common;

namespace ShoppingCart.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        #region Private properties
        CategoryManager categoryManager = new CategoryManager();
        #endregion

        [HttpGet("/api/getuser/{id:int?}")]
        public OperationResult Get(int? id)
        {
            OperationResult operationResult = categoryManager.GetAllCategories(id);
            return operationResult;
        }
    }
}
