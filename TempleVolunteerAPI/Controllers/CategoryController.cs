using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TempleVolunteerAPI.Domain;
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
        private ServiceResponse<IList<CategoryResponse>> _collResponse;
        private ServiceResponse<CategoryResponse> _response;

        public CategoryController(ICategoryService CategoryService, IMapper mapper)
        {
            _categoryService = CategoryService;
            _mapper = mapper;
            _collResponse = new ServiceResponse<IList<CategoryResponse>>();
            _response = new ServiceResponse<CategoryResponse>();
        }

        [HttpGet("GetAllAsync")]
        public async Task<ServiceResponse<IList<CategoryResponse>>> GetAllAsync()
        {
            _collResponse.Data = _mapper.Map<IList<CategoryResponse>>(await ReturnCollection());
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpGet("GetByIdAsync")]
        public async Task<ServiceResponse<CategoryResponse>> GetByIdAsync(int id)
        {
            _response.Data = _mapper.Map<CategoryResponse>(await _categoryService.GetAsync(id));
            _response.Success = _response.Data != null ? true : false;

            return _response;
        }

        [HttpPost("PostAsync")]
        public async Task<ServiceResponse<IList<CategoryResponse>>> PostAsync([FromBody] CategoryResponse request)
        {
            if (await _categoryService.AddAsync(_mapper.Map<Category>(request)))
            {
                _collResponse.Data = _mapper.Map<IList<CategoryResponse>>(await ReturnCollection());
                _collResponse.Success = _collResponse.Data != null ? true : false;

                return _collResponse;
            }
            else
            {
                throw new Exception("Unable to create Category");
            }
        }

        [HttpPut("PutAsync")]
        public async Task<ServiceResponse<IList<CategoryResponse>>> PutAsync([FromBody] CategoryResponse request)
        {
            if (await _categoryService.UpdateAsync(_mapper.Map<Category>(request)))
            {
                _collResponse.Data = _mapper.Map<IList<CategoryResponse>>(await ReturnCollection());
                _collResponse.Success = _collResponse.Data != null ? true : false;

                return _collResponse;
            }
            else
            {
                throw new Exception("Unable to update Category");
            }
        }

        [HttpDelete("DeleteAsync")]
        public async Task<ServiceResponse<IList<CategoryResponse>>> DeleteAsync(int id)
        {
            if (await _categoryService.DeleteAsync(id))
            {
                _collResponse.Data = _mapper.Map<IList<CategoryResponse>>(await ReturnCollection());
                _collResponse.Success = _collResponse.Data != null ? true : false;

                return _collResponse;
            }
            else
            {
                throw new Exception("Unable to delete Category");
            }
        }

        private async Task<IList<Category>> ReturnCollection()
        {
            return await _categoryService.GetAllAsync();
        }
    }
}
