using BlazorTransientDisposables.Client;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddTransient<TransientDisposableService>();

await builder.Build().RunAsync();
