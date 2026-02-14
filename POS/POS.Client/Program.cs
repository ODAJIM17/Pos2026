using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using POS.Client.Providers;
using POS.Client.Services;

namespace POS.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            var urlLocal = "https://localhost:7067";
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(urlLocal) });

            builder.Services.AddMudServices();
            builder.Services.AddAuthorizationCore();
            builder.Services.AddScoped<CustomAuthProvider>();
            builder.Services.AddScoped<AuthService>();
            builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthProvider>(x => x.GetRequiredService<CustomAuthProvider>());
            builder.Services.AddScoped<ILoginService, CustomAuthProvider>(x => x.GetRequiredService<CustomAuthProvider>());
            await builder.Build().RunAsync();
        }
    }
}