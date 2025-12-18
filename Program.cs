using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Coborzan_Tudor_Lab2_M.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Coborzan_Tudor_Lab2_MContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Coborzan_Tudor_Lab2_MContext")
    ?? throw new InvalidOperationException("Connection string 'Coborzan_Tudor_Lab2_MContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    DbInitializer.Initialize(services);
}
    // Configure the HTTP request pipeline.
    if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
