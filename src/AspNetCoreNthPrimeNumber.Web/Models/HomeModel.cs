using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreNthPrimeNumber.Web.Models
{
    public class HomeModel
    {
        public int? Nth { get; set; }
        public long? NthPrime { get; set; }
    }
}
