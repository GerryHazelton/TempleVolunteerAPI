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
        private IAreaRepository _area;
        private IAreaSupplyItemRepository _areaSupplyItem;
        private ICategoryRepository _category;
        private ICredentialRepository _credential;
        private IDocumentRepository _document;
        private IErrorLogRepository _errorLog;
        private IEventRepository _event;
        private IEventTaskRepository _eventTask;
        private IEventTypeRepository _eventType;
        private IMessageRepository _message;
        private IPropertyRepository _property;
        private IRoleRepository _role;
        private IStaffRepository _staff;
        private ISupplyItemRepository _supplyItem;


        public RepositoryWrapper(ApplicationDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
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

        public IAreaSupplyItemRepository AreasSupplyItems
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

        public void Save()
        {
            try
            {
                _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
