using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nasa.Domain.Models
{
	public class Category
	{
        
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Rovers> Rovers { get; set; } = new List<Rovers>();
        public int Antalhjul { get; internal set; }
        public int Hastighet { get; internal set; }
        public int Vikt { get; internal set; }
    }
}
