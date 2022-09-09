
using AutoMapper;
using TempleVolunteerAPI.Domain;
using VolunteerAPI.Domain;

namespace TempleVolunteerAPI.API
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            #region Area
            CreateMap<Area, AreaResponse>();
            CreateMap<AreaResponse, Area>();
            #endregion

            #region Category
            CreateMap<Category, CategoryResponse>();
            CreateMap<CategoryResponse, Category>();
            #endregion

            #region Credential
            CreateMap<Credential, CredentialResponse>();
            CreateMap<CredentialResponse, Credential>();
            #endregion

            #region Document
            CreateMap<Document, DocumentResponse>();
            CreateMap<DocumentResponse, Document>();
            #endregion

            #region Event
            CreateMap<Event, EventResponse>();
            CreateMap<EventResponse, Event>();
            #endregion

            #region EventTask
            CreateMap<EventTask, EventTaskResponse>();
            CreateMap<EventTaskResponse, EventTask>();
            #endregion

            #region EventType
            CreateMap<EventType, EventTypeResponse>();
            CreateMap<EventTypeResponse, EventType>();
            #endregion

            #region Message
            CreateMap<Message, MessageResponse>();
            CreateMap<MessageResponse, Message>();
            #endregion

            #region Property
            CreateMap<Property, PropertyResponse>();
            CreateMap<PropertyResponse, Property>();
            #endregion

            #region Role
            CreateMap<Role, RoleResponse>();
            CreateMap<RoleResponse, Role>();
            #endregion

            #region Staff
            CreateMap<Staff, StaffResponse>();
            CreateMap<StaffResponse, Staff>();

            CreateMap<Staff, RegisterResponse>();
            CreateMap<RegisterResponse, Staff>();
            #endregion

            #region SupplyItem
            CreateMap<SupplyItem, SupplyItemResponse>();
            CreateMap<SupplyItemResponse, SupplyItem>();
            #endregion
        }
    }
}
