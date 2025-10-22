using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Cart.Models
{
    public class PhysicalProduct:Product
    {
        public double Weight {  get; set; }
        public PhysicalProduct(int id, string name, decimal price, double weight) : base(id, name, price) 
        { 
            Weight = weight;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"[Physical] ID: {Id}, Name: {Name}, Price: ${Price}, Format: {Weight}");
        }

    }
    public class OnlineProduct : Product
    {
        public string FileFormat { get; set; }
        public OnlineProduct(int id, string name, decimal price,string fileformat) : base(id, name, price) { FileFormat = fileformat; }

        
        public override void DisplayInfo()
        {
            Console.WriteLine($"[Digital] ID: {Id}, Name: {Name}, Price: {Price:C}, Format: {FileFormat}");
        }
    }
}
