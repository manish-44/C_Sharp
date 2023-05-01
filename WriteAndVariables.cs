using System;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    public class WriteAndVariables
    {
        public void func()
        {
            bool flag = true;
            double x = 1.45;
            decimal num = 3.14159265359M;

            Console.WriteLine("x*x = {0} ", x * x);
            Console.WriteLine("Biggest Integer = {0}, Hello  : {1}", int.MaxValue, "This is the output");
            Console.WriteLine("Biggest long = {0}", long.MaxValue);
            Console.WriteLine("Biggest integer - Biggest long ={0}", long.MaxValue - int.MaxValue);

        }
    }
}
