using System.Linq.Expressions;
using System.Text.RegularExpressions;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Repository;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Service
{
    public class GeneralService : IGeneralService
    {
        private readonly IRepositoryWrapper _uow;
        private bool _result;

        public GeneralService(IRepositoryWrapper uow)
        {
            this._uow = uow;
        }

        public ICollection<General> FindAll(int propertyId, string userId)
        {
            return _uow.General.GetAll(propertyId, userId);
        }

        public IQueryable<General> FindByCondition(Expression<Func<General, bool>> match, int propertyId, string userId)
        {
            return _uow.General.GetByMatch(match, propertyId, userId);
        }
    }
}