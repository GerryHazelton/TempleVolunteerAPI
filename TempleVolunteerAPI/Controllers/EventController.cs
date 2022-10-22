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
    public class EventController : ControllerBase
    {
        private readonly IEventService _eventService;
        private readonly IMapper _mapper;
        private ServiceResponse<IList<EventRequest>> _collResponse;
        private ServiceResponse<EventResponse> _response;

        public EventController(IEventService EventService, IMapper mapper)
        {
            _eventService = EventService;
            _mapper = mapper;
            _collResponse = new ServiceResponse<IList<EventRequest>>();
            _response = new ServiceResponse<EventResponse>();
        }
    }
}
