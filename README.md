![.NET Core](https://github.com/Facing-South/DiscordBotBase/workflows/.NET%20Core/badge.svg?branch=master&event=push)

# How to use DiscordBotBase

## Register a bot with Discord
The creation of a Discord bot is completely free. All you need is a Discord account. If you don't have an account yet, you can create one [here](https://discord.com/).
If you already have an account, you can create a Discord application [here](https://discord.com/developers) and your bot within this application.To do this successfully, 
follow these steps:
1. Click on the "New Application" button and choose a name. Note that this will not be the name of your bot, but only of the application. If possible, make sure to choose a unique name for your application and later for your bot. A name can be used more often by different users, but at some point the limit of the use of the name has been reached and it can no longer be used.

2. After you have created your application, click on the "Bot" button in the left side menu.

3. Click the "Add Bot" button.

4. Customize the name and picture of your bot and copy the token. The token can be displayed and copied directly under the bot name you selected. Save the token in a text file, as we will need it later. Please note that you should keep your token secret, otherwise others will be able to abuse your bot.

5. After you have chosen a name and a picture and saved the token, click on "OAuth2" in the left side menu.

6. Here you will find many checkboxes under the "Scopes" category. What we need is the "bot" checkbox. Click on this and copy the link below it.

7. Open the link in a browser (e.g. Google Chrome) and choose the server on which you want to invite your bot to be able to interact with it. Make sure that you have enough rights on the server so that everything works. If you want to invite a bot to a server on which you have no rights, please have an admin of the server open the link for you and invite the bot to the server.

8. After all these points have been dealt with, you are the proud owner of your own bot, which is already on a server. You will still see this as offline, but we will change that in the next steps ;)

## Visual Studio / Visual Studio Code
To be able to work with C # I recommend to use the free version of Visual Studio (Community Edition) under Windows. On Linux or Mac, I would personally recommend Visual Studio Code. How to install these variants e.g. can be found on Youtube.

## Download Repository
After downloading this project, open it in Visual Studio or Visual Studio Code. You may have to install the Discord nuget yourself, your system will show you some of the integrated libraries as unknown. In this case please install this nuget: [Discord.NET](https://www.nuget.org/packages/Discord.Net.Core/)

## Insert Token
Now that the solution has been downloaded and the Discord nuget has been installed, only one change has to be made in line 16 of the Program.cs. This is exactly where the token you received from the Discord bot has to be inserted.

## Run Bot
After the token has been inserted in line 16 of the Program.cs, you can start the program. As soon as the program runs, your bot should go online in the Discord channel you invited him to. Congratulations, your own bot is now online on Discord and you can interact with it.

## Example
To provide you with an example of how exactly you can interact with the bot, I have implemented a method in the BotCommand.cs class. If you write !Hello FacingSouth or !hello FacingSouth while the bot is online, the bot will answer you with "Nice to meet you FacingSouth". Of course you can also use other names than FacingSouth ;). If you just write hello without writing a name behind it, the bot will answer you with "Enter a name so I can greet you". The bot will not respond to any other input. At this point it is up to you to expand the possibilities of the bot and bring in your own ideas. Have lots of fun with it.
