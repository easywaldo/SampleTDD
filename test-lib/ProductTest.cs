using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using AutoFixture;
using SampleTDD.Product;

namespace SampleTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var builder = new Fixture();

            // Act
            var sut = builder.Create<Product>();

            // Assert
            sut.Should().BeOfType<Product>();
        }
    }
}
