using System.Collections.Generic;

namespace DesignPatterns
{
    public class ConcreteBuilder2 : IBuilder
    {
        private Product _product = new Product();

        public void BuildParts()
        {
            _product.AddComponents(new List<IComponent> {new ConcreteComponent1("A"),new ConcreteComponent1("B"),new ConcreteComponent2("C")});
        }

        public Product GetProduct() => _product;
    }
}
