using ImpactApplication;
using ImpactInfrastructure;
using ImpactInfrastructure.Persistence;
using ImpactPresentation;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Serilog;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services
    .AddApplication()
    .AddInfrastructure(builder.Configuration)
    .AddPresentation();
builder.Services.AddDbContext<ImpactDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly("ImpactWebApi")));
builder.Host.UseSerilog((context, configuration) =>
    configuration.ReadFrom.Configuration(context.Configuration));
//add authintication
builder.Services.AddAuthentication("Bearer").AddJwtBearer(
options =>
{
    options.TokenValidationParameters = new()
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = builder.Configuration["Authentiaction:Issuer"],
        ValidAudience = builder.Configuration["Authentiaction:Audience"],
        IssuerSigningKey = new
            SymmetricSecurityKey(Encoding.ASCII.GetBytes(builder.Configuration["Authentiaction:Secret"])),
    };
}
);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();

app.UseAuthorization();
app.MapControllers();

app.Run();
