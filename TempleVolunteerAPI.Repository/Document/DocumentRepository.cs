using TempleVolunteerAPI.Domain;

namespace TempleVolunteerAPI.Repository
{
    public class DocumentRepository : RepositoryBase<Document>, IDocumentRepository
    {
        public DocumentRepository(ApplicationDBContext context)
            : base(context)
        {
        }
    }
}
