using ABX_RMO.Application.Interface;
using ABX_RMO.Application.Repository;
using ABX_RMO.Application.Services;
using ABX_RMO.Infrastructure;
using ABX_RMO.Infrastructure.Repository;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<IRobotService, RobotService>();
builder.Services.AddScoped<IRobotRepositroy, RobotRepository>();
builder.Services.AddScoped<ILogService, LogService>();
builder.Services.AddScoped<ILogRepository, LogRepository>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.InfrastructurePersistence(builder.Configuration);
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
