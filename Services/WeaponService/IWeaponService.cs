using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnetBackend.Dtos.Character;
using dotnetBackend.Dtos.Weapon;

namespace dotnetBackend.Services.WeaponService
{
    public interface IWeaponService
    {
        Task<ServiceResponse<GetCharacterDto>> AddWeapon(AddWeaponDto newWeapon);
    }
}