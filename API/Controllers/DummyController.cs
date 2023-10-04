using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DummyController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public DummyController(ApplicationDbContext context)
        {
            _context = context;
            
        }

       

    }
}