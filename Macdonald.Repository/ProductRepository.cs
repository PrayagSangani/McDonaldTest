using Macdonald.Contract;
using Mcdonald.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Macdonald.Repository
{
    public class ProductRepository: IProductRepository
    {
        private List<Product> lstprod;
        
        // prepare a list of products offered
        public ProductRepository()
        {
            lstprod = new List<Product>()
            {
                new Product() { ProdId = 1, ProdName = "Cola - Cold", ProdType = Convert.ToInt32(ProductType.Drink), Price = Convert.ToDecimal(0.50) },
                new Product() { ProdId = 2, ProdName = "Coffee - Hot", ProdType = Convert.ToInt32(ProductType.Drink), Price = Convert.ToDecimal(1) },
                new Product() { ProdId = 3, ProdName = "Cheese Sandwich - Cold", ProdType = Convert.ToInt32(ProductType.Food), Price = Convert.ToDecimal(2) },
                new Product() { ProdId = 4, ProdName = "Steak Sandwich - Hot", ProdType = Convert.ToInt32(ProductType.Food), Price = Convert.ToDecimal(4.50) }
            };
        }

        // a method to get all products
        public IEnumerable<Product> GetAllProduct()
        {
            return lstprod;
        }

        // a method to get a productby id
        public Product GetProductById(int id)
        {
            return this.lstprod.FirstOrDefault(e => e.ProdId == id);
        }
        
    }
}
