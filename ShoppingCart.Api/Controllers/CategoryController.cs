using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Business;
using ShoppingCart.Business.ManagerClasses;
using ShoppingCart.Common;
using ShoppingCart.DataAccess.Models;

namespace ShoppingCart.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        #region Private properties
        CategoryManager categoryManager = new CategoryManager();
        #endregion

       [HttpGet("/api/getcategory/{id:int?}")]
       public OperationResult Get(int? id)
       {
            OperationResult operationResult = categoryManager.GetAllCategories(id);
            return operationResult;
        }
    }
}
