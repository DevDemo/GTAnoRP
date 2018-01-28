using GrandTheftMultiplayer.Server;
using GrandTheftMultiplayer.Server.API;
using GrandTheftMultiplayer.Server.Elements;
using GrandTheftMultiplayer.Server.Constant;
using GrandTheftMultiplayer.Server.Managers;
using GrandTheftMultiplayer.Shared;
using GrandTheftMultiplayer.Shared.Math;
using Newtonsoft.Json.Linq;
using GTAnoRP.Server.User;
using GTAnoRP.Server.Vehicles;

namespace GTAnoRP.Server.http
{
    public class Vehicle
    {
        public static void Listener(string server, string url, string post)
        {
            if (url == server + "VehicleStorage")
            {
                var Args = JObject.Parse(post);
                var UserName = (string)Args.SelectToken("UserName");
                var SocialClub = (string)Args.SelectToken("SocialClub");

                Client player = AccountController.GetClientFromSocialClub(SocialClub);

                VehicleController.VehicleStorage(player);
                Global.CEFController.Close(player);
            }
        }
    }
}
