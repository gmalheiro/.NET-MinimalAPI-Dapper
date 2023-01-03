using TarefasDapperApi.Endpoints;
using TarefasDapperApi.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.AddPersistance();

var app = builder.Build();

app.MapTarefasEndpoints();

app.Run();
