using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using UIBlazorTickets;
using UIBlazorTickets.Services.ResponseServices;
using UIBlazorTickets.Services.TicketServices;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<ITicketService, TicketService>();
builder.Services.AddScoped<IResponseService, ResponseService>();
await builder.Build().RunAsync();
