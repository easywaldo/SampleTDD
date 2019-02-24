using System;

namespace SampleTDD.Product
{
    public class Product
    {
        public Guid Id { get; }
        public Product()
        {
            Id = Guid.NewGuid();
        }
    }
}