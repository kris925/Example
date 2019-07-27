using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    class Program
    {

        //delegate int delPointer(int i);
        //static int Square(int x)
        //{
        //    return x * x;
        //}

        //static delPointer obj = Square; //Delegate pointing to Square method..
        //public static void Main()
        //{
        //    //Invoking deleaget
        //    int Result = obj(5);
        //    Console.WriteLine("Square :" + Result);
        //}
        delegate int del(int i);
        static void Main()
        {
            // Invoking delegate
            del myDelegate = x => x * x;
            int j = myDelegate(5);
            Console.WriteLine("Square:"+ j);

            Console.ReadKey();

        }
    }
}
