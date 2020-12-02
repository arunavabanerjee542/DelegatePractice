using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousDelegates
{
    delegate string dd(string a);
    class Program
    {
        static void main()
        {

            dd d = delegate (string a)
            {
                return "a";
            };

            string aa = d("hckdjkjd");

            Console.WriteLine(aa);
        }
    }
}
