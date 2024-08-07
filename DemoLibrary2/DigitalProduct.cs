using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary2
{
    public class DigitalProduct : IDigitalProductModel
    {
        public string Title { get; set; }
        public bool HasOrderBeenCompleted { get; private set; }

        public int TotalDownloadsLeft { get; private set; } = 5;

        public void shipItem(CustomerModel customer)
        {
            if (!HasOrderBeenCompleted)
            {
                Console.WriteLine($"Emailing {Title} to {customer.FirstName} on emailaddress at {customer.EmailAddress}");
                TotalDownloadsLeft -= 1;
                if(TotalDownloadsLeft < 1)
                {
                    TotalDownloadsLeft = 0;
                    HasOrderBeenCompleted = true;
                }
            }
        }
    }
}
