using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nasa.Domain.Models
{
    public class Rovers
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Date { get; set; }

        public EUnitOfMeasurement UnitOfMeasurement { get; set; }

        public int CategoryId { get; set; }
        public int Antalhjul { get; set; }
         
        public int Hastighet { get; set; }
        public int  Vikt { get; set; }

        public Category Category { get; set; }
    }
}
