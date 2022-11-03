using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Repository
{
    public interface IDocumentRepository : IRepositoryBase<Document>
    {
        IQueryable<Document> GetAllDocuments(int propertyId, string userId);
        IQueryable<Document> GetDocumentByMatch(Expression<Func<Document, bool>> match, int propertyId, string userId);
        IQueryable<Document> GetDocumentWithDetails(Expression<Func<Document, bool>> match, int propertyId, string userId, WithDetails details);
        Document CreateDocument(Document document, int propertyId, string userId);
        bool UpdateDocument(Document document, int propertyId, string userId);
        bool DeleteDocument(Document document, int propertyId, string userId);
    }
}

