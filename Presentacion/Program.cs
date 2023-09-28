using Proyecto.Persistencia;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Presentacion.Areas.Identity.Data;


var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("PresentacionIdentityDbContextConnection") ?? throw new InvalidOperationException("Connection string 'PresentacionIdentityDbContextConnection' not found.");

builder.Services.AddDbContext<PresentacionIdentityDbContext>(options =>
    options.UseSqlServer(connectionString));

//builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
   // .AddEntityFrameworkStores<PresentacionIdentityDbContext>();

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddScoped<IRepositorio, Repositorio>();
builder.Services.AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<PresentacionIdentityDbContext>()
    .AddDefaultUI()
    .AddDefaultTokenProviders();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();;

app.UseAuthorization();

app.MapRazorPages();

app.Run();
