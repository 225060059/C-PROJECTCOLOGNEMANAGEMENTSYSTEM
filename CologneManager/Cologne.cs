using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CologneManager
{
    public class Cologne
    {
        // Properties
        public int Id { get; set; }
        public string Brand { get; set; } = "";
        public string Name { get; set; } = "";
        public decimal Price { get; set; }
        public string ImagePath { get; set; } = "";

        
        public int Stock { get; set; }

        // Constructor
        public Cologne(int id, string brand, string name, decimal price, string imagePath, int stock)
        {
            Id = id;
            Brand = brand;
            Name = name;
            Price = price;
            ImagePath = imagePath;
            Stock = stock;
        }

        // Allow creating without stock (defaults to 0)
        public Cologne(int id, string brand, string name, decimal price, string imagePath)
        {
            Id = id;
            Brand = brand;
            Name = name;
            Price = price;
            ImagePath = imagePath;
            Stock = 0;
        }
    }
}