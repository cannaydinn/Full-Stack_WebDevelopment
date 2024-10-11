using CodeFirstRelation.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var connectionString = builder.Configuration.GetConnectionString("default");
builder.Services.AddDbContext<PatikaSecondDbContext>(options => options.UseSqlServer(connectionString));

var app = builder.Build();

app.UseAuthorization();

app.MapDefaultControllerRoute();

app.Run();
