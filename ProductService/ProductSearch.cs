using System;
using System.Collections.Generic;
using System.Linq;
using SampleTDD.Product;
using System.Runtime;

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

        public IEnumerable<Product> GetProductsRandom(int discountFrom, int discountTo)
        {
            if (discountFrom < 0) 
            {
                throw new ArgumentException("invalid range parameter", $"{discountFrom}");
            }
            if (discountTo > 100)
            {
                throw new ArgumentException("invalid range parameter", $"{discountTo}");
            }
            return _products.Where(x => 
                x.DiscountRate >= discountFrom && x.DiscountRate <= discountTo);
        }
    }
}
