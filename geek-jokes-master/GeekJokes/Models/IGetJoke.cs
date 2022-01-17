using GeekJokes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekJokes.Services
{
    interface IGetJoke
    {
        public Joke Joke { get; set; }
    }
}
