using GeekJokes.Models;
using System;
using System.Linq;

namespace GeekJokes.Services
{

    public class JokeAnalyzer
    {
        public int GetWordCount(Joke joke)
        {
            var words = joke.JokeText.Split(' ');
            return words.Length;
        }

        public int GetCharCount(Joke joke, bool includeSpecialChars = true, bool includeWhitespaces = true)
        {
            if (includeSpecialChars && includeWhitespaces)
            {
                return joke.JokeText.Length;
            }

            if (includeSpecialChars && !includeWhitespaces)
            {
                return joke.JokeText.Where(c => !char.IsWhiteSpace(c)).ToArray().Length;
            }

            int alphanumericCharCount = joke.JokeText
                .Where(c => (c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
                .ToArray()
                .Length;

            if (!includeSpecialChars && includeWhitespaces)
            {
                return alphanumericCharCount + joke.JokeText.Where(c => char.IsWhiteSpace(c)).ToArray().Length;
            }

            return alphanumericCharCount;
        }

        public int GetFunniness(Joke joke)
        {
            Random _funninessAnalyzer = new Random();
            return _funninessAnalyzer.Next(1, 6);
        }
    }
}
