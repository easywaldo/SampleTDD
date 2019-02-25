using System;
using System.Collections.Generic;
using SampleTDD.Product;

namespace ProductService
{
    public class ProductSearch : IProductSearch
    {
        private IList<Product> _products = null;
        public ProductSearch(IList<Product> products)
        {
            _products = products;
        }

        public IEnumerable<Product> GetProducts(List<Guid> ids)
        {
            throw new NotImplementedException();
        }
    }
}
