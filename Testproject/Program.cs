using Microsoft.EntityFrameworkCore;
using Testproject.Data;
using Testproject.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddOpenApi();
builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlServer(
        "Server=DESKTOP-1PLQTL1\\SQLEXPRESS;Database=TestDatabase;Trusted_Connection=True;TrustServerCertificate=True;"));
builder.Services.AddControllers();
builder.Services.AddTransient<ITaskService, TodoTaskService>();
builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<IRegisterService, RegisterService>();
// Add CORS policy if needed
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", builder =>
    {
        builder.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.UseCors("AllowAll"); // Use CORS policy
app.MapControllers(); // Enable routing for controllers

app.Run();