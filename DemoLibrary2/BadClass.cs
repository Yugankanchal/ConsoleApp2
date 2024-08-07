using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary2
{
    public class BadClass
    {
        private int _age;
        public int Age 
        { 
            get { return _age; }
            set 
            { 
                if(value >= 0 && value < 130)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("Enter a Valid Age:");
                    _age = -1;
                }
            }
        }



    }
}
