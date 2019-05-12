using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using node_todo_api_net_core.Contexts;
using node_todo_api_net_core.Models;

namespace node_todo_api_net_core.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly TodoAppContext _context;

        public UserRepository(TodoAppContext context) => _context = context;

        /// <summary>
        /// GET
        /// </summary>

        #region snippet_GetAll
        public async Task<IEnumerable<User>> GetAll() => await Task.Run(() =>
        {
            return _context.Users.ToList();
        });
        #endregion

        #region snippet_GetById
        public async Task<User> GetById(long id) => await _context.Users.FindAsync(id);

        #endregion

        /// <summary>
        /// POST
        /// </summary>
        public async Task Create(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }
    }
}