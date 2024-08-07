using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class AccessDemo
    {
        public void publicDemo()
        {
            System.Console.WriteLine("publicDemo");
            privateDemo();
        }
        private void demo()
        {
            privateDemo();
        }
        private void privateDemo()
        {
            Console.WriteLine("Private Demo");
        }

        protected void protectedDemo()
        {

        }

        protected internal void protectedInternalDemo()
        {

        }
    }
}
