using Chloe.Components.Contracts;
namespace Chloe.Web
{
    public class PartialHelloWorld : IPartialHelloWorld
    {
        public string Message { get; set; }

        public IPartialHelloWorld Invoke()
        {
            return new PartialHelloWorld() { Message = "Partial Hello World!" };
        }
    }
}