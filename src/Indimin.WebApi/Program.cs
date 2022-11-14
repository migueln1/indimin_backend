global using FastEndpoints;
using FastEndpoints.Swagger;
using Indimin.Application;
using Microsoft.AspNetCore.Cors.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddFastEndpoints();
builder.Services.AddSwaggerDoc();
builder.Services.AddApplicationConfig(builder.Configuration);
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy => 
        policy.WithOrigins("http://localhost:3000")
            .AllowAnyHeader().AllowAnyMethod());
});
var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseCors();

app.UseFastEndpoints(c =>
{
    c.Endpoints.RoutePrefix = "api";
});


if (app.Environment.IsDevelopment())
{
    app.UseOpenApi();
    app.UseSwaggerUi3(s => s.ConfigureDefaults());
}

app.Run();
