using System;
using AutoFixture;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleTDD.Product;

namespace SampleTest
{
    [TestClass]
    public class ProductTest
    {
        [TestMethod]
        public void constructor_should_makes_correctly()
        {
            var sut = new Product();
            sut.Id.Should().NotBe(Guid.Empty);
        }

        [TestMethod]
        public void sut_has_name_property()
        {
            typeof(Product).Should().HaveProperty(typeof(string), "Name");
        }
    }
}