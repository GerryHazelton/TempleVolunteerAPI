﻿using AutoMapper;
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
    public class StaffController : ControllerBase
    {
        private readonly IStaffService _staffService;
        private readonly IMapper _mapper;
        private ServiceResponse<IList<StaffRequest>> _collResponse;
        private ServiceResponse<StaffRequest> _response;

        public StaffController(IStaffService StaffService, IMapper mapper)
        {
            _staffService = StaffService;
            _mapper = mapper;
            _collResponse = new ServiceResponse<IList<StaffRequest>>();
            _response = new ServiceResponse<StaffRequest>();
        }

        [HttpGet("GetAllAsync")]
        public async Task<ServiceResponse<IList<StaffRequest>>> GetAllAsync(int propertyId, string userId)
        {
            _collResponse.Data = _mapper.Map<IList<StaffRequest>>(await ReturnCollection(propertyId, userId));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpGet("GetByIdAsync")]
        public async Task<ServiceResponse<StaffRequest>> GetByIdAsync(int id, int propertyId, string userId)
        {
            _response.Data = _mapper.Map<StaffRequest>(await _staffService.GetByIdAsync(id, propertyId, userId));
            _response.Success = _response.Data != null ? true : false;

            return _response;
        }

        [HttpPost("PostAsync")]
        public async Task<ServiceResponse<IList<StaffRequest>>> PostAsync([FromBody] StaffRequest request)
        {
            await _staffService.AddAsync(_mapper.Map<Staff>(request), request.StaffId, request.UpdatedBy);
            _collResponse.Data = _mapper.Map<IList<StaffRequest>>(await ReturnCollection(request.StaffId, request.CreatedBy));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpPut("PutAsync")]
        public async Task<ServiceResponse<IList<StaffRequest>>> PutAsync([FromBody] StaffRequest request)
        {
            await _staffService.UpdateAsync(_mapper.Map<Staff>(request), request.StaffId, request.CreatedBy);
            _collResponse.Data = _mapper.Map<IList<StaffRequest>>(await ReturnCollection(request.StaffId, request.UpdatedBy));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpDelete("DeleteAsync")]
        public async Task<ServiceResponse<IList<StaffRequest>>> DeleteAsync([FromBody] MiscRequest request)
        {
            await _staffService.DeleteAsync(request.DeleteById, request.PropertyId, request.UserId);
            _collResponse.Data = _mapper.Map<IList<StaffRequest>>(await ReturnCollection(request.PropertyId, request.UserId));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        private async Task<IList<Staff>> ReturnCollection(int StaffId, string userId)
        {
            return await _staffService.GetAllAsync(StaffId, userId);
        }
    }
}
