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
    public class SupplyItemController : ControllerBase
    {
        private readonly ISupplyItemService _supplyItemService;
        private readonly IMapper _mapper;
        private ServiceResponse<IList<SupplyItemRequest>> _collResponse;
        private ServiceResponse<SupplyItemResponse> _response;

        public SupplyItemController(ISupplyItemService SupplyItemService, IMapper mapper)
        {
            _supplyItemService = SupplyItemService;
            _mapper = mapper;
            _collResponse = new ServiceResponse<IList<SupplyItemRequest>>();
            _response = new ServiceResponse<SupplyItemResponse>();
        }
    }
}
