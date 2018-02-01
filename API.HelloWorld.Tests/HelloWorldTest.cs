using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace API.HelloWorld.Tests
{
    [TestClass]
    public class HelloWorldTest
    {
        [TestMethod]
        public void GetHelloWorldMessage()
        {            
            var hello = new  API.HelloWorld.Controllers.HelloWorldController();            
            Assert.AreEqual(hello.TestMessage, hello.Get("Hellowwww World..."), true);
        }
    }
}
