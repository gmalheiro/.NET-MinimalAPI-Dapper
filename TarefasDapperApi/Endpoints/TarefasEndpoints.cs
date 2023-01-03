using Dapper.Contrib.Extensions;
using TarefasDapperApi.Data;
using static TarefasDapperApi.Data.TarefaContext;

namespace TarefasDapperApi.Endpoints
{
    public static class TarefasEndpoints
    {
        public static void MapTarefasEndpoints(this WebApplication app)
        {
            app.MapGet("/", () => $"Bem vindo a API Tarefas {DateTime.Now}");

            app.MapGet("/tarefas", async (GetConnection connectionGetter) =>
            {
                using var con = await connectionGetter();
                var tarefas = con.GetAll<Tarefa>().ToList();

                if (tarefas is null)
                    return Results.NotFound();

                return Results.Ok(tarefas);
            });

            app.MapGet("/tarefas/{id}", async (GetConnection connectionGetter, int id) =>
            {
                using var con = await connectionGetter();
                return con.Get<Tarefa>(id) is Tarefa tarefa ? Results.Ok(tarefa) : Results.NotFound($"A tarefa de id: {id} não foi encontrada...");
            });
        }
    }
}
