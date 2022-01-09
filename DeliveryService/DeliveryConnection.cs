using DeliveryService.Models;
using RequestService;
using RequestService.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DeliveryService
{
    /// <summary>
    /// Makes the connection to the REST "Delivery" Service
    /// </summary>
    public class DeliveryConnection
    {
        // Variables
        private static string host = "localhost";
        private static int port = 44315;
        private static string mediaType = @"application/json";
        private static HttpClient client = new HttpClient();

        /// <summary>
        /// 
        /// </summary>
        public DeliveryConnection()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(mediaType));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static DataTable GetDeliveries()
        {
            //
            string requestUrl;
            DataTable table = null;
            HttpResponseMessage response;

            //
            requestUrl = $"https://{ host }:{ port }/api/deliveries";

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

                return JsonSerializer.Deserialize<DataTable>(response.Content.ReadAsStringAsync().Result, jsonDeserializerOptions);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            // In case there is no delivery
            return table;
        }

        public static DataTable Filter(string keyword)
        {
            //
            string requestUrl;
            DataTable table = null;
            HttpResponseMessage response;

            //
            requestUrl = $"https://{ host }:{ port }/api/deliveries/{ keyword.Trim() }";

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

                return JsonSerializer.Deserialize<DataTable>(response.Content.ReadAsStringAsync().Result, jsonDeserializerOptions);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            // In case there is no delivery
            return table;
        }

        public static void Place(RequestClient request)
        {
            //
            string requestUrl;
            HttpResponseMessage response;

            //
            requestUrl = $"https://{ host }:{ port }/api/deliveries";

            try
            {
                //
                response = client.PostAsJsonAsync(requestUrl, request).Result;

                //
                if (!response.StatusCode.Equals(HttpStatusCode.OK))
                {
                    throw new Exception(response.Content.ReadAsStringAsync().Result);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            // Deletes the Request from the database
            RequestConnection.Delete(request.RequestId);
        }
    }
}
