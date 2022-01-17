using GeekJokes.Models;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace GeekJokes.Services
{
    public class JokeProviderStub : JokeProvider
    {
        
        public async Task<Joke> GetJoke()
        {
            Joke joke = new Joke() {};
            int callCount = 0;
            if (GetJoke().IsCompleted)
            {
                callCount += 1;
            }
            if(callCount % 2 == 0)
            {
                joke.JokeText = "this is a horrible joke";
            }
            else
            {
                joke.JokeText = "this is not a horrible joke";

            }
            return joke;
        }
    }
}
