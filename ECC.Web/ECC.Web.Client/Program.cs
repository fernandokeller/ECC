using ECC.Web.Client.Services.Ecclesiastical;
using ECC.Web.Client.Services.Form;
using ECC.Web.Client.Services.Location;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Configure Services
Action<HttpClient> clientConfiguration = (client) =>
{
    client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
    client.DefaultRequestHeaders.TryAddWithoutValidation("X-Requested-With", "XMLHttpRequest");
};

builder.Services.AddHttpClient<ILocationService>(clientConfiguration);
builder.Services.AddHttpClient<IEcclesiasticalService>(clientConfiguration);
builder.Services.AddHttpClient<IFormService>(clientConfiguration);

await builder.Build().RunAsync();
