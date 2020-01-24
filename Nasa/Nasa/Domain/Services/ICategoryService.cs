using Nasa.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nasa.Domain.Services
{
    public interface ICategoryService

    {
          Task<IEnumerable<Category>> ListAsync();
	}
}
