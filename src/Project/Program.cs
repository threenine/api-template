using ApiProject.Behaviours;
using ApiProject.Middleware;
using FluentValidation;
using Kingsbridge.Helpers;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Serilog;

Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .CreateBootstrapLogger();

Log.Information("Starting up");

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Host.UseSerilog((ctx, lc) => lc
    .WriteTo.Console()
    .ReadFrom.Configuration(ctx.Configuration));

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo {Title = "ApiProject", Version = "v1"});
    c.CustomSchemaIds(x => x.FullName);
    c.DocumentFilter<JsonPatchDocumentFilter>();
    c.EnableAnnotations();
});
builder.Services.AddTransient<ExceptionHandlingMiddleware>();
builder.Services.AddValidatorsFromAssembly(typeof(Program).Assembly);
builder.Services.AddMediatR(cfg =>
{
    cfg.RegisterServicesFromAssembly(typeof(Program).Assembly);
    cfg.AddOpenBehavior(typeof(LoggingBehaviour<,>));
    cfg.AddOpenBehavior(typeof(ValidationBehaviour<,>));
});
           
builder.Services.AddAutoMapper(typeof(Program));


var app = builder.Build();

app.UseSerilogRequestLogging();
app.UseMiddleware<ExceptionHandlingMiddleware>();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ApiProject v1"));
}
app.UseHttpsRedirection();


app.UseAuthorization();
app.MapControllers();
app.Run();
