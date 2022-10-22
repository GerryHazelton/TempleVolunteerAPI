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
    public class EventTypeController : ControllerBase
    {
        private readonly IEventTypeService _eventTypeService;
        private readonly IMapper _mapper;
        private ServiceResponse<IList<EventTypeRequest>> _collResponse;
        private ServiceResponse<EventTypeResponse> _response;

        public EventTypeController(IEventTypeService EventTypeService, IMapper mapper)
        {
            _eventTypeService = EventTypeService;
            _mapper = mapper;
            _collResponse = new ServiceResponse<IList<EventTypeRequest>>();
            _response = new ServiceResponse<EventTypeResponse>();
        }
    }
}
