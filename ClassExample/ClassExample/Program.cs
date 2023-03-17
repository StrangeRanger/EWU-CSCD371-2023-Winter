using ClassExample.Data;
using ClassExample.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

using var db = app.Services.CreateAsyncScope().ServiceProvider.GetRequiredService<ApplicationDbContext>();
await db.Database.MigrateAsync();

if (!db.People.Any())
{
    for(int i = 1; i < 11; i++)
    {
        db.People.Add(new Person()
        {
            FirstName = $"Person",
            LastName = i.ToString(),
            Age = i+10,
            Address = $"{i}{i+1} N Spokane St.",
            City = "Spokane"
        });
    }
    await db.SaveChangesAsync();
}

app.Run();
