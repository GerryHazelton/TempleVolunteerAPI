﻿using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Repository
{
    public class CommitteeRepository : RepositoryBase<Committee>, ICommitteeRepository
    {
        private readonly ApplicationDBContext _context;

        public CommitteeRepository(ApplicationDBContext context)
            : base(context)
        {
            _context = context;
        }

        public IQueryable<Committee> GetAllCommittees(int propertyId, string userId)
        {
            var committees = FindAll(propertyId, userId).OrderBy(x => x.Name).AsNoTracking();
            return committees.Where(x => x.PropertyId == propertyId);
        }

        public IQueryable<Committee> GetCommitteeByMatch(Expression<Func<Committee, bool>> match, int propertyId, string userId)
        {
            return FindByCondition(match, propertyId, userId).AsNoTracking();
        }

        public IQueryable<Committee> GetCommitteeWithDetails(Expression<Func<Committee, bool>> match, int propertyId, string userId, WithDetails details)
        {
            switch (details)
            {
                case WithDetails.Yes:
                    return FindByCondition(match, propertyId, userId).Include(x => x.Areas).Include(x => x.Staff).AsNoTracking();
                    break;
                default:
                    return FindByCondition(match, propertyId, userId).AsNoTracking();
                    break;
            }
        }

        public Committee CreateCommittee(Committee committee, int propertyId, string userId)
        {
            return Create(committee, propertyId, userId);
        }

        public bool UpdateCommittee(Committee committee, int propertyId, string userId)
        {
            return Update(committee, propertyId, userId);
        }

        public bool DeleteCommittee(Committee committee, int propertyId, string userId)
        {
            return Delete(committee, propertyId, userId);
        }
    }
}
