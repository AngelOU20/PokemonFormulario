using Microsoft.EntityFrameworkCore;
using Practica02.Models;

namespace pokemon.Data
{
    public class PokemonContext : DbContext
    {
        public DbSet<Pokemon> CiudadPokemon { get; set; }

        public PokemonContext(DbContextOptions dco) : base(dco) {

        }
    }
}