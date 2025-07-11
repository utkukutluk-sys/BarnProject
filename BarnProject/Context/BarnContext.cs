using BarnProject.Abstract;
using BarnProject.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarnProject.Context
{
    public class BarnContext :DbContext
    {
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
