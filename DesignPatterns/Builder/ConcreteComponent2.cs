namespace DesignPatterns
{
    public class ConcreteComponent2 : IComponent
    {
        private string _name;

        public ConcreteComponent2(string name)
        {
            _name = name;
        }

        public override string ToString() => this.GetType().Name + "[" + _name + "]";
    }
}
