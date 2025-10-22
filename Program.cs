using Shopping_Cart.Models;
using Shopping_Cart.Service;
using System;


namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            ProductService service = new ProductService();
            
            while (true)
            {
                Console.WriteLine("\n==============================");
                Console.WriteLine("Choose the option 1 - 6");
                Console.WriteLine("1 - Add product details");
                Console.WriteLine("2 - Display all / OnlineProducts / PhysicalProducts");
                Console.WriteLine("3 - Display one product by ID");
                Console.WriteLine("4 - Update product details");
                Console.WriteLine("5 - Delete a product from list");
                Console.WriteLine("6 - Exit");
                Console.WriteLine("==============================");
                int option=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (option)
                {
                    case 1:
                        //create
                        service.AddProduct();
                        break;

                    case 2:
                        //read
                        service.Display();
                        break;

                    case 3:
                        //getbyid
                        service.DisplayById();
                        break;

                    case 4:
                        //update
                        Console.WriteLine("add the name of the product to update the price");
                        string findproduct = Console.ReadLine();
                        service.Update(findproduct);
                        break;

                    case 5:
                        //delete 
                        Console.WriteLine("give the id of the product you want to update");
                        int i_d = Convert.ToInt32(Console.ReadLine());
                        service.Delete(i_d);
                        break;

                    case 6:
                        Console.WriteLine("Exit");
                        return;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }







           

            //read
            service.Display();

            //getbyid
            service.DisplayById();

            //update
            Console.WriteLine("add the name of the product to update the price");
            string find_product = Console.ReadLine();
            service.Update(find_product);

            //delete 
            Console.WriteLine("give the id of the product you want to update");
            int id = Convert.ToInt32(Console.ReadLine());
            service.Delete(id);
            

        
        }

    }
}