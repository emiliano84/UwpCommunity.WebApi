﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Text.Json;
using System.Threading.Tasks;
using UwpCommunity.WebApi.Interfaces;
using UwpCommunity.WebApi.Models.Bot;
using UwpCommunity.WebApi.Models.Discord;

namespace UwpCommunity.WebApi.BotCommands
{
    public class UserBotCommand : IBotCommand
    {
        private readonly IDiscordBotService _discordBotService;

        public UserBotCommand(IDiscordBotService discordBotService)
        {
            _discordBotService = discordBotService;
        }

        public async Task<string> Execute(DiscordBotCommand discordBotCommand)
        {
            return await GetUser(discordBotCommand.Parameters[0]);
        }

        private async Task<string> GetUser(string userId)
        {
            var resultJson = await _discordBotService.GetUserByDiscordId(userId);
            var discordUser = new DiscordUserDto(resultJson);

            return (discordUser != null)
                ? JsonSerializer.Serialize(discordUser) : "not found";
        }
    }
}
