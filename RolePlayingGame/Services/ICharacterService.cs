using RolePlayingGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RolePlayingGame.Api.Services
{
    public interface ICharacterService
    {
        List<Character> GetAllCharacters();
        Character GetCharacterById(int id);
        List<Character> AddCharacter(Character newCharater);
    }
}
