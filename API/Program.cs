using Microsoft.AspNetCore.Builder;
using System.Diagnostics;
using System.Globalization;
using System.Text.RegularExpressions;

namespace API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

        
            app.Use(async(context, next) =>
            {
                var cultureQuery = context.Request.Query["culture"];
                if (!string.IsNullOrWhiteSpace(cultureQuery))
                {
                    var cultur=new CultureInfo(cultureQuery);
                    CultureInfo.CurrentCulture = cultur;
                    CultureInfo.CurrentUICulture = cultur;
                }
                await next(context);
            });
            app.useShabbat();
            app.Run();
            
        }
    }
}