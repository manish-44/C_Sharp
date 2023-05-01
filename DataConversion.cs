namespace ConsoleApp1
{
    public class DataConversion
    {
        public void func()
        {
            double dblval = double.Parse("22.54");
            bool boolFromStr = bool.Parse("True");
            int intFromStr = int.Parse("100");

            string strval= dblval.ToString();
            Console.WriteLine("Data type : {0}",strval);
            Console.WriteLine($"Integer :{(int)dblval}");
        }
    }
}
