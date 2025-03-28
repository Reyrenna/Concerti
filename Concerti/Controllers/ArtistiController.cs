using Concerti.Data;
using Concerti.DTOs.Artisti;
using Concerti.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Concerti.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtistiController : ControllerBase
    {
        private readonly EventiDbContext _context;
        public ArtistiController(EventiDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Create(ArtistiRequest artistiRequest)
        {
            try {
                var newArtisti = new Artisti()
                {
                    Nome = artistiRequest.Nome,
                    Genere = artistiRequest.Genere,
                    Descrizione = artistiRequest.Descrizione

                };
            
            }
            catch (Exception e) { 
            return StatusCode(500, e.Message);
            }

        }

    }
}
