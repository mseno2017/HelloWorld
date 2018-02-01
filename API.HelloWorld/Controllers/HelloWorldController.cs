using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace API.HelloWorld.Controllers
{
    public class HelloWorldController : Controller
    {
        public string TestMessage { get { return "Hellowwww World..."; } }
            
        public string Get(string message)
        {
            var hello = new Business.HelloWorld.HelloWorldMessenger(message);
            return hello.Message;
        }
    }
}