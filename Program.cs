using Microsoft.EntityFrameworkCore;
using WebAPI.Data;
using WebAPI.Services.DeviceService;

// const string AngularApp = "AngularApp";
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IDeviceService, DeviceService>();
builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultDb")));
// builder.Services.AddCors(options => options.AddPolicy(AngularApp,
//     policy =>
//     {
//         policy.AllowAnyHeader()
//             .WithOrigins("http://localhost:4200")
//             .AllowAnyMethod()
//             .AllowCredentials();
//     }));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// app.UseCors(AngularApp);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();