using Chloe.Components.Contracts;
using Chloe.Web.Components;

namespace Chloe.Web
{
    public class PartialHelloWorld : BaseComponent<IPartialHelloWorld>, IPartialHelloWorld
    {
        public string Message { get; set; }

        public override IPartialHelloWorld Invoke()
        {
            return new PartialHelloWorld() { Message = "Partial Hello World!" };
        }
    }
}