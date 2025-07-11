using BarnProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarnProject.Concrete
{
    public class Product
    {
        public string ProductName { get; set; }
        public decimal ProductPricePerUnit { get; set; }
        public bool isReadyToSell { get; set; }
        public int ProductCount { get; set; } 

        
    }
}
