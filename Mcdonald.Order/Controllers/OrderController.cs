using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Macdonald.Contract;
using Mcdonald.Model;
using Mcdonald.Order.Models;
using Microsoft.AspNetCore.Mvc;

namespace Mcdonald.Order.Controllers
{
    public class OrderController : Controller
    {
        private IProductRepository _productRepository;

        public OrderController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        [HttpGet]
        public IActionResult Index()
        {
            // retrieve all the products
            var model = _productRepository.GetAllProduct();
            // Pass the list of Product to the view
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(List<string> productIds)
        {
            decimal orderBill = 0; // total bill of the order
            for (int i = 0; i < productIds.Count; i++)
            {
                // get the product by selected product Id
                Product product = _productRepository.GetProductById(Convert.ToInt32(productIds[i]));

                // check if the selected product is a food or drink
                if (product.ProdType ==Convert.ToInt32(ProductType.Food))
                {
                    // if the selected product is food, add 10% service charge
                    orderBill += (product.Price * 10) / 100 + product.Price;
                } else
                {
                    // for drink, no service charge added to the bill
                    orderBill += product.Price;
                }
            }
            ViewBag.BillGenerate = orderBill;
            var model = _productRepository.GetAllProduct();
            return View(model);
        }
    }   
}
