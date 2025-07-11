using BarnProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarnProject.Concrete
{
    public class Beef : Animal
    {
        public static int beefCount = 0;

        public Beef()
        {
            AnimalSpecies = "Beef";
            AnimalifePeriodByYear = 60;
            AnimalPrice = 2000;
            AnimalProductTimeByMonth = 12;
            
        }

        public override Product Produce()
        {
            return new Product
            {
                ProductName = "Meat",
                ProductPricePerUnit = 450,
                isReadyToSell = false
            };

        }


    }
}
