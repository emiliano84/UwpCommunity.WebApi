﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using UwpCommunity.Data.Interfaces;
using UwpCommunity.Data.Models;
using UwpCommunity.WebApi.Models.Data;

namespace UwpCommunity.WebApi.Controllers
{
    [ApiVersion("2")]
    [Route("v{v:apiVersion}/[controller]")]
    [ApiController]
    [EnableCors]
    public class UsersController : ControllerBase
    {
        private readonly ILogger<UsersController> _logger;
        private readonly IUserService _userService;

        public UsersController(ILogger<UsersController> logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        [HttpPost]
        [Authorize(AuthenticationSchemes = "DiscordAuthentication")]
        public ActionResult<UserDto> Add(User user)
        {
            var result = _userService.Add(user);

            return result.IsSuccess ? Ok(new UserDto(result.Value))
                : (ActionResult)NotFound();
        }

        [HttpGet]
        public ActionResult<IEnumerable<UserDto>> Get()
        {
            var result = _userService.Get();

            if (result.IsSuccess)
            {
                List<UserDto> users = new List<UserDto>();
                foreach (var user in result.Value)
                {
                    users.Add(new UserDto(user));
                }
                return Ok(users);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("{userId}")]
        public ActionResult<UserDto> Get(Guid userId)
        {
            var result = _userService.Single(userId);

            return result.IsSuccess ? Ok(new UserDto(result.Value))
                : (ActionResult)NotFound();
        }

        [HttpGet("[action]/{discordId}")]
        public ActionResult<UserDto> DiscordId(string discordId)
        {
            var result = _userService.SingleByDiscordId(discordId);

            return result.IsSuccess ? Ok(new UserDto(result.Value))
                : (ActionResult)NotFound();
        }

        [HttpPut]
        [Authorize(AuthenticationSchemes = "DiscordAuthentication")]
        public ActionResult<UserDto> Update(User user)
        {
            var result = _userService.UpdateDetachedEntity(user, user.UserId);

            return result.IsSuccess ? Ok(new UserDto(result.Value))
                : (ActionResult)NotFound();
        }

        [HttpDelete("{userId}")]
        [Authorize(AuthenticationSchemes = "DiscordAuthentication")]
        public ActionResult Delete(Guid userId)
        {
            var result = _userService.Delete(userId);

            return result.IsSuccess ? Ok()
                : (ActionResult)NotFound();
        }
    }
}
