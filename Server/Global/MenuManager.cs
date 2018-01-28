using GrandTheftMultiplayer.Server;
using GrandTheftMultiplayer.Server.API;
using GrandTheftMultiplayer.Server.Elements;
using GrandTheftMultiplayer.Server.Constant;
using GrandTheftMultiplayer.Server.Managers;
using GrandTheftMultiplayer.Shared;
using GrandTheftMultiplayer.Shared.Math;
using GTAnoRP.Server.Characters;
using System.Collections.Generic;
using GTAnoRP.Server.Property;
using GTAnoRP.Server.User;
using GTAnoRP.Data;
using GTAnoRP.Data.Enums;

namespace GTAnoRP.Server.Menu
{
    public class MenuManager : Script
    {
        public MenuManager()
        {
            API.onClientEventTrigger += onClientEventTrigger;
        }

        private void onClientEventTrigger(Client player, string eventName, object[] args)
        {
            if(eventName == "menu_handler_select_item")
            {
                int callback = (int)args[0];
                if(callback == 0) // Character Menu
                {
                    if ((int)args[1] == (int)args[2]-1) CharacterController.CreateCharacter(player);
                    else CharacterController.SelectCharacter(player, (int)args[1]+1);
                }
                else if(callback == 1) // Vehicle Menu
                {
                    AccountController account = player.getData("ACCOUNT");
                    List<int> VehicleIDs = player.getData("VSTORAGE");

                    int vehID = VehicleIDs[(int)args[1]];
                    Vehicles.VehicleController _VehicleController = EntityManager.GetVehicle(vehID);
                    if (_VehicleController == null) Vehicles.VehicleController.LoadVehicle(account, vehID);
                    else _VehicleController.UnloadVehicle(account);
                    player.resetData("VSTORAGE");
                }
            }
        }
    }
}
