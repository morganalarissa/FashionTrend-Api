using fashionTrend.Api.BD;
using fashionTrend.Api.Extensions;
using fashionTrend.Persistence.Repositories;
using fashionTrend.Application.Services;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Configurando nossa camada de persistencia

builder.Services.ConfigurePersistenceApp(builder.Configuration);
// Registrar os servi�os relacionado a camada de aplica��o
// auto mapper, mediator, fluent id
builder.Services.ConfigureApplicationApp();
builder.Services.ConfigureCorsPolicy();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Esse m�todo precisamos criar na m�o para subir nosso BD a nossa aplica��o
BD.CreateDatabase(app);

app.UseSwagger();
app.UseSwaggerUI();

app.UseCors();
app.MapControllers();
app.Run();
