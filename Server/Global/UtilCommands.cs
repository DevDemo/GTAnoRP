using GrandTheftMultiplayer.Server;
using GrandTheftMultiplayer.Server.API;
using GrandTheftMultiplayer.Server.Elements;
using GrandTheftMultiplayer.Server.Constant;
using GrandTheftMultiplayer.Server.Managers;
using GrandTheftMultiplayer.Shared;
using GrandTheftMultiplayer.Shared.Math;
using System.IO;

namespace GTAnoRP.Server.Global
{
    public class UtilCMD : Script
    {
        [Command("save", GreedyArg = true)]
        public void Command_Save(Client sender)
        {
            var pos = API.getEntityPosition(sender);
            var angle = API.getEntityRotation(sender);
            File.AppendAllText("savepos.txt", string.Format("{0}: {1} {2} {3} {4}\n", sender.name, pos.X, pos.Y, pos.Z, angle));
            API.sendNotificationToPlayer(sender, string.Format("Position saved in savepos.txt as: {0}", sender.name), true);
        }

        [Command("savecam", GreedyArg = true)]
        public void Command_SaveCam(Client sender)
        {
            var pos = API.getEntityPosition(sender);
            var angle = API.getEntityRotation(sender);
            File.AppendAllText("savepos.txt", string.Format("{0}: {1} {2} {3} {4}\n", sender.name, pos.X, pos.Y, pos.Z, angle));
            API.sendNotificationToPlayer(sender, string.Format("Position saved in savepos.txt as: {0}", sender.name), true);
        }
    }
}