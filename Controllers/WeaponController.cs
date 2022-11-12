using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnetBackend.Dtos.Character;
using dotnetBackend.Dtos.Weapon;
using dotnetBackend.Services.WeaponService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace dotnetBackend.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class WeaponController : ControllerBase
    {
        private readonly IWeaponService _weaponService;
        public WeaponController(IWeaponService weaponService)
        {
            _weaponService = weaponService;
            
        }
        [HttpPost]
        public async Task<ActionResult<ServiceResponse<GetCharacterDto>>> AddWeapon(AddWeaponDto newWeapon)
        {
            var response = await _weaponService.AddWeapon(newWeapon);
            if(response.Success == false)
            {
                return BadRequest(response);
            }
            return Ok(response);

        }
    }
}