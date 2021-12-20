using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deleginsteadswitch
{
    class SingleCastDelegates
    {
        public static void Nyet()
        {
            Console.WriteLine("Nyet");
        }
        public static void Shiet()
        {
            Console.WriteLine("Shiet");
        }
        public virtual void Hmm()
        {
            Console.WriteLine("Hmm");
        }
    }
}
