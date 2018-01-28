using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using GTAnoRP.WEB.Models;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;
using GTAnoRP.WEB.Models.GameViewModel.Vehicle;

namespace GTAnoRP.WEB.Controllers.Game.Vehicle
{
    [Authorize]
    public class VehicleController : Controller
    {
        private class JSONData
        {
            public string UserName;
            public string SocialClub;
            public string Token;
        }

        [HttpPost]
        public async Task VehicleStorage(VehicleStorageViewModel model)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = DefaultDbContext.Instance.Users.FirstOrDefault(x => x.Id == userId);

            var jsonData = new JSONData();
            jsonData.UserName = user?.UserName;
            jsonData.SocialClub = model.socialclub;

            using (var client = new HttpClient())
            {
                string json = JsonConvert.SerializeObject(jsonData);
                var content = new StringContent(json.ToString(), Encoding.UTF8, "application/json");
                var response = await client.PostAsync("YOUR IP:3001/VehicleStorage", content);

                var responseString = await response.Content.ReadAsStringAsync();
            }
        }

    }
}