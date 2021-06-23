using BestOil__MVP_Practice.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestOil__MVP_Practice.Data
{
    class GasOilContext:DbContext
    {
        public GasOilContext():base("GasOilDb2")
        {

        }
        public DbSet<GasOil> GasOils { get; set; }
    }
}
