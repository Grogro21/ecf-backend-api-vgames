
using Ecf.Vgames.DB;
using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace Ecf.Vgames
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
            builder.Services.AddDbContext<ContexteGizmondo>();
            builder.Services.AddCors(o => {
                o.AddPolicy(name: "_localhostOrigins",
                                  policy =>
                                  {
                                      policy.WithOrigins("http://127.0.0.1:5500")
                                      .AllowAnyMethod()
                                      .AllowAnyHeader();
                                  });
            });

            builder.Services
    .AddControllers(options =>
    {
        options.Conventions.Add(
            new RouteTokenTransformerConvention(new SnakeCaseParameterTransformer())
        );
    });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseCors("_localhostOrigins");
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
