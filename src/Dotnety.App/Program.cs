using MudBlazor.Services;
using Dotnety.App.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Dotnety.App.Infrastructure;
using SQLitePCL;

var builder = WebApplication.CreateBuilder(args);
Batteries.Init();

// Load connection strings
var configuration = builder.Configuration;
var environment = builder.Environment;
// Add MudBlazor services
builder.Services.AddMudServices();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddDbContext<DotnetyDbContext>(options =>
    options.UseSqlite(configuration.GetConnectionString("SQLiteConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
