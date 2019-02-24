using System.Collections.Generic;
using System.Linq;
using SampleTDD.Product;

namespace ProductService
{
    public interface IProductSearch
    {
        IEnumerable<Product> GetProducts(List<int> ids);
    }
}