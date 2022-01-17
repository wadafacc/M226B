using GeekJokes.Models;
using System.Threading.Tasks;

namespace GeekJokes.Services
{
    public class JokeService
    {
        private JokeProvider provider;

        public JokeService(JokeProvider provider)
        {
            this.provider = provider;
        }

        public async Task<Joke> RetrieveAndAnalyzeJoke(bool includeSpecialChars = true, bool includeWhitespaces = true)
        {
            // Retrieve joke
            JokeProvider jokeProvider = provider;
            Joke joke = await jokeProvider.GetJoke();

            // Analyze Joke
            JokeAnalyzer jokeAnalyzer = new JokeAnalyzer();
            int wordCount = jokeAnalyzer.GetWordCount(joke);
            int charCount = jokeAnalyzer.GetCharCount(joke, includeSpecialChars, includeWhitespaces);
            int funnyness = jokeAnalyzer.GetFunniness(joke);
            JokeAnalytics analytics = new JokeAnalytics(wordCount, charCount, funnyness);
            joke.Analytics = analytics;

            return joke;
        }
    }
}
