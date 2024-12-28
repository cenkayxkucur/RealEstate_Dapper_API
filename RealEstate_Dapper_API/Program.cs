using RealEstate_Dapper_API.Models.DapperContext;
using RealEstate_Dapper_API.Repositories.BottomGridRepositories;
using RealEstate_Dapper_API.Repositories.CategoryRepository;
using RealEstate_Dapper_API.Repositories.EmployeeRepositories;
using RealEstate_Dapper_API.Repositories.PopularLocationRepositories;
using RealEstate_Dapper_API.Repositories.ProductRepository;
using RealEstate_Dapper_API.Repositories.ServiceRepository;
using RealEstate_Dapper_API.Repositories.StatisticsRepositories;
using RealEstate_Dapper_API.Repositories.TestimonialRepositories;
using RealEstate_Dapper_API.Repositories.WhoWeAreRepository;
using RealEstate_Dapper_API.Repositories.ContactRepositories;
using RealEstate_Dapper_API.Repositories.ToDoListRepositories;
using RealEstate_Dapper_API.Hubs;
using RealEstate_Dapper_API.Repositories.EstateAgentRepositories.DashboardRepositories.StatisticRepositories;
using RealEstate_Dapper_API.Repositories.EstateAgentRepositories.DashboardRepositories.ChartRepositories;
using RealEstate_Dapper_API.Repositories.EstateAgentRepositories.DashboardRepositories.LastProductsRepositories;
using RealEstate_Dapper_API.Repositories.MessageRepositories;
using RealEstate_Dapper_API.Repositories.ProductImageRepositories;
using RealEstate_Dapper_API.Repositories.AppUserRepositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddTransient<Context>();
builder.Services.AddTransient<ICategoryRepository, CategoryRepository>();
builder.Services.AddTransient<IProductRepository, ProductRepository>();
builder.Services.AddTransient<IWhoWeAreDetailRepository, WhoWeAreDetailRepository>();
builder.Services.AddTransient<IServiceRepository, ServiceRepository>();
builder.Services.AddTransient<IBottomGridRepository, BottomGridRepository>();
builder.Services.AddTransient<IPopularLocationRepository, PopularLocationRepository>();
builder.Services.AddTransient<ITestimonialRepository, TestimonialRepository>();
builder.Services.AddTransient<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddTransient<IStatisticsRepository , StatisticsRepository>();
builder.Services.AddTransient<IContactRepository , ContactRepository>();
builder.Services.AddTransient<IToDoListRepository, ToDoListRepository>();
builder.Services.AddTransient<IStatisticRepository, StatisticRepository>();
builder.Services.AddTransient<IChartRepository, ChartRepository>();
builder.Services.AddTransient<ILast5ProductsRepository, Last5ProductsRepository>();
builder.Services.AddTransient<IMessageRepository, MessageRepository>();
builder.Services.AddTransient<IProductImageRepository, ProductImageRepository >();
builder.Services.AddTransient<IAppUserRepository, AppUserRepository >();

builder.Services.AddCors(opt =>
{ 
    opt.AddPolicy("CorsPolicy",builder => 
    {
        builder.AllowAnyHeader()
               .AllowAnyMethod()
               .SetIsOriginAllowed((host) => true)
               .AllowCredentials();
        
    });
});
builder.Services.AddHttpClient();
builder.Services.AddSignalR();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("CorsPolicy");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapHub<SignalRHub>("/signalrhub");


app.Run();
