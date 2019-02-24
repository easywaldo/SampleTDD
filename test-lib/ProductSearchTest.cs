using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using AutoFixture;
using SampleTDD.Product;
using ProductService;

namespace SampleTest
{
    [TestClass]
    public class ProductSearchTest
    {
        [TestMethod]
        public void sut_should_implement_interface()
        {
            typeof(ProductSearch).Should().Implement<IProductSearch>();
        }
    }
}
