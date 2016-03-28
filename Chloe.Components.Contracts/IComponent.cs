namespace Chloe.Components.Contracts
{
    public interface IComponent<T>
    {
        T Invoke();
    }
}
