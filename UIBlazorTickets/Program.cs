using AppLogic.Services.ResponseServices;
using AppLogic.Services.TicketServices;
using AppLogic.Services.ViewServices;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using UIBlazorTickets;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<ITicketServices, TicketServices>();
builder.Services.AddScoped<IResponseService, ResponseService>();
builder.Services.AddScoped<IViewServices, ViewServices>();
await builder.Build().RunAsync();
