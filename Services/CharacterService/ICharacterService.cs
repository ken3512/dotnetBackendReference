using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnetBackend.Dtos.Character;

namespace dotnetBackend.Services.CharacterService
{
    public interface ICharacterService
    {
        Task<ServiceResponse<List<GetCharacterDto>>> GetallCharacters();
        Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id);
        Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter);
        Task<ServiceResponse<GetCharacterDto>> UpdateCharacter(UpdateCharacterDto updatedCharater);
        Task<ServiceResponse<List<GetCharacterDto>>> DeleteCharacter(int id);

    }
}