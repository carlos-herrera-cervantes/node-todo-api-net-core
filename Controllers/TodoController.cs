using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using node_todo_api_net_core.Models;
using node_todo_api_net_core.Repositories;

namespace node_todo_api_net_core.Controllers
{
    [Route("api/v1/todos")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly ITodoRepository _todoRepository;

        public TodoController(ITodoRepository todoRepository) => _todoRepository = todoRepository;

        /**
        * @GET
        */
        #region snippet_GetAll
        public async Task<IEnumerable<Todo>> GetAll() => await _todoRepository.GetAll();
        
        #endregion
    }
}