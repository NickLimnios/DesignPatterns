namespace DesignPatterns
{
    /// <summary>
    /// The director class doesn't create and assemble the objects directly.
    /// It refers to the Builder interface for building the parts of a 
    /// complex object.
    /// </summary>
    public class Director
    {
        public void Construct(IBuilder builder) => builder.BuildParts();
    }
}
