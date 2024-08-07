using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary2
{
    internal class InheritFromAccessDemo : AccessDemo
    {
        public void Test()
        {
            ProtectedDemo();
            internalProtectedDemo();
            privateProtectedDemo();
            //privateDemo();

        }
    }
}
