using Concerti.Data;
using Concerti.DTOs.Artisti;
using Concerti.Models;

namespace Concerti.Services
{
    public class ArtistiService
    {
        private readonly EventiDbContext _context;
        public ArtistiService(EventiDbContext context)
        {
            _context = context;
        }
        public async Task<Artisti> Create(ArtistiRequest artistiRequest)
        {
            var newArtisti = new Artisti()
            {
                Nome = artistiRequest.Nome,
                Genere = artistiRequest.Genere,
                Descrizione = artistiRequest.Descrizione
            };
            _context.Artisti.Add(newArtisti);
            await _context.SaveChangesAsync();
            return newArtisti;
        }
    }
}
