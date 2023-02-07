
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Options;
using System.Linq.Expressions;
using TempleVolunteerAPI.Common;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Domain.DTO;
using TempleVolunteerAPI.Repository;
using TempleVolunteerAPI.Repository.Migrations;

namespace TempleVolunteerAPI.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly ApplicationDBContext _context;
        public AccountRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public void AddTemporaryPassword(int staffId, string password)
        {
            TemporaryPassword tempPwd = new TemporaryPassword();
            tempPwd.StaffId = staffId;
            tempPwd.Password = password;

            try
            {
                this._context.Set<TemporaryPassword>().Add(tempPwd);
                this._context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public string GetTemporaryPassword(int staffId)
        {
            try
            {
                TemporaryPassword tempPwd = this._context.Set<TemporaryPassword>().Where(x=>x.StaffId == staffId).FirstOrDefault();
                
                return tempPwd.Password;
            }
            catch
            {
                throw;
            }
        }

        public void DeleteTemporaryPassword(int staffId)
        {
            try
            {
                TemporaryPassword tempPwd = this._context.Set<TemporaryPassword>().Where(x => x.StaffId == staffId).AsNoTracking().FirstOrDefault();
                this._context.Set<TemporaryPassword>().Remove(tempPwd);
                this._context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
