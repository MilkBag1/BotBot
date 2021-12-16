using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;

namespace BotBot.Modules
{
   public class Commands : ModuleBase<SocketCommandContext>
    {
        String[] yesno = { "yes", "no" };

        [Command("yesno")]
        public async Task YesNo()
        {
            int item = new Random().Next(0, yesno.Length);
            await ReplyAsync(yesno[item]);
        }

        [Command("weather")]
        public async Task Weather()
        {
            
            await ReplyAsync("https://www.theweathernetwork.com/ca/weather/british-columbia/victoria");
        }

        [Command("commands")]
        public async Task commands()
        {

            await ReplyAsync("``` Current Commands: !yesno | !weather | !commands ```");

        }

    }
}
