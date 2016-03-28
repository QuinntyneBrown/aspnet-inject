using System;
using Chloe.Components.Contracts;


namespace Chloe.Web.Components
{
    public class HelloWorld: IHelloWorld
    {
        public HelloWorld()
        {
            this.Message = "Hello from Web Project";
        }

        public string Message { get; set; }

        public IHelloWorld Invoke()
        {
            return new HelloWorld() { Message = "Hello from Web Project" };
        }
    }
}