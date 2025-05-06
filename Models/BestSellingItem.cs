using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuApp.Models
{
    public class BestSellingItem
    {
        [PrimaryKey, AutoIncrement]
        public string Name { get; set; }
        public int TotalQuantity { get; set; }
        public decimal TotalRevenue { get; set; }

    }
}
