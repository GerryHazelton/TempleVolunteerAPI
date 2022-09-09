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
    public class DocumentController : ControllerBase
    {
        private readonly IDocumentService _documentService;
        private readonly IMapper _mapper;
        private ServiceResponse<IList<DocumentResponse>> _collResponse;
        private ServiceResponse<DocumentResponse> _response;

        public DocumentController(IDocumentService documentService, IMapper mapper)
        {
            _documentService = documentService;
            _mapper = mapper;
            _collResponse = new ServiceResponse<IList<DocumentResponse>>();
            _response = new ServiceResponse<DocumentResponse>();
        }

        [HttpGet("GetAllAsync")]
        public async Task<ServiceResponse<IList<DocumentResponse>>> GetAllAsync()
        {
            _collResponse.Data = _mapper.Map<IList<DocumentResponse>>(await ReturnCollection());
            _collResponse.Success = _collResponse.Data != null ? true : false;

            return _collResponse;
        }

        [HttpGet("GetByIdAsync")]
        public async Task<ServiceResponse<DocumentResponse>> GetByIdAsync(int id)
        {
            _response.Data = _mapper.Map<DocumentResponse>(await _documentService.GetAsync(id));
            _response.Success = _response.Data != null ? true : false;

            return _response;
        }

        [HttpPost("PostAsync")]
        public async Task<ServiceResponse<IList<DocumentResponse>>> PostAsync([FromBody] DocumentResponse request)
        {
            if (await _documentService.AddAsync(_mapper.Map<Document>(request)))
            {
                _collResponse.Data = _mapper.Map<IList<DocumentResponse>>(await ReturnCollection());
                _collResponse.Success = _collResponse.Data != null ? true : false;

                return _collResponse;
            }
            else
            {
                throw new Exception("Unable to create Document");
            }
        }

        [HttpPut("PutAsync")]
        public async Task<ServiceResponse<IList<DocumentResponse>>> PutAsync([FromBody] DocumentResponse request)
        {
            if (await _documentService.UpdateAsync(_mapper.Map<Document>(request)))
            {
                _collResponse.Data = _mapper.Map<IList<DocumentResponse>>(await ReturnCollection());
                _collResponse.Success = _collResponse.Data != null ? true : false;

                return _collResponse;
            }
            else
            {
                throw new Exception("Unable to update Document");
            }
        }

        [HttpDelete("DeleteAsync")]
        public async Task<ServiceResponse<IList<DocumentResponse>>> DeleteAsync(int id)
        {
            if (await _documentService.DeleteAsync(id))
            {
                _collResponse.Data = _mapper.Map<IList<DocumentResponse>>(await ReturnCollection());
                _collResponse.Success = _collResponse.Data != null ? true : false;

                return _collResponse;
            }
            else
            {
                throw new Exception("Unable to delete Document");
            }
        }

        private async Task<IList<Document>> ReturnCollection()
        {
            return await _documentService.GetAllAsync();
        }
    }
}
