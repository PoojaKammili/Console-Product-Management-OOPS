using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Cart.Models
{
    public abstract class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Product(int id,string name,decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
        public abstract void DisplayInfo();
    }
}
