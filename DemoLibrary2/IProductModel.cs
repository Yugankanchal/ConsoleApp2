using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary2
{
    public interface IProductModel
    {
        public string Title { get; set; }

        public bool HasOrderBeenCompleted { get; }  // property signature

        public void shipItem(CustomerModel customer); // method signature


    }
}
