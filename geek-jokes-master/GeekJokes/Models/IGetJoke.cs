using GeekJokes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekJokes.Services
{
    public interface IGetJoke
    {
        public Joke Joke { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        void RetrieveAndAnalyzeJoke();
    }
}
