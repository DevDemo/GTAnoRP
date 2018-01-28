using GrandTheftMultiplayer.Server;
using GrandTheftMultiplayer.Server.API;
using GrandTheftMultiplayer.Server.Elements;
using GrandTheftMultiplayer.Server.Constant;
using GrandTheftMultiplayer.Server.Managers;
using GrandTheftMultiplayer.Shared;
using GrandTheftMultiplayer.Shared.Math;
using GTAnoRP.Server.Characters;
using GTAnoRP.Server.Property;

namespace GTAnoRP.Server.Global
{
    class KeyManager : Script
    {
        public KeyManager()
        {
            API.onClientEventTrigger += OnClientEventTrigger;
        }

        private void OnClientEventTrigger(Client player, string eventName, object[] args)
        {
            if(eventName == "onKeyDown")
            {
                if ((int)args[0] == 2)
                {
                    PropertyController PropertController = player.getData("AT_PROPERTY");
                    if ((PropertController = player.getData("AT_PROPERTY")) != null)
                    {
                        PropertController.PropertyDoor(player);
                    }
                }
                else if((int)args[0] == 3)
                {
                    if(player.isInVehicle)
                    {
                        player.vehicle.specialLight = true;
                    }
                }
                else if ((int)args[0] == 4)
                {
                    if (player.isInVehicle)
                    {
                        player.vehicle.specialLight = true;
                    }
                }
                else if ((int)args[0] == 5)
                {
                    if (player.isInVehicle)
                    {
                        Vehicles.VehicleController.TriggerDoor(player.vehicle, 4);
                    }
                }
                else if ((int)args[0] == 6)
                {
                    if (player.isInVehicle)
                    {
                        Vehicles.VehicleController.TriggerDoor(player.vehicle, 5);
                    }
                }

                else if ((int)args[0] == 8)
                {
                    CharacterController.StopAnimation(player);
                }
            }
        }
    }
}
