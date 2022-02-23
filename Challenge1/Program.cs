using Challenge1.Contexts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddEntityFrameworkSqlServer();
builder.Services.AddDbContextPool<DisneyContext>((services, options) =>
{
    options.UseInternalServiceProvider(services); // a esto no hay que darle bola
    options.UseSqlServer(builder.Configuration.GetConnectionString("DisneyConnectionString"));
    //aca le decis que se conectes a Sql, esto funciona con una credencial, que ser? la conection string

});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) // cuando entra una request, pasa por ac? y se dispara a swagger
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers(); //mapea los controladores que tenemos

app.Run();
