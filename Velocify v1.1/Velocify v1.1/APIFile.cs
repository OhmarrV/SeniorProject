using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Newtonsoft.Json;

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
        public static async Task<(int id, string name, string coverUrl)> GetGameDataAsync(string gameName)
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
                    string jsonResponse = await response.Content.ReadAsStringAsync();

                    // Parse JSON to extract id, name, and cover URL
                    JArray data = JArray.Parse(jsonResponse);
                    if (data.Count > 0)
                    {
                        int id = data[0]["id"].Value<int>();
                        string name = data[0]["name"].Value<string>();
                        string coverUrl = data[0]["cover"]?["url"]?.Value<string>() ?? "No URL";
                        return (id, name, coverUrl);
                    }
                }
                return (0, "Error", "Error");
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

        public static async Task<List<GameData>> GetAllGamesAsync()
        {
            List<GameData> games = new List<GameData>();
            // Fetch the game data from your API or database
            // Here, I'm providing a dummy implementation, replace it with actual logic

            // Example: Making an API call or database query
            // var response = await httpClient.GetAsync("your_api_endpoint");
            // if (response.IsSuccessStatusCode)
            // {
            //     var content = await response.Content.ReadAsStringAsync();
            //     games = JsonConvert.DeserializeObject<List<GameData>>(content);
            // }

            // For demonstration, let's add some dummy data
            //games.Add(new GameData { id = 1, name = "Fortnite", coverUrl = "url_to_cover" });
            //games.Add(new GameData { id = 2, name = "Minecraft", coverUrl = "url_to_cover" });
            //// Add more games as needed

            return games;
        }

        public static async Task<List<GameData>> GetGamesByNameAndGenreAsync(string gameName, string genre)
        {
            List<GameData> games = new List<GameData>();

            using (HttpClient client = new HttpClient())
            {
                // Set up headers for the request
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("Client-ID", clientId);
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + accessToken);

                // Build the query with conditional logic for game name and genre
                var query = new StringBuilder();

                // Add the search for the game name, if provided
                if (!string.IsNullOrEmpty(gameName))
                {
                    query.Append($"search \"{gameName}\";");
                }

                // Add the filter for the genre, if provided
                if (!string.IsNullOrEmpty(genre))
                {
                    // Assuming IGDB uses a 'where' clause for genre filtering
                    query.Append($" where genres.name = \"{genre}\";");
                }

                // Select the fields you want from the API
                query.Append(" fields id,name,cover.url,genres.name; limit 10;");

                var content = new StringContent(query.ToString(), Encoding.Default, "application/json");

                // Make the API request
                HttpResponseMessage response = await client.PostAsync(baseUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();

                    // Parse the JSON response
                    JArray data = JArray.Parse(jsonResponse);
                    if (data.Count > 0)
                    {
                        // Loop through the games and extract the relevant data
                        foreach (var item in data)
                        {
                            int id = item["id"].Value<int>();
                            string name = item["name"].Value<string>();
                            string coverUrl = item["cover"]?["url"]?.Value<string>() ?? "No URL";
                            string genreName = item["genres"]?[0]?["name"]?.Value<string>() ?? "Unknown Genre";

                            games.Add(new GameData { id = id, name = name, coverUrl = coverUrl, genre = genreName });
                        }
                    }
                }
            }

            return games;
        }



    }
}
