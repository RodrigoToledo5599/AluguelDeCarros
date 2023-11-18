﻿using AluguelDeCarros.Data.Context;
using AluguelDeCarros.Data.DTO.Usuario;
using AluguelDeCarros.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AluguelDeCarros.Controllers
{
    [Authorize(AuthenticationSchemes ="Bearer")]
    [ApiController]
    [Route("api/[controller]")]
    public class AuthenticationController : ControllerBase
    {
        private readonly UserManager<Usuario> _userManager;
        private readonly SignInManager<Usuario> _signInManager;
        public AuthenticationController(UserManager<Usuario> userManager, SignInManager<Usuario> signInManager) 
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpPost("register")]
        public async Task<ActionResult> RegisterUser( [FromBody] UsuarioDTO model)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values.SelectMany(e => e.Errors));
            }

            var user = new Usuario
            {
                UserName = model.Email,
                Email = model.Email,
                EmailConfirmed = true
            };

            var result = await _userManager.CreateAsync(user,model.Password);

            if(!result.Succeeded)
            {
                return BadRequest(result.Errors);
            }
            await _signInManager.SignInAsync(user, false);
            return Ok(user);


        }


        [HttpGet("login")]
        public async Task<ActionResult> Login([FromQuery] UsuarioSignIn model)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values.SelectMany(e => e.Errors));
            }

            

            var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password,false,false);

            if (!result.Succeeded)
                return StatusCode(401,"Senha ou email estão errado(s) o sua mula");
            else
                return Ok("nice");
            
            


        }


    }
}
