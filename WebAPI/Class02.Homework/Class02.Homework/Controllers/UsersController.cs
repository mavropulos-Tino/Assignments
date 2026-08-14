using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Class02.Homework.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        /// <summary>
        /// Retrieves all users from the database.
        /// </summary>
        /// <returns>A list of all users.</returns>
        /// <response code="200">Returns the full list of users.</response>
        [HttpGet] // https://localhost:[port]/api/users
        public IActionResult GetUsers()
        {
            return Ok(StaticDb.Users);
        }

        /// <summary>
        /// Retrieves a single user by their id.
        /// </summary>
        /// <param name="id">The unique id of the user.</param>
        /// <returns>The user object with the parameter id.</returns>
        /// <response code="200">Returns the requested user.</response>
        /// <response code="404">If no user is found with the specified id.</response>
        [HttpGet("{id:int}")] // https://localhost:[port]/api/users/{id}
        public IActionResult GetUserById(int id)
        {
            var user = StaticDb.Users.FirstOrDefault(x => x.Id == id);

            if (user == null)
            {
                return StatusCode(StatusCodes.Status404NotFound, new
                {
                    StatusCode = 404,
                    Message = $"Note with id {id} does not exist."
                });
            }

            return Ok(user);
        }
    }
}
