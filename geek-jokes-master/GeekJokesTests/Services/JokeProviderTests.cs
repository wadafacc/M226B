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



    }
}