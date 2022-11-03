using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Repository;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Service
{
    public class DocumentService : IDocumentService
    {
        private readonly IRepositoryWrapper _uow;
        private bool _result;

        public DocumentService(IRepositoryWrapper uow)
        {
            this._uow = uow;
        }

        public Document Create(Document entity, int propertyId, string userId)
        {
            var document = _uow.Documents.CreateDocument(entity, propertyId, userId);

            return document;
        }

        public bool Delete(Document entity, int propertyId, string userId)
        {
            _result = _uow.Documents.DeleteDocument(entity, propertyId, userId);

            return _result;
        }

        public IQueryable<Document> FindAll(int propertyId, string userId)
        {
            return _uow.Documents.GetAllDocuments(propertyId, userId);
        }

        public IQueryable<Document> FindByCondition(Expression<Func<Document, bool>> match, int propertyId, string userId, WithDetails details)
        {
            return _uow.Documents.GetDocumentWithDetails(match, propertyId, userId, details);
        }

        public bool Update(Document entity, int propertyId, string userId)
        {
            _result = _uow.Documents.UpdateDocument(entity, propertyId, userId);

            return _result;
        }
    }
}