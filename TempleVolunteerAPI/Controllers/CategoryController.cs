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

        [HttpGet("GetAllAsync")]
        public async Task<ServiceResponse<IList<CategoryRequest>>> GetAllAsync(int propertyId, string userId)
        {
            _collResponse.Data = _mapper.Map<IList<CategoryRequest>>(await ReturnCollection(propertyId, userId));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpGet("GetByIdAsync")]
        public async Task<ServiceResponse<CategoryResponse>> GetByIdAsync(int id, int propertyId, string userId)
        {
            _response.Data = _mapper.Map<CategoryResponse>(await _categoryService.GetByIdAsync(id, propertyId, userId));
            _response.Success = _response.Data != null ? true : false;

            return _response;
        }

        [HttpPost("PostAsync")]
        public async Task<ServiceResponse<IList<CategoryRequest>>> PostAsync([FromBody] CategoryRequest request)
        {
            await _categoryService.AddAsync(_mapper.Map<Category>(request), request.PropertyId, request.UpdatedBy);
            _collResponse.Data = _mapper.Map<IList<CategoryRequest>>(await ReturnCollection(request.PropertyId, request.CreatedBy));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpPut("PutAsync")]
        public async Task<ServiceResponse<IList<CategoryRequest>>> PutAsync([FromBody] CategoryRequest request)
        {
            await _categoryService.UpdateAsync(_mapper.Map<Category>(request), request.PropertyId, request.CreatedBy);
            _collResponse.Data = _mapper.Map<IList<CategoryRequest>>(await ReturnCollection(request.PropertyId, request.UpdatedBy));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpDelete("DeleteAsync")]
        public async Task<ServiceResponse<IList<CategoryRequest>>> DeleteAsync(MiscRequest request)
        {
            await _categoryService.DeleteAsync(request.DeleteById, request.PropertyId, request.UserId);
            _collResponse.Data = _mapper.Map<IList<CategoryRequest>>(await ReturnCollection(request.PropertyId, request.UserId));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        private async Task<IList<Category>> ReturnCollection(int propertyId, string userId)
        {
            return await _categoryService.GetAllAsync(propertyId, userId);
        }
    }
}
