using ShoppingCart.DataAccess.Models;
using ShoppingCart.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Business.ManagerClasses
{
    public class BaseManager
    {
        #region Private Properties

        private IRepository<Product> productRepository { get; set; }

        private IRepository<Category> categoryRepository { get; set; }

        private IRepository<User> userRepository { get; set; }

        #endregion

        #region Public Properties

        public IRepository<Product> ProductRepository
        {
            get
            {
                productRepository = productRepository ?? new Repository<Product>();
                return productRepository;

            }
        }

        public IRepository<Category> CategoryRepository
        {
            get
            {
                categoryRepository = categoryRepository ?? new Repository<Category>();
                return categoryRepository;
            }
        }

        public IRepository<User> UserRepository
        {
            get
            {
                userRepository = userRepository ?? new Repository<User>();
                return userRepository;
            }
        }
        #endregion

    }
}
