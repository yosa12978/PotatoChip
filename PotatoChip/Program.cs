using Microsoft.EntityFrameworkCore;
using PotatoChip.Data;

namespace PotatoChip
{ 
    public class Program
    {
        static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(s => s.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
            {
                Title = "PotatoChip API",
                Description = "Api for restaurant routine",
                Version = "v1",
            }));
            builder.Services.AddHealthChecks();

            builder.Services.AddDbContext<PotatochipDb>(options => options.UseSqlite("Data Source = potatochip.db"));

            var app = builder.Build();

            app.UseSwagger();
            app.UseSwaggerUI();
            app.UseHealthChecks("/health");

            app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}