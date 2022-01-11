using RequestService.Models;
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

namespace RequestService
{
    /// <summary>
    /// Makes the connection to the REST "Request" Service
    /// </summary>
    public class RequestConnection
    {
        // Variables
        private static string host = "localhost";
        private static int port = 44380;
        private static string mediaType = @"application/json";
        private static HttpClient client = new HttpClient();

        /// <summary>
        /// 
        /// </summary>
        public RequestConnection()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(mediaType));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static DataTable GetRequests()
        {
            //
            string requestUrl;
            DataTable table = null;
            HttpResponseMessage response;

            //
            requestUrl = $"https://{ host }:{ port }/api/requests";

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

            // In case there is no requests
            return table;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="keyword"></param>
        /// <returns></returns>
        public static DataTable Filter(string keyword)
        {
            //
            string requestUrl;
            DataTable table = null;
            HttpResponseMessage response;

            //
            requestUrl = $"https://{ host }:{ port }/api/requests/{ keyword.Trim() }";

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

            // In case there is no request
            return table;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public static void Delete(int id)
        {
            //
            string requestUrl;
            HttpResponseMessage response;

            //
            requestUrl = $"https://{ host }:{ port }/api/requests/{ id.ToString().Trim() }";

            //
            JsonSerializerOptions jsonDeserializerOptions = new() { PropertyNameCaseInsensitive = true };

            try
            {
                //
                response = client.DeleteAsync(requestUrl).Result;

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
        }
    }
}
