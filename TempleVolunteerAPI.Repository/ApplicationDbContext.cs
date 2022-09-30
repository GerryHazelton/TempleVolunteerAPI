using Microsoft.EntityFrameworkCore;
using TempleVolunteerAPI.Domain;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace TempleVolunteerAPI.Repository
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }

        public virtual DbSet<Area> Areas { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
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

        public virtual DbSet<AreaEventTask> AreaEventTask { get; set; }
        public virtual DbSet<AreaEventType> AreaEventType { get; set; }
        public virtual DbSet<AreaSupplyItem> AreaSupplyItem { get; set; }
        public virtual DbSet<CredentialStaff> CredentialStaff { get; set; }
        public virtual DbSet<EventEventType> EventEventType { get; set; }
        //public virtual DbSet<PropertyStaff> PropertyStaff { get; set; }
        public virtual DbSet<RoleStaff> RoleStaff { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region Area EventTask
            modelBuilder.Entity<AreaEventTask>()
            .HasKey(x => new { x.AreaId, x.EventTaskId });

            modelBuilder.Entity<AreaEventTask>()
                .HasOne(x => x.Area)
                .WithMany()
                .HasForeignKey(x => x.AreaId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<AreaEventTask>()
                .HasOne(x => x.EventTask)
                .WithMany()
                .HasForeignKey(x => x.EventTaskId)
                .OnDelete(DeleteBehavior.Restrict);
            #endregion

            #region Area EventType
            modelBuilder.Entity<AreaEventType>()
            .HasKey(x => new { x.AreaId, x.EventTypeId });

            modelBuilder.Entity<AreaEventType>()
                .HasOne(x => x.Area)
                .WithMany()
                .HasForeignKey(x => x.AreaId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<AreaEventType>()
                .HasOne(x => x.EventType)
                .WithMany()
                .HasForeignKey(x => x.EventTypeId)
                .OnDelete(DeleteBehavior.Restrict);
            #endregion

            #region Area SupplyItem
            modelBuilder.Entity<AreaSupplyItem>()
            .HasKey(x => new { x.AreaId, x.SupplyItemId });

            modelBuilder.Entity<AreaSupplyItem>()
                .HasOne(x => x.Area)
                .WithMany()
                .HasForeignKey(x => x.AreaId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<AreaSupplyItem>()
                .HasOne(x => x.SupplyItem)
                .WithMany()
                .HasForeignKey(x => x.SupplyItemId)
                .OnDelete(DeleteBehavior.Restrict);
            #endregion

            #region Credential Staff
            modelBuilder.Entity<CredentialStaff>()
            .HasKey(x => new { x.CredentialId, x.StaffId });

            modelBuilder.Entity<CredentialStaff>()
                .HasOne(x => x.Credential)
                .WithMany()
                .HasForeignKey(x => x.CredentialId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<CredentialStaff>()
                .HasOne(x => x.Staff)
                .WithMany()
                .HasForeignKey(x => x.StaffId)
                .OnDelete(DeleteBehavior.Restrict);
            #endregion

            #region Event EventType
            modelBuilder.Entity<EventEventType>()
            .HasKey(x => new { x.EventId, x.EventTypeId });

            modelBuilder.Entity<EventEventType>()
                .HasOne(x => x.Event)
                .WithMany()
                .HasForeignKey(x => x.EventId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<EventEventType>()
                .HasOne(x => x.EventType)
                .WithMany()
                .HasForeignKey(x => x.EventTypeId)
                .OnDelete(DeleteBehavior.Restrict);
            #endregion

            //#region Property Staff
            //modelBuilder.Entity<PropertyStaff>()
            //.HasKey(x => new { x.PropertyId, x.StaffId });

            //modelBuilder.Entity<PropertyStaff>()
            //    .HasOne(x => x.Property)
            //    .WithMany()
            //    .HasForeignKey(x => x.PropertyId);

            //modelBuilder.Entity<PropertyStaff>()
            //    .HasOne(x => x.Staff)
            //    .WithMany()
            //    .HasForeignKey(x => x.StaffId);
            //#endregion

            #region Role Staff
            modelBuilder.Entity<RoleStaff>()
            .HasKey(x => new { x.RoleId, x.StaffId });

            modelBuilder.Entity<RoleStaff>()
                .HasOne(x => x.Role)
                .WithMany()
                .HasForeignKey(x => x.RoleId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<RoleStaff>()
                .HasOne(x => x.Staff)
                .WithMany()
                .HasForeignKey(x => x.StaffId)
                .OnDelete(DeleteBehavior.Restrict);
            #endregion

            Property glendale = new Property("gerryhazelton@gmail.com");
            glendale.PropertyId = 1;
            glendale.Name = "Glendale Temple";
            glendale.Address = "123 Main Street";
            glendale.Address2 = "Suite 45";
            glendale.City = "Glendale";
            glendale.State = "CA";
            glendale.PostalCode = "91001";
            glendale.Country = "US";
            glendale.EmailAddress = "Glendale@Srf.com";
            glendale.PhoneNumber = "222-222-2222";
            glendale.FaxNumber = "333-333-3333";
            glendale.Website = "https://www.glendaletemple.org";
            glendale.Note = "Currently, there are no notes";
            glendale.CreatedBy = "gerryhazelton@gmail.com";
            glendale.CreatedDate = DateTime.UtcNow;
            glendale.IsActive = true;
            glendale.IsHidden = false;

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

            modelBuilder.Entity<Property>().HasData(
                glendale,
                encinitas
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

            modelBuilder.Entity<Role>().HasData(
                glendaleAdmin,
                glendaleVolunteer,
                encinitasAdmin,
                encinitasVolunteer
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
            gerry.Password = "OLpa5mnXgMZyfwlSkiHI2/enbMo4iTQkPpE9+xYHMEI=";
            gerry.PasswordSalt = "371952==";
            gerry.PropertyId = 1;
            gerry.CreatedBy = "gerryhazelton@gmail.com";
            gerry.CreatedDate = DateTime.UtcNow;

            Staff gerry2 = new Staff("gerryhazelton@gmail.com");
            gerry2.StaffId = 2;
            gerry2.FirstName = "Gerry";
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
            gerry2.Password = "OLpa5mnXgMZyfwlSkiHI2/enbMo4iTQkPpE9+xYHMEI=";
            gerry2.PasswordSalt = "371952==";
            gerry.PropertyId = 2;
            gerry2.CreatedBy = "gerryhazelton@gmail.com";
            gerry2.CreatedDate = DateTime.UtcNow;

            modelBuilder.Entity<Staff>().HasData(
                gerry, gerry2
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

            modelBuilder.Entity<EventType>().HasData(
                new EventType
                {
                    EventTypeId = 1,
                    Name = "Birthday",
                    Description = "Birthday event",
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
                    Subject = "Hello",
                    MessageSent = "This is my message",
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
                    PropertyId = 1,
                    CategoryId = 1,
                    CreatedBy = "gerryhazelton@gmail.com",
                    CreatedDate = DateTime.UtcNow,
                    IsActive = true,
                    IsHidden = false,
                }
            );

            modelBuilder.Entity<Area>()
                .HasMany(left => left.EventTasks)
                .WithMany(right => right.Areas)
                .UsingEntity<AreaEventTask>(
                right => right.HasOne(e => e.EventTask).WithMany(),
                left => left.HasOne(e => e.Area).WithMany().HasForeignKey(e => e.AreaId),
                join => join.ToTable("AreaEvenTask")
            );

            modelBuilder.Entity<AreaEventTask>().HasData(
                new AreaEventTask() { AreaId = 1, EventTaskId = 1, PropertyId = 1 }
            );

            modelBuilder.Entity<Area>()
                .HasMany(left => left.EventTypes)
                .WithMany(right => right.Areas)
                .UsingEntity<AreaEventType>(
                right => right.HasOne(e => e.EventType).WithMany(),
                left => left.HasOne(e => e.Area).WithMany().HasForeignKey(e => e.AreaId),
                join => join.ToTable("AreaEvenType")
            );

            modelBuilder.Entity<AreaEventType>().HasData(
                new AreaEventType() { AreaId = 1, EventTypeId = 1, PropertyId = 1 }
            );

            modelBuilder.Entity<Area>()
                .HasMany(left => left.SupplyItems)
                .WithMany(right => right.Areas)
                .UsingEntity<AreaSupplyItem>(
                right => right.HasOne(e => e.SupplyItem).WithMany(),
                left => left.HasOne(e => e.Area).WithMany().HasForeignKey(e => e.AreaId),
                join => join.ToTable("AreaSupplyItem")
            );

            modelBuilder.Entity<AreaSupplyItem>().HasData(
                new AreaSupplyItem() { AreaId = 1, SupplyItemId = 1, PropertyId = 1 }
            );

            modelBuilder.Entity<Credential>()
                .HasMany(left => left.Staff)
                .WithMany(right => right.Credentials)
                .UsingEntity<CredentialStaff>(
                right => right.HasOne(e => e.Staff).WithMany(),
                left => left.HasOne(e => e.Credential).WithMany().HasForeignKey(e => e.CredentialId),
                join => join.ToTable("CredentialStaff")
            );

            modelBuilder.Entity<CredentialStaff>().HasData(
                new CredentialStaff() { CredentialId = 1, StaffId = 1, PropertyId = 1 }
            );

            modelBuilder.Entity<Event>()
                .HasMany(left => left.EventTypes)
                .WithMany(right => right.Events)
                .UsingEntity<EventEventType>(
                right => right.HasOne(e => e.EventType).WithMany(),
                left => left.HasOne(e => e.Event).WithMany().HasForeignKey(e => e.EventId),
                join => join.ToTable("EventEventType")
            );

            modelBuilder.Entity<EventEventType>().HasData(
                new EventEventType() { EventId = 1, EventTypeId = 1, PropertyId = 1 }
            );

            modelBuilder.Entity<Property>()
                .HasMany(left => left.Staff)
                .WithMany(right => right.Properties)
                .UsingEntity<PropertyStaff>(
                right => right.HasOne(e => e.Staff).WithMany(),
                left => left.HasOne(e => e.Property).WithMany().HasForeignKey(e => e.PropertyId),
                join => join.ToTable("PropertyStaff")
            );

            //modelBuilder.Entity<PropertyStaff>().HasData(
            //    new PropertyStaff() { PropertyId = 1, StaffId = 1 },
            //    new PropertyStaff() { PropertyId = 2, StaffId = 2 }
            //);

            modelBuilder.Entity<Staff>()
                .HasMany(left => left.Roles)
                .WithMany(right => right.Staff)
                .UsingEntity<RoleStaff>(
                right => right.HasOne(e => e.Role).WithMany(),
                left => left.HasOne(e => e.Staff).WithMany().HasForeignKey(e => e.StaffId),
                join => join.ToTable("RoleStaff")
            );

            modelBuilder.Entity<RoleStaff>().HasData(
                new RoleStaff() { RoleId = 1, StaffId = 1, PropertyId = 1 },
                new RoleStaff() { RoleId = 4, StaffId = 2, PropertyId = 2 }
            );
        }
    }
}

