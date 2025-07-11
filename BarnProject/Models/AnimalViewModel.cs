using BarnProject.Abstract;
using BarnProject.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarnProject.Models
{
   public class AnimalViewModel
    {
        [Browsable(false)]
        public Animal _animal { get; private set; }
        public string Type { get; set; }
        public int Count { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string ProductName { get; set; }
        public bool IsProductCompleted { get; set; }
         public AnimalViewModel(Animal animal) 
        {
            _animal = animal;
            if(animal.AnimalSpecies=="Chicken")
            {
                Type = animal.AnimalSpecies;
                Count = Chicken.chickenCount;
                Age = animal.AnimalAge;
                Gender = animal.AnimalGender;
                ProductName = new Chicken().Produce().ProductName;
                IsProductCompleted = animal.isProductCompleted;
            }
            else if(animal.AnimalSpecies=="Beef")
            {
                Type = animal.AnimalSpecies;
                Count = Beef.beefCount;
                Age = animal.AnimalAge;
                Gender = animal.AnimalGender;
                ProductName = new Beef().Produce().ProductName;
                IsProductCompleted = animal.isProductCompleted;
            }
            else if(animal.AnimalSpecies=="Cow")
            {
                Type = animal.AnimalSpecies;
                Count = Cow.cowCount ;
                Age = animal.AnimalAge;
                Gender = animal.AnimalGender;
                ProductName = new Cow().Produce().ProductName;
                IsProductCompleted = animal.isProductCompleted;
            }
        }

        public int getAnimalProductTimeByMonth(Animal animal)
        {
            if (animal.AnimalSpecies == "Chicken")
            {
                return new Chicken().AnimalProductTimeByMonth;
            }
            else if (animal.AnimalSpecies == "Cow")
            {
                return new Cow().AnimalProductTimeByMonth;
            }
            else if (animal.AnimalSpecies == "Beef")
            {
                return new Beef().AnimalProductTimeByMonth;
            }
            else
            {
                return 0;
            }
        }
      

        
        

    }
}
