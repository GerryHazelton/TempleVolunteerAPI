using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Domain.DTO;
using TempleVolunteerAPI.Service;

namespace TempleVolunteerAPI.API
{
    //[Authorize]
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;
        private ServiceResponse<IList<CategoryRequest>> _collResponse;
        private ServiceResponse<CategoryResponse> _response;

        public CategoryController(ICategoryService CategoryService, IMapper mapper)
        {
            _categoryService = CategoryService;
            _mapper = mapper;
            _collResponse = new ServiceResponse<IList<CategoryRequest>>();
            _response = new ServiceResponse<CategoryResponse>();
        }
    }
}
