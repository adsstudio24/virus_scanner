using System;
using System.Net.Http;
using System.Threading.Tasks;

class VirusScanner
{
    static async Task Main()
    {
        Console.Write("Введіть хеш файлу для перевірки: ");
        string fileHash = Console.ReadLine();

        string apiKey = "YOUR_VIRUSTOTAL_API_KEY";
        string url = $"https://www.virustotal.com/api/v3/files/{fileHash}";

        using (HttpClient client = new HttpClient())
        {
            client.DefaultRequestHeaders.Add("x-apikey", apiKey);
            HttpResponseMessage response = await client.GetAsync(url);
            string result = await response.Content.ReadAsStringAsync();
            Console.WriteLine(result);
        }
    }
}