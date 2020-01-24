using Microsoft.EntityFrameworkCore;
using Nasa.Domain.Models;
using Nasa.Domain.Repositories;
using Nasa.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nasa.Persistence.Repositories
{
    public class CategoryRepository : BaseRepository, ICategoryRepository

    {

        public CategoryRepository(AppDbContext context) : base(context)

        {

        }



        public async Task<IEnumerable<Category>> ListAsync()

        {

            return await _context.rovers.ToListAsync();

        }

    }
}
