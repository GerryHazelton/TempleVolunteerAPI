using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempleVolunteerAPI.Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private readonly ApplicationDBContext _context;
        private readonly IMapper _mapper;
        private IAccountRepository _account;
        private IAreaRepository _area;
        private ICategoryRepository _category;
        private ICommitteeRepository _committee;
        private ICredentialRepository _credential;
        private IDocumentRepository _document;
        private IErrorLogRepository _errorLog;
        private IEventRepository _event;
        private IEventTaskRepository _eventTask;
        private IEventTypeRepository _eventType;
        private IGeneralRepository _general;
        private IMessageRepository _message;
        private IPropertyRepository _property;
        private IRoleRepository _role;
        private IStaffRepository _staff;
        private ISupplyItemRepository _supplyItem;

        private IAreaCommitteeRepository _areaCommittees;
        private IAreaEventTaskRepository _areaEventTask;
        private IAreaSupplyItemRepository _areaSupplyItem;
        private ICommitteeStaffRepository _committeeStaff;
        private IEventEventTypeRepository _eventEventType;
        private IEventTypeAreaRepository _eventTypeArea;
        private IStaffCredentialRepository _staffCredential;
        private IStaffRoleRepository _staffRole;
        private IPropertyStaffRepository _propertyStaff;

        public RepositoryWrapper(ApplicationDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IAccountRepository Account
        {
            get
            {
                if (_account == null)
                {
                    _account = new AccountRepository(_context);
                }
                
                return _account;
            }
        }

        public IAreaRepository Area
        {
            get
            {
                if (_area == null)
                {
                    _area = new AreaRepository(_context);
                }

                return _area;
            }
        }

        public IAreaRepository Areas
        {
            get
            {
                if (_area == null)
                {
                    _area = new AreaRepository(_context);
                }

                return _area;
            }
        }

        public IAreaCommitteeRepository AreaCommittees
        {
            get
            {
                if (_areaCommittees == null)
                {
                    _areaCommittees = new AreaCommitteeRepository(_context);
                }

                return _areaCommittees;
            }
        }

        public ICategoryRepository Categories
        {
            get
            {
                if (_category == null)
                {
                    _category = new CategoryRepository(_context);
                }

                return _category;
            }
        }

        public ICommitteeRepository Committees
        {
            get
            {
                if (_committee == null)
                {
                    _committee = new CommitteeRepository(_context);
                }

                return _committee;
            }
        }

        public ICommitteeStaffRepository CommitteeStaff
        {
            get
            {
                if (_committeeStaff == null)
                {
                    _committeeStaff = new CommitteeStaffRepository(_context);
                }

                return _committeeStaff;
            }
        }

        public ICredentialRepository Credentials
        {
            get
            {
                if (_credential == null)
                {
                    _credential = new CredentialRepository(_context);
                }

                return _credential;
            }
        }

        public IDocumentRepository Documents
        {
            get
            {
                if (_document == null)
                {
                    _document = new DocumentRepository(_context);
                }

                return _document;
            }
        }

        public IErrorLogRepository ErrorLog
        {
            get
            {
                if (_errorLog == null)
                {
                    _errorLog = new ErrorLogRepository(_context);
                }

                return _errorLog;
            }
        }

        public IEventRepository Events
        {
            get
            {
                if (_event == null)
                {
                    _event = new EventRepository(_context);
                }

                return _event;
            }
        }

        public IEventTaskRepository EventTasks
        {
            get
            {
                if (_eventTask == null)
                {
                    _eventTask = new EventTaskRepository(_context);
                }

                return _eventTask;
            }
        }

        public IEventTypeRepository EventTypes
        {
            get
            {
                if (_eventType == null)
                {
                    _eventType = new EventTypeRepository(_context);
                }

                return _eventType;
            }
        }

        public IGeneralRepository General
        {
            get
            {
                if (_general == null)
                {
                    _general = new GeneralRepository(_context);
                }

                return _general;
            }
        }

        public IMessageRepository Messages
        {
            get
            {
                if (_message == null)
                {
                    _message = new MessageRepository(_context);
                }

                return _message;
            }
        }

        public IPropertyRepository Properties
        {
            get
            {
                if (_property == null)
                {
                    _property = new PropertyRepository(_context);
                }

                return _property;
            }
        }

        public IRoleRepository Roles
        {
            get
            {
                if (_role == null)
                {
                    _role = new RoleRepository(_context);
                }

                return _role;
            }
        }

        public IStaffRepository Staff
        {
            get
            {
                if (_staff == null)
                {
                    _staff = new StaffRepository(_context, _mapper);
                }

                return _staff;
            }
        }

        public ISupplyItemRepository SupplyItems
        {
            get
            {
                if (_supplyItem == null)
                {
                    _supplyItem = new SupplyItemRepository(_context);
                }

                return _supplyItem;
            }
        }

        public IAreaEventTaskRepository AreaEventTasks
        {
            get
            {
                if (_areaEventTask == null)
                {
                    _areaEventTask = new AreaEventTaskRepository(_context);
                }

                return _areaEventTask;
            }
        }

        public IAreaSupplyItemRepository AreaSupplyItems
        {
            get
            {
                if (_areaSupplyItem == null)
                {
                    _areaSupplyItem = new AreaSupplyItemRepository(_context);
                }

                return _areaSupplyItem;
            }
        }

        public IEventEventTypeRepository EventEventTypes
        {
            get
            {
                if (_eventEventType == null)
                {
                    _eventEventType = new EventEventTypeRepository(_context);
                }

                return _eventEventType;
            }
        }

        public IEventTypeAreaRepository EventTypeAreas
        {
            get
            {
                if (_eventTypeArea == null)
                {
                    _eventTypeArea = new EventTypeAreaRepository(_context);
                }

                return _eventTypeArea;
            }
        }

        public IStaffCredentialRepository StaffCredentials
        {
            get
            {
                if (_staffCredential == null)
                {
                    _staffCredential = new StaffCredentialRepository(_context);
                }

                return _staffCredential;
            }
        }

        public IStaffRoleRepository StaffRoles
        {
            get
            {
                if (_staffRole == null)
                {
                    _staffRole = new StaffRoleRepository(_context);
                }

                return _staffRole;
            }
        }

        public IPropertyStaffRepository PropertyStaff
        {
            get
            {
                if (_propertyStaff == null)
                {
                    _propertyStaff = new PropertyStaffRepository(_context);
                }

                return _propertyStaff;
            }
        }
    }
}
