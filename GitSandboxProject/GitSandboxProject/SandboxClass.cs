using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitSandboxProject
{
    public class SandboxClass
    {
        public void DoSomething(string someParam)
        {
            Console.WriteLine(someParam);
            Debug.WriteLine(someParam);
        }
    }
}
