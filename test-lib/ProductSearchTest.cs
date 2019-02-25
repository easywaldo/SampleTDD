using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using AutoFixture;
using SampleTDD.Product;
using ProductService;
using System.Collections.Generic;
using System;

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

        [TestMethod]
        public void sut_should_takes_product_correctly()
        {
            // Arrange
            var builder = new Fixture();
            var expectedId = Guid.NewGuid();
            var product = builder.Build<Product>()
                .With(x => x.Id, expectedId)
                .Create();
            var unExpected = builder.Create<Product>();
            var productList = new List<Product>
            {
                product,
                unExpected,
            };
            var sut = new ProductSearch(productList);

            // Act
            var actual = sut.GetProducts(new List<Guid> { expectedId });

            // Assert
            actual.Should().NotBeNullOrEmpty();
        }
    }
}
