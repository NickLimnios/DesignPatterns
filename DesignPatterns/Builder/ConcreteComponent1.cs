namespace DesignPatterns
{
    public class ConcreteComponent1 : IComponent
    {
        private string _name;

        public ConcreteComponent1(string name)
        {
            _name = name;
        }

        public override string ToString() => this.GetType().Name + "[" + _name + "]";
    }
}
