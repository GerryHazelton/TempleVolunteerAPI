﻿using System.Linq.Expressions;
using TempleVolunteerAPI.Domain;
using static TempleVolunteerAPI.Common.EnumHelper;

namespace TempleVolunteerAPI.Service
{
    public interface IServiceBase<T>
    {
        IQueryable<T> FindAll(int propertyId, string userId);
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> match, int propertyId, string userId, WithDetails details);
        T Create(T entity, int propertyId, string userId);
        bool Update(T entity, int propertyId, string userId);
        bool Delete(T entity, int propertyId, string userId);
    }
}
