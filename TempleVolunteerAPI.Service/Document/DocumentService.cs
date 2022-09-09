using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Repository;

namespace TempleVolunteerAPI.Service
{
    public class DocumentService : ServiceBase<Document>, IDocumentService
    {
        public DocumentService(IUnitOfWork uow, IErrorLogService errorLog) : base(uow, errorLog)
        {

        }
    }
}