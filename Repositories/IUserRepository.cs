using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.JsonPatch;
using node_todo_api_net_core.Models;

namespace node_todo_api_net_core.Repositories
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAll();
        Task<User> GetById(long id);
         Task Create(User user);
         Task Update(User newUser, JsonPatchDocument<User> currentUser);
    }
}