using ECC.Web.Client.Pages;
using ECC.Web.Client.Services.Ecclesiastical;
using ECC.Web.Client.Services.Form;
using ECC.Web.Client.Services.Location;
using ECC.Web.Components;

var builder = WebApplication.CreateBuilder(args);

// Add telemetry services?

// Configure authentication and authorization?

// Configure data protection to share keys between BFF and API
builder.Services.AddDataProtection(setup => setup.ApplicationDiscriminator = "ECC");

// Configure Client Services
builder.Services.AddScoped<ILocationService, LocationService>();
builder.Services.AddScoped<IEcclesiasticalService, EcclesiasticalService>();
builder.Services.AddScoped<IFormService, FormService>();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveWebAssemblyComponents();

builder.Services.AddHttpForwarderWithServiceDiscovery();

// Configure authentication client for API?

var app = builder.Build();

// Configure telemetry services?

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(ECC.Web.Client._Imports).Assembly);

// Map BFF endpoints

await app.RunAsync();
