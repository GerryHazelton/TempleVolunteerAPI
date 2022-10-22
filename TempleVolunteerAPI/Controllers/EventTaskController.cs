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
    public class EventTaskController : ControllerBase
    {
        private readonly IEventTaskService _eventTaskService;
        private readonly IMapper _mapper;
        private ServiceResponse<IList<EventTaskRequest>> _collResponse;
        private ServiceResponse<EventTaskResponse> _response;

        public EventTaskController(IEventTaskService EventTaskService, IMapper mapper)
        {
            _eventTaskService = EventTaskService;
            _mapper = mapper;
            _collResponse = new ServiceResponse<IList<EventTaskRequest>>();
            _response = new ServiceResponse<EventTaskResponse>();
        }
    }
}
