using Microsoft.EntityFrameworkCore;
using TempleVolunteerAPI.Domain;

namespace TempleVolunteerAPI.Repository
{
    public class MessageRepository : IMessageRepository
    {
        private readonly ApplicationDBContext _context;
        private readonly IRepositoryWrapper _unitOfWork;

        public MessageRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<bool> AddAsync(Message message)
        {
            try
            {
                _context.Set<Message>().Add(message);
            }
            catch
            {
                return false;
            }

            return true;
        }

        public async Task<IList<Message>> GetAllAsync(int propertyId)
        {
            try
            {
                return await _context.Set<Message>().Where(x=>x.PropertyId == propertyId).ToListAsync(); ;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IList<Message>> GetAllByIdAsync(int id)
        {
            try
            {
                return await _context.Set<Message>().Where(x => x.StaffId == id).ToListAsync(); ;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
