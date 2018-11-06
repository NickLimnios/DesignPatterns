namespace DesignPatterns
{
    public class MiddlewareFactory
    {
        public IMiddleware GetMiddleware<T>() where T : IMiddleware, new()
        {
            return new T();
        }
    }
}
