namespace ConsoleApp1
{
    public class ExeptionHandling
    {
       
       public static double divisionFunc(double x,double y)
        {
            if(y==0)
            {
                throw new System.DivideByZeroException();
            }

            return x/y;
        } 

        public void func()
        {
            //zero division handling
            double num1 =20;
            double num2 = 0;

            try{
                Console.WriteLine("20/0 ;{0}",divisionFunc(num1,num2));
            }
            catch(DivideByZeroException ex){
                Console.WriteLine("You can''t divide by zero");
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }

            catch(Exception ex)
            {
                Console.WriteLine("An error occured");
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message );
            }

            finally {
                Console.WriteLine("Cleaning Up");
            }
        }
    }
}
