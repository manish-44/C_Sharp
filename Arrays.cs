namespace ConsoleApp1
{
    public class Arrays
    {
        public void func()
        {
            int[] favnums = new int[3];
            string[] favStrings= new string[3]{"man","ish","meena"};

            string[] favCars = { "Bolera", "Scorpio", "Fortuner", "LandCruiser" };
            long[] favPrice = { 10000000, 10000000, 1010100110, 10101010101 };

            Console.WriteLine($"{favnums[0]}, {favStrings[0]}, {favCars[0]}, {favPrice[0]}");

            //loop through the arrays
            foreach (string i in favCars)
            {
                Console.Write( $"{i}, " );
            }

            //totaling the price of cars
            long total_price = 0;
            for(int i=0;i < favnums.Length;i++)
            {   
                total_price += favPrice[i];
            }

            Console.WriteLine("total price of cars is : {0}", total_price);

            //object type => different type of values can be stored
            object[] newarrays = { "Manish", 21, 17 - 06 - 2001 };
            newarrays[0] = 24;
            Console.WriteLine(newarrays[2].GetType());

            //var ,values must be same type
            var employees = new[]{ "Manish", "Meena", "Graduate" };

            Console.WriteLine("--------------------------------------");

            //2-d arrays

            int[,] mat = new int[2, 2] { { 1, 2 }, { 3, 4 } };

            Console.WriteLine($"the value is {mat[1, 0]}");

            //create array
            Array anArray = Array.CreateInstance(typeof(long),4);
            favPrice.CopyTo( anArray, 0 );

            Console.WriteLine("-----------------");
            foreach(long i in anArray)
            {
                Console.Write($"{i},");
            }
            Console.Write("\n");

        }
    }
}
