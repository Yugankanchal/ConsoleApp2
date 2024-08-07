using DemoLibrary2;
using System;

namespace ConsoleApp2
{
    
    class Program
    {
        static void Main(string[] args)
        {
            List<IProductModel> cart = AddSampleData();
            CustomerModel customer = getCustomer();
            foreach (var product in cart) 
            {
                product.shipItem(customer);
                if (product is IDigitalProductModel digital)
                {
                    Console.WriteLine($"Total Numbers of downloads Left are {digital.TotalDownloadsLeft}");
                }
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

        private static List<IProductModel> AddSampleData()
        {
            List<IProductModel> output = new List<IProductModel>();
            output.Add(new PhysicalProductModel { Title = "Nerf Blaster" });
            output.Add(new PhysicalProductModel { Title = "Hard Drive" });
            output.Add(new PhysicalProductModel { Title = "Jordan Shoes" });
            output.Add(new DigitalProduct { Title= "Digital Service Product"});
            output.Add(new DigitalProduct { Title = "Digital Service Product" });
            output.Add(new CourseProductModel { Title = "Dotnet FullStack Course" });
            return output;
        }
    }
    

}