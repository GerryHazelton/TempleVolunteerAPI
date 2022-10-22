using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Repository;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Service
{
    public class DocumentService : IDocumentService
    {
        private readonly IRepositoryWrapper _uow;

        public DocumentService(IRepositoryWrapper uow)
        {
            this._uow = uow;
        }

        public bool Create(Document entity, int propertyId, string userId)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Document entity, int propertyId, string userId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Document> FindAll(int propertyId, string userId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Document> FindByCondition(Expression<Func<Document, bool>> match, int propertyId, string userId, WithDetails details)
        {
            throw new NotImplementedException();
        }

        public bool Update(Document entity, int propertyId, string userId)
        {
            throw new NotImplementedException();
        }
    }
}