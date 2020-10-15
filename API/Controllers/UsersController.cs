using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;
        }

        //adding 2 endpoints
        // - 1 to get all users

        //using async to transfer traffic to different threads
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> Getusers()
        {
            return await _context.Users.ToListAsync();

            
        }

        // - 1 to get specific user
        //api/users/3
        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> Getusers(int id)
        {
            return await _context.Users.FindAsync(id);
        }
    }
}