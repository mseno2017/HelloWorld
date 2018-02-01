using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.HelloWorld
{
    public class HelloWorldMessenger: HelloWorld
    {        
        public HelloWorldMessenger(string message)
        {
            Message = message;
        }

        public override string Message { get; set; }
    }
}
