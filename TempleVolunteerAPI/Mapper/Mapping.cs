
using AutoMapper;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Domain;

namespace TempleVolunteerAPI.API
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            #region Area
            CreateMap<Area, AreaRequest>();
            CreateMap<AreaRequest, Area>();
            #endregion

            #region Category
            CreateMap<Category, CategoryRequest>();
            CreateMap<CategoryRequest, Category>();
            #endregion

            #region Credential
            CreateMap<Credential, CredentialRequest>();
            CreateMap<CredentialRequest, Credential>();
            #endregion

            #region Document
            CreateMap<Document, DocumentRequest>();
            CreateMap<DocumentRequest, Document>();
            #endregion

            #region Event
            CreateMap<Event, EventRequest>();
            CreateMap<EventRequest, Event>();
            #endregion

            #region EventTask
            CreateMap<EventTask, EventTaskRequest>();
            CreateMap<EventTaskRequest, EventTask>();
            #endregion

            #region EventType
            CreateMap<EventType, EventTypeRequest>();
            CreateMap<EventTypeRequest, EventType>();
            #endregion

            #region Message
            CreateMap<Message, MessageRequest>();
            CreateMap<MessageRequest, Message>();
            #endregion

            #region Property
            CreateMap<Property, PropertyRequest>();
            CreateMap<PropertyRequest, Property>();
            #endregion

            #region Role
            CreateMap<Role, RoleRequest>();
            CreateMap<RoleRequest, Role>();
            #endregion

            #region Staff
            CreateMap<Staff, StaffRequest>();
            CreateMap<StaffRequest, Staff>();

            CreateMap<Staff, StaffRequest>();
            CreateMap<StaffRequest, Staff>();

            CreateMap<Staff, RegisterRequest>();
            CreateMap<RegisterRequest, Staff>();

            CreateMap<Staff, MyProfileRequest>();
            CreateMap<MyProfileRequest, Staff>();
            #endregion

            #region SupplyItem
            CreateMap<SupplyItem, SupplyItemRequest>();
            CreateMap<SupplyItemRequest, SupplyItem>();
            #endregion
        }
    }
}
