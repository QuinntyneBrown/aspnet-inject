namespace Chloe.Components.Contracts
{
    public interface IPartialHelloWorld: IComponent<IPartialHelloWorld>
    {
        string Message { get; set; }
    }
}
