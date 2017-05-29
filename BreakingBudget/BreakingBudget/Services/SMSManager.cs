using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingBudget.Services
{
    static class SMSManager
    {
        private const string REMOTE_URL = "http://127.0.0.1:8000/api/SMSManager/handler.php";

        public static async void SendSMS(string[] targets, string message)
        {
            HttpClient client = new HttpClient();
            var values = new Dictionary<string, string>
            {
               { "thing1", "hello" },
               { "thing2", "world" }
            };

            var content = new FormUrlEncodedContent(values);

            var response = await client.PostAsync("http://www.example.com/recepticle.aspx", content);

            var responseString = await response.Content.ReadAsStringAsync();
        }
    }
}
