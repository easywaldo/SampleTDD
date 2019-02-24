using System;
using System.Collections.Generic;
using SampleTDD.Product;

namespace ProductService
{
    public class ProductSearch : IProductSearch
    {
        public IEnumerable<Product> GetProducts(List<int> ids)
        {
            throw new NotImplementedException();
        }
    }
}
