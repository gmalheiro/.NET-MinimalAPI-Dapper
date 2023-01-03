using System.ComponentModel.DataAnnotations.Schema;

namespace TarefasDapperApi.Data;

[Table("Tarefas")]
public record Tarefa (int Id, string Atividade, string Status);