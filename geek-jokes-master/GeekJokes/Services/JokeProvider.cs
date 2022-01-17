using GeekJokes.Models;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace GeekJokes.Services
{
    public class JokeProvider
    {
        private readonly HttpClient client = new HttpClient();

        private const string ApiUrl = "https://geek-jokes.sameerkumar.website/api?format=json";

        public JokeProvider()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<Joke> GetJoke()
        {
            Stream jokeJson = await client.GetStreamAsync(ApiUrl);
            Joke joke = await JsonSerializer.DeserializeAsync<Joke>(jokeJson);
            return joke;
        }
    }
}
