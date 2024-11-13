using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Velocify_v1._1
{
    internal class NetworkHelper
    {
        /// <summary>
        /// Tests download speed by streaming the file from the provided URL.
        /// </summary>
        /// <param name="url">URL of the file to download.</param>
        /// <returns>Download speed in Mbps.</returns>
        public async Task<double> TestDownloadSpeedAsync(string url)
        {
            using HttpClient client = new HttpClient();
            client.Timeout = TimeSpan.FromSeconds(20); // Adjusted timeout for larger files

            try
            {
                Stopwatch stopwatch = Stopwatch.StartNew();

                // Stream the file from the server without loading it fully into memory
                using (var response = await client.GetAsync(url, HttpCompletionOption.ResponseHeadersRead))
                {
                    response.EnsureSuccessStatusCode();

                    using (var stream = await response.Content.ReadAsStreamAsync())
                    {
                        byte[] buffer = new byte[8192]; // 8 KB buffer
                        long totalBytesRead = 0;
                        int bytesRead;

                        while ((bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                        {
                            totalBytesRead += bytesRead;
                        }

                        stopwatch.Stop();
                        double seconds = stopwatch.Elapsed.TotalSeconds;

                        // Convert bytes to Megabits and calculate Mbps
                        double megabits = (totalBytesRead * 8) / (1024.0 * 1024.0);
                        return megabits / seconds; // Mbps
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error testing download speed: {ex.Message}");
                return -1; // Indicates failure
            }
        }

        /// <summary>
        /// Tests upload speed by streaming a test file to the provided URL.
        /// </summary>
        /// <param name="url">URL to upload the test file.</param>
        /// <returns>Upload speed in Mbps.</returns>
        public async Task<double> TestUploadSpeedAsync(string url)
        {
            using HttpClient client = new HttpClient();
            client.Timeout = TimeSpan.FromSeconds(20); // Adjusted timeout for uploads

            // Generate a large stream for upload testing
            var testStream = new MemoryStream(new byte[5 * 1024 * 1024]); // 5 MB

            try
            {
                Stopwatch stopwatch = Stopwatch.StartNew();

                using (var content = new StreamContent(testStream))
                {
                    var response = await client.PostAsync(url, content);
                    response.EnsureSuccessStatusCode();
                }

                stopwatch.Stop();
                double seconds = stopwatch.Elapsed.TotalSeconds;

                // Convert bytes to Megabits and calculate Mbps
                double megabits = (testStream.Length * 8) / (1024.0 * 1024.0);
                return megabits / seconds; // Mbps
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error testing upload speed: {ex.Message}");
                return -1; // Indicates failure
            }
        }

        public double CheckInternetSpeed()
        {
            // Create Object Of WebClient
            System.Net.WebClient wc = new System.Net.WebClient();

            //DateTime Variable To Store Download Start Time.
            DateTime dt1 = DateTime.UtcNow;

            //Number Of Bytes Downloaded Are Stored In ‘data’
            byte[] data = wc.DownloadData("http://google.com");

            //DateTime Variable To Store Download End Time.
            DateTime dt2 = DateTime.UtcNow;

            //To Calculate Speed in Kb Divide Value Of data by 1024 And Then by End Time Subtract Start Time To Know Download Per Second.
            return Math.Round(((data.Length / 1024) / (dt2 - dt1).TotalSeconds)/4, 2);
        }

        public double CheckUploadSpeed()
        {
            // Create Object Of WebClient
            System.Net.WebClient wc = new System.Net.WebClient();

            // Create a byte array with random data to upload
            byte[] uploadData = new byte[1024 * 100]; // 100 KB of data
            new Random().NextBytes(uploadData);

            // DateTime Variable To Store Upload Start Time.
            DateTime dt1 = DateTime.UtcNow;

            try
            {
                // Upload the data to a test server (must be configured to accept POST requests)
                byte[] response = wc.UploadData("https://httpbin.org/post", "POST", uploadData);

                // DateTime Variable To Store Upload End Time.
                DateTime dt2 = DateTime.UtcNow;

                // To Calculate Speed in Kb Divide Value Of uploadData by 1024 And Then by End Time Subtract Start Time To Know Upload Per Second.
                return Math.Round(((uploadData.Length / 1024.0) / (dt2 - dt1).TotalSeconds)/10, 2);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error during upload: " + ex.Message);
                return 0; // Return 0 if there's an error
            }
        }
    }
}