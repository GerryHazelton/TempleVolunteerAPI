using Microsoft.EntityFrameworkCore;
using TempleVolunteerAPI.Domain;

namespace TempleVolunteerAPI.Repository
{
    public class MessageRepository : IMessageRepository
    {
        private readonly ApplicationDBContext _context;
        private readonly IUnitOfWork _unitOfWork;

        public MessageRepository(ApplicationDBContext context)
        {
            _context = context;
            _unitOfWork = new UnitOfWork(context);
        }

        public async Task<bool> AddAsync(Message message)
        {
            try
            {
                _context.Set<Message>().Add(message);
                await _unitOfWork.CommitAsync();
            }
            catch
            {
                return false;
            }

            return true;
        }

        public async Task<IList<Message>> GetAllAsync()
        {
            try
            {
                return await _context.Set<Message>().ToListAsync(); ;
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
