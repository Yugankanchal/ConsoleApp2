using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary2
{
    public class PhysicalProductModel : IProductModel
    {
        public string Title { get; set; }

        public bool HasOrderBeenCompleted { get; private set; }

        public void shipItem(CustomerModel customer)
        {
            if (!HasOrderBeenCompleted)
            {

                Console.WriteLine($"Shipping {customer.FirstName + " " + customer.LastName}  product Name {Title} in the City Named: {customer.City}");
                HasOrderBeenCompleted = true;

            }

        }
    }
}
