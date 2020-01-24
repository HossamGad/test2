using Nasa.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Nasa.Domain.Services;
using Nasa.Domain.Repositories;

namespace Nasa.Services
{
	public class CategoryService: ICategoryService
	{
        private readonly ICategoryRepository _categoryRepository;



        public CategoryService(ICategoryRepository categoryRepository)

        {

            this._categoryRepository = categoryRepository;

        }



        public async Task<IEnumerable<Category>> ListAsync()

        {

            return await _categoryRepository.ListAsync();

        }
    }
}
