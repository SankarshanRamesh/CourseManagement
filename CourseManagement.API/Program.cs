using CourseManagement.Core.Entities;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

// Add services to the container.

//DB configuration goes here
//Tips, if you want to see what are paramters we can enable here but it shows all sensitive data
//so only used for development purpose should not go to PRODUCTION!
builder.Services.AddDbContextPool<OnlineCourseDbContext>(options =>
{
    options.UseSqlServer(
        configuration.GetConnectionString("DbContext"),
    provideroptions => provideroptions.EnableRetryOnFailure()

    );
    options.EnableSensitiveDataLogging();
    options.EnableDetailedErrors();

});


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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
