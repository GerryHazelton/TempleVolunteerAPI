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
    public class DocumentController : ControllerBase
    {
        private readonly IDocumentService _documentService;
        private readonly IMapper _mapper;
        private ServiceResponse<IList<DocumentRequest>> _collResponse;
        private ServiceResponse<DocumentResponse> _response;

        public DocumentController(IDocumentService DocumentService, IMapper mapper)
        {
            _documentService = DocumentService;
            _mapper = mapper;
            _collResponse = new ServiceResponse<IList<DocumentRequest>>();
            _response = new ServiceResponse<DocumentResponse>();
        }
    }
}
