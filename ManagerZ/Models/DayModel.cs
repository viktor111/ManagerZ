using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerZ.Models
{
    class DayModel
    {
        public int Id { get; set; }

        [LoadColumn(0)]
        public double TotalMade { get; set; }

        [LoadColumn(1)]
        public double TotalSpent { get; set; }

        [LoadColumn(2)]
        [ColumnName("Features")]
        [VectorType(1)]
        public int SoldProductsCount { get; set; }

        [LoadColumn(3)]
        public string MostCommonProduct { get; set; }

        [LoadColumn(4)]
        public string MostCommonCategory { get; set; }

        [LoadColumn(5)]
        public DateTime Date { get { return DateTime.Now; } }
    }
}
