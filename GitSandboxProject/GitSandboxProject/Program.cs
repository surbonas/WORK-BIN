using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitSandboxProject
{
    class Program
    {
        private static SandboxClass sandbox;

        static void Main(string[] args)
        {
            sandbox = new SandboxClass();
            sandbox.DoSomething("param");

            BugFixClass.BugFixMethod();
        }

    }
}
