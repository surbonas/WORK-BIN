using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SandboxShared;

namespace GitSandboxProject
{
    class Program
    {
        private static SandboxClass sandbox;
        private static SharedClassExtended extendedSharedClass;

        static void Main(string[] args)
        {
            sandbox = new SandboxClass();
            sandbox.DoSomething("another param");

            extendedSharedClass = new SharedClassExtended();
            sandbox.DoSomething(string.Empty);
        }

    }
}
