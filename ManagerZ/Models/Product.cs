using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerZ.Models
{
    class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; } // Where i get error

        public string Category { get; set; }

        public double Cost { get; set; }

        public double FinalPrice { get { return Price - Cost; } set { FinalPrice = Price - Cost; } }
    }
}
