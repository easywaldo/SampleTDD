using System;
using System.Collections.Generic;
using System.Linq;
using SampleTDD.Product;

namespace ProductService
{
    public interface IProductSearch
    {
        IEnumerable<Product> GetProductList(List<string> ids);

        IEnumerable<Product> GetProductsRandom(int discountFrom, int discountTo);
    }
}