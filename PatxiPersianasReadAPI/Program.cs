using DBContext;
using DTOs.Mappers;
using Infrastructure;
using Infrastructure.Exceptions;
using Infrastructure.Logging;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//REGISTER DBCONTEXT
builder.Services.AddDbContext<ProductsAPIContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DataContext") ?? throw new InvalidOperationException("Connection string 'DataContext' not found."))
    );

//REGISTER EXCEPTION POLICIES
builder.Services.RegisterExceptionPolicies();

// REGISTER VALIDATORS, REPOSITORIES AND SERVICES.
builder.Services.RegisterValidators().RegisterRepositories().RegisterServices();

////REGISTER LOGGING
builder.Logging.RegisterLogging(builder.Configuration);

//Automapper
builder.Services.AddAutoMapper(typeof(BrandsMapperProfile));

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

app.UseMiddleware<ExceptionHandlingMiddleware>();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
