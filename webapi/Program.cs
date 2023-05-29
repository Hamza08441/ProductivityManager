using Microsoft.EntityFrameworkCore;
using webapi.Data;
using webapi.services.EmployeeService;
using webapi.services.ProjectsService;
using webapi.services.UsersService;
using webapi.services.UserTypesService;
using webapi.services.UserTypesServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddDbContext<dbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString") ?? throw new InvalidOperationException("Connection string 'dbContext' not found.")));
builder.Services.AddTransient<IEmployeeService, EmployeeService>();
builder.Services.AddTransient<IProjectsService, ProjectsService>();
builder.Services.AddTransient<IUsersService, UsersService>();
builder.Services.AddTransient<IUserTypesService, UserTypesService>();


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options=>
{ });
var provider =builder.Services.BuildServiceProvider();
var configuration = provider.GetService<IConfiguration>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
