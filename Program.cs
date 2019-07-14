using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class First
    {
       public void PrintText(int Counter)
        {
           int Fact = Counter;
            while(Counter>1)
            {
                Counter--;
                Fact *= Counter;
                          
            }
            Console.WriteLine(Fact);
        }
        public int value { get { return value; } set { value = 1; } }
      
       

    }

    public class Second: First
    {
        public new int value { get { return value; } set { value = 2; } }

    }
    class Start
    { 
        static void Main(string[] args)
        {
            //  Console.WriteLine("Enter number");
            //int Counter =int.Parse( Console.ReadLine());

            //  Program obj = new Program();
            //obj.PrintText(Counter);

            //double val = 40000000000000000;
            //int x = checked((int) val);
            //Console.Write(x);

            //for(int i=1;i<=10;i++)
            //{
            //    Console.Write(Counter + " * " + i + " = " + Counter * i);
            //}

            //
            //string s1 = "hi";
            //string s2 = s1;
            //Console.WriteLine(s1 == s2 ? true : false);
            //Console.WriteLine(object.ReferenceEquals(s1,s2) ? true : false);
            //Console.ReadKey();

            First obj1 = new Second();
            Console.WriteLine(obj1.value);
            Console.ReadKey();

        }
    }
}
