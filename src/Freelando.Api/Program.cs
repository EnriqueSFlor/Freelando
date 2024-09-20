using Freelando.Api.Endpoints;
using Freelando.Dados;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<FreelandoContext>((option) =>
    {
        option.UseSqlServer(builder.Configuration["ConnectionStrings:DefaultConnection"]);
        });





var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.AddEndPointEspecialidades();
app.AddEndPointProjeto();
app.AddEndPointContrato();
app.UseHttpsRedirection();

app.Run();
