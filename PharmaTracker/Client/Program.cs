using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.AspNetCore.Components.Authorization;
using PharmaTracker.Client;
using PharmaTracker.Client.Extensions;
using Blazored.SessionStorage;
using Radzen;
using PharmaTracker.Client.Services.CarritoService;
using PharmaTracker.Client.Services.ProductosService;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddBlazoredSessionStorage();
builder.Services.AddScoped<IProductosService, ProductosService>();
builder.Services.AddScoped<ICarritoService, CarritoService>();
builder.Services.AddScoped<AuthenticationStateProvider, AuthenticacionExtension>();
builder.Services.AddAuthorizationCore();

builder.Services.AddScoped<NotificationService>();
builder.Services.AddRadzenComponents();

await builder.Build().RunAsync();
