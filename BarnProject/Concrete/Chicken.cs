using BarnProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarnProject.Concrete
{
    public class Chicken : Animal
    {

        public static int chickenCount = 0;




        public Chicken()
        {
            AnimalSpecies = "Chicken";
            AnimalifePeriodByYear = 45;
            AnimalPrice = 800;
            AnimalProductTimeByMonth = 9;
            
        }

        public override Product Produce()
        {
            return new Product {
                ProductName="Egg",
                ProductPricePerUnit=100,
                isReadyToSell = false

            };
        }
    }
}
