using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Domain.DTO;
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
        private ServiceResponse<CategoryResponse> _response;
        private bool _result;

        public CategoryController(ICategoryService categoryService, IMapper mapper, ISupplyItemService supplyItemService)
        {
            _categoryService = categoryService;
            _mapper = mapper;
            _collResponse = new ServiceResponse<IList<CategoryRequest>>();
            _response = new ServiceResponse<CategoryResponse>();
        }

        [HttpGet("GetAllAsync")]
        public ServiceResponse<IList<CategoryRequest>> GetAllAsync(int propertyId, string userId)
        {
            _collResponse.Data = _mapper.Map<IList<CategoryRequest>>(ReturnCollection(propertyId, userId));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpGet("GetByIdAsync")]
        public ServiceResponse<CategoryResponse> GetByIdAsync(int id, int propertyId, string userId)
        {
            _response.Data = _mapper.Map<CategoryResponse>(_categoryService.FindByCondition(x => x.CategoryId == id && x.PropertyId == propertyId && x.CreatedBy == userId, propertyId, userId, WithDetails.No));
            _response.Success = _response.Data != null ? true : false;

            return _response;
        }

        [HttpPost("PostAsync")]
        public ServiceResponse<IList<CategoryRequest>> PostAsync([FromBody] CategoryRequest request)
        {
            Category category = _mapper.Map<Category>(request);
            category = (Category)_categoryService.Create(category, request.PropertyId, request.CreatedBy);
            _collResponse.Data = _mapper.Map<IList<CategoryRequest>>(ReturnCollection(request.PropertyId, request.CreatedBy));
            _collResponse.Success = category != null ? true : false;

            return _collResponse;
        }

        [HttpPut("PutAsync")]
        public ServiceResponse<IList<CategoryRequest>> PutAsync([FromBody] CategoryRequest request)
        {
            Category category = _categoryService.FindByCondition(x => x.CategoryId == request.CategoryId, request.PropertyId, request.UpdatedBy, WithDetails.No).FirstOrDefault();
            category = _mapper.Map<Category>(request);

            _result = _categoryService.Update(category, request.PropertyId, request.CreatedBy);
            _collResponse.Data = _mapper.Map<IList<CategoryRequest>>(ReturnCollection(request.PropertyId, request.UpdatedBy));
            _collResponse.Success = _result ? true : false;

            return _collResponse;
        }

        [HttpDelete("DeleteAsync")]
        public ServiceResponse<IList<CategoryRequest>> DeleteAsync(MiscRequest request)
        {
            Category category = _categoryService.FindByCondition(x => x.CategoryId == request.DeleteById, request.PropertyId, request.UserId, WithDetails.No).FirstOrDefault();

            _result = _categoryService.Delete(category, request.PropertyId, request.UserId);
            _collResponse.Data = _mapper.Map<IList<CategoryRequest>>(ReturnCollection(request.PropertyId, request.UserId));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        private IList<Category> ReturnCollection(int propertyId, string userId)
        {
            return _categoryService.FindAll(propertyId, userId).ToList();
        }
    }
}
