﻿using AutoMapper;
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

        public CategoryController(ICategoryService CategoryService, IMapper mapper, ISupplyItemService supplyItemService)
        {
            _categoryService = CategoryService;
            _mapper = mapper;
            _collResponse = new ServiceResponse<IList<CategoryRequest>>();
            _response = new ServiceResponse<CategoryResponse>();
        }

        [HttpGet("GetAll")]
        public ServiceResponse<IList<CategoryRequest>> GetAll(int propertyId, string userId)
        {
            _collResponse.Data = _mapper.Map<IList<CategoryRequest>>(ReturnCollection(propertyId, userId));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpGet("GetById")]
        public ServiceResponse<CategoryResponse> GetById(int id, int propertyId, string userId)
        {
            _response.Data = _mapper.Map<CategoryResponse>(_categoryService.FindByCondition(x => x.CategoryId == id && x.PropertyId == propertyId && x.CreatedBy == userId, propertyId, userId, WithDetails.None));
            _response.Success = _response.Data != null ? true : false;

            return _response;
        }

        [HttpPost("Post")]
        public ServiceResponse<IList<CategoryRequest>> Post([FromBody] CategoryRequest request)
        {
            Category category = _mapper.Map<Category>(request);
            category = (Category)_categoryService.Create(category, request.PropertyId, request.CreatedBy);
            _collResponse.Data = _mapper.Map<IList<CategoryRequest>>(ReturnCollection(request.PropertyId, request.CreatedBy));
            _collResponse.Success = category != null ? true : false;

            return _collResponse;
        }

        [HttpPut("Put")]
        public ServiceResponse<IList<CategoryRequest>> Put([FromBody] CategoryRequest request)
        {
            Category category = _categoryService.FindByCondition(x => x.CategoryId == request.CategoryId, request.PropertyId, request.UpdatedBy, WithDetails.None).FirstOrDefault();
            category = _mapper.Map<Category>(request);

            _result = _categoryService.Update(category, request.PropertyId, request.CreatedBy);
            _collResponse.Data = _mapper.Map<IList<CategoryRequest>>(ReturnCollection(request.PropertyId, request.UpdatedBy));
            _collResponse.Success = _result ? true : false;

            return _collResponse;
        }

        [HttpDelete("Delete")]
        public ServiceResponse<IList<CategoryRequest>> Delete(MiscRequest request)
        {
            Category category = _categoryService.FindByCondition(x => x.CategoryId == request.DeleteById, request.PropertyId, request.UserId, WithDetails.None).FirstOrDefault();

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
