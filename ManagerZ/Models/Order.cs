using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerZ.Models
{
    public partial class Order
    {
        public int Id { get; set; }

        public string Status { get; set; }

        public DateTime Date { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public string Name { get; set; }

        public decimal Cost { get; set; }

        public int ProductCount { get; set; }

        public string ProductIds { get; set; }

        public string Note { get; set; }

    }
}
