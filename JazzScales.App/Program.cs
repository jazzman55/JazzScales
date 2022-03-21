using JazzScales.App;
using JazzScales.App.ViewModels;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddTransient<FindScaleViewModel>();
builder.Services.AddTransient<ScalesViewModel>();
builder.Services.AddSingleton<MessageViewModel>();

await builder.Build().RunAsync();
