using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBot
{
    public class BotCommand : ModuleBase<SocketCommandContext>
    {
        [Command("!Hello"), Alias("!helllo")]
        public async Task SayHelo(string value)
        {
            if (value.Length != 0)
            {
                await Context.Channel.SendMessageAsync($"Nice to meet you {value}");
            }
            else
            {
                await Context.Channel.SendMessageAsync("Enter a name so I can greet you");
            }
        }
    }
}
