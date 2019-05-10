namespace DesignPatterns
{
    /// <summary>
    /// Each Builder create and assemble a kind of product with its components.
    /// </summary>
    public interface IBuilder
    {
        void BuildParts();
        Product GetProduct();
    }
}
