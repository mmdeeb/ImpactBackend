using Infrastructure.Persistence;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(opt =>
{
    opt.ReturnHttpNotAcceptable = true;
});

builder.Services.AddInfrastructureServices(builder.Configuration);
builder.Services.AddApplicationServices();
builder.Services.AddWebUIServices();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


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
    using (var scope = app.Services.CreateScope())
    {
        var initialiser = scope.ServiceProvider.GetRequiredService<ApplicationDbContextInitialiser>();
        await initialiser.InitialiseAsync();
    }
}
else
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.UseHttpsRedirection();
app.UseAuthentication();

app.UseAuthorization();


app.Run();
