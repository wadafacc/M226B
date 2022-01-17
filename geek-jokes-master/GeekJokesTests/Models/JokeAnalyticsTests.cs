using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeekJokes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeekJokes.Services;
using Moq;

namespace GeekJokes.Models.Tests
{
    [TestClass()]
    public class JokeAnalyticsTests
    {
        [TestMethod()]
        public void MoqAnalytics()
        {
            // Create the mock
            var mock = new Mock<JokeProvider>();

            // Configure the mock to do something
            mock.Setup(x => x.GetJoke()).Returns(async () =>
            {
                Joke j = new Joke() { JokeText = "nej ne vafan" };
                return j;
            });

            JokeService service = new JokeService(mock.Object);
            Joke joke = service.RetrieveAndAnalyzeJoke().Result;
            Assert.AreEqual(10, joke.Analytics.CharCount);
            Assert.AreEqual(2, joke.Analytics.WordCount);

            // Verify that the mock was invoked
            mock.Verify(x => x.GetJoke());
        }
    }
}