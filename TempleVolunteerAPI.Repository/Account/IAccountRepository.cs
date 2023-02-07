using Microsoft.AspNetCore.Mvc;
using TempleVolunteerAPI.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;
using TempleVolunteerAPI.Domain.DTO;
using TempleVolunteerAPI.Repository;
using TempleVolunteerAPI.Common;

namespace TempleVolunteerAPI.Repository
{
    public interface IAccountRepository
    {
        void AddTemporaryPassword(int staffId, string password);
        string GetTemporaryPassword(int staffId);
        void DeleteTemporaryPassword(int staffId);
    }
}
