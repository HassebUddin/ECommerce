using ECommerce.Application;
using ECommerce.Application.Extensions;
using ECommerce.Infrastructure;
using ECommerce.Infrastructure.Filters;
using ECommerce.Infrastructure.Service.Storage.Local;
using ECommerce.Persistence;
using Serilog.Sinks.MSSqlServer;
using Serilog;
using System.Data;
using Microsoft.AspNetCore.HttpLogging;
using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;
using Serilog.Context;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddJwt(builder.Configuration);
builder.Services.AddPersistence();
builder.Services.AddApplication();
builder.Services.AddInfrastructure();
builder.Services.AddStorage<LocalStorage>();



builder.Services.AddControllers(op =>
{
    op.Filters.Add(typeof(HandleValidationFilters));
}).ConfigureApiBehaviorOptions(op => op.SuppressModelStateInvalidFilter = true); ;




//inject Serlog
var columnOptions = new ColumnOptions
{
    AdditionalColumns = new List<SqlColumn>
            {
                new SqlColumn("user_name", SqlDbType.VarChar) // New user_name column
            }
};

var Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .WriteTo.File("Logs/log.txt") // File logging
    .WriteTo.MSSqlServer(
        connectionString: "Server=DESKTOP-P78AVG1\\SQLEXPRESS;Database=ECommerce;Trusted_Connection=True;Encrypt=False;",
        tableName: "Logs",
        autoCreateSqlTable: true,
        columnOptions: columnOptions)
    .Enrich.FromLogContext()
    .MinimumLevel.Information()
    .CreateLogger();
builder.Host.UseSerilog(Logger);

builder.Services.AddHttpLogging(logging =>
{
    logging.LoggingFields = HttpLoggingFields.All;
    logging.RequestHeaders.Add("sec-ch-ua");
    logging.MediaTypeOptions.AddText("application/javascript");
    logging.RequestBodyLogLimit = 4096;
    logging.ResponseBodyLogLimit = 4096;
    
});


// In production, modify this with the actual domains you want to allow
builder.Services.AddCors(o => o.AddPolicy("CorsPolicy", builder =>
{
    builder.AllowAnyOrigin()
           .AllowAnyMethod()
           .AllowAnyHeader();
}));





// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


app.UseCors("CorsPolicy");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

}

app.ConfiguureExceptionHandler<Program>(app.Services.GetRequiredService<ILogger<Program>>());

app.UseStaticFiles();
app.UseSerilogRequestLogging();
app.UseHttpLogging();


app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();


//enter currrent username in Serlog Table(e.g Logs Table in database)
app.Use(async (context, next) =>
{
    var userEmail = context.User?.Identity?.Name;
    using (LogContext.PushProperty("user_name", userEmail))
    {
        await next(); // Call the next middleware
    }
});


app.MapControllers();

app.Run();
