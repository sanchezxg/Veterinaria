using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using veterinariafront;
using veterinariafront.servicios;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7051") });

builder.Services.AddScoped<Irepositorio, repositorio>();


await builder.Build().RunAsync();
