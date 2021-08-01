using Microsoft.AspNetCore.Mvc;
using RolePlayingGame.Api.Services;
using RolePlayingGame.Models;
using System.Collections.Generic;
using System.Linq;

namespace RolePlayingGame.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        //private static Character knight = new Character();
        //private static List<Character> characters = new List<Character>
        //{
        //    new Character(),
        //    new Character {Id = 1, Name = "Sam"}
        //};
        private readonly ICharacterService _characterServices;
        public CharacterController(ICharacterService characterService)
        {
            _characterServices = characterService;
        }


        [HttpGet]
        [Route("GetAll")]
        public IActionResult Get()
        {
            var result = _characterServices.GetAllCharacters();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetSingel(int id)
        {
            var result = _characterServices.GetCharacterById(id);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult AddCharacter(Character newCharacter)
            {
            var result = _characterServices.AddCharacter(newCharacter);
            return Ok(result);
        }

    }
}
