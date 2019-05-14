using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using node_todo_api_net_core.Contexts;
using node_todo_api_net_core.Models;

namespace node_todo_api_net_core.Repositories
{
    public class TodoRepository : ITodoRepository
    {
        private readonly TodoAppContext _context;

        public TodoRepository(TodoAppContext context) => _context = context;

        #region snippet_GetAll
        public async Task<IEnumerable<Todo>> GetAll() => await Task.Run(() =>
        {
            return _context.Todos.ToList();
        });
        
        #endregion
    }
}