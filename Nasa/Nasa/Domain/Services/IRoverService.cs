using Nasa.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nasa.Domain.Services
{
	public interface IRoverService
	{
		Task<IEnumerable<Rovers>> ListAsync();

	}
}
