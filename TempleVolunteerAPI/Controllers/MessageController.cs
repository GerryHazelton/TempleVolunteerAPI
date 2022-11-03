using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Service;

namespace TempleVolunteerAPI.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("[controller]")]
    public class MessageController : ControllerBase
    {
        private readonly IEmailService _emailService;
        private readonly IMessageService _messageService;
        private readonly IConfiguration _config;
        private readonly IMapper _mapper;

        public MessageController(
            IEmailService emailService,
            IConfiguration config,
            IMapper mapper,
            IMessageService messageHistory)
        {
            _emailService = emailService;
            _config = config;
            _mapper = mapper;
            _messageService = messageHistory;
        }


        [HttpPost("SendAsync")]
        public async Task<ServiceResponse<Staff>> SendAsync([FromBody] MessageRequest request)
        {
            ServiceResponse<Staff> response = new ServiceResponse<Staff>();

            Message message = new Message(request.From);
            message.Subject = request.Subject;
            message.From = request.From;
            message.To = request.To;
            message.MessageSent = request.MessageSent;

            await _emailService.Send(request.To, request.Subject, request.MessageSent, request.From, request.PropertyId);
            await _messageService.AddAsync(message);

            response.Success = true;
            response.Message = "Send Message successful (Service: SendMessageEmailAsync)";

            return response;
        }

        [HttpGet("GetAllByIdAsync")]
        public async Task<ServiceResponse<IList<Message>>> GetAllByIdAsync(int id, int propertyId, string userId)
        {
            ServiceResponse<IList<Message>> response = new ServiceResponse<IList<Message>>();

            response.Data = await _messageService.GetAllByIdAsync(id);
            response.Success = true;
            response.Message = "Get All Messages by staffId successful (Service: GetAllMessagesByIdAsync)";

            return response;
        }

        [HttpGet("GetAllAsync")]
        public async Task<ServiceResponse<IList<Message>>> GetAllAsync(int propertyId, string userId)
        {
            ServiceResponse<IList<Message>> response = new ServiceResponse<IList<Message>>();

            response.Data = await _messageService.GetAllAsync(propertyId);
            response.Success = true;
            response.Message = "Get All Messages (Service: GetAllMessagesAsync)";

            return response;
        }
    }
}
