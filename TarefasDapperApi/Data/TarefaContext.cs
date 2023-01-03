using System.Data;

namespace TarefasDapperApi.Data
{
    public class TarefaContext
    {
        public delegate Task<IDbConnection> GetConnection(); 
    }
}
