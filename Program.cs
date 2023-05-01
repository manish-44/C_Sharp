using System;


//*********
//write v/s writeline 
// write does not led to new line while generating the output
// writeline shows the ouput in new line

//Console.Write("What is your roll no ? ");
//string roll_number = Console.ReadLine();
//Console.WriteLine($"Your roll number is {roll_number}");


//*****
//second way to print using writline {0}, {1} 


//********
//type of variables
//decimal => M is suffix
//double, bool, int,long


//********
//double v/s float v/s decimal v/s long
//decimal is more precise than double and float
//in float we can store values upto 4 bytes (6 places after decimal point)
//Double upto 8 bytes And long double even more than float and double.

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //WriteAndVariables obj1= new WriteAndVariables();
            //DataConversion obj2= new DataConversion();
            Arrays obj3= new Arrays();

            //Console.WriteLine("obj1 is executing");
            //obj1.func();

            //Console.WriteLine();

            //Console.WriteLine("obj2 is executing");
            //obj2.func();


            //Console.WriteLine();

            Console.WriteLine("obj3 is executing");
            obj3.func();
          
        }
    }
}
