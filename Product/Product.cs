using System;

namespace SampleTDD.Product
{
    public class Product
    {
        public Guid Id { get; }

        public string Name { get; set; }
        public Product()
        {
            Id = Guid.NewGuid();
        }
    }
}