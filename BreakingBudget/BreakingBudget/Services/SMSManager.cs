﻿using System;
using System.Net.Http;
using System.Collections.Generic;
using BreakingBudget.Services.Lang;
using System.Windows.Forms;

namespace BreakingBudget.Services
{
    static class SMSManager
    {
        private const string REMOTE_URL = "http://kisune.com/private/api/SMSManager/handler.php";
        private const string SERVER_RESPONSE_HEADER = "X-SERVER-ANSWER";

        public static async void SendSMS(IWin32Window owner, string[] numbers, string message,
            params KeyValuePair<string, string>[] additional_parameters)
        {
            HttpClient client = new HttpClient();
            var values = new Dictionary<string, string>
            {
               { "message", message },
               { "api_token", "a415ab5cc17c8c093c015ccdb7e552aee7911aaa4" }
            };
            Console.WriteLine("Sending SMS to: " + string.Join(",", numbers));

            // append the additional parameters to the query string
            foreach (var additional_parameter in additional_parameters)
            {
                values[additional_parameter.Key] = additional_parameter.Value;
            }

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

            // read the HTTP status code, if 2xx or 3xx, it's ok.
            if ((int)response.StatusCode >= 200 && (int)response.StatusCode < 400)
            {
                if (response.Headers.Contains(SMSManager.SERVER_RESPONSE_HEADER))
                {
                    var responseHeader = response.Headers.GetValues(SMSManager.SERVER_RESPONSE_HEADER);
                    ErrorManager.SMSSuccessfullySent(owner, string.Join(",", responseHeader));
                }
            }
            else
            {
                ErrorManager.ShowOperationFailed(owner, 
                    String.Format(
                        Program.settings.localize.Translate("err_message_not_sent_err_code_{0}"),
                        (int)response.StatusCode
                    )
                );
            }
        }
    }
}
