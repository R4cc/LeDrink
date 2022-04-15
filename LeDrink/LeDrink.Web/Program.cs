using Blazorise;
using Blazorise.Bootstrap;
using Blazorise.Icons.FontAwesome;
using LeDrink.DAL.Interfaces;
using LeDrink.DAL.Repos;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddAntDesign();

builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<Radzen.DialogService>();
builder.Services.AddScoped<Radzen.NotificationService>();
builder.Services.AddScoped<IFileUpload, FileUpload>();

builder.Services.AddDbContext<LeDrink.DAL.Data.ApplicationDBContext>(options =>
{
    options.UseSqlite("Data Source = Drinks.db");
});

builder.Services
    .AddBlazorise(options =>
    {
        options.Immediate = true;
    })
    .AddBootstrapProviders()
    .AddFontAwesomeIcons();

builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.UseRequestLocalization(new RequestLocalizationOptions()
    .AddSupportedCultures(new[] { "de-AT", "en-US" })
    .AddSupportedUICultures(new[] { "de-AT", "en-US" })
    .SetDefaultCulture("en-US"));
    //.SetDefaultCulture("de-AT"));

app.Run();
