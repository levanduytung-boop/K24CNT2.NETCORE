using LeVanDuyTung2410900085_exam.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Cấu hình kết nối SQL Server với LvdtDbContext
builder.Services.AddDbContext<LvdtDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("LvdtDbConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

// Map route dự phòng cho tên gốc HvtEmployees và HvtStudents
app.MapControllerRoute(
    name: "hvtEmployees",
    pattern: "HvtEmployees/{action=Index}/{id?}",
    defaults: new { controller = "LvdtEmployees" });

app.MapControllerRoute(
    name: "hvtStudents",
    pattern: "HvtStudents/{action=Index}/{id?}",
    defaults: new { controller = "LvdtStudents" });

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

app.Run();
