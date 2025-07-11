using BarnProject.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarnProject.Abstract
{
    public abstract class Animal
    {
        public string AnimalSpecies { get; set; }
       public int AnimalAge { get; set; }
        public string AnimalGender { get; set; }
       public int AnimalifePeriodByYear { get; set; }
        public decimal AnimalPrice { get; set; }
        public int AnimalProductTimeByMonth { get; set; }
        public bool isProductCompleted { get; set; } = false;

        public abstract Product Produce();
        public bool IsAlive()
        {
            return AnimalifePeriodByYear - AnimalAge > 0;
        }
    }
}
