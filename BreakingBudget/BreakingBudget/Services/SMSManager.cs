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
        private const string REMOTE_URL = "http://kisune.com/api/SMSManager/handler.php";

        public static async void SendSMS(string[] numbers, string message)
        {
            HttpClient client = new HttpClient();
            var values = new Dictionary<string, string>
            {
               { "message", message },
               { "api_token", "a415ab5cc17c8c093c015ccdb7e552aee7911aa4" }
            };
            Console.WriteLine("Sending SMS to: " + string.Join(",", numbers));

            // create a query string's parameter of array of number
            for (int i = 0; i < numbers.Length; ++i) {
                values["number[" + i + "]"] = numbers[i];
            }

            // create the request query string
            var content = new FormUrlEncodedContent(values);

            // send the HTTP POST request to the remote URL
            // with the query string (x-www-form-urlencoded)
            // and wait (async) for the server's response.
            var response = await client.PostAsync(SMSManager.REMOTE_URL, content);

            // then, read the response's data
            var responseString = await response.Content.ReadAsStringAsync();
        }
    }
}
