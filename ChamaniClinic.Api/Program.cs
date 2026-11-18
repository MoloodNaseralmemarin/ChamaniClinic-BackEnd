using ChamaniClinic.Application.Interfaces;
using ChamaniClinic.Application.Services;
using ChamaniClinic.Domain.Interfaces;
using ChamaniClinic.Infrastructure.DBContext;
using ChamaniClinic.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// ────── Configuration ──────
builder.Configuration
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true, reloadOnChange: true);

// ────── Services ──────
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddOpenApi();

// ────── Database Context ──────
builder.Services.AddDbContext<ChamaniClinicDBContext>(options =>
{
    var connectionString = builder.Configuration.GetConnectionString("Development");
    if (string.IsNullOrWhiteSpace(connectionString))
        throw new ArgumentNullException(nameof(connectionString), "Connection string is null or empty.");
    options.UseSqlServer(connectionString);
});

// ────── Dependency Injection ──────
builder.Services.AddScoped<IServiceRepository, ServiceRepository>();
builder.Services.AddScoped<IServiceManager, ServiceManager>();

builder.Services.AddScoped<IBlogRepository, BlogRepository>();
builder.Services.AddScoped<IBlogManager, BlogManager>();

builder.Services.AddScoped<ICertificateRepository, CertificateRepository>();
builder.Services.AddScoped<ICertificateManager, CertificateManager>();

// ────── Build App ──────
var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

// ────── Middleware ──────
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
        c.RoutePrefix = "swagger"; // مسیر پیشفرض swagger/index.html
    });
}

app.UseCors(builder => builder
    .WithOrigins("https://dr-vahidchamani.ir")
    .AllowAnyMethod()
    .AllowAnyHeader()
    .WithCredentials();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
