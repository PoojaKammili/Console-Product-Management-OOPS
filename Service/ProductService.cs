using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shopping_Cart.Models;

namespace Shopping_Cart.Service
{
    public class ProductService
    {
        private static List<Product> products = new List<Product>();
        static int id = 1;
       
        //physical product/online product

        //create
        public Product AddProduct()
        {
            Console.WriteLine("Enter product type (1: Physical, 2: Online):");
            string Type = Console.ReadLine();
            Product product = null;
            if (Type == "1")
            {
                Console.WriteLine("Enter the name of the product");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the price of the product");
                decimal price = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Enter the weight of the product");
                double weight = Convert.ToDouble(Console.ReadLine());
                product = new PhysicalProduct(id++, name, price, weight);
                products.Add(product);
                Console.WriteLine();
                product.DisplayInfo();
                Console.WriteLine("physical product added successfully");
            }
            else if (Type == "2") 
            {
                Console.WriteLine("Enter the name of the product");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the price of the product");
                decimal price = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Enter the fileformat of the product");
                string fileformat = Console.ReadLine();
                product = new OnlineProduct(id++, name, price, fileformat);
                products.Add(product);
                Console.WriteLine();
                product.DisplayInfo();
                Console.WriteLine("online product added successfully");
            }
            return product;
        }

        //readall
        public List<Product> Display()
        {
            Console.WriteLine("Choose type to display: 1 - PhysicalProducts, 2 - OnlineProducts, 3 - AllProducts");
            string type = Console.ReadLine();
            List<Product> filteredProducts = new List<Product>();

            if (type == "1")
            {
                filteredProducts = products.Where(p => p is PhysicalProduct).ToList();
                if (filteredProducts.Count == 0)
                {
                    Console.WriteLine("No Physical Products found!");
                }
                else
                {
                    Console.WriteLine("\n--- Physical Products ---");
                    Console.WriteLine();
                    foreach (var p in filteredProducts)
                        p.DisplayInfo();
                }
            }
            else if (type == "2")
            {
                filteredProducts = products.Where(p => p is OnlineProduct).ToList();
                if (filteredProducts.Count == 0)
                {
                    Console.WriteLine("No Online Products found!");
                }
                else
                {
                    Console.WriteLine("\n--- Online Products ---");
                    Console.WriteLine();
                    foreach (var p in filteredProducts)
                        p.DisplayInfo();
                }
            }
            else
            {
                if (products.Count == 0)
                {
                    Console.WriteLine("No products found!");
                }
                else
                {
                    Console.WriteLine("\n--- All Products ---");
                    Console.WriteLine();
                    foreach (var p in products)
                        p.DisplayInfo();
                    //filteredProducts = products;
                }
            }

            return filteredProducts;
        }


        //display by id 
        public void DisplayById()
        {
            Console.WriteLine("Enter the id of the product you want to display");
            int id = Convert.ToInt32(Console.ReadLine());
            var product = products.FirstOrDefault(p=>p.Id == id);
            if(product != null)
            {
                product.DisplayInfo();
            }
            else
            {
                Console.WriteLine("No product found with given id");
            }
        }

        //update by id 
        public Product Update(string find_product)
        {
            Console.WriteLine();
            
            var product = products.FirstOrDefault(p => p.Name.Equals(find_product, StringComparison.OrdinalIgnoreCase));
            if (product != null)
            {
                Console.WriteLine($"This is the price of {find_product} before update");
                product.DisplayInfo();
                product.Price = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"This is the price of {find_product} before update");
                Console.WriteLine();
                product.DisplayInfo();
                Console.WriteLine("product updated successfully");
            }
            else
            {
                Console.WriteLine("No product found");
            }
            
            return product;
        }

        //delete by id 
        public void Delete(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if(product == null)
            {
                Console.WriteLine("No product found with this id");
            }
            products.Remove(product);
            Console.WriteLine();
            Console.WriteLine("product deleted successfully");
        }
    } 
}
    

