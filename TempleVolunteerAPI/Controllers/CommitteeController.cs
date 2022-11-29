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
    public class CommitteeController : ControllerBase
    {
        private readonly ICommitteeService _committeeService;
        private readonly IAreaCommitteeService _areaCommitteeService;
        private readonly IStaffService _staffService;
        private readonly ICommitteeStaffService _committeeStaffService;
        private readonly IAreaService _areaService;
        private readonly IMapper _mapper;
        private ServiceResponse<IList<CommitteeRequest>> _collResponse;
        private ServiceResponse<CommitteeRequest> _response;
        private bool _result;

        public CommitteeController(ICommitteeService CommitteeService, IMapper mapper, IAreaCommitteeService areaCommitteeService, IStaffService staffService, ICommitteeStaffService committeeStaffService, IAreaService areaService)
        {
            _committeeService = CommitteeService;
            _mapper = mapper;
            _collResponse = new ServiceResponse<IList<CommitteeRequest>>();
            _response = new ServiceResponse<CommitteeRequest>();
            _areaCommitteeService = areaCommitteeService;
            _staffService = staffService;
            _committeeStaffService = committeeStaffService;
            _areaService = areaService;
        }

        [HttpGet("GetAllAsync")]
        public ServiceResponse<IList<CommitteeRequest>> GetAllAsync(int propertyId, string userId)
        {
            _collResponse.Data = _mapper.Map<IList<CommitteeRequest>>(ReturnCollection(propertyId, userId));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpGet("GetByIdAsync")]
        public ServiceResponse<CommitteeRequest> GetByIdAsync(int id, int propertyId, string userId)
        {
            var committee = _committeeService.FindByCondition(x => x.CommitteeId == id && x.PropertyId == propertyId, propertyId, userId, WithDetails.Yes).FirstOrDefault();
            _response.Data = _mapper.Map<CommitteeRequest>(committee);

            if (committee.Areas.Count > 0)
            {
                _response.Data.AreaIds = new int[committee.Areas.Count];
                for (int i = 0; i < committee.Areas.Count; i++)
                {
                    _response.Data.AreaIds[i] = committee.Areas.ToList()[i].AreaId;
                }
            }

            if (committee.Staff.Count > 0)
            {
                _response.Data.StaffIds = new int[committee.Staff.Count];
                for (int i = 0; i < committee.Staff.Count; i++)
                {
                    _response.Data.StaffIds[i] = committee.Staff.ToList()[i].StaffId;
                }
            }

            _response.Success = _response.Data != null ? true : false;

            return _response;
        }

        [HttpPost("PostAsync")]
        public ServiceResponse<IList<CommitteeRequest>> PostAsync([FromBody] CommitteeRequest request)
        {
            Committee committee = _mapper.Map<Committee>(request);
            committee = (Committee)_committeeService.Create(committee, request.PropertyId, request.CreatedBy);

            if (request.AreaIds.Length > 0)
            {
                committee.Areas = GetAreas(committee, request.AreaIds, request.PropertyId, request.CreatedBy);
            }

            if (request.StaffIds.Length > 0)
            {
                committee.Staff = GetStaff(committee, request.StaffIds, request.PropertyId, request.CreatedBy);
            }

            _result = _committeeService.Update(committee, request.PropertyId, request.CreatedBy);
            _collResponse.Data = _mapper.Map<IList<CommitteeRequest>>(ReturnCollection(request.PropertyId, request.CreatedBy));
            _collResponse.Success = _result;

            return _collResponse;
        }

        [HttpPut("PutAsync")]
        public ServiceResponse<IList<CommitteeRequest>> PutAsync([FromBody] CommitteeRequest request)
        {
            Committee committee = _committeeService.FindByCondition(x => x.CommitteeId == request.CommitteeId, request.PropertyId, request.UpdatedBy, WithDetails.Yes).FirstOrDefault();
            committee = _mapper.Map<Committee>(request);

            if (committee.Areas != null && committee.Areas.Count > 0)
            {
                committee.Areas.Clear();
            }

            if (committee.Staff != null && committee.Staff.Count > 0)
            {
                committee.Staff.Clear();
            }

            var areaCommittees = _areaCommitteeService.FindByCondition(x => x.CommitteeId == committee.CommitteeId, request.PropertyId, request.UpdatedBy, WithDetails.No).ToList();

            foreach (AreaCommittee ac in areaCommittees)
            {
                _areaCommitteeService.Delete(ac, request.PropertyId, request.UpdatedBy);
            }

            if (request.AreaIds.Length > 0)
            {
                committee.Areas = GetAreas(committee, request.AreaIds, request.PropertyId, request.CreatedBy);
            }

            var committeeStaff = _committeeStaffService.FindByCondition(x => x.CommitteeId == committee.CommitteeId, request.PropertyId, request.UpdatedBy, WithDetails.No).ToList();

            foreach (CommitteeStaff cs in committeeStaff)
            {
                _committeeStaffService.Delete(cs, request.PropertyId, request.UpdatedBy);
            }

            if (request.StaffIds.Length > 0)
            {
                committee.Staff = GetStaff(committee, request.StaffIds, request.PropertyId, request.UpdatedBy);
            }

            _result = _committeeService.Update(committee, request.PropertyId, request.CreatedBy);
            _collResponse.Data = _mapper.Map<IList<CommitteeRequest>>(ReturnCollection(request.PropertyId, request.UpdatedBy));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpDelete("DeleteAsync")]
        public ServiceResponse<IList<CommitteeRequest>> DeleteAsync(int committeeId, int propertyId, string userId)
        {
            Committee committee = _committeeService.FindByCondition(x => x.CommitteeId == committeeId, propertyId, userId, WithDetails.Yes).FirstOrDefault();

            _result = _committeeService.Delete(committee, propertyId, userId);
            _collResponse.Data = _mapper.Map<IList<CommitteeRequest>>(ReturnCollection(propertyId, userId));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        private IList<AreaCommittee> GetAreas(Committee committee, int[] areaIds, int propertyId, string userId)
        {
            Area area;
            AreaCommittee addAreaCommittee;
            IList<AreaCommittee> areaCommittees = new List<AreaCommittee>();

            foreach (int areaId in areaIds)
            {
                area = _areaService.FindByCondition(x => x.AreaId == areaId, propertyId, userId, WithDetails.No).FirstOrDefault();
                addAreaCommittee = new AreaCommittee { Area = area, Committee = committee };
                areaCommittees.Add(addAreaCommittee);
            }

            return areaCommittees;
        }

        private IList<CommitteeStaff> GetStaff(Committee committee, int[] staffIds, int propertyId, string userId)
        {
            Staff staff;
            CommitteeStaff addCommitteeStaff;
            IList<CommitteeStaff> committeeStaff = new List<CommitteeStaff>();

            foreach (int staffId in staffIds)
            {
                staff = _staffService.FindByCondition(x => x.StaffId == staffId, propertyId, userId, WithDetails.No).FirstOrDefault();
                addCommitteeStaff = new CommitteeStaff { Committee = committee, Staff = staff };
                committeeStaff.Add(addCommitteeStaff);
            }

            return committeeStaff;
        }

        private IList<Committee> ReturnCollection(int propertyId, string userId)
        {
            return _committeeService.FindAll(propertyId, userId).ToList();
        }
    }
}
