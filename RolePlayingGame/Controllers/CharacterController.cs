using Microsoft.AspNetCore.Mvc;
using RolePlayingGame.Models;
namespace RolePlayingGame.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        private static Character knight = new Character();
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(knight);
        }
    }
}
