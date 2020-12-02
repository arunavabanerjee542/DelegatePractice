using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePractice
{

    delegate string dd(string ss);
    
    class AnonymousDelegate
    {

     /**   public static string sh(string s)
        {
            return "s";
        }
     */

        static void main()
        {

            dd d = delegate (string a)
            {
                return "a";
            };

            string aa =d("hckdjkjd");

            Console.WriteLine(aa);
        }

    }
}
