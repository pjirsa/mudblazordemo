using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using mudblazordemo.Client;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped<IWeatherService, ClientWeatherService>();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddMudServices();

await builder.Build().RunAsync();
