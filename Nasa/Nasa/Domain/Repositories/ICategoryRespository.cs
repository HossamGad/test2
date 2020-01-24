using Nasa.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nasa.Domain.Repositories
{
    public interface ICategoryRepository

    {

        Task<IEnumerable<Category>> ListAsync();

    }
}
