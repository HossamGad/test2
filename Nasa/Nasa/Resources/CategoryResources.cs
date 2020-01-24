using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nasa.Resources
{
	public class CategoryResources 
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int Antalhjul { get; set; }

		public int Hastighet { get; set; }
		public int Vikt { get; set; }
	}
}
