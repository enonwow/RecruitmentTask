using RecruitmentTask.Calculator;
using RecruitmentTask.Calculator.Abstractions;
using RecruitmentTask.DataAccess;
using RecruitmentTask.DataAccess.Abstractions;
using RecruitmentTask.Utility;
using RecruitmentTask.Utility.Abstractions;
using RecruitmentTask.Web.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services
    .AddSingleton<IDataHandler, DataHandler>()
    .AddSingleton<IParserCSV, ParserCSV>()
    .AddSingleton<IFilterCalculator, FilterCalculator>()
    .AddSingleton<IDataCache, DataCache>()
    .AddMemoryCache();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
