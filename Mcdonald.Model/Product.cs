using System;
using System.Threading.Tasks;

namespace Mcdonald.Model
{
    public class Product
    {

        public int ProdId { get; set; }

        public string ProdName { get; set; }

        public int ProdType { get; set; }

        public decimal Price { get; set; }
       
        public bool Selected { get; set; }

    }

   
    
}
