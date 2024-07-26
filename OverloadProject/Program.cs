using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadProject
{
    internal class Program
    {
        public void Test()
        {
            Console.WriteLine("1ST METHOD");

        }
        public void Test(int i)
        {
            Console.WriteLine("2nd METHOD");

        }
        public void Test(String s)
        {
            Console.WriteLine("3rd METHOD");

        }
        public void Test(int i , string s)
        {
            Console.WriteLine("4th METHOD");

        }
      
        public void Test(String s , int i)
        {
            Console.WriteLine("5th METHOD");

        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Test();
            p.Test(5);
            p.Test("Abhishek");
            p.Test(69,"abc");
            p.Test("abc",69);

               Console.ReadLine();
        }
    }
}
