﻿using UwpCommunity.WebApi.Models.Discord;
using Yugen.Toolkit.Standard.Core.Models;

namespace UwpCommunity.WebApi.Interfaces
{
    public interface IDiscordHttpClientService
    {
        Result<DiscordUser> GetDiscordUser(string accessToken);
    }
}
