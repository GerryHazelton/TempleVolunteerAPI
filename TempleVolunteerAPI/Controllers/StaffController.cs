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
    public class StaffController : ControllerBase
    {
        private readonly IStaffService _staffService;
        private readonly IMapper _mapper;
        private ServiceResponse<IList<StaffRequest>> _collResponse;
        private ServiceResponse<StaffRequest> _response;
        private bool _result;

        public StaffController(IStaffService StaffService, IMapper mapper)
        {
            _staffService = StaffService;
            _mapper = mapper;
            _collResponse = new ServiceResponse<IList<StaffRequest>>();
            _response = new ServiceResponse<StaffRequest>();
        }

        [HttpGet("GetAllAsync")]
        public ServiceResponse<IList<StaffRequest>> GetAllAsync(int propertyId, string userId)
        {
            _collResponse.Data = _mapper.Map<IList<StaffRequest>>(ReturnCollection(propertyId, userId));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpGet("GetByIdAsync")]
        public ServiceResponse<StaffRequest> GetByIdAsync(int id, int propertyId, string userId)
        {
            var staff = _staffService.FindByCondition(x => x.StaffId == id && x.PropertyId == propertyId, propertyId, userId, WithDetails.Yes).FirstOrDefault();
            _response.Data = _mapper.Map<StaffRequest>(staff);
            _response.Success = _response.Data != null ? true : false;

            return _response;
        }

        [HttpPost("PostAsync")]
        public ServiceResponse<IList<StaffRequest>> PostAsync([FromBody] StaffRequest request)
        {
            Staff staff = _mapper.Map<Staff>(request);
            staff = (Staff)_staffService.Create(staff, request.PropertyId, request.CreatedBy);
            _result = _staffService.Update(staff, request.PropertyId, request.CreatedBy);
            _collResponse.Data = _mapper.Map<IList<StaffRequest>>(ReturnCollection(request.PropertyId, request.CreatedBy));
            _collResponse.Success = _result;

            return _collResponse;
        }

        [HttpPut("PutAsync")]
        public ServiceResponse<IList<StaffRequest>> PutAsync([FromBody] StaffRequest request)
        {
            Staff staff = _staffService.FindByCondition(x => x.StaffId == request.StaffId, request.PropertyId, request.UpdatedBy, WithDetails.Yes).FirstOrDefault();
            staff = _mapper.Map<Staff>(request);

            _result = _staffService.Update(staff, request.PropertyId, request.CreatedBy);
            _collResponse.Data = _mapper.Map<IList<StaffRequest>>(ReturnCollection(request.PropertyId, request.UpdatedBy));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpDelete("DeleteAsync")]
        public ServiceResponse<IList<StaffRequest>> DeleteAsync(int staffId, int propertyId, string userId)
        {
            Staff staff = _staffService.FindByCondition(x => x.StaffId == staffId, propertyId, userId, WithDetails.Yes).FirstOrDefault();

            _result = _staffService.Delete(staff, propertyId, userId);
            _collResponse.Data = _mapper.Map<IList<StaffRequest>>(ReturnCollection(propertyId, userId));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        private IList<Staff> ReturnCollection(int propertyId, string userId)
        {
            return _staffService.FindAll(propertyId, userId).ToList();
        }
    }
}
