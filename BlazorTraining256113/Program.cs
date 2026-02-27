using BlazorTraining256113.Components;
using BlazorTraining256113.Components.Pages.Modul4;
using BlazorTraining256113.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddScoped<ToDoVM>();
builder.Services.AddSingleton<ChatVM>();
builder.Services.AddHttpClient();
builder.Services.AddDbContext<NorthwindContext>(o => o.UseSqlServer(
    builder.Configuration.GetConnectionString("northwind")));
//builder.Services.AddDbContextFactory<NorthwindContext>(o => o.UseSqlServer(
//    builder.Configuration.GetConnectionString("northwind")));
builder.Services.AddQuickGridEntityFrameworkAdapter();

builder.Services.AddDatabaseDeveloperPageExceptionFilter();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    app.UseMigrationsEndPoint();
}
app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
