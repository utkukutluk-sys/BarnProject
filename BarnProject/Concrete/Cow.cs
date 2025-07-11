using BarnProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarnProject.Concrete
{
    public class Cow : Animal
    {
        public static int cowCount = 0;
        public Cow()
        {
            AnimalSpecies = "Cow";
            AnimalifePeriodByYear = 30;
            AnimalPrice = 1500;
            AnimalProductTimeByMonth = 6;
            
        }

        public override Product Produce()
        {
            return new Product
            {
                ProductName = "Milk",
                ProductPricePerUnit=110,
                isReadyToSell = false
            };
        }
    }
}
