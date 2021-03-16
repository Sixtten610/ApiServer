using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ApiServer.Controllers
{
    [ApiController]
    [Route("api/pokemon")]
    public class PokemonController: ControllerBase
    {
        List<Pokemon> pokemons = new List<Pokemon>()
        {
            new Pokemon() {name = "Pikachu"},
            new Pokemon() {name = "Snorlax"}
            new Pokemon() {name = "https://www.youtube.com/watch?v=M69Sn3OERZo&ab_channel=MemeZee"}
        };

        //https://10.151.168.128:5001/api/pokemon

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(pokemons[0]);
        }

        [HttpPut]
        public ActionResult Put(Pokemon pokemon)
        {
            pokemons.Add(pokemon);
            return Ok()
        }

    }
}
