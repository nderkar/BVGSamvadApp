using Blazored.LocalStorage;
using Samvad_App.Client;
using Samvad_App.Client.Helpers;
using Samvad_App.Client.Services;
using Samvad_App.Shared.Helpers;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddBlazoredLocalStorage();
builder.Services.AddAuthorizationCore(config =>
{
	config.AddPolicy(Policies.IsAdmin, Policies.IsAdminPolicy());
	config.AddPolicy(Policies.IsUser, Policies.IsUserPolicy());
});
builder.Services.AddScoped<AuthenticationStateProvider, ApiAuthenticationStateProvider>();
builder.Services.AddScoped<IAuthService, AuthService>();
await builder.Build().RunAsync();

