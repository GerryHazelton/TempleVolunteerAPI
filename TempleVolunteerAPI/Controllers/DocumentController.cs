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

        [HttpGet("GetAllAsync")]
        public async Task<ServiceResponse<IList<DocumentRequest>>> GetAllAsync(int propertyId, string userId)
        {
            _collResponse.Data = _mapper.Map<IList<DocumentRequest>>(await ReturnCollection(propertyId, userId));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpGet("GetByIdAsync")]
        public async Task<ServiceResponse<DocumentResponse>> GetByIdAsync(int id, int propertyId, string userId)
        {
            _response.Data = _mapper.Map<DocumentResponse>(await _documentService.GetByIdAsync(id, propertyId, userId));
            _response.Success = _response.Data != null ? true : false;

            return _response;
        }

        [HttpPost("PostAsync")]
        public async Task<ServiceResponse<IList<DocumentRequest>>> PostAsync([FromBody] DocumentRequest request)
        {
            await _documentService.AddAsync(_mapper.Map<Document>(request), request.PropertyId, request.UpdatedBy);
            _collResponse.Data = _mapper.Map<IList<DocumentRequest>>(await ReturnCollection(request.PropertyId, request.CreatedBy));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpPut("PutAsync")]
        public async Task<ServiceResponse<IList<DocumentRequest>>> PutAsync([FromBody] DocumentRequest request)
        {
            await _documentService.UpdateAsync(_mapper.Map<Document>(request), request.PropertyId, request.CreatedBy);
            _collResponse.Data = _mapper.Map<IList<DocumentRequest>>(await ReturnCollection(request.PropertyId, request.UpdatedBy));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpDelete("DeleteAsync")]
        public async Task<ServiceResponse<IList<DocumentRequest>>> DeleteAsync(MiscRequest request)
        {
            await _documentService.DeleteAsync(request.DeleteById, request.PropertyId, request.UserId);
            _collResponse.Data = _mapper.Map<IList<DocumentRequest>>(await ReturnCollection(request.PropertyId, request.UserId));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        private async Task<IList<Document>> ReturnCollection(int propertyId, string userId)
        {
            return await _documentService.GetAllAsync(propertyId, userId);
        }
    }
}
