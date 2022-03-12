using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages().AddNToastNotifyNoty();


builder.Services.AddDbContext<ContactApplication.Data.SampledbContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("SampleDatabase")));


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
app.UseNToastNotify();
app.UseRouting();

app.MapRazorPages();

app.Run();
