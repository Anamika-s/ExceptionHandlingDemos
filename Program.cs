using System;

namespace ExceptionHandlingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            try
            {
                Console.WriteLine("Enter No1");
                num1 = Convert.ToByte(Console.ReadLine());
                Console.WriteLine("Number is " + num1);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Value of num1 is " + num1);
            }
            }
    }
}
