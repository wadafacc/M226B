using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeekJokes.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeekJokes.Models;
using Moq;

namespace GeekJokes.Services.Tests
{
    [TestClass()]
    public class JokeProviderTests
    {
        [TestMethod()]
        public void JokeProviderTest()
        {
            JokeProviderStub provaido = new JokeProviderStub();
            JokeService service = new JokeService(provaido);
            Joke joke = service.RetrieveAndAnalyzeJoke().Result;

            //test
            Assert.AreEqual(joke, "this is a horrible joke");
        }
        [TestMethod]
        public void MoqAnalytics()
        {
            // Create the mock
            var mock = new Mock<IGetJoke>();

            // Configure the mock to do something
            mock.Setup(x => x.GetJoke()).Returns(async () =>
            {
                Joke j = new Joke() { JokeText = "ABC test" };
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