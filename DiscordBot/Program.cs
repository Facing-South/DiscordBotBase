using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Reflection;
using System.Threading.Tasks;

namespace DiscordBot
{
    class Program
    {
        private DiscordSocketClient _client;
        private CommandService _commands;
        private SocketCommandContext _context;

        private string _token = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";

        static void Main(string[] args)
        => new Program().MainAsync().GetAwaiter().GetResult();

        private async Task MainAsync()
        {
            _client = new DiscordSocketClient(new DiscordSocketConfig
            {
                LogLevel = LogSeverity.Debug
            }); ;

            _commands = new CommandService(new CommandServiceConfig
            {
                CaseSensitiveCommands = true,
                DefaultRunMode = RunMode.Async,
                LogLevel = LogSeverity.Debug
            });

            _client.MessageReceived += Client_MessageReceived;

            await _commands.AddModulesAsync(Assembly.GetEntryAssembly(), null);

            _client.Ready += Client_Ready;

            await _client.LoginAsync(TokenType.Bot, _token);
            await _client.StartAsync();

            await Task.Delay(-1);
        }

        private async Task Client_Ready()
        {
            await _client.SetGameAsync("");
            Console.WriteLine("Bot is connected!...");
        }

        private async Task Client_MessageReceived(SocketMessage MessageParam)
        {
            var Message = MessageParam as SocketUserMessage;

            if (_client != null && Message != null)
            {
                int ArgPos = 0;
                var _context = new SocketCommandContext(_client, Message);

                var Result = await _commands.ExecuteAsync(_context, ArgPos, null);

                if (_context.Message == null || _context.Message.Content == "")
                    return;

                if (_context.User.IsBot)
                    return;

                if (!Result.IsSuccess)
                    Console.WriteLine($"[{DateTime.Now} at Commands] Something went wrong with executing a command. Text: {_context.Message.Content} | Error: {Result.ErrorReason}");
            }
        }
    }
}
