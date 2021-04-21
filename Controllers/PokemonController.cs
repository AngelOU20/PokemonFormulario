using System.Linq;
using Microsoft.AspNetCore.Mvc;
using pokemon.Data;
using Practica02.Models;

namespace Practica02.Controllers
{
    public class PokemonController: Controller 
    {
        private PokemonContext _context;
        public PokemonController(PokemonContext context)
        {
            _context = context;
        }

        public IActionResult Form() {
            return View();
        }

        [HttpPost]
        public IActionResult Form(Pokemon p) {
            if (ModelState.IsValid) {
                // Guardar el objeto Pokemon (p)
                _context.Add(p);
                _context.SaveChanges();
                
                return RedirectToAction("Lista");
            }
            
            return View(p);
        }

        public IActionResult Lista() {
            var ciudadpokemon = _context.CiudadPokemon.OrderBy(x => x.NombreCiudad).ToList();
            return View(ciudadpokemon);
        }
    }
}

