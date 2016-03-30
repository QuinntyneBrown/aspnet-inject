using Chloe.Components.Contracts;

namespace Chloe.Web.Components
{
    public abstract class BaseComponent<T> : IComponent<T>
    {
        public abstract T Invoke();

        public T Invoke(dynamic options)
        {
            return this.Invoke();
        }
    }
}