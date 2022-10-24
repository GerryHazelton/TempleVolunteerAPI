using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TempleVolunteerAPI.Repository;

namespace TempleVolunteerAPI.Repository
{
    public interface IRepositoryWrapper
    {
        IAreaRepository Areas { get; }
        ICategoryRepository Categories { get; }
        ICredentialRepository Credentials { get; }
        IDocumentRepository Documents { get; }
        IErrorLogRepository ErrorLog { get; }
        IEventRepository Events { get; }
        IEventTaskRepository EventTasks { get; }
        IEventTypeRepository EventTypes { get; }
        IMessageRepository Messages { get; }
        IPropertyRepository Properties { get; }
        IRoleRepository Roles { get; }
        IStaffRepository Staff { get; }
        ISupplyItemRepository SupplyItems { get; }

        IAreaSupplyItemRepository AreaSupplyItems { get; }
        IEventTypeAreaRepository EventTypeAreas { get; }
        IEventEventTypeRepository EventEventTypes { get; }
        IStaffCredentialRepository StaffCredentials { get; }
        IStaffRoleRepository StaffRoles { get; }
        IPropertyStaffRepository PropertyStaff { get; }
    }
}
