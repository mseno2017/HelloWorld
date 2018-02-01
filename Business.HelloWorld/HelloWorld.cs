using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.HelloWorld
{
    public class HelloWorld : IHelloWorld
    {
        public virtual string Message { get; set; }
    }
}
