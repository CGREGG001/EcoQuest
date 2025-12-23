using DotNetEnv;
using EcoQuest.Web.Data;
using EcoQuest.Web.Extensions; // Access the AddEcoQuestServices() extension method
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

Env.Load();

// load connection strings from env.
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(Environment.GetEnvironmentVariable("ConnectionStrings__DefaultConnection")));

// Add services to the container.
builder.Services.AddControllersWithViews();

// Configure ASP.NET Core Identity (users, roles, tokens)
builder.Services.AddEcoQuestIdentity();

// Register EcoQuest application services and repositories
builder.Services.AddEcoQuestServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

// Adds the authentication middleware to the HTTP pipeline
app.UseAuthentication();

// Adds the authorization middleware to the HTTP pipeline
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
