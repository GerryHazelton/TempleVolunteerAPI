using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.Generic;
using System.Xml.Linq;
using TempleVolunteerAPI.Domain;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using Property = TempleVolunteerAPI.Domain.Property;

namespace TempleVolunteerAPI.Repository
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }

        public virtual DbSet<Area> Areas { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Committee> Committees { get; set; }
        public virtual DbSet<Credential> Credentials { get; set; }
        public virtual DbSet<Document> Documents { get; set; }
        public virtual DbSet<ErrorLog> ErrorLog { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<EventTask> EventTasks { get; set; }
        public virtual DbSet<EventType> EventTypes { get; set; }
        public virtual DbSet<Property> Properties { get; set; }
        public virtual DbSet<RefreshToken> RefreshTokens { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Staff> Staff { get; set; }
        public virtual DbSet<SupplyItem> SupplyItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Area>().ToTable("Areas");
            modelBuilder.Entity<Category>().ToTable("Categories");
            modelBuilder.Entity<Committee>().ToTable("Committees");
            modelBuilder.Entity<Credential>().ToTable("Credentials");
            modelBuilder.Entity<Document>().ToTable("Documents");
            modelBuilder.Entity<ErrorLog>().ToTable("ErrorLog");
            modelBuilder.Entity<Message>().ToTable("Messages");
            modelBuilder.Entity<Event>().ToTable("Events");
            modelBuilder.Entity<EventTask>().ToTable("EventTask");
            modelBuilder.Entity<EventType>().ToTable("EventTypes");
            modelBuilder.Entity<Property>().ToTable("Properties");
            modelBuilder.Entity<RefreshToken>().ToTable("RefreshTokens");
            modelBuilder.Entity<Role>().ToTable("Roles");
            modelBuilder.Entity<Staff>().ToTable("Staff");
            modelBuilder.Entity<SupplyItem>().ToTable("SupplyItems");
            modelBuilder.Entity<AreaCommittee>().ToTable("AreaCommittees");
            modelBuilder.Entity<CommitteeStaff>().ToTable("CommitteeStaff");
            modelBuilder.Entity<StaffCredential>().ToTable("StaffCredentials");
            modelBuilder.Entity<PropertyStaff>().ToTable("PropertyStaff");
            modelBuilder.Entity<RefreshTokenStaff>().ToTable("StaffRefreshTokens");
            modelBuilder.Entity<StaffRole>().ToTable("StaffRoles");
            modelBuilder.Entity<AreaEventTask>().ToTable("AreaEventTasks");
            modelBuilder.Entity<AreaSupplyItem>().ToTable("AreaSupplyItems");
            modelBuilder.Entity<EventTypeArea>().ToTable("EventTypeAreas");
            modelBuilder.Entity<EventEventType>().ToTable("EventEventTypes");

            #region Area Committee
            modelBuilder.Entity<AreaCommittee>()
            .HasKey(x => new { x.AreaId, x.CommitteeId });
            #endregion

            #region Area EventTask
            modelBuilder.Entity<AreaEventTask>()
            .HasKey(x => new { x.AreaId, x.EventTaskId });
            #endregion

            #region Area SupplyItem
            modelBuilder.Entity<AreaSupplyItem>()
            .HasKey(x => new { x.AreaId, x.SupplyItemId });
            #endregion

            #region Committee Staff
            modelBuilder.Entity<CommitteeStaff>()
            .HasKey(x => new { x.CommitteeId, x.StaffId });
            #endregion

            #region Credential Staff
            modelBuilder.Entity<StaffCredential>()
            .HasKey(x => new { x.CredentialId, x.StaffId });
            #endregion

            #region EventType Area
            modelBuilder.Entity<EventTypeArea>()
            .HasKey(x => new { x.EventTypeId, x.AreaId });
            #endregion

            #region Event EventType
            modelBuilder.Entity<EventEventType>()
            .HasKey(x => new { x.EventId, x.EventTypeId });
            #endregion

            #region Property Staff
            modelBuilder.Entity<PropertyStaff>()
            .HasKey(x => new { x.PropertyId, x.StaffId });
            #endregion

            #region RefreshToken Staff
            modelBuilder.Entity<RefreshTokenStaff>()
            .HasKey(x => new { x.RefreshTokenId, x.StaffId });
            #endregion

            #region Role Staff
            modelBuilder.Entity<StaffRole>()
            .HasKey(x => new { x.RoleId, x.StaffId });
            #endregion

            #region Add Data
            Property glendale = new Property
            {
                PropertyId = 1,
                Name = "Glendale Temple",
                Address = "123 Main Street",
                Address2 = "Suite 45",
                City = "Glendale",
                State = "CA",
                PostalCode = "91001",
                Country = "US",
                EmailAddress = "Glendale@Srf.com",
                PhoneNumber = "222-222-2222",
                FaxNumber = "333-333-3333",
                Website = "https://www.glendaletemple.org",
                Note = "Currently, there are no notes",
                CreatedBy = "gerryhazelton@gmail.com",
                CreatedDate = DateTime.UtcNow,
                IsActive = true,
                IsHidden = false
            };

            Property encinitas = new Property
            {
                PropertyId = 2,
                Name = "Encinitas Temple",
                Address = "456 Main Street",
                Address2 = "Suite 65",
                City = "Encinitas",
                State = "CA",
                PostalCode = "92026",
                Country = "US",
                EmailAddress = "Encinitas@Srf.com",
                PhoneNumber = "555-555-5555",
                FaxNumber = "666-666-6666",
                Website = "https://www.encinitastemple.org",
                Note = "Currently, there are no notes",
                CreatedBy = "gerryhazelton@gmail.com",
                CreatedDate = DateTime.UtcNow,
                IsActive = true,
                IsHidden = false,
            };

            Property fullerton = new Property
            {
                PropertyId = 3,
                Name = "Fullterton Temple",
                Address = "789 Main Street",
                Address2 = "Suite 22",
                City = "Fullerton",
                State = "CA",
                PostalCode = "92026",
                Country = "US",
                EmailAddress = "Fullerton@Srf.com",
                PhoneNumber = "555-555-5555",
                FaxNumber = "666-666-6666",
                Website = "https://www.fullertontemple.org",
                Note = "Currently, there are no notes",
                CreatedBy = "gerryhazelton@gmail.com",
                CreatedDate = DateTime.UtcNow,
                IsActive = true,
                IsHidden = false,
            };

            Property sandiego = new Property
            {
                PropertyId = 4,
                Name = "San Diego Temple",
                Address = "222 South Street",
                Address2 = "Suite 11",
                City = "San Diego",
                State = "CA",
                PostalCode = "92026",
                Country = "US",
                EmailAddress = "SanDiego@Srf.com",
                PhoneNumber = "555-555-5555",
                FaxNumber = "666-666-6666",
                Website = "https://www.sandiegotemple.org",
                Note = "Currently, there are no notes",
                CreatedBy = "gerryhazelton@gmail.com",
                CreatedDate = DateTime.UtcNow,
                IsActive = true,
                IsHidden = false,
            };

            Property hollywood = new Property
            {
                PropertyId = 5,
                Name = "Hollywood Temple",
                Address = "444 South Street",
                Address2 = "Suite 33",
                City = "Hollywood Diego",
                State = "CA",
                PostalCode = "92026",
                Country = "US",
                EmailAddress = "Hollywood@Srf.com",
                PhoneNumber = "555-555-5555",
                FaxNumber = "666-666-6666",
                Website = "https://www.hollywoodtemple.org",
                Note = "Currently, there are no notes",
                CreatedBy = "gerryhazelton@gmail.com",
                CreatedDate = DateTime.UtcNow,
                IsActive = true,
                IsHidden = false,
            };

            modelBuilder.Entity<Property>().HasData(
                glendale,
                encinitas,
                fullerton,
                sandiego,
                hollywood
            );

            Role glendaleAdmin = new Role
            {
                RoleId = 1,
                Name = "Admin",
                Description = "Admin role has full prviliedges",
                PropertyId = 1,
                CreatedBy = "gerryhazelton@gmail.com",
                CreatedDate = DateTime.UtcNow,
                IsActive = true,
                IsHidden = false,
            };

            Role glendaleVolunteer = new Role
            {
                RoleId = 2,
                Name = "Volunteer",
                Description = "Volunteer has limited prviliedges",
                PropertyId = 1,
                CreatedBy = "gerryhazelton@gmail.com",
                CreatedDate = DateTime.UtcNow,
                IsActive = true,
                IsHidden = false,
            };

            Role encinitasAdmin = new Role
            {
                RoleId = 3,
                Name = "Admin",
                Description = "Admin role has full prviliedges",
                PropertyId = 2,
                CreatedBy = "gerryhazelton@gmail.com",
                CreatedDate = DateTime.UtcNow,
                IsActive = true,
                IsHidden = false,
            };

            Role encinitasVolunteer = new Role
            {
                RoleId = 4,
                Name = "Volunteer",
                Description = "Volunteer has limited prviliedges",
                PropertyId = 2,
                CreatedBy = "gerryhazelton@gmail.com",
                CreatedDate = DateTime.UtcNow,
                IsActive = true,
                IsHidden = false,
            };

            Role fullertonAdmin = new Role
            {
                RoleId = 5,
                Name = "Admin",
                Description = "Admin role has full prviliedges",
                PropertyId = 3,
                CreatedBy = "gerryhazelton@gmail.com",
                CreatedDate = DateTime.UtcNow,
                IsActive = true,
                IsHidden = false,
            };

            Role fullertonVolunteer = new Role
            {
                RoleId = 6,
                Name = "Volunteer",
                Description = "Volunteer has limited prviliedges",
                PropertyId = 3,
                CreatedBy = "gerryhazelton@gmail.com",
                CreatedDate = DateTime.UtcNow,
                IsActive = true,
                IsHidden = false,
            };

            Role sandiegoAdmin = new Role
            {
                RoleId = 7,
                Name = "Admin",
                Description = "Admin role has full prviliedges",
                PropertyId = 4,
                CreatedBy = "gerryhazelton@gmail.com",
                CreatedDate = DateTime.UtcNow,
                IsActive = true,
                IsHidden = false,
            };

            Role sandiegoVolunteer = new Role
            {
                RoleId = 8,
                Name = "Volunteer",
                Description = "Volunteer has limited prviliedges",
                PropertyId = 4,
                CreatedBy = "gerryhazelton@gmail.com",
                CreatedDate = DateTime.UtcNow,
                IsActive = true,
                IsHidden = false,
            };

            Role hollywoodAdmin = new Role
            {
                RoleId = 9,
                Name = "Admin",
                Description = "Admin role has full prviliedges",
                PropertyId = 5,
                CreatedBy = "gerryhazelton@gmail.com",
                CreatedDate = DateTime.UtcNow,
                IsActive = true,
                IsHidden = false,
            };

            Role hollywoodVolunteer = new Role
            {
                RoleId = 10,
                Name = "Volunteer",
                Description = "Volunteer has limited prviliedges",
                PropertyId = 5,
                CreatedBy = "gerryhazelton@gmail.com",
                CreatedDate = DateTime.UtcNow,
                IsActive = true,
                IsHidden = false,
            };

            modelBuilder.Entity<Role>().HasData(
                glendaleAdmin,
                glendaleVolunteer,
                encinitasAdmin,
                encinitasVolunteer,
                fullertonAdmin,
                fullertonVolunteer,
                sandiegoAdmin,
                sandiegoVolunteer,
                hollywoodAdmin,
                hollywoodVolunteer
            );

            Staff gerry = new Staff("gerryhazelton@gmail.com");
            gerry.StaffId = 1;
            gerry.FirstName = "Gerry";
            gerry.LastName = "Hazelton";
            gerry.Address = "123 Main Street";
            gerry.Address2 = "Apt. B";
            gerry.City = "Carlsbad";
            gerry.State = "CA";
            gerry.PostalCode = "92009";
            gerry.Country = "US";
            gerry.EmailAddress = "gerryhazelton@gmail.com";
            gerry.PhoneNumber = "760-444-4444";
            gerry.Gender = "Male";
            gerry.FirstAid = true;
            gerry.CPR = true;
            gerry.Kriyaban = true;
            gerry.LessonStudent = true;
            gerry.AcceptTerms = true;
            gerry.CanSendMessages = true;
            gerry.EmailConfirmed = true;
            gerry.IsVerified = true;
            gerry.IsActive = true;
            gerry.VerifiedDate = DateTime.Now;
            gerry.RememberMe = true;
            gerry.IsLockedOut = false;
            gerry.LoginAttempts = 0;
            gerry.Password = "11111111";
            gerry.PasswordSalt = "371952==";
            gerry.PropertyId = 1;
            gerry.CreatedBy = "gerryhazelton@gmail.com";
            gerry.CreatedDate = DateTime.UtcNow;

            Staff gerry2 = new Staff("gerryhazelton@gmail.com");
            gerry2.StaffId = 2;
            gerry2.FirstName = "Dolores";
            gerry2.LastName = "Hazelton";
            gerry2.Address = "123 Main Street";
            gerry2.Address2 = "Apt. B";
            gerry2.City = "Carlsbad";
            gerry2.State = "CA";
            gerry2.PostalCode = "92009";
            gerry2.Country = "US";
            gerry2.EmailAddress = "gerryhazelton@gmail.com";
            gerry2.PhoneNumber = "760-444-4444";
            gerry2.Gender = "Male";
            gerry2.FirstAid = true;
            gerry2.CPR = true;
            gerry2.Kriyaban = true;
            gerry2.LessonStudent = true;
            gerry2.AcceptTerms = true;
            gerry2.CanSendMessages = true;
            gerry.EmailConfirmed = true;
            gerry2.IsVerified = true;
            gerry2.IsActive = true;
            gerry2.VerifiedDate = DateTime.Now;
            gerry2.RememberMe = true;
            gerry2.IsLockedOut = false;
            gerry2.LoginAttempts = 0;
            gerry2.Password = "11111111";
            gerry2.PasswordSalt = "371952==";
            gerry2.PropertyId = 2;
            gerry2.CreatedBy = "gerryhazelton@gmail.com";
            gerry2.CreatedDate = DateTime.UtcNow;

            modelBuilder.Entity<Staff>().HasData(
                gerry, gerry2
            );

            modelBuilder.Entity<StaffRole>().HasData(
                new StaffRole() { RoleId = 1, StaffId = 1 },
                new StaffRole() { RoleId = 4, StaffId = 2 }
            );

            modelBuilder.Entity<Area>().HasData(
                new Area
                {
                    AreaId = 1,
                    Name = "Main Temple",
                    Description = "This is the main temple area",
                    Note = "There are no notes",
                    SupplyItemsAllowed = true,
                    PropertyId = 1,
                    CreatedBy = "gerryhazelton@gmail.com",
                    CreatedDate = DateTime.UtcNow,
                    IsActive = true,
                    IsHidden = false,
                }
            );

            modelBuilder.Entity<Area>().HasData(
                new Area
                {
                    AreaId = 2,
                    Name = "Kitchen",
                    Description = "This is the kitchen area",
                    Note = "There are no notes",
                    SupplyItemsAllowed = true,
                    PropertyId = 1,
                    CreatedBy = "gerryhazelton@gmail.com",
                    CreatedDate = DateTime.UtcNow,
                    IsActive = true,
                    IsHidden = false,
                }
            );

            modelBuilder.Entity<Area>().HasData(
                new Area
                {
                    AreaId = 3,
                    Name = "Bathroom",
                    Description = "This is the bathroom area",
                    Note = "There are no notes",
                    SupplyItemsAllowed = true,
                    PropertyId = 1,
                    CreatedBy = "gerryhazelton@gmail.com",
                    CreatedDate = DateTime.UtcNow,
                    IsActive = true,
                    IsHidden = false,
                }
            );

            modelBuilder.Entity<Area>().HasData(
                new Area
                {
                    AreaId = 4,
                    Name = "Sunday School Room",
                    Description = "This is the sunday school room area",
                    Note = "There are no notes",
                    SupplyItemsAllowed = true,
                    PropertyId = 1,
                    CreatedBy = "gerryhazelton@gmail.com",
                    CreatedDate = DateTime.UtcNow,
                    IsActive = true,
                    IsHidden = false,
                }
            );

            modelBuilder.Entity<Area>().HasData(
                new Area
                {
                    AreaId = 5,
                    Name = "Parking Lot",
                    Description = "This is the parking lot area",
                    Note = "There are no notes",
                    SupplyItemsAllowed = true,
                    PropertyId = 1,
                    CreatedBy = "gerryhazelton@gmail.com",
                    CreatedDate = DateTime.UtcNow,
                    IsActive = true,
                    IsHidden = false,
                }
            );

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    CategoryId = 1,
                    Name = "Garden Tool",
                    Description = "This is a garden tool category",
                    Note = "There are no notes",
                    PropertyId = 1,
                    CreatedBy = "gerryhazelton@gmail.com",
                    CreatedDate = DateTime.UtcNow,
                    IsActive = true,
                    IsHidden = false,
                }
            );

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    CategoryId = 2,
                    Name = "Cleaning Liquid",
                    Description = "This is cleaning liquid category",
                    Note = "There are no notes",
                    PropertyId = 1,
                    CreatedBy = "gerryhazelton@gmail.com",
                    CreatedDate = DateTime.UtcNow,
                    IsActive = true,
                    IsHidden = false,
                }
            );

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    CategoryId = 3,
                    Name = "Gas Powered Tool",
                    Description = "This is gas powered tool category",
                    Note = "There are no notes",
                    PropertyId = 1,
                    CreatedBy = "gerryhazelton@gmail.com",
                    CreatedDate = DateTime.UtcNow,
                    IsActive = true,
                    IsHidden = false,
                }
            );

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    CategoryId = 4,
                    Name = "Literature",
                    Description = "This is literature category",
                    Note = "There are no notes",
                    PropertyId = 1,
                    CreatedBy = "gerryhazelton@gmail.com",
                    CreatedDate = DateTime.UtcNow,
                    IsActive = true,
                    IsHidden = false,
                }
            );

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    CategoryId = 5,
                    Name = "Cleaning Appliance",
                    Description = "This is cleaning appliance category",
                    Note = "There are no notes",
                    PropertyId = 1,
                    CreatedBy = "gerryhazelton@gmail.com",
                    CreatedDate = DateTime.UtcNow,
                    IsActive = true,
                    IsHidden = false,
                }
            );

            modelBuilder.Entity<Credential>().HasData(
                new Credential
                {
                    CredentialId = 1,
                    Name = "CPR",
                    Description = "CRP Certification",
                    Note = "There are no notes",
                    CompletedDate = DateTime.Now,
                    PropertyId = 1,
                    CreatedBy = "gerryhazelton@gmail.com",
                    CreatedDate = DateTime.UtcNow,
                    IsActive = true,
                    IsHidden = false,
                }
            );

            modelBuilder.Entity<Credential>().HasData(
                new Credential
                {
                    CredentialId = 2,
                    Name = "First Aid",
                    Description = "First Aid Certification",
                    Note = "There are no notes",
                    CompletedDate = DateTime.Now,
                    PropertyId = 1,
                    CreatedBy = "gerryhazelton@gmail.com",
                    CreatedDate = DateTime.UtcNow,
                    IsActive = true,
                    IsHidden = false,
                }
            );

            modelBuilder.Entity<Credential>().HasData(
                new Credential
                {
                    CredentialId = 3,
                    Name = "Drivers License",
                    Description = "Drivers License",
                    Note = "There are no notes",
                    CompletedDate = DateTime.Now,
                    PropertyId = 1,
                    CreatedBy = "gerryhazelton@gmail.com",
                    CreatedDate = DateTime.UtcNow,
                    IsActive = true,
                    IsHidden = false,
                }
            );

            modelBuilder.Entity<Credential>().HasData(
                new Credential
                {
                    CredentialId = 4,
                    Name = "Passport",
                    Description = "Drivers License",
                    Note = "There are no notes",
                    CompletedDate = DateTime.Now,
                    PropertyId = 1,
                    CreatedBy = "gerryhazelton@gmail.com",
                    CreatedDate = DateTime.UtcNow,
                    IsActive = true,
                    IsHidden = false,
                }
            );

            modelBuilder.Entity<Credential>().HasData(
                new Credential
                {
                    CredentialId = 5,
                    Name = "Fork Lift Certification",
                    Description = "Fork Lift Certification",
                    Note = "There are no notes",
                    CompletedDate = DateTime.Now,
                    PropertyId = 1,
                    CreatedBy = "gerryhazelton@gmail.com",
                    CreatedDate = DateTime.UtcNow,
                    IsActive = true,
                    IsHidden = false,
                }
            );

            modelBuilder.Entity<Document>().HasData(
                new Document
                {
                    DocumentId = 1,
                    Name = "Annual Event List",
                    Description = "A list of events for the year",
                    Note = "There are no notes",
                    PropertyId = 1,
                    CreatedBy = "gerryhazelton@gmail.com",
                    CreatedDate = DateTime.UtcNow,
                    IsActive = true,
                    IsHidden = false,
                }
            );

            modelBuilder.Entity<Document>().HasData(
                new Document
                {
                    DocumentId = 2,
                    Name = "India Night Announcement",
                    Description = "India Night event announcement",
                    Note = "There are no notes",
                    PropertyId = 1,
                    CreatedBy = "gerryhazelton@gmail.com",
                    CreatedDate = DateTime.UtcNow,
                    IsActive = true,
                    IsHidden = false,
                }
            );

            modelBuilder.Entity<Document>().HasData(
                new Document
                {
                    DocumentId = 3,
                    Name = "Masters Birthday Announcement",
                    Description = "Masters Birthday event announcement",
                    Note = "There are no notes",
                    PropertyId = 1,
                    CreatedBy = "gerryhazelton@gmail.com",
                    CreatedDate = DateTime.UtcNow,
                    IsActive = true,
                    IsHidden = false,
                }
            );

            modelBuilder.Entity<Document>().HasData(
                new Document
                {
                    DocumentId = 4,
                    Name = "All Day Meditation Announcement",
                    Description = "All Day Meditation event announcement",
                    Note = "There are no notes",
                    PropertyId = 1,
                    CreatedBy = "gerryhazelton@gmail.com",
                    CreatedDate = DateTime.UtcNow,
                    IsActive = true,
                    IsHidden = false,
                }
            );

            modelBuilder.Entity<Document>().HasData(
                new Document
                {
                    DocumentId = 5,
                    Name = "All Day Christmas Meditation Announcement",
                    Description = "All Day Christmas Meditation event announcement",
                    Note = "There are no notes",
                    PropertyId = 1,
                    CreatedBy = "gerryhazelton@gmail.com",
                    CreatedDate = DateTime.UtcNow,
                    IsActive = true,
                    IsHidden = false,
                }
            );

            modelBuilder.Entity<Event>().HasData(
                new Event
                {
                    EventId = 1,
                    Name = "Master's Birthday",
                    Description = "Master's birthday celebration",
                    Note = "There are no notes",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddDays(1),
                    PropertyId = 1,
                    CreatedBy = "gerryhazelton@gmail.com",
                    CreatedDate = DateTime.UtcNow,
                    IsActive = true,
                    IsHidden = false,
                }
            );

            modelBuilder.Entity<Event>().HasData(
                new Event
                {
                    EventId = 2,
                    Name = "Krisha's Birthday",
                    Description = "Krishna's birthday celebration",
                    Note = "There are no notes",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddDays(1),
                    PropertyId = 1,
                    CreatedBy = "gerryhazelton@gmail.com",
                    CreatedDate = DateTime.UtcNow,
                    IsActive = true,
                    IsHidden = false,
                }
            );

            modelBuilder.Entity<Event>().HasData(
                new Event
                {
                    EventId = 3,
                    Name = "Sri Yukteswar's Birthday",
                    Description = "Sri Yukteswar's birthday celebration",
                    Note = "There are no notes",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddDays(1),
                    PropertyId = 1,
                    CreatedBy = "gerryhazelton@gmail.com",
                    CreatedDate = DateTime.UtcNow,
                    IsActive = true,
                    IsHidden = false,
                }
            );

            modelBuilder.Entity<Event>().HasData(
                new Event
                {
                    EventId = 4,
                    Name = "Mahatar Babaji's Birthday",
                    Description = "Mahavatar's birthday celebration",
                    Note = "There are no notes",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddDays(1),
                    PropertyId = 1,
                    CreatedBy = "gerryhazelton@gmail.com",
                    CreatedDate = DateTime.UtcNow,
                    IsActive = true,
                    IsHidden = false,
                }
            );

            modelBuilder.Entity<Event>().HasData(
                new Event
                {
                    EventId = 5,
                    Name = "Jesus' Birthday",
                    Description = "Jesus' birthday celebration",
                    Note = "There are no notes",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddDays(1),
                    PropertyId = 1,
                    CreatedBy = "gerryhazelton@gmail.com",
                    CreatedDate = DateTime.UtcNow,
                    IsActive = true,
                    IsHidden = false,
                }
            );

            modelBuilder.Entity<EventType>().HasData(
                new EventType
                {
                    EventTypeId = 1,
                    Name = "Comemerative Service",
                    Description = "Comemerative Service event",
                    Note = "There are no notes",
                    PropertyId = 1,
                    CreatedBy = "gerryhazelton@gmail.com",
                    CreatedDate = DateTime.UtcNow,
                    IsActive = true,
                    IsHidden = false,
                }
            );

            modelBuilder.Entity<EventType>().HasData(
                new EventType
                {
                    EventTypeId = 2,
                    Name = "Birthday",
                    Description = "Birthday Service event",
                    Note = "There are no notes",
                    PropertyId = 1,
                    CreatedBy = "gerryhazelton@gmail.com",
                    CreatedDate = DateTime.UtcNow,
                    IsActive = true,
                    IsHidden = false,
                }
            );

            modelBuilder.Entity<EventType>().HasData(
                new EventType
                {
                    EventTypeId = 3,
                    Name = "Memorial Service",
                    Description = "Memorial Service event",
                    Note = "There are no notes",
                    PropertyId = 1,
                    CreatedBy = "gerryhazelton@gmail.com",
                    CreatedDate = DateTime.UtcNow,
                    IsActive = true,
                    IsHidden = false,
                }
            );

            modelBuilder.Entity<EventType>().HasData(
                new EventType
                {
                    EventTypeId = 4,
                    Name = "Wedding Service",
                    Description = "Wedding Service event",
                    Note = "There are no notes",
                    PropertyId = 1,
                    CreatedBy = "gerryhazelton@gmail.com",
                    CreatedDate = DateTime.UtcNow,
                    IsActive = true,
                    IsHidden = false,
                }
            );

            modelBuilder.Entity<EventType>().HasData(
                new EventType
                {
                    EventTypeId = 5,
                    Name = "Christening Service",
                    Description = "Christening Service event",
                    Note = "There are no notes",
                    PropertyId = 1,
                    CreatedBy = "gerryhazelton@gmail.com",
                    CreatedDate = DateTime.UtcNow,
                    IsActive = true,
                    IsHidden = false,
                }
            );

            modelBuilder.Entity<EventTask>().HasData(
                new EventTask
                {
                    EventTaskId = 1,
                    Name = "Table setup",
                    Description = "Setting up tables",
                    Note = "There are no notes",
                    PropertyId = 1,
                    CreatedBy = "gerryhazelton@gmail.com",
                    CreatedDate = DateTime.UtcNow,
                    IsActive = true,
                    IsHidden = false,
                }
            );

            modelBuilder.Entity<EventTask>().HasData(
                new EventTask
                {
                    EventTaskId = 2,
                    Name = "Chairs setup",
                    Description = "Setting up chairs",
                    Note = "There are no notes",
                    PropertyId = 1,
                    CreatedBy = "gerryhazelton@gmail.com",
                    CreatedDate = DateTime.UtcNow,
                    IsActive = true,
                    IsHidden = false,
                }
            );

            modelBuilder.Entity<EventTask>().HasData(
                new EventTask
                {
                    EventTaskId = 3,
                    Name = "Toilets",
                    Description = "Cleaning toilets",
                    Note = "There are no notes",
                    PropertyId = 1,
                    CreatedBy = "gerryhazelton@gmail.com",
                    CreatedDate = DateTime.UtcNow,
                    IsActive = true,
                    IsHidden = false,
                }
            );

            modelBuilder.Entity<EventTask>().HasData(
                new EventTask
                {
                    EventTaskId = 4,
                    Name = "Mop Floors",
                    Description = "Mopping floors",
                    Note = "There are no notes",
                    PropertyId = 1,
                    CreatedBy = "gerryhazelton@gmail.com",
                    CreatedDate = DateTime.UtcNow,
                    IsActive = true,
                    IsHidden = false,
                }
            );

            modelBuilder.Entity<EventTask>().HasData(
                new EventTask
                {
                    EventTaskId = 5,
                    Name = "Clean Windows",
                    Description = "Cleaning windows",
                    Note = "There are no notes",
                    PropertyId = 1,
                    CreatedBy = "gerryhazelton@gmail.com",
                    CreatedDate = DateTime.UtcNow,
                    IsActive = true,
                    IsHidden = false,
                }
            );

            modelBuilder.Entity<Message>().HasData(
                new Message
                {
                    MessageId = 1,
                    From = "gerryhazelton@gmail.com",
                    To = "janedoe@gmail.com",
                    Subject = "Hello Jane",
                    MessageSent = "This is my message to Jane Doe",
                    PropertyId = 1,
                    StaffId = 1,
                    CreatedBy = "gerryhazelton@gmail.com",
                    CreatedDate = DateTime.UtcNow,
                    IsActive = true,
                    IsHidden = false,
                }
            );

            modelBuilder.Entity<Message>().HasData(
                new Message
                {
                    MessageId = 2,
                    From = "gerryhazelton@gmail.com",
                    To = "johndoe@gmail.com",
                    Subject = "Hello John",
                    MessageSent = "This is my message to John Doe",
                    PropertyId = 1,
                    StaffId = 1,
                    CreatedBy = "gerryhazelton@gmail.com",
                    CreatedDate = DateTime.UtcNow,
                    IsActive = true,
                    IsHidden = false,
                }
            );

            modelBuilder.Entity<Message>().HasData(
                new Message
                {
                    MessageId = 3,
                    From = "gerryhazelton@gmail.com",
                    To = "master@gmail.com",
                    Subject = "Hello Master",
                    MessageSent = "This is my message to Master",
                    PropertyId = 1,
                    StaffId = 1,
                    CreatedBy = "gerryhazelton@gmail.com",
                    CreatedDate = DateTime.UtcNow,
                    IsActive = true,
                    IsHidden = false,
                }
            );

            modelBuilder.Entity<Message>().HasData(
                new Message
                {
                    MessageId = 4,
                    From = "gerryhazelton@gmail.com",
                    To = "dolores@gmail.com",
                    Subject = "Hello Dolores",
                    MessageSent = "This is my message to Dolores",
                    PropertyId = 1,
                    StaffId = 1,
                    CreatedBy = "gerryhazelton@gmail.com",
                    CreatedDate = DateTime.UtcNow,
                    IsActive = true,
                    IsHidden = false,
                }
            );

            modelBuilder.Entity<Message>().HasData(
                new Message
                {
                    MessageId = 5,
                    From = "gerryhazelton@gmail.com",
                    To = "seannie@gmail.com",
                    Subject = "Hello Seannie",
                    MessageSent = "This is my message to Seannie",
                    PropertyId = 1,
                    StaffId = 1,
                    CreatedBy = "gerryhazelton@gmail.com",
                    CreatedDate = DateTime.UtcNow,
                    IsActive = true,
                    IsHidden = false,
                }
            );

            modelBuilder.Entity<SupplyItem>().HasData(
                new SupplyItem
                {
                    SupplyItemId = 1,
                    Name = "Shovel",
                    Description = "Flathead shovel",
                    Quantity = 5,
                    BinNumber = "23A",
                    Note = "No notes",
                    PropertyId = 1,
                    CategoryId = 1,
                    CreatedBy = "gerryhazelton@gmail.com",
                    CreatedDate = DateTime.UtcNow,
                    IsActive = true,
                    IsHidden = false,
                }
            );

            modelBuilder.Entity<SupplyItem>().HasData(
                new SupplyItem
                {
                    SupplyItemId = 2,
                    Name = "Rake",
                    Description = "Flimsy rake",
                    Quantity = 2,
                    BinNumber = "24A",
                    Note = "No notes",
                    PropertyId = 1,
                    CategoryId = 1,
                    CreatedBy = "gerryhazelton@gmail.com",
                    CreatedDate = DateTime.UtcNow,
                    IsActive = true,
                    IsHidden = false,
                }
            );

            modelBuilder.Entity<SupplyItem>().HasData(
                new SupplyItem
                {
                    SupplyItemId = 3,
                    Name = "Lawn Mower",
                    Description = "Gas driven",
                    Quantity = 1,
                    BinNumber = "10C",
                    Note = "No notes",
                    PropertyId = 1,
                    CategoryId = 1,
                    CreatedBy = "gerryhazelton@gmail.com",
                    CreatedDate = DateTime.UtcNow,
                    IsActive = true,
                    IsHidden = false,
                }
            );

            modelBuilder.Entity<SupplyItem>().HasData(
                new SupplyItem
                {
                    SupplyItemId = 4,
                    Name = "Pick",
                    Description = "Pick",
                    Quantity = 1,
                    BinNumber = "13C",
                    Note = "No notes",
                    PropertyId = 1,
                    CategoryId = 1,
                    CreatedBy = "gerryhazelton@gmail.com",
                    CreatedDate = DateTime.UtcNow,
                    IsActive = true,
                    IsHidden = false,
                }
            );

            modelBuilder.Entity<SupplyItem>().HasData(
                new SupplyItem
                {
                    SupplyItemId = 5,
                    Name = "Leaf Blower",
                    Description = "Gas driven",
                    Quantity = 1,
                    BinNumber = "16B",
                    Note = "No notes",
                    PropertyId = 1,
                    CategoryId = 1,
                    CreatedBy = "gerryhazelton@gmail.com",
                    CreatedDate = DateTime.UtcNow,
                    IsActive = true,
                    IsHidden = false,
                }
            );
            #endregion
        }
    }
}

