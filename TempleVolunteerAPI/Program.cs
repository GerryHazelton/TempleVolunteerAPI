using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using TempleVolunteerAPI.Service;
using System.Text;
using TempleVolunteerAPI.Domain;
using TempleVolunteerAPI.Repository;
using SRFSDP.Api.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("SQLConn");
builder.Services.AddDbContext<ApplicationDBContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers().AddJsonOptions(x => x.JsonSerializerOptions.IgnoreNullValues = true);
builder.Services.Configure<AppSettings>(builder.Configuration.GetSection("AppSettings"));
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromSeconds(200);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

#region Services injection
builder.Services.AddScoped<IEmailService, EmailService>();
builder.Services.AddTransient(typeof(IAccountService), typeof(AccountService));
builder.Services.AddTransient(typeof(IAreaService), typeof(AreaService));
builder.Services.AddTransient(typeof(ICredentialService), typeof(CredentialService));
builder.Services.AddTransient(typeof(IDocumentService), typeof(DocumentService));
builder.Services.AddTransient(typeof(IErrorLogService), typeof(ErrorLogService));
builder.Services.AddTransient(typeof(IEventService), typeof(EventService));
builder.Services.AddTransient(typeof(IEventTypeService), typeof(EventTypeService));
builder.Services.AddTransient(typeof(IMessageService), typeof(MessageService));
builder.Services.AddTransient(typeof(IPropertyService), typeof(PropertyService));
builder.Services.AddTransient(typeof(IRoleService), typeof(RoleService));
builder.Services.AddTransient(typeof(IStaffService), typeof(StaffService));
builder.Services.AddTransient(typeof(ISupplyItemService), typeof(SupplyItemService));
builder.Services.AddTransient(typeof(ITokenService), typeof(TokenService));
builder.Services.AddTransient(typeof(IPropertyStaffService), typeof(PropertyStaffService));
builder.Services.AddTransient(typeof(IRoleStaffService), typeof(RoleStaffService));
#endregion

#region Repositories injection
builder.Services.AddTransient(typeof(IAccountRepository), typeof(AccountRepository));
builder.Services.AddTransient(typeof(IAreaRepository), typeof(AreaRepository));
builder.Services.AddTransient(typeof(ICredentialRepository), typeof(CredentialRepository));
builder.Services.AddTransient(typeof(IDocumentRepository), typeof(DocumentRepository));
builder.Services.AddTransient(typeof(IErrorLogRepository), typeof(ErrorLogRepository));
builder.Services.AddTransient(typeof(IEventRepository), typeof(EventRepository));
builder.Services.AddTransient(typeof(IEventTypeRepository), typeof(EventTypeRepository));
builder.Services.AddTransient(typeof(IMessageRepository), typeof(MessageRepository));
builder.Services.AddTransient(typeof(IPropertyRepository), typeof(PropertyRepository));
builder.Services.AddTransient(typeof(IRoleRepository), typeof(RoleRepository));
builder.Services.AddTransient(typeof(IStaffRepository), typeof(StaffRepository));
builder.Services.AddTransient(typeof(ISupplyItemRepository), typeof(SupplyItemRepository));
builder.Services.AddTransient(typeof(IPropertyStaffRepository), typeof(PropertyStaffRepository));
builder.Services.AddTransient(typeof(IRoleStaffRepository), typeof(RoleStaffRepository));
#endregion

#region Misc injection
builder.Services.AddControllers();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
builder.Services.AddTransient<IUnitOfWorkManyToMany, UnitOfWorkManyToMany>();
builder.Services.AddTransient(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
builder.Services.AddTransient(typeof(IRepositoryManyToManyBase<>), typeof(RepositoryManyToManyBase<>));
builder.Services.AddTransient(typeof(IServiceBase<>), typeof(ServiceBase<>));
builder.Services.AddTransient(typeof(IServiceManyToManyBase<>), typeof(ServiceManyToManyBase<>));
#endregion

var sharedKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("Mataji22Mataji33Mataji44Mataji55Mataji66Mataji77Mataji88Mataji99Mataji00"));

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
        .AddJwtBearer(options =>
        {
            options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateIssuerSigningKey = true,
                ValidIssuer = "http://sdportal.com",
                ValidAudience = "http://sdportal.com",
                IssuerSigningKey = new SymmetricSecurityKey(Convert.FromBase64String("Mataji22Mataji33Mataji44Mataji55Mataji66Mataji77Mataji88Mataji99Mataji00"))
            };

        });

builder.Services.AddMvc(
        x => x.EnableEndpointRouting = false
    );

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});
app.UseHttpsRedirection();
app.MapControllers();
app.Run();
