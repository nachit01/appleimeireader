using Microsoft.AspNetCore.Hosting;

var builder = WebApplication.CreateBuilder(args);

// // Configure Kestrel and set the desired port (e.g., 8000)
// builder.WebHost.ConfigureKestrel(options =>
// {
//     options.ListenAnyIP(7001); // Change the port here
// });

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

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
