using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PeriPeri.Domain.Entities.User;
using PeriPeri.Persistence.Contexts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowVueApp",
        policy => policy.WithOrigins("http://localhost:3000")
                        .AllowAnyMethod()
                        .AllowAnyHeader());
});

string postgresConnectionString = string.Empty;

postgresConnectionString = builder.Configuration.GetConnectionString("DefaultConnection") 
    ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

builder.Services.AddDbContext<DomainEntityDbContext>(options =>
{
    options.UseNpgsql(postgresConnectionString);
});

builder.Services.AddDbContext<UserDbContext>(options =>
{
    options.UseNpgsql(postgresConnectionString);
});

// builder.Services.AddIdentity<User, UserTypes>()
//     .AddEntityFrameworkStores<UserDbContext>()
//     .AddDefaultTokenProviders();


var app = builder.Build();

app.UseCors("AllowVueApp"); // Apply CORS policy

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
