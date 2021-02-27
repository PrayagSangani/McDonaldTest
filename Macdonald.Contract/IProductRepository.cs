using Mcdonald.Model;
using System.Collections.Generic;

namespace Macdonald.Contract
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProduct();
        Product GetProductById(int Id);
    }
}
