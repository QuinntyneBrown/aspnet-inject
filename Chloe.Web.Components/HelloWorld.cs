using System;
using Chloe.Components.Contracts;


namespace Chloe.Web.Components
{
    public class HelloWorld: IHelloWorld
    {
        public HelloWorld()
        {
        }

        public string Message { get; set; }

        public IHelloWorld Invoke()
        {
            return new HelloWorld() { Message = "Hello from Web Project", PartialViewLocation = Chloe.Core.Components.Constants.PartialHelloWorldViewLocation };
        }

        public string PartialViewLocation { get; set; }
    }
}