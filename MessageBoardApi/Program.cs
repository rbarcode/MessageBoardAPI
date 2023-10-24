using MessageBoardApi.Models;
using Microsoft.EntityFrameworkCore;
// using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// THIS VERSION PREVENTS FEEDBACK LOOPS ("OBJECT CYCLES) BUT LEAVES A REFERENCE TO NULL IN PAYLOAD
// builder.Services.AddControllers().AddJsonOptions(options =>
//         {
//           options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
//         });

builder.Services.AddControllers();

builder.Services.AddDbContext<MessageBoardApiContext>(
                  dbContextOptions => dbContextOptions
                    .UseMySql(
                      builder.Configuration["ConnectionStrings:DefaultConnection"],
                      ServerVersion.AutoDetect(builder.Configuration["ConnectionStrings:DefaultConnection"]
                    )
                  )
                );

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI();
}
else
{
  app.UseHttpsRedirection();
}

app.UseAuthorization();

app.MapControllers();

app.Run();