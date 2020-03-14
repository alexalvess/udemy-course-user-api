using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CursoMobile.Api.Domain.DTOs;
using CursoMobile.Api.Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CursoMobile.Api.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IServiceUser _serviceUser;

        public UserController(IServiceUser serviceUser) =>
            _serviceUser = serviceUser;

        [HttpGet]
        public async Task<IActionResult> Recover()
        {
            try
            {
                var datas = await _serviceUser.Get();

                return Ok(datas);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Insert([FromBody] UserDto userDto)
        {
            try
            {
                var data = await _serviceUser.Add(userDto);

                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Remove(string id)
        {
            try
            {
                await _serviceUser.Delete(id);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}