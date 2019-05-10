using System.Collections.Generic;

namespace DesignPatterns
{
    /// <summary>
    /// The product and components classes that will be used in the assemble process in the builders.
    /// </summary>
    public class Product
    {
        private List<IComponent> _components = new List<IComponent>();

        public void AddComponents(List<IComponent> comps) => _components.AddRange(comps);

        public override string ToString() => "Product components: " + string.Join("", _components);
    }
}
