﻿using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TempleVolunteerAPI.Service;
using TempleVolunteerAPI.Domain;

namespace TempleVolunteerAPI.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("[controller]")]
    public class StaffController : ControllerBase
    {
        private readonly IStaffService _staffService;
        private readonly IMapper _mapper;
        private ServiceResponse<IList<Staff>> _collResponse;
        private ServiceResponse<Staff> _response;

        public StaffController(IStaffService staffService, IMapper mapper)
        {
            _staffService = staffService;
            _mapper = mapper;
            _collResponse = new ServiceResponse<IList<Staff>>();
            _response = new ServiceResponse<Staff>();
        }

        [HttpGet("GetAllAsync")]
        public async Task<ServiceResponse<IList<Staff>>> GetAllAsync()
        {
            _collResponse.Data = _mapper.Map<IList<Staff>>(await ReturnCollection());
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpGet("GetByIdAsync")]
        public async Task<ServiceResponse<Staff>> GetByIdAsync(int id)
        {
            _response.Data = _mapper.Map<Staff>(await _staffService.GetAsync(id));
            _response.Success = _response.Data != null ? true : false;

            return _response;
        }

        [HttpPost("PostAsync")]
        public async Task<ServiceResponse<IList<Staff>>> PostAsync([FromBody] StaffResponse request)
        {
            if (await _staffService.AddAsync(_mapper.Map<Staff>(request)))
            {
                _collResponse.Data = _mapper.Map<IList<Staff>>(await ReturnCollection());
                _collResponse.Success = _collResponse.Data != null ? true : false;

                return _collResponse;
            }
            else
            {
                throw new Exception("Unable to create Staff");
            }
        }

        [HttpPut("PutAsync")]
        public async Task<ServiceResponse<IList<Staff>>> PutAsync([FromBody] StaffResponse request)
        {
            if (await _staffService.UpdateAsync(_mapper.Map<Staff>(request)))
            {
                _collResponse.Data = _mapper.Map<IList<Staff>>(await ReturnCollection());
                _collResponse.Success = _collResponse.Data != null ? true : false;

                return _collResponse;
            }
            else
            {
                throw new Exception("Unable to update Staff");
            }
        }

        [HttpDelete("DeleteAsync")]
        public async Task<ServiceResponse<IList<Staff>>> DeleteAsync(int id)
        {
            if (await _staffService.DeleteAsync(id))
            {
                _collResponse.Data = _mapper.Map<IList<Staff>>(await ReturnCollection());
                _collResponse.Success = _collResponse.Data != null ? true : false;

                return _collResponse;
            }
            else
            {
                throw new Exception("Unable to delete Staff");
            }
        }

        private async Task<IList<Staff>> ReturnCollection()
        {
            return await _staffService.GetAllAsync();
        }
    }
}