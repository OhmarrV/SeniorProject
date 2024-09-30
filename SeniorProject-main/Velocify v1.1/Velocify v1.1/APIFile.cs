using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Velocify_v1._1
{
    internal class APIFile
    {
        // Your OAuth Token and Client ID
        private static readonly string clientId = "mq5q2stycdb2yljnhff3j344t8agcf";
        private static readonly string accessToken = "w6a07rfrs2dhmgn6zxhuc4zpf1f0hw"; // Replace with your actual access token

        // Base URL for IGDB API
        private static readonly string baseUrl = "https://api.igdb.com/v4/games";

        // Method to fetch game data
        public static async Task<string> GetGameDataAsync(string gameName)
        {
            using (HttpClient client = new HttpClient())
            {
                // Set up the headers for the request
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("Client-ID", clientId);
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + accessToken);

                // Query to search for the game name and get id, name, and cover URL
                var query = $"search \"{gameName}\"; fields id,name,cover.url; limit 1;";
                var content = new StringContent(query, Encoding.Default, "application/json");

                // Make the API call
                HttpResponseMessage response = await client.PostAsync(baseUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    // Read and return the response content
                    return await response.Content.ReadAsStringAsync();
                }
                else
                {
                    // Return error message if API call fails
                    return $"Error: {response.StatusCode} - {response.ReasonPhrase}";
                }
            }

        }

        // Method to fetch game data by ID
        public static async Task<string> GetGameByIdAsync(int gameId)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("Client-ID", clientId);
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + accessToken);

                // Query to get the game details by ID
                var query = $"fields id,name,cover.url; where id = {gameId};";
                var content = new StringContent(query, Encoding.Default, "application/json");

                HttpResponseMessage response = await client.PostAsync(baseUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }
                else
                {
                    return $"Error: {response.StatusCode} - {response.ReasonPhrase}";
                }
            }
        }

    }
}
