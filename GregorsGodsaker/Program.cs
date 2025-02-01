using GregorsGodsaker.Components;
using GregorsGodsaker.Components.Services;
using GregorsGodsaksKontrakter;
using Refit;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Her legger man til flere servicer, ved behov
builder.Services.AddScoped<ISnackService, SnackService>();

// Her har vi definert en Refit-klient, som går mot API-et vårt
builder.Services.AddRefitClient<ISnacks>()
    .ConfigureHttpClient(c => c.BaseAddress = new Uri("http://localhost:5007"));

builder.Services.AddRefitClient<IWines>()
    .ConfigureHttpClient(c => c.BaseAddress = new Uri("http://localhost:5007"));

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", true);
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();