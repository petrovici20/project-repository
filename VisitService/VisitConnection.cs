using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace VisitService
{
    /// <summary>
    /// Makes the connection to the REST "Visit" Service
    /// </summary>
    public class VisitConnection
    {
        // Variables
        private static string host = "localhost";
        private static int port = 44357;
        private static string mediaType = @"application/json";
        private static HttpClient client = new HttpClient();

        /// <summary>
        /// 
        /// </summary>
        public VisitConnection()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(mediaType));
        }

        /// <summary>
        /// Calls the service method that gets all the visits
        /// </summary>
        /// <returns></returns>
        public static string GetVisits()
        {
            //
            string requestUrl;
            HttpResponseMessage response;

            //
            requestUrl = $"https://{ host }:{ port }/api/visits";

            //
            JsonSerializerOptions jsonDeserializerOptions = new() { PropertyNameCaseInsensitive = true };

            try
            {
                //
                response = client.GetAsync(requestUrl).Result;

                //
                if (!response.StatusCode.Equals(HttpStatusCode.OK))
                {
                    throw new Exception(response.Content.ReadAsStringAsync().Result);
                }

                return response.Content.ReadAsStringAsync().Result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            // In case there is no visits
            return "No data found";
        }
    }
}
