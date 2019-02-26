using System;
using System.Collections.Generic;
using System.Linq;
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

        public IEnumerable<Product> GetProductList(List<string> ids)
        {
            return _products.Where(x => ids.Contains(x.Name)).ToList();
        }
    }
}
