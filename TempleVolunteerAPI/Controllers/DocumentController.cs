using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Domain.DTO;
using TempleVolunteerAPI.Service;
using static TempleVolunteerAPI.Common.EnumHelper;

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
        private bool _result;

        public DocumentController(IDocumentService documentService, IMapper mapper, ISupplyItemService supplyItemService)
        {
            _documentService = documentService;
            _mapper = mapper;
            _collResponse = new ServiceResponse<IList<DocumentRequest>>();
            _response = new ServiceResponse<DocumentResponse>();
        }

        [HttpGet("GetAllAsync")]
        public ServiceResponse<IList<DocumentRequest>> GetAllAsync(int propertyId, string userId)
        {
            _collResponse.Data = _mapper.Map<IList<DocumentRequest>>(ReturnCollection(propertyId, userId));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpGet("GetByIdAsync")]
        public ServiceResponse<DocumentResponse> GetByIdAsync(int id, int propertyId, string userId)
        {
            _response.Data = _mapper.Map<DocumentResponse>(_documentService.FindByCondition(x => x.DocumentId == id && x.PropertyId == propertyId && x.CreatedBy == userId, propertyId, userId, WithDetails.No));
            _response.Success = _response.Data != null ? true : false;

            return _response;
        }

        [HttpPost("PostAsync")]
        public ServiceResponse<IList<DocumentRequest>> PostAsync([FromBody] DocumentRequest request)
        {
            Document document = _mapper.Map<Document>(request);
            document = (Document)_documentService.Create(document, request.PropertyId, request.CreatedBy);
            _collResponse.Data = _mapper.Map<IList<DocumentRequest>>(ReturnCollection(request.PropertyId, request.CreatedBy));
            _collResponse.Success = document != null ? true : false;

            return _collResponse;
        }

        [HttpPut("PutAsync")]
        public ServiceResponse<IList<DocumentRequest>> PutAsync([FromBody] DocumentRequest request)
        {
            Document document = _documentService.FindByCondition(x => x.DocumentId == request.DocumentId, request.PropertyId, request.UpdatedBy, WithDetails.No).FirstOrDefault();
            document = _mapper.Map<Document>(request);

            _result = _documentService.Update(document, request.PropertyId, request.CreatedBy);
            _collResponse.Data = _mapper.Map<IList<DocumentRequest>>(ReturnCollection(request.PropertyId, request.UpdatedBy));
            _collResponse.Success = _result ? true : false;

            return _collResponse;
        }

        [HttpDelete("DeleteAsync")]
        public ServiceResponse<IList<DocumentRequest>> DeleteAsync(MiscRequest request)
        {
            Document document = _documentService.FindByCondition(x => x.DocumentId == request.DeleteById, request.PropertyId, request.UserId, WithDetails.No).FirstOrDefault();

            _result = _documentService.Delete(document, request.PropertyId, request.UserId);
            _collResponse.Data = _mapper.Map<IList<DocumentRequest>>(ReturnCollection(request.PropertyId, request.UserId));
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        private IList<Document> ReturnCollection(int propertyId, string userId)
        {
            return _documentService.FindAll(propertyId, userId).ToList();
        }
    }
}
