using Microsoft.AspNetCore.Mvc;
using RolePlayingGame.Api.Services;
using RolePlayingGame.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        public async Task<IActionResult> Get()
        {
            var result = await _characterServices.GetAllCharacters();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingel(int id)
        {
            var result = await _characterServices.GetCharacterById(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> AddCharacter(Character newCharacter)
            {
            var result = await _characterServices.AddCharacter(newCharacter);
            return Ok(result);
        }

    }
}
