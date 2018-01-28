﻿using GrandTheftMultiplayer.Server;
using GrandTheftMultiplayer.Server.API;
using GrandTheftMultiplayer.Server.Elements;
using GrandTheftMultiplayer.Server.Constant;
using GrandTheftMultiplayer.Server.Managers;
using GrandTheftMultiplayer.Shared;
using GrandTheftMultiplayer.Shared.Math;
using GTAnoRP.Server.Extensions;
using GTAnoRP.Server.User;

namespace GTAnoRP.Server.Global
{
    public class CEFController
    {

        public static void OpenVoice(Client player)
        {
            API.shared.triggerClientEvent(player, "CEFController", GlobalVars.WebRTCServerConnectionString);
            API.shared.sendChatMessageToPlayer(player, GlobalVars.WebRTCServerConnectionString);
        }

        public static void SendRequest(Client player, string baseurl, string querystring)
        {
            string sendUrl = GlobalVars.WebServerConnectionString + baseurl + "?socialclub=" + player.socialClubName + querystring;
            API.shared.triggerClientEvent(player, "CEFController", sendUrl);
            API.shared.sendChatMessageToPlayer(player, sendUrl);
        }


        public static void Close(Client player)
        {
            API.shared.triggerClientEvent(player, "CEFDestroy");
        }

        public static void ShowCursor(Client player)
        {
            if (player.getData("CURSOR") != null)
            {
                API.shared.triggerClientEvent(player, "CEFController_ShowCursor", false);
                player.resetData("CURSOR");
            }
            else
            {
                API.shared.triggerClientEvent(player, "CEFController_ShowCursor", true);
                player.setData("CURSOR", true);
            }

        }
    }
}
