using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Repository
{
    public class DocumentRepository : RepositoryBase<Document>, IDocumentRepository
    {
        private readonly ApplicationDBContext _context;

        public DocumentRepository(ApplicationDBContext context)
            : base(context)
        {
            _context = context;
        }

        public IQueryable<Document> GetAllDocuments(int propertyId, string userId)
        {
            return FindAll(propertyId, userId).OrderBy(x => x.Name).AsNoTracking();
        }

        public IQueryable<Document> GetDocumentByMatch(Expression<Func<Document, bool>> match, int propertyId, string userId)
        {
            return FindByCondition(match, propertyId, userId).AsNoTracking();
        }

        public IQueryable<Document> GetDocumentWithDetails(Expression<Func<Document, bool>> match, int propertyId, string userId, WithDetails details)
        {
            switch (details)
            {
                default:
                    return FindByCondition(match, propertyId, userId).AsNoTracking();
                    break;
            }
        }

        public Document CreateDocument(Document document, int propertyId, string userId)
        {
            return Create(document, propertyId, userId);
        }

        public bool UpdateDocument(Document document, int propertyId, string userId)
        {
            return Update(document, propertyId, userId);
        }

        public bool DeleteDocument(Document document, int propertyId, string userId)
        {
            return Delete(document, propertyId, userId);
        }
    }
}
