using Microsoft.EntityFrameworkCore;

namespace PokeCodexBlazor
{
    public class PokemonService
    {
        private readonly ApplicationDbContext _context;

        public PokemonService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Pokemon>> GetAllPokemonsAsync()
        {
            return await _context.Pokemons.ToListAsync();
        }

        public async Task<Pokemon> GetPokemonByIdAsync(int id)
        {
            return await _context.Pokemons.FindAsync(id);
        }
    }
}
