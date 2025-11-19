namespace Lecture09
{
    using System;
    using Lecture08.Models;
    using Lecture08.Repositories;
   

    class Program{
        static void Main(string [] args){
        Console.WriteLine("=== LIST REPOSITORY DEMO ===");
        DemoListRepository();
        
        Console.WriteLine("\n=== ARRAY REPOSITORY DEMO ===");
        DemoArrayRepository();
        }

        public static void DemoListRepository()
        {
            IReopsitory<Customer> customerRepo = new ListRepository<Customer>();
            
            // Add customers
            customerRepo.Add(new Customer { Name = "John Doe", Email = "john@email.com" });
            customerRepo.Add(new Customer { Name = "Jane Smith", Email = "jane@email.com" });
            
            // Get all customers
            var allCustomers = customerRepo.GetAll();
            Console.WriteLine($"Total customers: {customerRepo.Count}");
            foreach (var customer in allCustomers)
            {
                Console.WriteLine(customer);
            }
            
            // Update a customer
            var john = customerRepo.GetById(1);
            if (john != null)
            {
                john.Email = "john.doe@newemail.com";
                customerRepo.Update(john);
            }
            
            // Delete a customer
            var customerToDelete = customerRepo.GetById(2);
            customerRepo.Delete(customerToDelete);
        }

        public static void DemoArrayRepository()
        {
            IReopsitory<Product> productRepo = new ArrayRepository<Product>(3);
            
            // Add products
            productRepo.Add(new Product { Name = "Laptop", Price = 999.99m });
            productRepo.Add(new Product { Name = "Mouse", Price = 29.99m });
            productRepo.Add(new Product { Name = "Keyboard", Price = 79.99m });
            
            // Get all products
            var allProducts = productRepo.GetAll();
            Console.WriteLine($"Total products: {productRepo.Count}");
            foreach (var product in allProducts)
            {
                Console.WriteLine(product);
            }
            
            // Test array resizing by adding more items
            for (int i = 0; i < 15; i++)
            {
                productRepo.Add(new Product { Name = $"Product {i}", Price = i * 10 });
            }
            Console.WriteLine($"After adding more: {productRepo.Count} products");
        }
    }
}