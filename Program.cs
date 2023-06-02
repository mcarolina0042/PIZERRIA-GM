using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using PIZERRIAGM.Data;
using PIZERRIAGM.Data.Context;
using PIZERRIAGM.Data.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddDbContext<MyDbContext>();
builder.Services.AddScoped<IMyDbContext, MyDbContext>();
builder.Services.AddScoped<IClienteServices, ClienteServices>();
builder.Services.AddScoped<IDetalleFacturaServices, DetalleFacturaServices>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
