using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary2
{
    public class CourseProductModel : IProductModel
    {
        public string Title { get; set ; }

        public bool HasOrderBeenCompleted { get; private set; }

        public void shipItem(CustomerModel customer)
        {
            Console.WriteLine($"Added {Title} to {customer.FirstName} account's");
        }
    }
}
