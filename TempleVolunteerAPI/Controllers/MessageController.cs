using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Service;

namespace TempleVolunteerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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


        [HttpPost("SendMessageAsync")]
        public async Task<ServiceResponse<Staff>> SendMessageAsync([FromBody] MessageRequest request)
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

        [HttpGet("GetAllMessagesByIdAsync")]
        public async Task<ServiceResponse<IList<Message>>> GetAllMessagesByIdAsync(int id, int propertyId, string userId)
        {
            ServiceResponse<IList<Message>> response = new ServiceResponse<IList<Message>>();

            response.Data = await _messageService.GetAllByIdAsync(userId);
            response.Success = true;
            response.Message = "Get All Messages by staffId successful (Service: GetAllMessagesByIdAsync)";

            return response;
        }

        [HttpGet("GetAllMessagesAsync")]
        public async Task<ServiceResponse<IList<Message>>> GetAllMessagesAsync(int propertyId, string userId)
        {
            ServiceResponse<IList<Message>> response = new ServiceResponse<IList<Message>>();

            response.Data = await _messageService.GetAllAsync();
            response.Success = true;
            response.Message = "Get All Messages (Service: GetAllMessagesAsync)";

            return response;
        }
    }
}
