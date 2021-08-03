using RolePlayingGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RolePlayingGame.Api.Services
{
    //CharacterService is implementation of ICharacterService
    public class CharacterService : ICharacterService
    {
        private static ServiceResponse<List<Character>> serviceResponse = new ServiceResponse<List<Character>>();
        private static ServiceResponse<Character> serviceResponseSingle = new ServiceResponse<Character>();

        private static List<Character> characters = new List<Character>
        {
            new Character(),
            
            new Character {Id = 1, Name = "Sam"}
        };

public async Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter)
        {
            serviceResponse.Data.Add(newCharacter);
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<Character>>> GetAllCharacters()
        {
            serviceResponse.Data = characters;
            return serviceResponse;
        }

        public async Task<ServiceResponse<Character>> GetCharacterById(int id)
        {
            serviceResponseSingle.Data = characters.FirstOrDefault(x => x.Id == id);
            return serviceResponseSingle;
        }
    }
}
