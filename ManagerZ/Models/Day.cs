using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerZ.Models
{
    class Day
    {
        public int Id { get; set; }

        public double TotalMade { get; set; }

        public double TotalSpent { get; set; }

        public int SoldProductsCount { get; set; }

        public string MostCommonProduct { get; set; }

        public string MostCommonCategory { get; set; }

        public DateTime Date { get { return DateTime.Now; } }
    }
}
