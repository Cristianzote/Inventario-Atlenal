using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Access.API
{
    public static class Users
    {


        public static async Task<string> GetUser(string user, string password)
        {

            HttpClient cliente = new HttpClient();

            cliente.BaseAddress = new Uri("http://api.inventory.linapps.co/");


            var response = await cliente.GetAsync($"auth/credentials?user={user}&password={password}");

            var body = await response.Content.ReadAsStringAsync();

            //var obj = System.Text.Json.JsonSerializer.Deserialize<UserModel>(body);


            return body;

        }













    }
}
