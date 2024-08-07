using DemoLibrary2;
using System;

namespace ConsoleApp2
{
    
    class Program
    {
        static void Main(string[] args)
        {
            List<PhysicalProductModel> cart = AddSampleData();
            CustomerModel customer = getCustomer();
            foreach (var product in cart) 
            {
                product.shipItem(customer);
            }

        }

        private static CustomerModel getCustomer()
        {
            return new CustomerModel
            {
                FirstName = "Tim",
                LastName = "Sharma",
                City = "kerala",
                EmailAddress = "abc@gmail.com",
                PhoneNumber = "2312343243"

            };
        }

        private static List<PhysicalProductModel> AddSampleData()
        {
            List<PhysicalProductModel> output = new List<PhysicalProductModel>();
            output.Add(new PhysicalProductModel { Title = "Nerf Blaster" });
            output.Add(new PhysicalProductModel { Title = "Hard Drive" });
            output.Add(new PhysicalProductModel { Title = "Jordan Shoes" });
            return output;
        }
    }
    

}