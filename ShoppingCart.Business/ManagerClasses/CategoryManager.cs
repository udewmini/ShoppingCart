using ShoppingCart.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using Constant = ShoppingCart.Common.Constant;
using Enum = ShoppingCart.Common.Enum;

namespace ShoppingCart.Business.ManagerClasses
{
    public class CategoryManager : BaseManager
    {
        ///<summary>
        ///method to get all the Categories
        ///</summary>
        ///<param name ="id">id for filtering</param>
        ///<returns></returns>
        ///
        public OperationResult GetAllCategories(int? id)
        {
            OperationResult operationResult = new OperationResult();
            operationResult.status = Enum.Status.Success;
            operationResult.Message = Constant.SuccessMessage;

            //check if the category Id is available
            if(id==null)
            {
                var categoryList = CategoryRepository.GetAll().ToList();
                operationResult.Data = categoryList;
            }
            else
            {
                var category = CategoryRepository.GetById(id);
                operationResult.Data = category;
            }

            return operationResult;

        }
    }
}
