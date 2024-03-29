﻿using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Repository
{
    public class PropertyRepository : RepositoryBase<Property>, IPropertyRepository
    {
        public PropertyRepository(ApplicationDBContext context)
            : base(context)
        {
        }

        public IQueryable<Property> GetAllProperties(int propertyId, string userId)
        {
            return FindAll(propertyId, userId).OrderBy(x => x.Name);
        }

        public IQueryable<Property> GetPropertyByMatch(Expression<Func<Property, bool>> match, int propertyId, string userId)
        {
            return FindByCondition(match, propertyId, userId);
        }

        public IQueryable<Property> GetPropertyWithDetails(Expression<Func<Property, bool>> match, int propertyId, string userId, WithDetails details)
        {
            return FindByCondition(match, propertyId, userId);
        }

        public Property CreateProperty(Property property, int propertyId, string userId)
        {
            return Create(property, propertyId, userId);
        }

        public bool UpdateProperty(Property property, int propertyId, string userId)
        {
            return Update(property, propertyId, userId);
        }

        public bool DeleteProperty(Property property, int propertyId, string userId)
        {
            return Delete(property, propertyId, userId);
        }
    }
}
