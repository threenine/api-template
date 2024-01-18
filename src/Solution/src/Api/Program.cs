using Api.Behaviours;
using Api.Middleware;
using Common;
using Database.ApiSolutions;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Serilog;
using Threenine;
using Threenine.Data.DependencyInjection;
using Threenine.Services;




Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .CreateBootstrapLogger();

Log.Information("Starting up");

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers().AddNewtonsoftJson();
builder.Services.AddEndpointsApiExplorer();

builder.Host.UseSerilog((ctx, lc) => lc
    .WriteTo.Console()
    .ReadFrom.Configuration(ctx.Configuration));

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo {Title = "Api", Version = "v1"});
    c.CustomSchemaIds(x => x.FullName);
    c.DocumentFilter<JsonPatchDocumentFilter>();
    c.EnableAnnotations();
});
builder.Services.AddTransient<ExceptionHandlingMiddleware>();
builder.Services.AddValidatorsFromAssemblies(new[] { typeof(Program).Assembly , typeof(ApiSolutionContext).Assembly});
builder.Services.AddMediatR(cfg =>
{
    cfg.RegisterServicesFromAssembly(typeof(Program).Assembly);
    cfg.AddOpenBehavior(typeof(LoggingBehaviour<,>));
    cfg.AddOpenBehavior(typeof(ValidationBehaviour<,>));
});

builder.Services.AddDatabase(builder.Configuration);
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddTransient(typeof(IEntityValidationService<>),typeof(EntityValidationService<>));



var app = builder.Build();


app.UseSerilogRequestLogging();
app.UseMiddleware<ExceptionHandlingMiddleware>();
app.DatabaseInitialise();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(settings =>
    {
        settings.SwaggerEndpoint("/swagger/v1/swagger.json", "Api v1");
    });
        
     
}
app.UseHttpsRedirection();


app.UseAuthorization();
app.MapControllers();
app.Run();
