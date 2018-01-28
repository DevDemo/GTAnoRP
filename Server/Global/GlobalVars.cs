using GrandTheftMultiplayer.Server;
using GrandTheftMultiplayer.Server.API;
using GrandTheftMultiplayer.Server.Elements;
using GrandTheftMultiplayer.Server.Constant;
using GrandTheftMultiplayer.Server.Managers;
using GrandTheftMultiplayer.Shared;
using GrandTheftMultiplayer.Shared.Math;

namespace GTAnoRP.Server.Global
{
    class GlobalVars : Script
    {
        public static string ListeningServer;
        public static int ListeningPort;
        public static string ListeningString;

        public static string WebServer;
        public static int WebServerPort;
        public static string WebServerConnectionString;

        public static string WebRTCServer;
        public static int WebRTCServerPort;
        public static string WebRTCServerConnectionString;



        public static string ServerName = "The Godfather";
		public static PedHash DefaultPedModel = PedHash.DrFriedlander;
    }
}
