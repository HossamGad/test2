using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Mvc;
using Nasa.Domain.Models;
using Nasa.Domain.Services;
using Nasa.Resources;
using Nasa.Services;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Nasa.Controllers
{
    [Route("/api/[controller]")]

    public class RoversController : Controller

    {

        private readonly ICategoryService _categoryService;
       // private readonly Rovers _Rovers;
        private readonly IMapper _mapper;

        public RoversController(ICategoryService categoryService, IMapper mapper)

        {

            _categoryService = categoryService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IEnumerable<CategoryResources>> GetAllAsync()
        {
            var categories = await _categoryService.ListAsync();
            var resources = _mapper.Map<IEnumerable<Category>, IEnumerable<CategoryResources>>(categories);

            return resources;
        }

        /* [HttpGet]

         public async Task<IEnumerable<Category>> GetAllAsync()

         {

             var categories = await _categoryService.ListAsync();

             return categories;

         }*/
         [HttpGet("{Name}")]

         public async Task<ActionResult<CategoryResources>> Get(string Name)

         {

           // var result = await _categoryService.ListAsync();
            var result = await _categoryService.ListAsync();

            return _mapper.Map<CategoryResources>(result);

         }

    }
}
