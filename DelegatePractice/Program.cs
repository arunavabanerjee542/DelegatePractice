using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePractice
{

    // in first few lines of code i practiced some basic examples of delegates
   
    // then i have  used the delegate to  verify if the salary of an employee is greater than 2000 then print his/her name

    // if we want to change out verification logic of my Employee class the we can do 
   //  so by changing the logic of the method to which our delegate is pointing, thus alowing us not perform any change in the employee class




    delegate string dd(string s); 

    public delegate void del();

    delegate bool verificaton(Employee e);

    delegate string multicast(String s);

    class Program
    {

        public void show()
        {
            Console.WriteLine(" show ");
        }


       static public string aaa(string s)
        {
            return " hi aaa " + s;
        }

       static  public string bbb(string s)
        {
            return " hi bbb " + s;
        }

        public bool  doverify(Employee l)
        {
            
                if(l.sal> 2000)
                {
                    return true;
                }
            return false;

        }


      static  public void showme()
        {
            Console.WriteLine(" show now ");
        }

        static void Main(string[] args)
        {
            Program p = new Program();

            del d = new del(p.show);

            d();

            del dd = new del(showme);
            dd();

            List<Employee> ll = new List<Employee>()
            {
               new Employee(){id= 1, name = "kjkjb", sal=254},
               new Employee(){id= 2, name = "aaaaa", sal=256444},
               new Employee(){id= 7, name = "bbbbb", sal=2544}

            };


            verificaton v = new verificaton(p.doverify);

            Employee e = new Employee();
            e.verify(ll,v);

            multicast m = new multicast(aaa);

            m += bbb;

            string ss = m(" SI ");

            Console.WriteLine(ss);


            // anonymous

            dd ddd = (string a) =>
            {
                return a; 
            };

            string zz = ddd("ajshvassjhjhkvj");

            Console.WriteLine(zz);






        }


    }


    class Employee
    {
        public string name { get; set; }

        public int id { get; set; }

        public int sal { get; set; }

        public void verify(List<Employee> l, verificaton v)
        {

            foreach(Employee e in l)
            {
                if(v(e))                           // here v is a delegate and we see that if we 
                {                                  // want to change out verification logic the we can do 
                                                    // do so by changing the logic of the method to which our delegate is pointing, thus alouing us not perform any change in the employee class
                    Console.WriteLine(e.name);
                }
            }
            


        }



    }






}
