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
    public class SupplyItemController : ControllerBase
    {
        private readonly ISupplyItemService _SupplyItemService;
        private readonly IMapper _mapper;
        private ServiceResponse<IList<SupplyItemResponse>> _collResponse;
        private ServiceResponse<SupplyItemResponse> _response;

        public SupplyItemController(ISupplyItemService SupplyItemService, IMapper mapper)
        {
            _SupplyItemService = SupplyItemService;
            _mapper = mapper;
            _collResponse = new ServiceResponse<IList<SupplyItemResponse>>();
            _response = new ServiceResponse<SupplyItemResponse>();
        }

        [HttpGet("GetAllAsync")]
        public async Task<ServiceResponse<IList<SupplyItemResponse>>> GetAllAsync()
        {
            _collResponse.Data = _mapper.Map<IList<SupplyItemResponse>>(await ReturnCollection());
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpGet("GetByIdAsync")]
        public async Task<ServiceResponse<SupplyItemResponse>> GetByIdAsync(int id)
        {
            _response.Data = _mapper.Map<SupplyItemResponse>(await _SupplyItemService.GetAsync(id));
            _response.Success = _response.Data != null ? true : false;

            return _response;
        }

        [HttpPost("PostAsync")]
        public async Task<ServiceResponse<IList<SupplyItemResponse>>> PostAsync([FromBody] SupplyItemResponse request)
        {
            if (await _SupplyItemService.AddAsync(_mapper.Map<SupplyItem>(request)))
            {
                _collResponse.Data = _mapper.Map<IList<SupplyItemResponse>>(await ReturnCollection());
                _collResponse.Success = _collResponse.Data != null ? true : false;

                return _collResponse;
            }
            else
            {
                throw new Exception("Unable to create SupplyItem");
            }
        }

        [HttpPut("PutAsync")]
        public async Task<ServiceResponse<IList<SupplyItemResponse>>> PutAsync([FromBody] SupplyItemResponse request)
        {
            if (await _SupplyItemService.UpdateAsync(_mapper.Map<SupplyItem>(request)))
            {
                _collResponse.Data = _mapper.Map<IList<SupplyItemResponse>>(await ReturnCollection());
                _collResponse.Success = _collResponse.Data != null ? true : false;

                return _collResponse;
            }
            else
            {
                throw new Exception("Unable to update SupplyItem");
            }
        }

        [HttpDelete("DeleteAsync")]
        public async Task<ServiceResponse<IList<SupplyItemResponse>>> DeleteAsync(int id)
        {
            if (await _SupplyItemService.DeleteAsync(id))
            {
                _collResponse.Data = _mapper.Map<IList<SupplyItemResponse>>(await ReturnCollection());
                _collResponse.Success = _collResponse.Data != null ? true : false;

                return _collResponse;
            }
            else
            {
                throw new Exception("Unable to delete SupplyItem");
            }
        }

        private async Task<IList<SupplyItem>> ReturnCollection()
        {
            return await _SupplyItemService.GetAllAsync();
        }
    }
}
