namespace Chloe.Components.Contracts
{
    public interface IHelloWorld: IComponent<IHelloWorld>
    {
        string Message { get; set; }
        string PartialViewLocation { get; set; }
    }
}
