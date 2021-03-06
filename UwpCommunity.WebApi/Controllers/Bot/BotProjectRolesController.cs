﻿using DSharpPlus.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Threading.Tasks;
using UwpCommunity.Data.Interfaces;
using UwpCommunity.WebApi.Interfaces;
using UwpCommunity.WebApi.Models.Discord;

namespace UwpCommunity.WebApi.Controllers
{
    [ApiController]
    [Area("bot")]
    [Route("[area]/project/roles")]
    [EnableCors]
    public class BotProjectRolesController : ControllerBase
    {
        private readonly ILogger<CategoriesController> _logger;
        private readonly IDiscordBotService _discordBotService;
        private readonly IUserService _userService;

        public BotProjectRolesController(ILogger<CategoriesController> logger, IDiscordBotService discordBotServic, IUserService userService)
        {
            _logger = logger;
            _discordBotService = discordBotServic;
            _userService = userService;
        }

        [HttpPost("{userId}")]
        [Authorize(AuthenticationSchemes = "DiscordAuthentication")]
        public async Task<ActionResult<DSharpPlus.Entities.DiscordGuild>> PutAsync(string userId, DiscordAppRole appRole)
        {
            var user = await _discordBotService.GetUserByDiscordId(userId);

            if (user == null)
            {
                return NotFound();
            }

            var guildMember = await _discordBotService.GetGuild(user.Id);

            if (guildMember == null)
            {
                return NotFound();
            }

            var projectsResult = _userService.GetProjectsByByDiscordId(userId);

            if (projectsResult.IsFailure)
            {
                return NotFound();
            }

            var guild = await _discordBotService.GetGuild();

            if (guild == null)
            {
                return NotFound();
            }

            var roleName = $"{appRole.AppName} {appRole.SubRole}";

            var role = guild.Roles.FirstOrDefault(x => x.Value.Name.Equals(roleName, StringComparison.OrdinalIgnoreCase)).Value;

            if (role == null)
            {
                role = await guild.CreateRoleAsync(roleName, null, new DiscordColor(appRole.Color), null, true);
            }

            return (guildMember != null) ? Ok(guildMember.Roles)
                : (ActionResult)NotFound();
        }
    }
}
