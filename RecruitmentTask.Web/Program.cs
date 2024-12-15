using RecruitmentTask.ApplicationLayer;
using RecruitmentTask.ApplicationLayer.Abstractions;
using RecruitmentTask.BuisnessLayer;
using RecruitmentTask.BuisnessLayer.Abstractions;
using RecruitmentTask.DataAccessLayer;
using RecruitmentTask.DataAccessLayer.Abstractions;
using RecruitmentTask.Web.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services
    .AddTransient<IDataContext, DataContext>()
    .AddTransient<IEmployeeRepository, EmployeeRepository>()
    .AddTransient<IEmployeeService, EmployeeService>()
    .AddSingleton<IDataCache, DataCache>()
    .AddTransient<IEmployeeAppService, EmployeeAppService>()
    .AddMemoryCache();

builder.Services.AddDistributedMemoryCache();

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

builder.Services.AddHttpContextAccessor();

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

app.UseSession();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
