using DatingApp.Api.Data;
using DatingApp.Api.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.Api.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController(DataContext db) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            var users = await db.Users.ToListAsync();
            return Ok(users);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<AppUser>> GetUser(int id)
        {
            var user = await db.Users.FindAsync(id);
            if (user==null)
            {
                return NotFound();
            }
            return Ok(user);
        }
    }
}
