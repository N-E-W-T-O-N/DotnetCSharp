
using System.Text.Json.Nodes;

namespace Minimal
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddAuthorization();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddCors();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseCors(opt => opt.AllowAnyOrigin().AllowAnyMethod());
            app.UseRouting();
            app.UseHttpsRedirection();

            app.UseAuthorization();

            var summaries = new[]
            {
                "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
            };



#pragma warning disable ASP0014 // Suggest using top level route registrations
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/weatherforecast", (HttpContext httpContext) =>
                {
                    var forecast = Enumerable.Range(1, 5).Select(index =>
                        new WeatherForecast
                        {
                            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                            TemperatureC = Random.Shared.Next(-20, 55),
                            Summary = summaries[Random.Shared.Next(summaries.Length)]
                        })
                        .ToArray();
                    return forecast;
                })
            .WithName("GetWeatherForecast")
            .WithOpenApi();
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World");
                });

                endpoints.MapGet("/hello", async context =>
                {
                    await context.Response.WriteAsync("Hello World from a Method");
                });

                endpoints.MapGet("/input", (HttpContext httpContext) =>
                {
                    
                    string s = @"[{""name"": ""Laptop<br />Collection"", ""imgSrc"": ""/shop01.png""}, {""name"": ""Accessories<br />Collection"", ""imgSrc"": ""/shop02.png""}, {""name"": ""Cameras<br />Collection"", ""imgSrc"": ""/shop03.png""}]";
                    var d = JsonArray.Parse(s);

                    return  d?.ToString();
                } );

            });
#pragma warning restore ASP0014 // Suggest using top level route registrations

            app.Run();
        }



    }
}
