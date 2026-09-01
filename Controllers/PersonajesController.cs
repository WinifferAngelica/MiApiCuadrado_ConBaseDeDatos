using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MiApiCuadrado_ConBaseDeDatos.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonajesController : ControllerBase
    {
        private readonly HarryPotterDBContext _context;

        public PersonajesController(HarryPotterDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> ObtenerPersonajes()
        {
            var personajes = await _context.Personajes.ToListAsync();
            return Ok(personajes);
        }
    }
}