using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using AutoFixture;
using SampleTDD.Product;
using ProductService;
using System.Collections.Generic;
using System;
using System.Linq;
using AutoFixture.NUnit3;
using NUnit.Framework;

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
        [DataRow("john")]
        [DataRow("willy")]
        public void sut_should_takes_product_correctly(
            string expectedName)
        {
            // Arrange
            var builder = new Fixture();
            var product = builder.Build<Product>()
                .With(x => x.Name, expectedName)
                .Create();
            var unExpected = builder.Create<Product>();
            var productList = new List<Product>
            {
                product,
                unExpected,
            };
            var sut = new ProductSearch(productList);

            // Act
            var actual = sut.GetProductList(new List<string> { expectedName });

            // Assert
            actual.Should().NotBeNullOrEmpty();
            actual.Should().HaveCount(1);
            actual.First().Name.Should().Be(expectedName);
        }
    }
}
