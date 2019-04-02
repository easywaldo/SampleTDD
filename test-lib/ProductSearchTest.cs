using System;
using System.Collections.Generic;
using System.Linq;
using AutoFixture;
using AutoFixture.NUnit3;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using ProductService;
using SampleTDD.Product;

namespace SampleTest {
    [TestClass]
    public class ProductSearchTest {
        [TestMethod]
        public void sut_should_implement_interface () {
            typeof (ProductSearch).Should ().Implement<IProductSearch> ();
        }

        [TestMethod]
        [DataRow ("john")]
        [DataRow ("willy")]
        public void sut_should_takes_product_correctly (
            string expectedName) {
            // Arrange
            var builder = new Fixture ();
            var product = builder.Build<Product> ()
                .With (x => x.Name, expectedName)
                .Create ();
            var unExpected = builder.Create<Product> ();
            var productList = new List<Product> {
                product,
                unExpected,
            };
            var sut = new ProductSearch (productList);

            // Act
            var actual = sut.GetProductList (new List<string> { expectedName });

            // Assert
            actual.Should ().NotBeNullOrEmpty ();
            actual.Should ().HaveCount (1);
            actual.First ().Name.Should ().Be (expectedName);
        }

        [TestMethod]
        public void given_discount_rates_is_out_of_range_then_sut_should_throws_exceptions () {
            // Arrange
            var builder = new Fixture ();
            var productList = builder.CreateMany<Product> (10);
            var sut = new ProductSearch (productList.ToList ());

            // Act
            Action action = () => sut.GetProductsRandom (30, 200);

            // Assert
            action.Should().Throw<ArgumentException>();
            

        }
    }
}