using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using node_todo_api_net_core.Models;
using node_todo_api_net_core.Repositories;

namespace node_todo_api_net_core.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository) => _userRepository = userRepository;

        /// <summary>
        /// GET
        /// </summary>

        #region snippet_GetAll
        [HttpGet]
        public async Task<IEnumerable<User>> GetAll() => await _userRepository.GetAll();

        #endregion

        #region snippet_GetById
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(long id)
        {
            User user = await _userRepository.GetById(id);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }
        #endregion

        /// <summary>
        /// POST
        /// </summary>

        #region snippet_Create
        [HttpPost]
        public async Task<IActionResult> Create(User user)
        {
            if (ModelState.IsValid)
            {
                await _userRepository.Create(user);
                return Ok(user);
            }

            return BadRequest();
        }
        #endregion

        /// <summary>
        /// PUT
        /// </summary>

        #region snippet_Update
        [HttpPatch("{id}")]
        public async Task<IActionResult> Update(long id, [FromBody] JsonPatchDocument<User> currentUser)
        {
            User newUser = await _userRepository.GetById(id);

            if (newUser is null)
            {
                return NotFound();
            }

            await _userRepository.Update(newUser, currentUser);
            return Ok(currentUser);
        }
        #endregion
    }
}