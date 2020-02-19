using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIServer.Controllers
{
    [Route("api/pokemon")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        public static List<Pokemon> pokemons = new List<Pokemon>()
        {
            new Pokemon() {Name = "EKENS", Strength = 33},
            new Pokemon() {Name = "CHARMANDER", Strength = 100},
            new Pokemon() {Name = "EVEE", Strength = 300}
        };

        [HttpGet]
        public ActionResult Get()
        {
            /*Pokemon p = new Pokemon();
            p.Name = "PIKACHU";
            p.Strength = "67";*/

            return Ok(pokemons);
        }

        [HttpPost]
        public ActionResult Post(Pokemon newPokemon)
        {
            pokemons.Add(newPokemon);
            Console.WriteLine("Added " + newPokemon.Name);

            return Created("", newPokemon);
        }

    }
}
