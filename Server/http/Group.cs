using GTAnoRP.Data.MessagingModels;
using GrandTheftMultiplayer.Server;
using GrandTheftMultiplayer.Server.API;
using GrandTheftMultiplayer.Server.Elements;
using GrandTheftMultiplayer.Server.Constant;
using GrandTheftMultiplayer.Server.Managers;
using GrandTheftMultiplayer.Shared;
using GrandTheftMultiplayer.Shared.Math;
using Newtonsoft.Json;
using GTAnoRP.Server.Groups;
using GTAnoRP.Server.User;

namespace GTAnoRP.Server.http
{
    public class Group
    {
        public static void Listener(string server, string url, string post)
        {
            if (url != server + "CreateGroup")
            {
                return;
            }

            var createGroupMessage = JsonConvert.DeserializeObject<CreateGroupMessage>(post);

            Client player = AccountController.GetClientFromSocialClub(createGroupMessage.SocialClub);

            if (player == null) return;

            Data.Group group = new Data.Group()
            {
                Name = createGroupMessage.GroupName,
                Type = createGroupMessage.GroupType,
                ExtraType = createGroupMessage.GroupExtraType
            };
            GroupController GroupController = new GroupController(group);

            API.shared.sendChatMessageToPlayer(player, "You successfully created " + group.Name + " (ID: " + group.Id + ") with type " + GroupController.Type());
        }
    }
}
