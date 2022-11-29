using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Service;
using static TempleVolunteerAPI.Common.EnumHelper;

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
        private ServiceResponse<CategoryRequest> _response;
        private bool _result;

        public CategoryController(ICategoryService CategoryService, IMapper mapper)
        {
            _categoryService = CategoryService;
            _mapper = mapper;
            _collResponse = new ServiceResponse<IList<CategoryRequest>>();
            _response = new ServiceResponse<CategoryRequest>();
        }

        [HttpGet("GetAllAsync")]
        public ServiceResponse<IList<CategoryRequest>> GetAllAsync(int propertyId, string userId)
        {
            _collResponse.Data = _mapper.Map<IList<CategoryRequest>>(ReturnCollection(propertyId, userId));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpGet("GetByIdAsync")]
        public ServiceResponse<CategoryRequest> GetByIdAsync(int id, int propertyId, string userId)
        {
            var category = _categoryService.FindByCondition(x => x.CategoryId == id && x.PropertyId == propertyId, propertyId, userId, WithDetails.Yes).FirstOrDefault();
            _response.Data = _mapper.Map<CategoryRequest>(category);
            _response.Success = _response.Data != null ? true : false;

            return _response;
        }

        [HttpPost("PostAsync")]
        public ServiceResponse<IList<CategoryRequest>> PostAsync([FromBody] CategoryRequest request)
        {
            Category category = _mapper.Map<Category>(request);
            category = (Category)_categoryService.Create(category, request.PropertyId, request.CreatedBy);
            _result = _categoryService.Update(category, request.PropertyId, request.CreatedBy);
            _collResponse.Data = _mapper.Map<IList<CategoryRequest>>(ReturnCollection(request.PropertyId, request.CreatedBy));
            _collResponse.Success = _result;

            return _collResponse;
        }

        [HttpPut("PutAsync")]
        public ServiceResponse<IList<CategoryRequest>> PutAsync([FromBody] CategoryRequest request)
        {
            Category category = _categoryService.FindByCondition(x => x.CategoryId == request.CategoryId, request.PropertyId, request.UpdatedBy, WithDetails.Yes).FirstOrDefault();
            category = _mapper.Map<Category>(request);

            _result = _categoryService.Update(category, request.PropertyId, request.CreatedBy);
            _collResponse.Data = _mapper.Map<IList<CategoryRequest>>(ReturnCollection(request.PropertyId, request.UpdatedBy));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpDelete("DeleteAsync")]
        public ServiceResponse<IList<CategoryRequest>> DeleteAsync(int categoryId, int propertyId, string userId)
        {
            Category category = _categoryService.FindByCondition(x => x.CategoryId == categoryId, propertyId, userId, WithDetails.Yes).FirstOrDefault();

            _result = _categoryService.Delete(category, propertyId, userId);
            _collResponse.Data = _mapper.Map<IList<CategoryRequest>>(ReturnCollection(propertyId, userId));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        private IList<Category> ReturnCollection(int propertyId, string userId)
        {
            return _categoryService.FindAll(propertyId, userId).ToList();
        }
    }
}
