using GrandTheftMultiplayer.Server;
using GrandTheftMultiplayer.Server.API;
using GrandTheftMultiplayer.Server.Elements;
using GrandTheftMultiplayer.Server.Constant;
using GrandTheftMultiplayer.Server.Managers;
using GrandTheftMultiplayer.Shared;
using GrandTheftMultiplayer.Shared.Math;
using GTAnoRP.Server.User;

namespace GTAnoRP.Server.Global
{
    public class GlobalCommands : Script
    {

        [Command("id", GreedyArg = true)]
        public void id(Client player, string IDName)
        {
            AccountController account = EntityManager.GetUserAccount(player, IDName);
            if (account == null)
            {
                EntityManager.ListUserAccounts(player, IDName);
            }
            else
            {
                API.sendChatMessageToPlayer(player, "" + account.CharacterController.FormatName + " (ID: " + account.PlayerId + ") - (Level: " + account.CharacterController.Character.Level + ") - (Ping: " + API.getPlayerPing(account.Client) + ")");
            }
        }
    }
}